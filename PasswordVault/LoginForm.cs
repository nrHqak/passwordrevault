using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtMasterPassword.Text == "admin123")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMasterPassword.Clear();
            }
        }
    }
}
