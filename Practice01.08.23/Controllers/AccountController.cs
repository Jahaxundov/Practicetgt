using Practice01._08._23.Services.Helpers;
using Practice01._08._23.Services.Interfeces;
using Practice01._08._23.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01._08._23.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Add email");
        Email: string email = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();

            bool isLogin = _accountService.Login(email, password);

            if (isLogin)
            {
                switch (password) { }   
            }
            else
            {
                Console.WriteLine(AccountMessage.LoginFailed);
                goto Email;
            }

        }
    }
}
