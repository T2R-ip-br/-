using FinancialAnalysis.src.entity;
using FinancialAnalysis.src.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinancialAnalysis.src.controller
{
    public static class MainController
    {
        private static UserService userService = new UserService();
        private static AccountService accountService = new AccountService();

        // Запрос на добавление счёта
        internal static void AddAccount(Account account)
        {
            accountService.AddAccount(account);
        }

        internal static Account GetAccountById(int accountId)
        {
            return accountService.GetAccountById(accountId);
        }

        internal static User GetUserById(int userId)
        {
            return userService.GetUserById(userId);
        }

        // Запрос на авторизацию пользователя
        internal static int UserAutorization(string login, string password)
        {
            return userService.UserAutorization(login, password);
        }

        // Запрос на регистрацию пользователя 
        internal static int UserRegistration(string name, string lastname, string login, string password)
        {
            return userService.UserRegistration(name, lastname, login, password);
        }
    }
}
