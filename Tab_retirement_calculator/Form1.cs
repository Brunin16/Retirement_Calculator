using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tab_retirement_calculator.Model;
using Tab_retirement_calculator.Service;

namespace Tab_retirement_calculator
{
    public partial class Form1: Form
    {
        public UserFunctions _userFunctions;
        public Form1(UserFunctions userFunctions)
        {
            InitializeComponent();
            this._userFunctions = userFunctions;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            UserModel user = _userFunctions.login(username.Text, password.Text);
            if (user != null)
            {
                MessageBox.Show("Login efetuado com sucesso");
                new MenuUser(_userFunctions, user).Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Usuario ou senha incorretos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
