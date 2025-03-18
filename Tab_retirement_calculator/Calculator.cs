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
    public partial class Calculator: Form
    {
        public UserModel _user;
        public Calculator(UserModel user)
        {
            _user = user;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double value = !string.IsNullOrEmpty(approximateValue.Text)
                ? Convert.ToDouble(approximateValue.Text.Replace(".", ","))
                : 0;
            yearResponse.Text = new RetirementCalculator().responseYear(Convert.ToInt32(year.Text), Convert.ToInt32(workedYear.Text), _user.gender, value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
