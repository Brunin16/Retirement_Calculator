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
    public partial class MenuUser: Form
    {
        public UserFunctions _userFunctions;
        public UserModel _user;
        public MenuUser()
        {
            InitializeComponent();
        }
        public MenuUser(UserFunctions userFunctions, UserModel user)
        {
            InitializeComponent();
            this._userFunctions = userFunctions;
            this._user = user;
        }

        private void MenuUser_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1(_userFunctions).Show();
        }

        private void aponsetadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Calculator(_user).Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Register(_userFunctions).Show();
        }
    }
}
