namespace FlowerShop
{
    partial class UpdateFlowerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFlowerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateFlower = new System.Windows.Forms.Label();
            this.textBoxFlowerId = new System.Windows.Forms.TextBox();
            this.labelFlowerId = new System.Windows.Forms.Label();
            this.textBoxFlowerName = new System.Windows.Forms.TextBox();
            this.labelFlowerName = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateFlower);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelUpdateFlower
            // 
            this.labelUpdateFlower.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateFlower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdateFlower.Location = new System.Drawing.Point(0, 0);
            this.labelUpdateFlower.Name = "labelUpdateFlower";
            this.labelUpdateFlower.Size = new System.Drawing.Size(402, 67);
            this.labelUpdateFlower.TabIndex = 0;
            this.labelUpdateFlower.Text = "Изменить данные цветка";
            this.labelUpdateFlower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFlowerId
            // 
            this.textBoxFlowerId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxFlowerId.Location = new System.Drawing.Point(100, 108);
            this.textBoxFlowerId.Name = "textBoxFlowerId";
            this.textBoxFlowerId.Size = new System.Drawing.Size(200, 34);
            this.textBoxFlowerId.TabIndex = 1;
            // 
            // labelFlowerId
            // 
            this.labelFlowerId.AutoSize = true;
            this.labelFlowerId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFlowerId.Location = new System.Drawing.Point(100, 75);
            this.labelFlowerId.Name = "labelFlowerId";
            this.labelFlowerId.Size = new System.Drawing.Size(29, 28);
            this.labelFlowerId.TabIndex = 2;
            this.labelFlowerId.Text = "Id";
            // 
            // textBoxFlowerName
            // 
            this.textBoxFlowerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxFlowerName.Location = new System.Drawing.Point(100, 180);
            this.textBoxFlowerName.Name = "textBoxFlowerName";
            this.textBoxFlowerName.Size = new System.Drawing.Size(200, 34);
            this.textBoxFlowerName.TabIndex = 3;
            // 
            // labelFlowerName
            // 
            this.labelFlowerName.AutoSize = true;
            this.labelFlowerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFlowerName.Location = new System.Drawing.Point(100, 147);
            this.labelFlowerName.Name = "labelFlowerName";
            this.labelFlowerName.Size = new System.Drawing.Size(100, 28);
            this.labelFlowerName.TabIndex = 4;
            this.labelFlowerName.Text = "Название";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericUpDownAmount.Location = new System.Drawing.Point(100, 252);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(200, 34);
            this.numericUpDownAmount.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelAmount.Location = new System.Drawing.Point(100, 219);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(120, 28);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Количество";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(100, 324);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 34);
            this.textBoxPrice.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPrice.Location = new System.Drawing.Point(100, 291);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 28);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 383);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.numericUpDownAmount);
            this.panel1.Controls.Add(this.labelFlowerName);
            this.panel1.Controls.Add(this.textBoxFlowerName);
            this.panel1.Controls.Add(this.labelFlowerId);
            this.panel1.Controls.Add(this.textBoxFlowerId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 463);
            this.panel1.TabIndex = 0;
            // 
            // UpdateFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 463);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateFlowerForm";
            this.Text = "Изменить данные цветка";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateFlower;
        private System.Windows.Forms.TextBox textBoxFlowerId;
        private System.Windows.Forms.Label labelFlowerId;
        private System.Windows.Forms.TextBox textBoxFlowerName;
        private System.Windows.Forms.Label labelFlowerName;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}
