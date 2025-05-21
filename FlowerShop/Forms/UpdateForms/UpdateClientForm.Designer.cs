namespace FlowerShop
{
    partial class UpdateClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClientForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateClient = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientLastname = new System.Windows.Forms.TextBox();
            this.labelClientLastname = new System.Windows.Forms.Label();
            this.labelClientPhonenumber = new System.Windows.Forms.Label();
            this.maskedTextBoxClientPhonenumber = new System.Windows.Forms.MaskedTextBox();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelUpdateClient
            // 
            this.labelUpdateClient.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdateClient.Location = new System.Drawing.Point(1, 0);
            this.labelUpdateClient.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelUpdateClient.Name = "labelUpdateClient";
            this.labelUpdateClient.Size = new System.Drawing.Size(400, 67);
            this.labelUpdateClient.TabIndex = 0;
            this.labelUpdateClient.Text = "Изменить данные клиента";
            this.labelUpdateClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientName.Location = new System.Drawing.Point(100, 185);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientName.TabIndex = 1;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.Location = new System.Drawing.Point(100, 152);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(51, 28);
            this.labelClientName.TabIndex = 2;
            this.labelClientName.Text = "Имя";
            // 
            // textBoxClientLastname
            // 
            this.textBoxClientLastname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientLastname.Location = new System.Drawing.Point(100, 257);
            this.textBoxClientLastname.Name = "textBoxClientLastname";
            this.textBoxClientLastname.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientLastname.TabIndex = 3;
            // 
            // labelClientLastname
            // 
            this.labelClientLastname.AutoSize = true;
            this.labelClientLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientLastname.Location = new System.Drawing.Point(100, 224);
            this.labelClientLastname.Name = "labelClientLastname";
            this.labelClientLastname.Size = new System.Drawing.Size(96, 28);
            this.labelClientLastname.TabIndex = 4;
            this.labelClientLastname.Text = "Фамилия";
            // 
            // labelClientPhonenumber
            // 
            this.labelClientPhonenumber.AutoSize = true;
            this.labelClientPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientPhonenumber.Location = new System.Drawing.Point(100, 296);
            this.labelClientPhonenumber.Name = "labelClientPhonenumber";
            this.labelClientPhonenumber.Size = new System.Drawing.Size(166, 28);
            this.labelClientPhonenumber.TabIndex = 12;
            this.labelClientPhonenumber.Text = "Номер телефона";
            // 
            // maskedTextBoxClientPhonenumber
            // 
            this.maskedTextBoxClientPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBoxClientPhonenumber.Location = new System.Drawing.Point(100, 329);
            this.maskedTextBoxClientPhonenumber.Mask = "+7 (999) 000-0000";
            this.maskedTextBoxClientPhonenumber.Name = "maskedTextBoxClientPhonenumber";
            this.maskedTextBoxClientPhonenumber.Size = new System.Drawing.Size(200, 34);
            this.maskedTextBoxClientPhonenumber.TabIndex = 13;
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientEmail.Location = new System.Drawing.Point(100, 368);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(189, 28);
            this.labelClientEmail.TabIndex = 14;
            this.labelClientEmail.Text = "Электронная почта";
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientEmail.Location = new System.Drawing.Point(100, 401);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientEmail.TabIndex = 15;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 460);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientId.Location = new System.Drawing.Point(100, 113);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientId.TabIndex = 17;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientId.Location = new System.Drawing.Point(100, 80);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(29, 28);
            this.labelClientId.TabIndex = 18;
            this.labelClientId.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelClientId);
            this.panel1.Controls.Add(this.textBoxClientId);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.textBoxClientEmail);
            this.panel1.Controls.Add(this.labelClientEmail);
            this.panel1.Controls.Add(this.maskedTextBoxClientPhonenumber);
            this.panel1.Controls.Add(this.labelClientPhonenumber);
            this.panel1.Controls.Add(this.labelClientLastname);
            this.panel1.Controls.Add(this.textBoxClientLastname);
            this.panel1.Controls.Add(this.labelClientName);
            this.panel1.Controls.Add(this.textBoxClientName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 549);
            this.panel1.TabIndex = 4;
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 549);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateClientForm";
            this.Text = "Изменить данные клиента";
            this.Load += new System.EventHandler(this.UpdateClientForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateClient;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientLastname;
        private System.Windows.Forms.Label labelClientLastname;
        private System.Windows.Forms.Label labelClientPhonenumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientPhonenumber;
        private System.Windows.Forms.Label labelClientEmail;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Panel panel1;
    }
}