using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tab_retirement_calculator.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tab_retirement_calculator
{
    public partial class Register: Form
    {
        public UserFunctions _userFunctions;
        public Register()
        {
            InitializeComponent();
            FillComboBox();
        }
        public Register(UserFunctions _userFunctions)
        {
            InitializeComponent();
            this._userFunctions = _userFunctions;
            FillComboBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            _userFunctions.register(username.Text, password.Text, comboBox1.SelectedItem.ToString());
            MessageBox.Show("Usuario registrado com sucesso");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("H");
            comboBox1.Items.Add("M");
            comboBox1.SelectedIndex = 0;
        }
    }
}
