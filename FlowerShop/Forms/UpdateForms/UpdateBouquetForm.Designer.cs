namespace FlowerShop
{
    partial class UpdateBouquetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBouquetForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateBouquet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBouquetId = new System.Windows.Forms.Label();
            this.textBoxBouquetId = new System.Windows.Forms.TextBox();
            this.labelBouquetName = new System.Windows.Forms.Label();
            this.textBoxBouquetName = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateBouquet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelUpdateBouquet
            // 
            this.labelUpdateBouquet.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateBouquet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdateBouquet.Location = new System.Drawing.Point(0, 0);
            this.labelUpdateBouquet.Name = "labelUpdateBouquet";
            this.labelUpdateBouquet.Size = new System.Drawing.Size(400, 67);
            this.labelUpdateBouquet.TabIndex = 0;
            this.labelUpdateBouquet.Text = "Изменить данные букета";
            this.labelUpdateBouquet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelBouquetId);
            this.panel1.Controls.Add(this.textBoxBouquetId);
            this.panel1.Controls.Add(this.labelBouquetName);
            this.panel1.Controls.Add(this.textBoxBouquetName);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 473);
            this.panel1.TabIndex = 1;
            // 
            // labelBouquetId
            // 
            this.labelBouquetId.AutoSize = true;
            this.labelBouquetId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelBouquetId.Location = new System.Drawing.Point(100, 80);
            this.labelBouquetId.Name = "labelBouquetId";
            this.labelBouquetId.Size = new System.Drawing.Size(29, 28);
            this.labelBouquetId.TabIndex = 1;
            this.labelBouquetId.Text = "Id";
            // 
            // textBoxBouquetId
            // 
            this.textBoxBouquetId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBouquetId.Location = new System.Drawing.Point(100, 113);
            this.textBoxBouquetId.Name = "textBoxBouquetId";
            this.textBoxBouquetId.Size = new System.Drawing.Size(200, 34);
            this.textBoxBouquetId.TabIndex = 2;
            // 
            // labelBouquetName
            // 
            this.labelBouquetName.AutoSize = true;
            this.labelBouquetName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelBouquetName.Location = new System.Drawing.Point(100, 152);
            this.labelBouquetName.Name = "labelBouquetName";
            this.labelBouquetName.Size = new System.Drawing.Size(100, 28);
            this.labelBouquetName.TabIndex = 3;
            this.labelBouquetName.Text = "Название";
            // 
            // textBoxBouquetName
            // 
            this.textBoxBouquetName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBouquetName.Location = new System.Drawing.Point(100, 185);
            this.textBoxBouquetName.Name = "textBoxBouquetName";
            this.textBoxBouquetName.Size = new System.Drawing.Size(200, 34);
            this.textBoxBouquetName.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelAmount.Location = new System.Drawing.Point(100, 224);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(120, 28);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Количество";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmount.Location = new System.Drawing.Point(100, 257);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 34);
            this.textBoxAmount.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPrice.Location = new System.Drawing.Point(100, 296);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 28);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPrice.Location = new System.Drawing.Point(100, 329);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 34);
            this.textBoxPrice.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 388);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateBouquetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 473);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBouquetForm";
            this.Text = "Изменить данные букета";
            this.Load += new System.EventHandler(this.UpdateBouquetForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateBouquet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBouquetId;
        private System.Windows.Forms.TextBox textBoxBouquetId;
        private System.Windows.Forms.Label labelBouquetName;
        private System.Windows.Forms.TextBox textBoxBouquetName;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
