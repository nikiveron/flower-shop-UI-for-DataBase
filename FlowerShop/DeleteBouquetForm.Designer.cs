namespace FlowerShop
{
    partial class DeleteBouquetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBouquetForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectBouquetId = new System.Windows.Forms.Label();
            this.textBoxBouquetId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeleteBouquet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectBouquetId);
            this.panel1.Controls.Add(this.textBoxBouquetId);
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
            this.buttonDelete.Location = new System.Drawing.Point(79, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSelectBouquetId
            // 
            this.labelSelectBouquetId.AutoSize = true;
            this.labelSelectBouquetId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectBouquetId.Location = new System.Drawing.Point(79, 80);
            this.labelSelectBouquetId.Name = "labelSelectBouquetId";
            this.labelSelectBouquetId.Size = new System.Drawing.Size(174, 28);
            this.labelSelectBouquetId.TabIndex = 2;
            this.labelSelectBouquetId.Text = "Введите ID букета";
            // 
            // textBoxBouquetId
            // 
            this.textBoxBouquetId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBouquetId.Location = new System.Drawing.Point(79, 113);
            this.textBoxBouquetId.Name = "textBoxBouquetId";
            this.textBoxBouquetId.Size = new System.Drawing.Size(200, 34);
            this.textBoxBouquetId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeleteBouquet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelDeleteBouquet
            // 
            this.labelDeleteBouquet.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeleteBouquet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDeleteBouquet.Location = new System.Drawing.Point(1, 0);
            this.labelDeleteBouquet.Name = "labelDeleteBouquet";
            this.labelDeleteBouquet.Size = new System.Drawing.Size(350, 67);
            this.labelDeleteBouquet.TabIndex = 0;
            this.labelDeleteBouquet.Text = "Удалить букет";
            this.labelDeleteBouquet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteBouquetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteBouquetForm";
            this.Text = "Удалить букет";
            this.Load += new System.EventHandler(this.DeleteBouquetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectBouquetId;
        private System.Windows.Forms.TextBox textBoxBouquetId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeleteBouquet;
    }
}
