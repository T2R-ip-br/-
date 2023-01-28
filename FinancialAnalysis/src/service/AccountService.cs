using FinancialAnalysis.src.dao;
using FinancialAnalysis.src.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAnalysis.src.service
{
    internal class AccountService
    {
        AccountDAO accountDAO = new AccountDAO();

        internal void AddAccount(Account account)
        {
            accountDAO.AddAccount(account);
        }

        internal Account GetAccountById(int accountId)
        {
            return accountDAO.GetAccountById(accountId);
        }
    }
}
