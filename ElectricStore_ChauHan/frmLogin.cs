using ElectricStore_ChauHan_Repository.Repository;
using ElectricStore_ChauHan_Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_ChauHan
{
    public partial class frmLogin : Form
    {
        private IUserRepository _userRepository;
        public frmLogin()
        {
            _userRepository = new UserStore();
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("You have to enter User Name");
                txtUserName.Focus();
                return;
            }


            if (txtPass.Text == "")
            {
                MessageBox.Show("You have to enter Password");
                txtPass.Focus();
                return;
            }

            var member = _userRepository.GetUsers()
                .FirstOrDefault(m => m.UserName == txtUserName.Text && m.Password == txtPass.Text);

            if (member == null)
            {
                MessageBox.Show("User Name or Password is Invalid...");
            }
            else
            {
                if (member.UserRole == 1)
                {
                    frmManagement frmLogin = new();
                    frmLogin.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have no permission to access this function!");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }
    }
}
