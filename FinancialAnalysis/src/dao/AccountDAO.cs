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
    public class AccountDAO
    {
        private static MainDAO mainDAO = new MainDAO();

        // NF - Name File
        private const string NF_ACCOUNT_TXT = "account.txt";
        private const string NF_ACCOUNT_ID_TXT = "account_id.txt";

        // Получение id для нового счёта
        public static int GetNewId()
        {
            return mainDAO.GetNewId(NF_ACCOUNT_ID_TXT);
        }

        // Добавление записи о новом пользователе
        public void AddAccount(Account account)
        {
            mainDAO.AddRecord(account, NF_ACCOUNT_TXT);
        }

        internal Account GetAccountById(int accountId)
        {
            string fullPath = mainDAO.GetFullPath(NF_ACCOUNT_TXT);

            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string result;
                    while ((result = reader.ReadLine()) != null)
                    {
                        if (int.Parse(result.Substring(result.IndexOf("|id:") + 4, result.IndexOf("|accountBalance:") - result.IndexOf("|id:") - 4)) == accountId)
                        {
                            int id = accountId;
                            decimal accountBalance = decimal.Parse(result.Substring(result.IndexOf("|accountBalance:") + 16, result.Length - result.IndexOf("|accountBalance:") - 16));

                            return new Account(id, accountBalance);
                        }
                    }
                }
            }

            Account account = null;
            return account;
        }
    }
}
