using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    
    public interface IUserService : IRepository<User>
    {
        Task<Tokens> Login(UserLoginDTO loginDTO);
    }

    public class UserService : Repository<User>, IUserService
    {

        private readonly IJWTManagerRepository _jWTManagerRepository;
        public UserService(udemy2437chaitanyaContext context, IJWTManagerRepository jWTManagerRepository) : base(context)
        {
            this._jWTManagerRepository = jWTManagerRepository;
        }

        public async Task<List<User>> getUsers()
        {
            List<User> userlist = await base.GetAll();
            return userlist;
        }

        public async Task<User> addUser(User user)
        {
            User retUser = await base.Add(user);
            return retUser;
        }


        public async Task<Tokens> Login(UserLoginDTO loginDTO)
        {
            var token = await _jWTManagerRepository.Authenticate(loginDTO, null);
            return token;
        }
    }
}
