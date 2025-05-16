namespace FlowerShop
{
    partial class AddDiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownDiscountSum = new System.Windows.Forms.NumericUpDown();
            this.labelDiscountSum = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.numericUpDownSumOfPurchases = new System.Windows.Forms.NumericUpDown();
            this.labelSumOfPurchases = new System.Windows.Forms.Label();
            this.numericUpDownAmountOfPurchases = new System.Windows.Forms.NumericUpDown();
            this.labelAmountOfPurchases = new System.Windows.Forms.Label();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAddDiscount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfPurchases)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.numericUpDownDiscountSum);
            this.panel1.Controls.Add(this.labelDiscountSum);
            this.panel1.Controls.Add(this.dateTimePickerDateOfIssue);
            this.panel1.Controls.Add(this.labelDateOfIssue);
            this.panel1.Controls.Add(this.numericUpDownSumOfPurchases);
            this.panel1.Controls.Add(this.labelSumOfPurchases);
            this.panel1.Controls.Add(this.numericUpDownAmountOfPurchases);
            this.panel1.Controls.Add(this.labelAmountOfPurchases);
            this.panel1.Controls.Add(this.comboBoxIdClient);
            this.panel1.Controls.Add(this.labelIdClient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 518);
            this.panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(80, 441);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 50);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownDiscountSum
            // 
            this.numericUpDownDiscountSum.DecimalPlaces = 2;
            this.numericUpDownDiscountSum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownDiscountSum.Location = new System.Drawing.Point(80, 391);
            this.numericUpDownDiscountSum.Name = "numericUpDownDiscountSum";
            this.numericUpDownDiscountSum.Size = new System.Drawing.Size(200, 34);
            this.numericUpDownDiscountSum.TabIndex = 5;
            // 
            // labelDiscountSum
            // 
            this.labelDiscountSum.AutoSize = true;
            this.labelDiscountSum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiscountSum.Location = new System.Drawing.Point(80, 360);
            this.labelDiscountSum.Name = "labelDiscountSum";
            this.labelDiscountSum.Size = new System.Drawing.Size(141, 28);
            this.labelDiscountSum.TabIndex = 10;
            this.labelDiscountSum.Text = "Сумма скидки";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(80, 321);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerDateOfIssue.TabIndex = 4;
            // 
            // labelDateOfIssue
            // 
            this.labelDateOfIssue.AutoSize = true;
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDateOfIssue.Location = new System.Drawing.Point(80, 290);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(128, 28);
            this.labelDateOfIssue.TabIndex = 8;
            this.labelDateOfIssue.Text = "Дата выдачи";
            // 
            // numericUpDownSumOfPurchases
            // 
            this.numericUpDownSumOfPurchases.DecimalPlaces = 2;
            this.numericUpDownSumOfPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownSumOfPurchases.Location = new System.Drawing.Point(80, 251);
            this.numericUpDownSumOfPurchases.Name = "numericUpDownSumOfPurchases";
            this.numericUpDownSumOfPurchases.Size = new System.Drawing.Size(200, 34);
            this.numericUpDownSumOfPurchases.TabIndex = 3;
            // 
            // labelSumOfPurchases
            // 
            this.labelSumOfPurchases.AutoSize = true;
            this.labelSumOfPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSumOfPurchases.Location = new System.Drawing.Point(80, 220);
            this.labelSumOfPurchases.Name = "labelSumOfPurchases";
            this.labelSumOfPurchases.Size = new System.Drawing.Size(183, 28);
            this.labelSumOfPurchases.TabIndex = 6;
            this.labelSumOfPurchases.Text = "Сумма покупок (₽)";
            // 
            // numericUpDownAmountOfPurchases
            // 
            this.numericUpDownAmountOfPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownAmountOfPurchases.Location = new System.Drawing.Point(80, 181);
            this.numericUpDownAmountOfPurchases.Name = "numericUpDownAmountOfPurchases";
            this.numericUpDownAmountOfPurchases.Size = new System.Drawing.Size(200, 34);
            this.numericUpDownAmountOfPurchases.TabIndex = 2;
            // 
            // labelAmountOfPurchases
            // 
            this.labelAmountOfPurchases.AutoSize = true;
            this.labelAmountOfPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelAmountOfPurchases.Location = new System.Drawing.Point(80, 150);
            this.labelAmountOfPurchases.Name = "labelAmountOfPurchases";
            this.labelAmountOfPurchases.Size = new System.Drawing.Size(161, 28);
            this.labelAmountOfPurchases.TabIndex = 4;
            this.labelAmountOfPurchases.Text = "Кол-во покупок";
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(80, 111);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(200, 36);
            this.comboBoxIdClient.TabIndex = 1;
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelIdClient.Location = new System.Drawing.Point(80, 80);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(109, 28);
            this.labelIdClient.TabIndex = 2;
            this.labelIdClient.Text = "ID клиента";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelAddDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 70);
            this.panel2.TabIndex = 0;
            // 
            // labelAddDiscount
            // 
            this.labelAddDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddDiscount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelAddDiscount.Location = new System.Drawing.Point(0, 0);
            this.labelAddDiscount.Name = "labelAddDiscount";
            this.labelAddDiscount.Size = new System.Drawing.Size(352, 70);
            this.labelAddDiscount.TabIndex = 0;
            this.labelAddDiscount.Text = "Добавить скидку";
            this.labelAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 518);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить скидку";
            this.Load += new System.EventHandler(this.AddDiscountForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfPurchases)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAddDiscount;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountOfPurchases;
        private System.Windows.Forms.Label labelAmountOfPurchases;
        private System.Windows.Forms.NumericUpDown numericUpDownSumOfPurchases;
        private System.Windows.Forms.Label labelSumOfPurchases;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscountSum;
        private System.Windows.Forms.Label labelDiscountSum;
        private System.Windows.Forms.Button buttonAdd;
    }
}