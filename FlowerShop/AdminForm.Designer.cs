namespace FlowerShop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAccounting = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonClientPurchases = new System.Windows.Forms.Button();
            this.buttonClientDiscount = new System.Windows.Forms.Button();
            this.buttonClientSearch = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPageDiscount = new System.Windows.Forms.TabPage();
            this.buttonSearchDiscount = new System.Windows.Forms.Button();
            this.buttonDiscountClient = new System.Windows.Forms.Button();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.buttonPurchaseClient = new System.Windows.Forms.Button();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.buttonProductPrice = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPageBouquet = new System.Windows.Forms.TabPage();
            this.dataGridViewBouquet = new System.Windows.Forms.DataGridView();
            this.tabPageFlower = new System.Windows.Forms.TabPage();
            this.dataGridViewFlower = new System.Windows.Forms.DataGridView();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.dataGridViewOther = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBouquetSearch = new System.Windows.Forms.Button();
            this.buttonSearchFlower = new System.Windows.Forms.Button();
            this.buttonSearchOther = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPageDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageBouquet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBouquet)).BeginInit();
            this.tabPageFlower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlower)).BeginInit();
            this.tabPageOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1277, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цветочный магазин";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonAccounting);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 686);
            this.panel1.TabIndex = 2;
            // 
            // buttonAccounting
            // 
            this.buttonAccounting.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccounting.Location = new System.Drawing.Point(891, 600);
            this.buttonAccounting.Name = "buttonAccounting";
            this.buttonAccounting.Size = new System.Drawing.Size(371, 50);
            this.buttonAccounting.TabIndex = 5;
            this.buttonAccounting.Text = "Отчет за временной период";
            this.buttonAccounting.UseVisualStyleBackColor = true;
            this.buttonAccounting.Click += new System.EventHandler(this.buttonAccounting_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(196, 600);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(150, 50);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(362, 600);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 50);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(30, 600);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 50);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPageDiscount);
            this.tabControl1.Controls.Add(this.tabPagePurchase);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPageBouquet);
            this.tabControl1.Controls.Add(this.tabPageFlower);
            this.tabControl1.Controls.Add(this.tabPageOther);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(20, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 493);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.buttonClientPurchases);
            this.tabPageClients.Controls.Add(this.buttonClientDiscount);
            this.tabPageClients.Controls.Add(this.buttonClientSearch);
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Location = new System.Drawing.Point(4, 32);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1238, 457);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            this.tabPageClients.Enter += new System.EventHandler(this.tabPageClients_Enter);
            // 
            // buttonClientPurchases
            // 
            this.buttonClientPurchases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonClientPurchases.Location = new System.Drawing.Point(939, 130);
            this.buttonClientPurchases.Name = "buttonClientPurchases";
            this.buttonClientPurchases.Size = new System.Drawing.Size(282, 50);
            this.buttonClientPurchases.TabIndex = 5;
            this.buttonClientPurchases.Text = "Просмотр покупок клиента";
            this.buttonClientPurchases.UseVisualStyleBackColor = true;
            this.buttonClientPurchases.Click += new System.EventHandler(this.buttonClientPurchases_Click);
            // 
            // buttonClientDiscount
            // 
            this.buttonClientDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonClientDiscount.Location = new System.Drawing.Point(939, 74);
            this.buttonClientDiscount.Name = "buttonClientDiscount";
            this.buttonClientDiscount.Size = new System.Drawing.Size(282, 50);
            this.buttonClientDiscount.TabIndex = 4;
            this.buttonClientDiscount.Text = "Клиент + скидка";
            this.buttonClientDiscount.UseVisualStyleBackColor = true;
            this.buttonClientDiscount.Click += new System.EventHandler(this.buttonClientDiscount_Click);
            // 
            // buttonClientSearch
            // 
            this.buttonClientSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonClientSearch.Location = new System.Drawing.Point(939, 18);
            this.buttonClientSearch.Name = "buttonClientSearch";
            this.buttonClientSearch.Size = new System.Drawing.Size(282, 50);
            this.buttonClientSearch.TabIndex = 3;
            this.buttonClientSearch.Text = "Найти клиента";
            this.buttonClientSearch.UseVisualStyleBackColor = true;
            this.buttonClientSearch.Click += new System.EventHandler(this.buttonClientSearch_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // tabPageDiscount
            // 
            this.tabPageDiscount.Controls.Add(this.buttonSearchDiscount);
            this.tabPageDiscount.Controls.Add(this.buttonDiscountClient);
            this.tabPageDiscount.Controls.Add(this.dataGridViewDiscount);
            this.tabPageDiscount.Location = new System.Drawing.Point(4, 32);
            this.tabPageDiscount.Name = "tabPageDiscount";
            this.tabPageDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiscount.Size = new System.Drawing.Size(1238, 457);
            this.tabPageDiscount.TabIndex = 1;
            this.tabPageDiscount.Text = "Дисконты";
            this.tabPageDiscount.UseVisualStyleBackColor = true;
            this.tabPageDiscount.Enter += new System.EventHandler(this.tabPageDiscount_Enter);
            // 
            // buttonSearchDiscount
            // 
            this.buttonSearchDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSearchDiscount.Location = new System.Drawing.Point(939, 18);
            this.buttonSearchDiscount.Name = "buttonSearchDiscount";
            this.buttonSearchDiscount.Size = new System.Drawing.Size(282, 50);
            this.buttonSearchDiscount.TabIndex = 6;
            this.buttonSearchDiscount.Text = "Найти клиента";
            this.buttonSearchDiscount.UseVisualStyleBackColor = true;
            this.buttonSearchDiscount.Click += new System.EventHandler(this.buttonSearchDiscount_Click);
            // 
            // buttonDiscountClient
            // 
            this.buttonDiscountClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDiscountClient.Location = new System.Drawing.Point(939, 74);
            this.buttonDiscountClient.Name = "buttonDiscountClient";
            this.buttonDiscountClient.Size = new System.Drawing.Size(282, 50);
            this.buttonDiscountClient.TabIndex = 5;
            this.buttonDiscountClient.Text = "Клиент + скидка";
            this.buttonDiscountClient.UseVisualStyleBackColor = true;
            this.buttonDiscountClient.Click += new System.EventHandler(this.buttonDiscountClient_Click);
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.ReadOnly = true;
            this.dataGridViewDiscount.RowHeadersWidth = 51;
            this.dataGridViewDiscount.RowTemplate.Height = 24;
            this.dataGridViewDiscount.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewDiscount.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.buttonPurchaseClient);
            this.tabPagePurchase.Controls.Add(this.dataGridViewPurchase);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 32);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1238, 457);
            this.tabPagePurchase.TabIndex = 2;
            this.tabPagePurchase.Text = "Покупки";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            this.tabPagePurchase.Enter += new System.EventHandler(this.tabPagePurchase_Enter);
            // 
            // buttonPurchaseClient
            // 
            this.buttonPurchaseClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonPurchaseClient.Location = new System.Drawing.Point(939, 17);
            this.buttonPurchaseClient.Name = "buttonPurchaseClient";
            this.buttonPurchaseClient.Size = new System.Drawing.Size(282, 50);
            this.buttonPurchaseClient.TabIndex = 6;
            this.buttonPurchaseClient.Text = "Просмотр покупок клиента";
            this.buttonPurchaseClient.UseVisualStyleBackColor = true;
            this.buttonPurchaseClient.Click += new System.EventHandler(this.buttonPurchaseClient_Click);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.ReadOnly = true;
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewPurchase.TabIndex = 2;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.buttonProductSearch);
            this.tabPageProduct.Controls.Add(this.buttonProductPrice);
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 32);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(1238, 457);
            this.tabPageProduct.TabIndex = 6;
            this.tabPageProduct.Text = "Все товары";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            this.tabPageProduct.Enter += new System.EventHandler(this.tabPageProduct_Enter);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonProductSearch.Location = new System.Drawing.Point(940, 14);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(282, 50);
            this.buttonProductSearch.TabIndex = 7;
            this.buttonProductSearch.Text = "Найти товар";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // buttonProductPrice
            // 
            this.buttonProductPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonProductPrice.Location = new System.Drawing.Point(940, 70);
            this.buttonProductPrice.Name = "buttonProductPrice";
            this.buttonProductPrice.Size = new System.Drawing.Size(282, 50);
            this.buttonProductPrice.TabIndex = 5;
            this.buttonProductPrice.Text = "Товар + стоимость";
            this.buttonProductPrice.UseVisualStyleBackColor = true;
            this.buttonProductPrice.Click += new System.EventHandler(this.buttonProductPrice_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewProduct.TabIndex = 2;
            // 
            // tabPageBouquet
            // 
            this.tabPageBouquet.Controls.Add(this.buttonBouquetSearch);
            this.tabPageBouquet.Controls.Add(this.dataGridViewBouquet);
            this.tabPageBouquet.Location = new System.Drawing.Point(4, 32);
            this.tabPageBouquet.Name = "tabPageBouquet";
            this.tabPageBouquet.Size = new System.Drawing.Size(1238, 457);
            this.tabPageBouquet.TabIndex = 4;
            this.tabPageBouquet.Text = "Букеты";
            this.tabPageBouquet.UseVisualStyleBackColor = true;
            this.tabPageBouquet.Enter += new System.EventHandler(this.tabPageBouquet_Enter);
            // 
            // dataGridViewBouquet
            // 
            this.dataGridViewBouquet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBouquet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBouquet.Name = "dataGridViewBouquet";
            this.dataGridViewBouquet.ReadOnly = true;
            this.dataGridViewBouquet.RowHeadersWidth = 51;
            this.dataGridViewBouquet.RowTemplate.Height = 24;
            this.dataGridViewBouquet.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewBouquet.TabIndex = 2;
            // 
            // tabPageFlower
            // 
            this.tabPageFlower.Controls.Add(this.buttonSearchFlower);
            this.tabPageFlower.Controls.Add(this.dataGridViewFlower);
            this.tabPageFlower.Location = new System.Drawing.Point(4, 32);
            this.tabPageFlower.Name = "tabPageFlower";
            this.tabPageFlower.Size = new System.Drawing.Size(1238, 457);
            this.tabPageFlower.TabIndex = 5;
            this.tabPageFlower.Text = "Цветы";
            this.tabPageFlower.UseVisualStyleBackColor = true;
            this.tabPageFlower.Enter += new System.EventHandler(this.tabPageFlower_Enter);
            // 
            // dataGridViewFlower
            // 
            this.dataGridViewFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlower.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlower.Name = "dataGridViewFlower";
            this.dataGridViewFlower.ReadOnly = true;
            this.dataGridViewFlower.RowHeadersWidth = 51;
            this.dataGridViewFlower.RowTemplate.Height = 24;
            this.dataGridViewFlower.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewFlower.TabIndex = 2;
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.buttonSearchOther);
            this.tabPageOther.Controls.Add(this.dataGridViewOther);
            this.tabPageOther.Location = new System.Drawing.Point(4, 32);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Size = new System.Drawing.Size(1238, 457);
            this.tabPageOther.TabIndex = 3;
            this.tabPageOther.Text = "Другие товары";
            this.tabPageOther.UseVisualStyleBackColor = true;
            this.tabPageOther.Enter += new System.EventHandler(this.tabPageOther_Enter);
            // 
            // dataGridViewOther
            // 
            this.dataGridViewOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOther.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOther.Name = "dataGridViewOther";
            this.dataGridViewOther.ReadOnly = true;
            this.dataGridViewOther.RowHeadersWidth = 51;
            this.dataGridViewOther.RowTemplate.Height = 24;
            this.dataGridViewOther.Size = new System.Drawing.Size(917, 457);
            this.dataGridViewOther.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 67);
            this.panel2.TabIndex = 0;
            // 
            // buttonBouquetSearch
            // 
            this.buttonBouquetSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonBouquetSearch.Location = new System.Drawing.Point(938, 20);
            this.buttonBouquetSearch.Name = "buttonBouquetSearch";
            this.buttonBouquetSearch.Size = new System.Drawing.Size(282, 50);
            this.buttonBouquetSearch.TabIndex = 8;
            this.buttonBouquetSearch.Text = "Найти букет";
            this.buttonBouquetSearch.UseVisualStyleBackColor = true;
            this.buttonBouquetSearch.Click += new System.EventHandler(this.buttonBouquetSearch_Click);
            // 
            // buttonSearchFlower
            // 
            this.buttonSearchFlower.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSearchFlower.Location = new System.Drawing.Point(936, 19);
            this.buttonSearchFlower.Name = "buttonSearchFlower";
            this.buttonSearchFlower.Size = new System.Drawing.Size(282, 50);
            this.buttonSearchFlower.TabIndex = 9;
            this.buttonSearchFlower.Text = "Найти цветы";
            this.buttonSearchFlower.UseVisualStyleBackColor = true;
            this.buttonSearchFlower.Click += new System.EventHandler(this.buttonSearchFlower_Click);
            // 
            // buttonSearchOther
            // 
            this.buttonSearchOther.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSearchOther.Location = new System.Drawing.Point(937, 21);
            this.buttonSearchOther.Name = "buttonSearchOther";
            this.buttonSearchOther.Size = new System.Drawing.Size(282, 50);
            this.buttonSearchOther.TabIndex = 10;
            this.buttonSearchOther.Text = "Найти прочие товары";
            this.buttonSearchOther.UseVisualStyleBackColor = true;
            this.buttonSearchOther.Click += new System.EventHandler(this.buttonSearchOther_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 686);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цветочный магазин (админ)";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPageDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            this.tabPagePurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageBouquet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBouquet)).EndInit();
            this.tabPageFlower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlower)).EndInit();
            this.tabPageOther.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOther)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageDiscount;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.TabPage tabPageBouquet;
        private System.Windows.Forms.TabPage tabPageFlower;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewBouquet;
        private System.Windows.Forms.DataGridView dataGridViewFlower;
        private System.Windows.Forms.DataGridView dataGridViewOther;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClientSearch;
        private System.Windows.Forms.Button buttonClientPurchases;
        private System.Windows.Forms.Button buttonClientDiscount;
        private System.Windows.Forms.Button buttonAccounting;
        private System.Windows.Forms.Button buttonProductPrice;
        private System.Windows.Forms.Button buttonDiscountClient;
        private System.Windows.Forms.Button buttonSearchDiscount;
        private System.Windows.Forms.Button buttonPurchaseClient;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Button buttonBouquetSearch;
        private System.Windows.Forms.Button buttonSearchFlower;
        private System.Windows.Forms.Button buttonSearchOther;
    }
}