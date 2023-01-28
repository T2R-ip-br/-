using FinancialAnalysis.src.controller;
using FinancialAnalysis.src.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAnalysis.src.entity
{
    /// <summary>
    ///  Класс учёта счёта
    /// </summary>
    public class Account
    {
        public int Id { get; private set; }
        private decimal accountBalance; // Остаток на счету

        public Account()
        {
            Id = GetNewId();
            accountBalance = 0;

            MainController.AddAccount(this);
        }

        public Account(int id, decimal accountBalance)
        {
            Id = id;
            this.accountBalance = accountBalance;
        }

        // Получение Id для нового счёта
        private int GetNewId()
        {
            return AccountDAO.GetNewId(); ;
        }

        public override string ToString()
        {
            return $"|id:{Id}|accountBalance:{accountBalance}";
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
        }
    }
}
