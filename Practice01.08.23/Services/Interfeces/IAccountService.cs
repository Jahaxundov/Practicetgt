using Practice01._08._23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01._08._23.Services.Interfeces
{
    internal interface IAccountService
    {
            bool Login(string username, string password);
            List<User> GetUsers(); 
        
    }
}
