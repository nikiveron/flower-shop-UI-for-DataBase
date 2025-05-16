namespace FlowerShop
{
    partial class DeletePurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePurchaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectPurchaseId = new System.Windows.Forms.Label();
            this.textBoxPurchaseId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeletePurchase = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectPurchaseId);
            this.panel1.Controls.Add(this.textBoxPurchaseId);
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
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSelectPurchaseId
            // 
            this.labelSelectPurchaseId.AutoSize = true;
            this.labelSelectPurchaseId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectPurchaseId.Location = new System.Drawing.Point(79, 80);
            this.labelSelectPurchaseId.Name = "labelSelectPurchaseId";
            this.labelSelectPurchaseId.Size = new System.Drawing.Size(192, 28);
            this.labelSelectPurchaseId.TabIndex = 1;
            this.labelSelectPurchaseId.Text = "Введите ID покупки";
            // 
            // textBoxPurchaseId
            // 
            this.textBoxPurchaseId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPurchaseId.Location = new System.Drawing.Point(79, 118);
            this.textBoxPurchaseId.Name = "textBoxPurchaseId";
            this.textBoxPurchaseId.Size = new System.Drawing.Size(200, 34);
            this.textBoxPurchaseId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeletePurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 3;
            // 
            // labelDeletePurchase
            // 
            this.labelDeletePurchase.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeletePurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDeletePurchase.Location = new System.Drawing.Point(0, 0);
            this.labelDeletePurchase.Name = "labelDeletePurchase";
            this.labelDeletePurchase.Size = new System.Drawing.Size(352, 67);
            this.labelDeletePurchase.TabIndex = 0;
            this.labelDeletePurchase.Text = "Удалить покупку";
            this.labelDeletePurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeletePurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletePurchaseForm";
            this.Text = "Удалить покупку";
            this.Load += new System.EventHandler(this.DeletePurchaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectPurchaseId;
        private System.Windows.Forms.TextBox textBoxPurchaseId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeletePurchase;
    }
}
