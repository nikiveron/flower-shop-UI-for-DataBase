namespace FlowerShop
{
    partial class DeleteDiscountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDiscountForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectDiscountId = new System.Windows.Forms.Label();
            this.textBoxDiscountId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeleteDiscount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectDiscountId);
            this.panel1.Controls.Add(this.textBoxDiscountId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 353);
            this.panel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "клиента",
            "скидки"});
            this.checkedListBox1.Location = new System.Drawing.Point(79, 118);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 58);
            this.checkedListBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Удалить скидку по ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(79, 277);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSelectDiscountId
            // 
            this.labelSelectDiscountId.AutoSize = true;
            this.labelSelectDiscountId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectDiscountId.Location = new System.Drawing.Point(79, 185);
            this.labelSelectDiscountId.Name = "labelSelectDiscountId";
            this.labelSelectDiscountId.Size = new System.Drawing.Size(109, 28);
            this.labelSelectDiscountId.TabIndex = 2;
            this.labelSelectDiscountId.Text = "Введите ID";
            this.labelSelectDiscountId.Click += new System.EventHandler(this.labelSelectDiscountId_Click);
            // 
            // textBoxDiscountId
            // 
            this.textBoxDiscountId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDiscountId.Location = new System.Drawing.Point(79, 223);
            this.textBoxDiscountId.Name = "textBoxDiscountId";
            this.textBoxDiscountId.Size = new System.Drawing.Size(200, 34);
            this.textBoxDiscountId.TabIndex = 1;
            this.textBoxDiscountId.TextChanged += new System.EventHandler(this.textBoxDiscountId_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeleteDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelDeleteDiscount
            // 
            this.labelDeleteDiscount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeleteDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDeleteDiscount.Location = new System.Drawing.Point(1, 0);
            this.labelDeleteDiscount.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelDeleteDiscount.Name = "labelDeleteDiscount";
            this.labelDeleteDiscount.Size = new System.Drawing.Size(350, 67);
            this.labelDeleteDiscount.TabIndex = 0;
            this.labelDeleteDiscount.Text = "Удалить скидку";
            this.labelDeleteDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteDiscountForm";
            this.Text = "Удалить скидку";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeleteDiscount;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectDiscountId;
        private System.Windows.Forms.TextBox textBoxDiscountId;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}

