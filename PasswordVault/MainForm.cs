=== GENERATING: MainForm.cs ===
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class MainForm : Form
    {
        private List<PasswordEntry> _entries;

        public MainForm()
        {
            InitializeComponent();
            dgvPasswords.AutoGenerateColumns = false;
            InitializeDataGridView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _entries = VaultStorage.Load();
            RefreshGrid();
        }

        private void InitializeDataGridView()
        {
            dgvPasswords.Columns.Add(new DataGridViewTextBoxColumn { Name = "Service", HeaderText = "Сервис", Width = 200, DataPropertyName = "ServiceName" });
            dgvPasswords.Columns.Add(new DataGridViewTextBoxColumn { Name = "Login", HeaderText = "Логин", Width = 200, DataPropertyName = "Login" });
            dgvPasswords.Columns.Add(new DataGridViewTextBoxColumn { Name = "Password", HeaderText = "Пароль", Width = 150 });

            var showButton = new DataGridViewButtonColumn();
            showButton.Name = "Show";
            showButton.HeaderText = "";
            showButton.Text = "Показать";
            showButton.UseColumnTextForButtonValue = true;
            showButton.Width = 60;
            dgvPasswords.Columns.Add(showButton);

            var copyButton = new DataGridViewButtonColumn();
            copyButton.Name = "Copy";
            copyButton.HeaderText = "";
            copyButton.Text = "Копировать";
            copyButton.UseColumnTextForButtonValue = true;
            copyButton.Width = 80;
            dgvPasswords.Columns.Add(copyButton);

            var editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "";
            editButton.Text = "Изменить";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 70;
            dgvPasswords.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "Удалить";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 70;
            dgvPasswords.Columns.Add(deleteButton);
        }

        private void RefreshGrid()
        {
            dgvPasswords.Rows.Clear();
            foreach (var entry in _entries.Where(e => e.ServiceName.ToLower().Contains(txtSearch.Text.ToLower())))
            {
                dgvPasswords.Rows.Add(entry.ServiceName, entry.Login, "••••••");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvPasswords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var senderGrid = (DataGridView)sender;
            var entry = _entries.Where(pe => pe.ServiceName.ToLower().Contains(txtSearch.Text.ToLower())).ToList()[e.RowIndex];

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                switch (senderGrid.Columns[e.ColumnIndex].Name)
                {
                    case "Show":
                        MessageBox.Show(EncryptionHelper.Decrypt(entry.Password), entry.ServiceName);
                        break;
                    case "Copy":
                        Clipboard.SetText(EncryptionHelper.Decrypt(entry.Password));
                        MessageBox.Show("Скопировано!", "КриптоСейф", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Edit":
                        using (AddEntryForm addEntryForm = new AddEntryForm(entry))
                        {
                            if (addEntryForm.ShowDialog() == DialogResult.OK)
                            {
                                var updatedEntry = addEntryForm.ResultEntry;
                                entry.ServiceName = updatedEntry.ServiceName;
                                entry.Login = updatedEntry.Login;
                                entry.Password = updatedEntry.Password;
                                VaultStorage.Save(_entries);
                                RefreshGrid();
                            }
                        }
                        break;
                    case "Delete":
                        if (MessageBox.Show($"Удалить запись для {entry.ServiceName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _entries.Remove(entry);
                            VaultStorage.Save(_entries);
                            RefreshGrid();
                        }
                        break;
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (AddEntryForm addEntryForm = new AddEntryForm())
            {
                if (addEntryForm.ShowDialog() == DialogResult.OK)
                {
                    _entries.Add(addEntryForm.ResultEntry);
                    VaultStorage.Save(_entries);
                    RefreshGrid();
                }
            }
        }
    }
}
