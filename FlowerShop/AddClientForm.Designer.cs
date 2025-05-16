namespace FlowerShop
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxClientPhonenumber = new System.Windows.Forms.MaskedTextBox();
            this.labelClientPhonenumber = new System.Windows.Forms.Label();
            this.dateTimePickerClientBirthdate = new System.Windows.Forms.DateTimePicker();
            this.labelClientBirthdate = new System.Windows.Forms.Label();
            this.comboBoxClientSex = new System.Windows.Forms.ComboBox();
            this.labelClientSex = new System.Windows.Forms.Label();
            this.labelClientLastname = new System.Windows.Forms.Label();
            this.textBoxClientLastname = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.textBoxClientEmail);
            this.panel1.Controls.Add(this.labelClientEmail);
            this.panel1.Controls.Add(this.maskedTextBoxClientPhonenumber);
            this.panel1.Controls.Add(this.labelClientPhonenumber);
            this.panel1.Controls.Add(this.dateTimePickerClientBirthdate);
            this.panel1.Controls.Add(this.labelClientBirthdate);
            this.panel1.Controls.Add(this.comboBoxClientSex);
            this.panel1.Controls.Add(this.labelClientSex);
            this.panel1.Controls.Add(this.labelClientLastname);
            this.panel1.Controls.Add(this.textBoxClientLastname);
            this.panel1.Controls.Add(this.labelClientName);
            this.panel1.Controls.Add(this.textBoxClientName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 652);
            this.panel1.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(80, 565);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 50);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientEmail.Location = new System.Drawing.Point(80, 506);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientEmail.TabIndex = 15;
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientEmail.Location = new System.Drawing.Point(80, 470);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(189, 28);
            this.labelClientEmail.TabIndex = 14;
            this.labelClientEmail.Text = "Электронная почта";
            // 
            // maskedTextBoxClientPhonenumber
            // 
            this.maskedTextBoxClientPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBoxClientPhonenumber.Location = new System.Drawing.Point(80, 423);
            this.maskedTextBoxClientPhonenumber.Mask = "+7 (999) 000-0000";
            this.maskedTextBoxClientPhonenumber.Name = "maskedTextBoxClientPhonenumber";
            this.maskedTextBoxClientPhonenumber.Size = new System.Drawing.Size(200, 34);
            this.maskedTextBoxClientPhonenumber.TabIndex = 13;
            // 
            // labelClientPhonenumber
            // 
            this.labelClientPhonenumber.AutoSize = true;
            this.labelClientPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientPhonenumber.Location = new System.Drawing.Point(80, 389);
            this.labelClientPhonenumber.Name = "labelClientPhonenumber";
            this.labelClientPhonenumber.Size = new System.Drawing.Size(166, 28);
            this.labelClientPhonenumber.TabIndex = 12;
            this.labelClientPhonenumber.Text = "Номер телефона";
            // 
            // dateTimePickerClientBirthdate
            // 
            this.dateTimePickerClientBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerClientBirthdate.Location = new System.Drawing.Point(80, 346);
            this.dateTimePickerClientBirthdate.Name = "dateTimePickerClientBirthdate";
            this.dateTimePickerClientBirthdate.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerClientBirthdate.TabIndex = 10;
            // 
            // labelClientBirthdate
            // 
            this.labelClientBirthdate.AutoSize = true;
            this.labelClientBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientBirthdate.Location = new System.Drawing.Point(80, 315);
            this.labelClientBirthdate.Name = "labelClientBirthdate";
            this.labelClientBirthdate.Size = new System.Drawing.Size(153, 28);
            this.labelClientBirthdate.TabIndex = 8;
            this.labelClientBirthdate.Text = "Дата рождения";
            // 
            // comboBoxClientSex
            // 
            this.comboBoxClientSex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxClientSex.FormattingEnabled = true;
            this.comboBoxClientSex.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.comboBoxClientSex.Location = new System.Drawing.Point(80, 268);
            this.comboBoxClientSex.Name = "comboBoxClientSex";
            this.comboBoxClientSex.Size = new System.Drawing.Size(200, 36);
            this.comboBoxClientSex.TabIndex = 7;
            // 
            // labelClientSex
            // 
            this.labelClientSex.AutoSize = true;
            this.labelClientSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSex.Location = new System.Drawing.Point(80, 237);
            this.labelClientSex.Name = "labelClientSex";
            this.labelClientSex.Size = new System.Drawing.Size(49, 28);
            this.labelClientSex.TabIndex = 6;
            this.labelClientSex.Text = "Пол";
            // 
            // labelClientLastname
            // 
            this.labelClientLastname.AutoSize = true;
            this.labelClientLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientLastname.Location = new System.Drawing.Point(80, 160);
            this.labelClientLastname.Name = "labelClientLastname";
            this.labelClientLastname.Size = new System.Drawing.Size(96, 28);
            this.labelClientLastname.TabIndex = 4;
            this.labelClientLastname.Text = "Фамилия";
            // 
            // textBoxClientLastname
            // 
            this.textBoxClientLastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientLastname.Location = new System.Drawing.Point(80, 191);
            this.textBoxClientLastname.Name = "textBoxClientLastname";
            this.textBoxClientLastname.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientLastname.TabIndex = 3;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(80, 84);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(51, 28);
            this.labelClientName.TabIndex = 2;
            this.labelClientName.Text = "Имя";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientName.Location = new System.Drawing.Point(80, 115);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelAddClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelAddClient
            // 
            this.labelAddClient.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelAddClient.Location = new System.Drawing.Point(1, 0);
            this.labelAddClient.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(350, 67);
            this.labelAddClient.TabIndex = 0;
            this.labelAddClient.Text = "Добавить клиента";
            this.labelAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 652);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAddClient;
        private System.Windows.Forms.Label labelClientSex;
        private System.Windows.Forms.Label labelClientLastname;
        private System.Windows.Forms.TextBox textBoxClientLastname;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.ComboBox comboBoxClientSex;
        private System.Windows.Forms.Label labelClientBirthdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerClientBirthdate;
        private System.Windows.Forms.Label labelClientPhonenumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientPhonenumber;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Button buttonAdd;
    }
}