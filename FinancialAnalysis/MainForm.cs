using FinancialAnalysis.src.controller;
using FinancialAnalysis.src.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinancialAnalysis
{
    public partial class MainForm : Form
    {
        private User user;
        private Account account;

        public MainForm(int userId)
        {
            InitializeComponent();
            user = MainController.GetUserById(userId);
            account = MainController.GetAccountById(user.AccountId);
            FormGeneration();
        }

        private void FormGeneration()
        {
            lbIdUser.Text = $"#0.{user.Id}";
            lbName.Text = $"{user.LastName} {user.FirstName}";
            lbBalance.Text = $"{account.AccountBalance.ToString("0.00")} ₽";
        }

    }
}
