namespace FlowerShop
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxBouquet = new System.Windows.Forms.ComboBox();
            this.comboBoxFlower = new System.Windows.Forms.ComboBox();
            this.comboBoxOther = new System.Windows.Forms.ComboBox();
            this.labelBouquet = new System.Windows.Forms.Label();
            this.labelFlower = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.comboBoxBouquet);
            this.panel1.Controls.Add(this.comboBoxFlower);
            this.panel1.Controls.Add(this.comboBoxOther);
            this.panel1.Controls.Add(this.labelBouquet);
            this.panel1.Controls.Add(this.labelFlower);
            this.panel1.Controls.Add(this.labelOther);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 533);
            this.panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(77, 470);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 45);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxBouquet
            // 
            this.comboBoxBouquet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxBouquet.FormattingEnabled = true;
            this.comboBoxBouquet.Location = new System.Drawing.Point(77, 259);
            this.comboBoxBouquet.Name = "comboBoxBouquet";
            this.comboBoxBouquet.Size = new System.Drawing.Size(200, 36);
            this.comboBoxBouquet.TabIndex = 9;
            // 
            // comboBoxFlower
            // 
            this.comboBoxFlower.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxFlower.FormattingEnabled = true;
            this.comboBoxFlower.Location = new System.Drawing.Point(77, 333);
            this.comboBoxFlower.Name = "comboBoxFlower";
            this.comboBoxFlower.Size = new System.Drawing.Size(200, 36);
            this.comboBoxFlower.TabIndex = 8;
            // 
            // comboBoxOther
            // 
            this.comboBoxOther.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxOther.FormattingEnabled = true;
            this.comboBoxOther.Location = new System.Drawing.Point(77, 407);
            this.comboBoxOther.Name = "comboBoxOther";
            this.comboBoxOther.Size = new System.Drawing.Size(200, 36);
            this.comboBoxOther.TabIndex = 7;
            // 
            // labelBouquet
            // 
            this.labelBouquet.AutoSize = true;
            this.labelBouquet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelBouquet.Location = new System.Drawing.Point(77, 226);
            this.labelBouquet.Name = "labelBouquet";
            this.labelBouquet.Size = new System.Drawing.Size(86, 28);
            this.labelBouquet.TabIndex = 6;
            this.labelBouquet.Text = "ID букет";
            // 
            // labelFlower
            // 
            this.labelFlower.AutoSize = true;
            this.labelFlower.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFlower.Location = new System.Drawing.Point(77, 300);
            this.labelFlower.Name = "labelFlower";
            this.labelFlower.Size = new System.Drawing.Size(99, 28);
            this.labelFlower.TabIndex = 5;
            this.labelFlower.Text = "ID цветок";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOther.Location = new System.Drawing.Point(77, 374);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(103, 28);
            this.labelOther.TabIndex = 4;
            this.labelOther.Text = "ID прочее";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxName.Location = new System.Drawing.Point(77, 187);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 34);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelName.Location = new System.Drawing.Point(77, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(168, 28);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название товара";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCategory.Location = new System.Drawing.Point(77, 115);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(200, 34);
            this.textBoxCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 70);
            this.panel2.TabIndex = 11;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(352, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить товар";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 533);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxOther;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.ComboBox comboBoxFlower;
        private System.Windows.Forms.Label labelFlower;
        private System.Windows.Forms.ComboBox comboBoxBouquet;
        private System.Windows.Forms.Label labelBouquet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label1;
    }


}