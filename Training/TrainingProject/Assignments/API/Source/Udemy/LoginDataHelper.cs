using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy
{
    public class LoginDataHelper
    {
        public udemy2437chaitanyaContext dbcontext;

        public LoginDataHelper()
        {
            dbcontext = new udemy2437chaitanyaContext();
        }

        public async Task<bool> LoginCheck(UserLoginDTO loginDTO)
        {
            var userList = await dbcontext.Users.Select(x => x).ToListAsync();
            foreach (var user in userList)
            {
                if (user.Email == loginDTO.email && user.Password == loginDTO.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
