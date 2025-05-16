namespace FlowerShop
{
    partial class AddPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPurchaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownSumOfPur = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSumOfPurchase = new System.Windows.Forms.Label();
            this.dateTimePickerTimeOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelTimeOfIssue = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddPurchase = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfPur)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.numericUpDownSumOfPur);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelSumOfPurchase);
            this.panel1.Controls.Add(this.dateTimePickerTimeOfIssue);
            this.panel1.Controls.Add(this.labelTimeOfIssue);
            this.panel1.Controls.Add(this.dateTimePickerDateOfIssue);
            this.panel1.Controls.Add(this.labelDateOfIssue);
            this.panel1.Controls.Add(this.comboBoxIdClient);
            this.panel1.Controls.Add(this.labelIdClient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 473);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDownSumOfPur
            // 
            this.numericUpDownSumOfPur.DecimalPlaces = 2;
            this.numericUpDownSumOfPur.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownSumOfPur.Location = new System.Drawing.Point(79, 330);
            this.numericUpDownSumOfPur.Name = "numericUpDownSumOfPur";
            this.numericUpDownSumOfPur.Size = new System.Drawing.Size(200, 34);
            this.numericUpDownSumOfPur.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(79, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 50);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSumOfPurchase
            // 
            this.labelSumOfPurchase.AutoSize = true;
            this.labelSumOfPurchase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSumOfPurchase.Location = new System.Drawing.Point(79, 297);
            this.labelSumOfPurchase.Name = "labelSumOfPurchase";
            this.labelSumOfPurchase.Size = new System.Drawing.Size(155, 28);
            this.labelSumOfPurchase.TabIndex = 6;
            this.labelSumOfPurchase.Text = "Сумма покупки";
            // 
            // dateTimePickerTimeOfIssue
            // 
            this.dateTimePickerTimeOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerTimeOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeOfIssue.Location = new System.Drawing.Point(79, 258);
            this.dateTimePickerTimeOfIssue.Name = "dateTimePickerTimeOfIssue";
            this.dateTimePickerTimeOfIssue.ShowUpDown = true;
            this.dateTimePickerTimeOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerTimeOfIssue.TabIndex = 5;
            // 
            // labelTimeOfIssue
            // 
            this.labelTimeOfIssue.AutoSize = true;
            this.labelTimeOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTimeOfIssue.Location = new System.Drawing.Point(79, 225);
            this.labelTimeOfIssue.Name = "labelTimeOfIssue";
            this.labelTimeOfIssue.Size = new System.Drawing.Size(143, 28);
            this.labelTimeOfIssue.TabIndex = 4;
            this.labelTimeOfIssue.Text = "Время выдачи";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(78, 186);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerDateOfIssue.TabIndex = 3;
            // 
            // labelDateOfIssue
            // 
            this.labelDateOfIssue.AutoSize = true;
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDateOfIssue.Location = new System.Drawing.Point(78, 153);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(128, 28);
            this.labelDateOfIssue.TabIndex = 2;
            this.labelDateOfIssue.Text = "Дата выдачи";
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(76, 112);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(200, 36);
            this.comboBoxIdClient.TabIndex = 1;
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelIdClient.Location = new System.Drawing.Point(76, 79);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(101, 28);
            this.labelIdClient.TabIndex = 0;
            this.labelIdClient.Text = "Клиент ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelAddPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 70);
            this.panel2.TabIndex = 9;
            // 
            // labelAddPurchase
            // 
            this.labelAddPurchase.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelAddPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelAddPurchase.Location = new System.Drawing.Point(0, 0);
            this.labelAddPurchase.Name = "labelAddPurchase";
            this.labelAddPurchase.Size = new System.Drawing.Size(352, 70);
            this.labelAddPurchase.TabIndex = 0;
            this.labelAddPurchase.Text = "Добавить покупку";
            this.labelAddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 473);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить покупку";
            this.Load += new System.EventHandler(this.AddPurchaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfPur)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAddPurchase;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.Label labelTimeOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOfIssue;
        private System.Windows.Forms.Label labelSumOfPurchase;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownSumOfPur;
    }

}