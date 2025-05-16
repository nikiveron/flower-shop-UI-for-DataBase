namespace FlowerShop
{
    partial class UpdatePurchaseForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePurchaseForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdatePurchase = new System.Windows.Forms.Label();
            this.textBoxPurchaseId = new System.Windows.Forms.TextBox();
            this.labelPurchaseId = new System.Windows.Forms.Label();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.dateTimePickerTimeOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelTimeOfIssue = new System.Windows.Forms.Label();
            this.textBoxSumOfPurchase = new System.Windows.Forms.TextBox();
            this.labelSumOfPurchase = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdatePurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelUpdatePurchase
            // 
            this.labelUpdatePurchase.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdatePurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdatePurchase.Location = new System.Drawing.Point(1, 0);
            this.labelUpdatePurchase.Name = "labelUpdatePurchase";
            this.labelUpdatePurchase.Size = new System.Drawing.Size(400, 67);
            this.labelUpdatePurchase.TabIndex = 0;
            this.labelUpdatePurchase.Text = "Изменить данные покупки";
            this.labelUpdatePurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPurchaseId
            // 
            this.textBoxPurchaseId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPurchaseId.Location = new System.Drawing.Point(100, 108);
            this.textBoxPurchaseId.Name = "textBoxPurchaseId";
            this.textBoxPurchaseId.Size = new System.Drawing.Size(200, 34);
            this.textBoxPurchaseId.TabIndex = 1;
            // 
            // labelPurchaseId
            // 
            this.labelPurchaseId.AutoSize = true;
            this.labelPurchaseId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPurchaseId.Location = new System.Drawing.Point(100, 75);
            this.labelPurchaseId.Name = "labelPurchaseId";
            this.labelPurchaseId.Size = new System.Drawing.Size(114, 28);
            this.labelPurchaseId.TabIndex = 2;
            this.labelPurchaseId.Text = "ID покупки";
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxIdClient.Location = new System.Drawing.Point(100, 180);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(200, 34);
            this.textBoxIdClient.TabIndex = 3;
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelIdClient.Location = new System.Drawing.Point(100, 147);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(109, 28);
            this.labelIdClient.TabIndex = 4;
            this.labelIdClient.Text = "ID клиента";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(100, 252);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerDateOfIssue.TabIndex = 5;
            // 
            // labelDateOfIssue
            // 
            this.labelDateOfIssue.AutoSize = true;
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDateOfIssue.Location = new System.Drawing.Point(100, 219);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(137, 28);
            this.labelDateOfIssue.TabIndex = 6;
            this.labelDateOfIssue.Text = "Дата покупки";
            // 
            // dateTimePickerTimeOfIssue
            // 
            this.dateTimePickerTimeOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerTimeOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeOfIssue.Location = new System.Drawing.Point(100, 324);
            this.dateTimePickerTimeOfIssue.Name = "dateTimePickerTimeOfIssue";
            this.dateTimePickerTimeOfIssue.ShowUpDown = true;
            this.dateTimePickerTimeOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerTimeOfIssue.TabIndex = 7;
            // 
            // labelTimeOfIssue
            // 
            this.labelTimeOfIssue.AutoSize = true;
            this.labelTimeOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTimeOfIssue.Location = new System.Drawing.Point(100, 291);
            this.labelTimeOfIssue.Name = "labelTimeOfIssue";
            this.labelTimeOfIssue.Size = new System.Drawing.Size(152, 28);
            this.labelTimeOfIssue.TabIndex = 8;
            this.labelTimeOfIssue.Text = "Время покупки";
            // 
            // textBoxSumOfPurchase
            // 
            this.textBoxSumOfPurchase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSumOfPurchase.Location = new System.Drawing.Point(100, 397);
            this.textBoxSumOfPurchase.Name = "textBoxSumOfPurchase";
            this.textBoxSumOfPurchase.Size = new System.Drawing.Size(200, 34);
            this.textBoxSumOfPurchase.TabIndex = 9;
            // 
            // labelSumOfPurchase
            // 
            this.labelSumOfPurchase.AutoSize = true;
            this.labelSumOfPurchase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSumOfPurchase.Location = new System.Drawing.Point(100, 363);
            this.labelSumOfPurchase.Name = "labelSumOfPurchase";
            this.labelSumOfPurchase.Size = new System.Drawing.Size(155, 28);
            this.labelSumOfPurchase.TabIndex = 10;
            this.labelSumOfPurchase.Text = "Сумма покупки";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 456);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelPurchaseId);
            this.panel1.Controls.Add(this.textBoxPurchaseId);
            this.panel1.Controls.Add(this.labelIdClient);
            this.panel1.Controls.Add(this.textBoxIdClient);
            this.panel1.Controls.Add(this.labelDateOfIssue);
            this.panel1.Controls.Add(this.dateTimePickerDateOfIssue);
            this.panel1.Controls.Add(this.labelTimeOfIssue);
            this.panel1.Controls.Add(this.dateTimePickerTimeOfIssue);
            this.panel1.Controls.Add(this.labelSumOfPurchase);
            this.panel1.Controls.Add(this.textBoxSumOfPurchase);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 533);
            this.panel1.TabIndex = 1;
            // 
            // UpdatePurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 533);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePurchaseForm";
            this.Text = "Изменить данные покупки";
            this.Load += new System.EventHandler(this.UpdatePurchaseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdatePurchase;
        private System.Windows.Forms.TextBox textBoxPurchaseId;
        private System.Windows.Forms.Label labelPurchaseId;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOfIssue;
        private System.Windows.Forms.Label labelTimeOfIssue;
        private System.Windows.Forms.TextBox textBoxSumOfPurchase;
        private System.Windows.Forms.Label labelSumOfPurchase;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}
