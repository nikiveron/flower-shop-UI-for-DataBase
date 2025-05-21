namespace FlowerShop
{
    partial class DeleteClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSelectClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDeleteClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.labelSelectClientId);
            this.panel1.Controls.Add(this.textBoxClientId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 253);
            this.panel1.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(79, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 50);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSelectClientId
            // 
            this.labelSelectClientId.AutoSize = true;
            this.labelSelectClientId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectClientId.Location = new System.Drawing.Point(79, 80);
            this.labelSelectClientId.Name = "labelSelectClientId";
            this.labelSelectClientId.Size = new System.Drawing.Size(203, 28);
            this.labelSelectClientId.TabIndex = 17;
            this.labelSelectClientId.Text = "Выберите ID клиента";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxClientId.Location = new System.Drawing.Point(79, 118);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(200, 34);
            this.textBoxClientId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.labelDeleteClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 67);
            this.panel2.TabIndex = 0;
            // 
            // labelDeleteClient
            // 
            this.labelDeleteClient.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDeleteClient.Location = new System.Drawing.Point(1, 0);
            this.labelDeleteClient.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelDeleteClient.Name = "labelDeleteClient";
            this.labelDeleteClient.Size = new System.Drawing.Size(350, 67);
            this.labelDeleteClient.TabIndex = 0;
            this.labelDeleteClient.Text = "Удалить клиента";
            this.labelDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteClientForm";
            this.Text = "Удалить клиента";
            this.Load += new System.EventHandler(this.DeleteClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDeleteClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectClientId;
        private System.Windows.Forms.TextBox textBoxClientId;
    }
}