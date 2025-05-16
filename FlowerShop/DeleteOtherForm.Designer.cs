namespace FlowerShop
{
    partial class DeleteOtherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteOtherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectOtherId = new System.Windows.Forms.Label();
            this.textBoxOtherId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeleteOther = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectOtherId);
            this.panel1.Controls.Add(this.textBoxOtherId);
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
            // labelSelectOtherId
            // 
            this.labelSelectOtherId.AutoSize = true;
            this.labelSelectOtherId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectOtherId.Location = new System.Drawing.Point(79, 80);
            this.labelSelectOtherId.Name = "labelSelectOtherId";
            this.labelSelectOtherId.Size = new System.Drawing.Size(194, 28);
            this.labelSelectOtherId.TabIndex = 2;
            this.labelSelectOtherId.Text = "Выберите ID записи";
            // 
            // textBoxOtherId
            // 
            this.textBoxOtherId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxOtherId.Location = new System.Drawing.Point(79, 118);
            this.textBoxOtherId.Name = "textBoxOtherId";
            this.textBoxOtherId.Size = new System.Drawing.Size(200, 34);
            this.textBoxOtherId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeleteOther);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelDeleteOther
            // 
            this.labelDeleteOther.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeleteOther.Location = new System.Drawing.Point(1, 0);
            this.labelDeleteOther.Name = "labelDeleteOther";
            this.labelDeleteOther.Size = new System.Drawing.Size(350, 67);
            this.labelDeleteOther.TabIndex = 0;
            this.labelDeleteOther.Text = "Удалить запись";
            this.labelDeleteOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteOtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteOtherForm";
            this.Text = "Удалить запись";
            this.Load += new System.EventHandler(this.DeleteOtherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeleteOther;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectOtherId;
        private System.Windows.Forms.TextBox textBoxOtherId;
    }
}
