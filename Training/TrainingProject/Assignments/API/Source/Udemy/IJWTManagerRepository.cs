using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy
{
    public interface IJWTManagerRepository
    {
        Task<Tokens> Authenticate(UserLoginDTO loginDTO, string role);
    }

    public class JWTManagerRepository : IJWTManagerRepository
    {
        private udemy2437chaitanyaContext dbcontext;

        private readonly IConfiguration iconfiguration; 

        public JWTManagerRepository(IConfiguration config)
        {
            this.iconfiguration = config;
            dbcontext = new udemy2437chaitanyaContext();
        }
        public async Task<Tokens> Authenticate(UserLoginDTO user, string role)
        {
            List<User> userlist = await dbcontext.Users.Select(x => x).ToListAsync();

            if(!userlist.Any(x=>x.Email == user.email && x.Password == user.password))
            {
                return null;
            }
            else
            {
                if (string.IsNullOrEmpty(role))
                {
                    var tempuser = userlist.Where(x => x.Email == user.email && x.Password == user.password).First();
                    var temprole = dbcontext.ApplicationObjects.Where(x => x.ApplicationObjectId == tempuser.UserType).First();

                    role = temprole.ApplicationObjectName;
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Email, user.email),
                    new Claim(ClaimTypes.Role, role)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(5),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return new Tokens { Token = tokenHandler.WriteToken(token) };

            }
        }
    }
}
