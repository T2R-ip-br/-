using FinancialAnalysis.src.dao;
using FinancialAnalysis.src.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinancialAnalysis.src.service
{
    class UserService
    {
		private UserDAO userDAO = new UserDAO();

        private const string USER_NOT_FOUND = "Пользователь не найден";
        private const string INVALID_PASSWORD = "Неверный пароль";

        // Обработка запроса на авторизацию пользователя
        internal int UserAutorization(string login, string password)
        {
            try
            {
                User user = userDAO.GetUserByLogin(login);

                if (user == null)
                {
                    return -1; // Пользователь не найден
                }
                else if (user.Password != password)
                {
                    return -2; // Неправильный пароль
                }

                return user.Id;
            }
            catch
            {
                return -3; // Ошибка авторизации
            }
        }

		// Обработка запроса на регистрацию пользователя
        internal int UserRegistration(string name, string lastname, string login, string password)
        {
			try
			{
                // Проверка на занятость логина
                User temp = userDAO.GetUserByLogin(login);
                if (temp != null ) {  
                    return -1;
                }

                User user = new User(name, lastname, login, password);
				userDAO.AddUser(user);

				return 0;
			}
			catch
			{
				return -2;
			}
        }

        internal User GetUserById(int userId)
        {
            return userDAO.GetUserById(userId);
        }
    }
}
