using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class AddEntryForm : Form
    {
        public PasswordEntry ResultEntry { get; private set; }

        public AddEntryForm(PasswordEntry existingEntry = null)
        {
            InitializeComponent();

            if (existingEntry != null)
            {
                txtService.Text = existingEntry.ServiceName;
                txtLogin.Text = existingEntry.Login;
                txtPassword.Text = EncryptionHelper.Decrypt(existingEntry.Password);
                this.Text = "Редактировать запись";
                lblTitle.Text = "Редактировать запись";
            }
            else
            {
                this.Text = "Добавить запись";
                lblTitle.Text = "Добавить запись";
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '•') ? '\0' : '•';
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(numLength.Value);
            bool useLetters = chkLetters.Checked;
            bool useDigits = chkDigits.Checked;
            bool useSymbols = chkSymbols.Checked;

            txtPassword.Text = PasswordGenerator.Generate(length, useLetters, useDigits, useSymbols);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtService.Text) || string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResultEntry = new PasswordEntry(txtService.Text, txtLogin.Text, EncryptionHelper.Encrypt(txtPassword.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
