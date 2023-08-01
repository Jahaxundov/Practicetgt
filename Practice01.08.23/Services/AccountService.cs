using Practice01._08._23.Models;
using Practice01._08._23.Services.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01._08._23.Services
{
    internal class AccountService : IAccountService
    {
        public List<User> GetUsers()
        {
            List<User> list = new()
            {
                new User{Id=1,Email="cahangir@gmail",Password="caha12"},
                new User{Id=2,Email="sharaf@gmail",Password="sharaf12"},
                new User{Id=3,Email="pervin@gmail",Password="pervin12"}
            };
            return list;
        }

        public bool Login(string username, string password)
        {
            var users = GetUsers();

            foreach (var user in users)
            {
                if (username == user.Email && password == user.Password)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
