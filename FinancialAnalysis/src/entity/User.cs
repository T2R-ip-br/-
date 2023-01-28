using FinancialAnalysis.src.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAnalysis.src.entity
{
    /// <summary>
    /// Класс пользователей системы
    /// </summary>
    public class User
    {
        private int id;           // id
        private string firstName; // Имя
        private string lastName;  // Фамилия
        private string login;     // Логин
        private string password;  // Пароль
        private int accountId;

        public User() { }

        public User(string firstName, string lastName, string login, string password)
        {
            id = GetNewId();
            this.firstName = firstName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            accountId = new Account().Id;
        }

        public User(int id, string firstName, string lastName, string login, string password, int account)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            this.accountId = accountId;
        }

        // Получение Id для нового пользователя
        private int GetNewId()
        {
            return UserDAO.GetNewId(); ;
        }

        public override string ToString()
        {
            return $"|id:{id}|firstname:{firstName}|lastname:{lastName}|login:{login}|password:{password}|accountId:{accountId}";
        }

        public int Id
        {
            get { return id ; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string Password
        {
            get { return password ; }
        }

        public string Login
        {
            get { return login; }
        }

        public int AccountId
        {
            get { return accountId; }
        }
    }
}
