namespace FlowerShop
{
    partial class UpdateDiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDiscountForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateDiscount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDiscountId = new System.Windows.Forms.Label();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelAmountPurchases = new System.Windows.Forms.Label();
            this.textBoxAmountPurchases = new System.Windows.Forms.TextBox();
            this.labelSumPurchases = new System.Windows.Forms.Label();
            this.textBoxSumPurchases = new System.Windows.Forms.TextBox();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.labelDiscountSum = new System.Windows.Forms.Label();
            this.textBoxDiscountSum = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 70);
            this.panel2.TabIndex = 13;
            // 
            // labelUpdateDiscount
            // 
            this.labelUpdateDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpdateDiscount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateDiscount.Location = new System.Drawing.Point(0, 0);
            this.labelUpdateDiscount.Name = "labelUpdateDiscount";
            this.labelUpdateDiscount.Size = new System.Drawing.Size(402, 70);
            this.labelUpdateDiscount.TabIndex = 0;
            this.labelUpdateDiscount.Text = "Изменить скидку";
            this.labelUpdateDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelDiscountId);
            this.panel1.Controls.Add(this.textBoxDiscountId);
            this.panel1.Controls.Add(this.labelClientId);
            this.panel1.Controls.Add(this.textBoxClientId);
            this.panel1.Controls.Add(this.labelAmountPurchases);
            this.panel1.Controls.Add(this.textBoxAmountPurchases);
            this.panel1.Controls.Add(this.labelSumPurchases);
            this.panel1.Controls.Add(this.textBoxSumPurchases);
            this.panel1.Controls.Add(this.labelDateOfIssue);
            this.panel1.Controls.Add(this.dateTimePickerDateOfIssue);
            this.panel1.Controls.Add(this.labelDiscountSum);
            this.panel1.Controls.Add(this.textBoxDiscountSum);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 600);
            this.panel1.TabIndex = 0;
            // 
            // labelDiscountId
            // 
            this.labelDiscountId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiscountId.Location = new System.Drawing.Point(100, 75);
            this.labelDiscountId.Name = "labelDiscountId";
            this.labelDiscountId.Size = new System.Drawing.Size(200, 30);
            this.labelDiscountId.TabIndex = 0;
            this.labelDiscountId.Text = "ID дисконта";
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDiscountId.Location = new System.Drawing.Point(100, 110);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.Size = new System.Drawing.Size(200, 34);
            this.textBoxDiscountId.TabIndex = 1;
            // 
            // labelClientId
            // 
            this.labelClientId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelClientId.Location = new System.Drawing.Point(100, 149);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(200, 30);
            this.labelClientId.TabIndex = 2;
            this.labelClientId.Text = "ID клиента";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientId.Location = new System.Drawing.Point(100, 184);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientId.TabIndex = 3;
            // 
            // labelAmountPurchases
            // 
            this.labelAmountPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelAmountPurchases.Location = new System.Drawing.Point(100, 223);
            this.labelAmountPurchases.Name = "labelAmountPurchases";
            this.labelAmountPurchases.Size = new System.Drawing.Size(200, 30);
            this.labelAmountPurchases.TabIndex = 4;
            this.labelAmountPurchases.Text = "Количество покупок";
            // 
            // textBoxAmountPurchases
            // 
            this.textBoxAmountPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmountPurchases.Location = new System.Drawing.Point(100, 258);
            this.textBoxAmountPurchases.Name = "textBoxAmountPurchases";
            this.textBoxAmountPurchases.Size = new System.Drawing.Size(200, 34);
            this.textBoxAmountPurchases.TabIndex = 5;
            // 
            // labelSumPurchases
            // 
            this.labelSumPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSumPurchases.Location = new System.Drawing.Point(100, 297);
            this.labelSumPurchases.Name = "labelSumPurchases";
            this.labelSumPurchases.Size = new System.Drawing.Size(200, 30);
            this.labelSumPurchases.TabIndex = 6;
            this.labelSumPurchases.Text = "Сумма покупок";
            // 
            // textBoxSumPurchases
            // 
            this.textBoxSumPurchases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSumPurchases.Location = new System.Drawing.Point(100, 332);
            this.textBoxSumPurchases.Name = "textBoxSumPurchases";
            this.textBoxSumPurchases.Size = new System.Drawing.Size(200, 34);
            this.textBoxSumPurchases.TabIndex = 7;
            // 
            // labelDateOfIssue
            // 
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDateOfIssue.Location = new System.Drawing.Point(100, 371);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(200, 30);
            this.labelDateOfIssue.TabIndex = 8;
            this.labelDateOfIssue.Text = "Дата выдачи";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(100, 406);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(200, 34);
            this.dateTimePickerDateOfIssue.TabIndex = 9;
            // 
            // labelDiscountSum
            // 
            this.labelDiscountSum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDiscountSum.Location = new System.Drawing.Point(100, 445);
            this.labelDiscountSum.Name = "labelDiscountSum";
            this.labelDiscountSum.Size = new System.Drawing.Size(200, 30);
            this.labelDiscountSum.TabIndex = 10;
            this.labelDiscountSum.Text = "Сумма скидки (%)";
            // 
            // textBoxDiscountSum
            // 
            this.textBoxDiscountSum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDiscountSum.Location = new System.Drawing.Point(100, 480);
            this.textBoxDiscountSum.Name = "textBoxDiscountSum";
            this.textBoxDiscountSum.Size = new System.Drawing.Size(200, 34);
            this.textBoxDiscountSum.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 540);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 600);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateDiscountForm";
            this.Text = "Изменить данные скидки";
            this.Load += new System.EventHandler(this.UpdateDiscountForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDiscountId;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelAmountPurchases;
        private System.Windows.Forms.TextBox textBoxAmountPurchases;
        private System.Windows.Forms.Label labelSumPurchases;
        private System.Windows.Forms.TextBox textBoxSumPurchases;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.Label labelDiscountSum;
        private System.Windows.Forms.TextBox textBoxDiscountSum;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
