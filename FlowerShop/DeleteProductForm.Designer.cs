namespace FlowerShop
{
    partial class DeleteProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectProductId = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeleteProduct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectProductId);
            this.panel1.Controls.Add(this.textBoxProductId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 253);
            this.panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(79, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSelectProductId
            // 
            this.labelSelectProductId.AutoSize = true;
            this.labelSelectProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectProductId.Location = new System.Drawing.Point(79, 80);
            this.labelSelectProductId.Name = "labelSelectProductId";
            this.labelSelectProductId.Size = new System.Drawing.Size(193, 28);
            this.labelSelectProductId.TabIndex = 2;
            this.labelSelectProductId.Text = "Выберите ID товара";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxProductId.Location = new System.Drawing.Point(79, 118);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(200, 34);
            this.textBoxProductId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeleteProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelDeleteProduct
            // 
            this.labelDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDeleteProduct.Location = new System.Drawing.Point(1, 0);
            this.labelDeleteProduct.Name = "labelDeleteProduct";
            this.labelDeleteProduct.Size = new System.Drawing.Size(350, 67);
            this.labelDeleteProduct.TabIndex = 0;
            this.labelDeleteProduct.Text = "Удалить товар";
            this.labelDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteProductForm";
            this.Text = "Удалить товар";
            this.Load += new System.EventHandler(this.DeleteProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectProductId;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeleteProduct;
    }
}
