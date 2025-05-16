namespace FlowerShop
{
    partial class UpdateOtherForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOtherForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUpdateOther = new System.Windows.Forms.Label();
            this.textBoxOtherId = new System.Windows.Forms.TextBox();
            this.labelOtherId = new System.Windows.Forms.Label();
            this.textBoxOtherType = new System.Windows.Forms.TextBox();
            this.labelOtherType = new System.Windows.Forms.Label();
            this.textBoxOtherName = new System.Windows.Forms.TextBox();
            this.labelOtherName = new System.Windows.Forms.Label();
            this.textBoxOtherPrice = new System.Windows.Forms.TextBox();
            this.labelOtherPrice = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelUpdateOther);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelUpdateOther
            // 
            this.labelUpdateOther.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelUpdateOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUpdateOther.Location = new System.Drawing.Point(1, 0);
            this.labelUpdateOther.Name = "labelUpdateOther";
            this.labelUpdateOther.Size = new System.Drawing.Size(421, 67);
            this.labelUpdateOther.TabIndex = 0;
            this.labelUpdateOther.Text = "Изменить данные др. товар";
            this.labelUpdateOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOtherId
            // 
            this.textBoxOtherId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxOtherId.Location = new System.Drawing.Point(110, 108);
            this.textBoxOtherId.Name = "textBoxOtherId";
            this.textBoxOtherId.Size = new System.Drawing.Size(200, 34);
            this.textBoxOtherId.TabIndex = 1;
            // 
            // labelOtherId
            // 
            this.labelOtherId.AutoSize = true;
            this.labelOtherId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOtherId.Location = new System.Drawing.Point(109, 75);
            this.labelOtherId.Name = "labelOtherId";
            this.labelOtherId.Size = new System.Drawing.Size(29, 28);
            this.labelOtherId.TabIndex = 2;
            this.labelOtherId.Text = "Id";
            // 
            // textBoxOtherType
            // 
            this.textBoxOtherType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxOtherType.Location = new System.Drawing.Point(110, 178);
            this.textBoxOtherType.Name = "textBoxOtherType";
            this.textBoxOtherType.Size = new System.Drawing.Size(200, 34);
            this.textBoxOtherType.TabIndex = 3;
            // 
            // labelOtherType
            // 
            this.labelOtherType.AutoSize = true;
            this.labelOtherType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOtherType.Location = new System.Drawing.Point(110, 147);
            this.labelOtherType.Name = "labelOtherType";
            this.labelOtherType.Size = new System.Drawing.Size(46, 28);
            this.labelOtherType.TabIndex = 4;
            this.labelOtherType.Text = "Тип";
            // 
            // textBoxOtherName
            // 
            this.textBoxOtherName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxOtherName.Location = new System.Drawing.Point(110, 248);
            this.textBoxOtherName.Name = "textBoxOtherName";
            this.textBoxOtherName.Size = new System.Drawing.Size(200, 34);
            this.textBoxOtherName.TabIndex = 5;
            // 
            // labelOtherName
            // 
            this.labelOtherName.AutoSize = true;
            this.labelOtherName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOtherName.Location = new System.Drawing.Point(110, 217);
            this.labelOtherName.Name = "labelOtherName";
            this.labelOtherName.Size = new System.Drawing.Size(51, 28);
            this.labelOtherName.TabIndex = 6;
            this.labelOtherName.Text = "Имя";
            // 
            // textBoxOtherPrice
            // 
            this.textBoxOtherPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxOtherPrice.Location = new System.Drawing.Point(110, 320);
            this.textBoxOtherPrice.Name = "textBoxOtherPrice";
            this.textBoxOtherPrice.Size = new System.Drawing.Size(200, 34);
            this.textBoxOtherPrice.TabIndex = 7;
            // 
            // labelOtherPrice
            // 
            this.labelOtherPrice.AutoSize = true;
            this.labelOtherPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOtherPrice.Location = new System.Drawing.Point(110, 287);
            this.labelOtherPrice.Name = "labelOtherPrice";
            this.labelOtherPrice.Size = new System.Drawing.Size(59, 28);
            this.labelOtherPrice.TabIndex = 8;
            this.labelOtherPrice.Text = "Цена";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(110, 378);
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
            this.panel1.Controls.Add(this.labelOtherPrice);
            this.panel1.Controls.Add(this.textBoxOtherPrice);
            this.panel1.Controls.Add(this.labelOtherName);
            this.panel1.Controls.Add(this.textBoxOtherName);
            this.panel1.Controls.Add(this.labelOtherType);
            this.panel1.Controls.Add(this.textBoxOtherType);
            this.panel1.Controls.Add(this.labelOtherId);
            this.panel1.Controls.Add(this.textBoxOtherId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 453);
            this.panel1.TabIndex = 0;
            // 
            // UpdateOtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 453);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateOtherForm";
            this.Text = "Изменить данные прочего товара";
            this.Load += new System.EventHandler(this.UpdateOtherForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUpdateOther;
        private System.Windows.Forms.TextBox textBoxOtherId;
        private System.Windows.Forms.Label labelOtherId;
        private System.Windows.Forms.TextBox textBoxOtherType;
        private System.Windows.Forms.Label labelOtherType;
        private System.Windows.Forms.TextBox textBoxOtherName;
        private System.Windows.Forms.Label labelOtherName;
        private System.Windows.Forms.TextBox textBoxOtherPrice;
        private System.Windows.Forms.Label labelOtherPrice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}
