using FinancialAnalysis.src.entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAnalysis.src.dao
{
    public class UserDAO
    {
        private static MainDAO mainDAO = new MainDAO();

        // NF - Name File
        private const string NF_USER_TXT = "user.txt";
        private const string NF_USER_ID_TXT = "user_id.txt";

        // Получение id для нового пользователя
        public static int GetNewId()
        {
            return mainDAO.GetNewId(NF_USER_ID_TXT);
        }

        // Добавление записи о новом пользователе
        public void AddUser(User user)
        {
            mainDAO.AddRecord(user, NF_USER_TXT);
        }

        // Получение пользователя по логину
        public User GetUserByLogin(string login)
        {
            string fullPath = mainDAO.GetFullPath(NF_USER_TXT);
            User user = null;

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string result;
                    while ((result = reader.ReadLine()) != null)
                    {
                        if (result.Substring(result.IndexOf("|login:") + 7, result.IndexOf("|password:") - result.IndexOf("|login:") - 7) == login)
                        {
                            int id = int.Parse(result.Substring(result.IndexOf("|id:") + 4, result.IndexOf("|firstname:") - result.IndexOf("|id:") - 4));
                            string firstname = result.Substring(result.IndexOf("|firstname:") + 11, result.IndexOf("|lastname:") - result.IndexOf("|firstname:") - 11);
                            string lastname = result.Substring(result.IndexOf("|lastname:") + 10, result.IndexOf("|login:") - result.IndexOf("|lastname:") - 10);
                            string password = result.Substring(result.IndexOf("|password:") + 10, result.IndexOf("|accountId:") - result.IndexOf("|password:") - 10);
                            int accountId = int.Parse(result.Substring(result.IndexOf("|accountId:") + 11, result.Length - result.IndexOf("|accountId:") - 11));

                            return new User(id, firstname, lastname, login, password, accountId);
                        }
                    }
                }
            }

            return user;
        }

        internal User GetUserById(int userId)
        {
            string fullPath = mainDAO.GetFullPath(NF_USER_TXT);
            User user = null;

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string result;
                    while ((result = reader.ReadLine()) != null)
                    {
                        if (int.Parse(result.Substring(result.IndexOf("|id:") + 4, result.IndexOf("|firstname:") - result.IndexOf("|id:") - 4)) == userId)
                        {
                            int id = int.Parse(result.Substring(result.IndexOf("|id:") + 4, result.IndexOf("|firstname:") - result.IndexOf("|id:") - 4));
                            string firstname = result.Substring(result.IndexOf("|firstname:") + 11, result.IndexOf("|lastname:") - result.IndexOf("|firstname:") - 11);
                            string lastname = result.Substring(result.IndexOf("|lastname:") + 10, result.IndexOf("|login:") - result.IndexOf("|lastname:") - 10);
                            string login = result.Substring(result.IndexOf("|login:") + 7, result.IndexOf("|password:") - result.IndexOf("|login:") - 7);
                            string password = result.Substring(result.IndexOf("|password:") + 10, result.IndexOf("|accountId:") - result.IndexOf("|password:") - 10);
                            int accountId = int.Parse(result.Substring(result.IndexOf("|accountId:") + 11, result.Length - result.IndexOf("|accountId:") - 11));

                            return new User(id, firstname, lastname, login, password, accountId);
                        }
                    }
                }
            }

            return user;
        }
    }
}
