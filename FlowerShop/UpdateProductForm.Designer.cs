namespace FlowerShop
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.labelProductId = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 67);
            this.panel2.TabIndex = 13;
            // 
            // labelUpdateProduct
            // 
            this.labelUpdateProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdateProduct.Location = new System.Drawing.Point(0, 0);
            this.labelUpdateProduct.Name = "labelUpdateProduct";
            this.labelUpdateProduct.Size = new System.Drawing.Size(400, 67);
            this.labelUpdateProduct.TabIndex = 0;
            this.labelUpdateProduct.Text = "Изменить данные товара";
            this.labelUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.textBoxProductId);
            this.panel1.Controls.Add(this.labelProductId);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 323);
            this.panel1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(100, 237);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxProductId.Location = new System.Drawing.Point(100, 103);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(200, 34);
            this.textBoxProductId.TabIndex = 0;
            // 
            // labelProductId
            // 
            this.labelProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelProductId.Location = new System.Drawing.Point(100, 75);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(200, 30);
            this.labelProductId.TabIndex = 1;
            this.labelProductId.Text = "ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxName.Location = new System.Drawing.Point(100, 177);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 34);
            this.textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelName.Location = new System.Drawing.Point(100, 142);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 30);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Название";
            // 
            // UpdateProductForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 323);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProductForm";
            this.Text = "Изменить данные товара";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
