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
using System.Xml.Linq;

namespace FinancialAnalysis
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        const string AUTHORIZATION_ERROR = "Во время авторизации произошла ошибка. Проверьте корректность введёных данных!";
        const string EMPTY_FIELDS_ERROR = "Все поля должны быть заполнены!";
        const string USER_NOT_FOUND_ERROR = "Пользователь с данным логином не найден";
        const string INCORRECT_PASSWORD_ERROR = "Неправильный пароль";
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

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

        private void lbRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            // Открываем окно после того как регистрация была выполнена
            registrationForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); }; 
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void lbAuthorization_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (tbLogin.Text != "" && tbPassword.Text != "")
                {
                    int userId = MainController.UserAutorization(tbLogin.Text, tbPassword.Text);
                    if (userId >= 0)
                        Invoke(new Action(() =>
                        {
                            // TODO: Открытие страницы с финансами и передача userId
                            this.Hide();
                            tbLogin.Text = "";
                            tbLogin_Leave(sender, e);
                            tbPassword.Text = "";
                            tbPassword_Leave(sender, e);
                            MainForm mainForm = new MainForm(userId);
                            mainForm.Show();
                            mainForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                        }));
                    else if (userId == -1)
                        MessageBox.Show(USER_NOT_FOUND_ERROR);
                    else if (userId == -2)
                        MessageBox.Show(INCORRECT_PASSWORD_ERROR);
                    else
                        MessageBox.Show(AUTHORIZATION_ERROR);
                }
                else
                    MessageBox.Show(EMPTY_FIELDS_ERROR);

            });
        }
    }
}
