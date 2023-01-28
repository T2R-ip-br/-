using FinancialAnalysis.src.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAnalysis
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        const string REG_ERROR = "Во время регистрации произошла ошибка. Проверьте корректность введёных данных!";
        const string EMPTY_FIELDS_ERROR = "Все поля должны быть заполнены!";
        const string LOGIN_IS_USED_ERROR = "Указанный логин уже используется";


        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "логин")
                tbLogin.Text = "";
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "пароль")
                tbPassword.Text = "";
        }
        private void tbLastname_Enter(object sender, EventArgs e)
        {
            if (tbLastname.Text == "фамилия")
                tbLastname.Text = "";
        }
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "имя")
                tbName.Text = "";
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (tbLogin.Text.Length == 0)
                tbLogin.Text = "логин";
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length == 0)
                tbPassword.Text = "пароль";
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
                tbName.Text = "имя";
        }

        private void tbLastname_Leave(object sender, EventArgs e)
        {
            if (tbLastname.Text.Length == 0)
                tbLastname.Text = "фамилия";
        }

        /// <summary>
        /// Регистрация пользователя, выполняется после нажатия на кнопку "Готово" на форме регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void lbRegistration_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (tbName.Text != "" && tbLastname.Text != "" && tbLogin.Text != "" && tbPassword.Text != "") {
                    int statusReg = MainController.UserRegistration(tbName.Text, tbLastname.Text, tbLogin.Text, tbPassword.Text);
                    if (statusReg == 0)
                        Invoke(new Action(() =>
                        {
                            this.Close();
                        }));
                    else if (statusReg == -1)
                        MessageBox.Show(LOGIN_IS_USED_ERROR);
                    else
                        MessageBox.Show(REG_ERROR);
                }
                else
                    MessageBox.Show(EMPTY_FIELDS_ERROR);
                
            });
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
