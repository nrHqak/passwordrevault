=== GENERATING: AddEntryForm.Designer.cs ===
namespace PasswordVault
{
    partial class AddEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.groupBoxGenerator = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkLetters = new System.Windows.Forms.CheckBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Добавить / Редактировать запись";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 50);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(98, 13);
            this.lblService.TabIndex = 1;
            this.lblService.Text = "Название сервиса:";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(15, 66);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(440, 20);
            this.txtService.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 95);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 111);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(440, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 140);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(400, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Location = new System.Drawing.Point(421, 154);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(34, 23);
            this.btnTogglePassword.TabIndex = 7;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.UseVisualStyleBackColor = true;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // groupBoxGenerator
            // 
            this.groupBoxGenerator.Controls.Add(this.btnGenerate);
            this.groupBoxGenerator.Controls.Add(this.chkSymbols);
            this.groupBoxGenerator.Controls.Add(this.chkDigits);
            this.groupBoxGenerator.Controls.Add(this.chkLetters);
            this.groupBoxGenerator.Controls.Add(this.numLength);
            this.groupBoxGenerator.Controls.Add(this.lblLength);
            this.groupBoxGenerator.Location = new System.Drawing.Point(15, 190);
            this.groupBoxGenerator.Name = "groupBoxGenerator";
            this.groupBoxGenerator.Size = new System.Drawing.Size(440, 130);
            this.groupBoxGenerator.TabIndex = 8;
            this.groupBoxGenerator.TabStop = false;
            this.groupBoxGenerator.Text = "Генератор паролей";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(95)))), ((int)(((byte)(163)))));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(10, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(420, 30);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "СГЕНЕРИРОВАТЬ";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Location = new System.Drawing.Point(280, 55);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(130, 17);
            this.chkSymbols.TabIndex = 4;
            this.chkSymbols.Text = "Спецсимволы (!@#)";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Location = new System.Drawing.Point(140, 55);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(95, 17);
            this.chkDigits.TabIndex = 3;
            this.chkDigits.Text = "Цифры (0-9)";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkLetters
            // 
            this.chkLetters.AutoSize = true;
            this.chkLetters.Checked = true;
            this.chkLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetters.Location = new System.Drawing.Point(10, 55);
            this.chkLetters.Name = "chkLetters";
            this.chkLetters.Size = new System.Drawing.Size(100, 17);
            this.chkLetters.TabIndex = 2;
            this.chkLetters.Text = "Буквы (A-Z)";
            this.chkLetters.UseVisualStyleBackColor = true;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(55, 25);
            this.numLength.Maximum = new decimal(new int[] {32, 0, 0, 0});
            this.numLength.Minimum = new decimal(new int[] {6, 0, 0, 0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(50, 20);
            this.numLength.TabIndex = 1;
            this.numLength.Value = new decimal(new int[] {12, 0, 0, 0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(10, 27);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Длина:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "СОХРАНИТЬ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxGenerator);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить / Редактировать запись";
            this.groupBoxGenerator.ResumeLayout(false);
            this.groupBoxGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.GroupBox groupBoxGenerator;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.CheckBox chkLetters;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
