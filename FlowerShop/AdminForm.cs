using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FlowerShop
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void tabPageClients_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM clients;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewClients.DataSource = table;
                dataGridViewClients.Columns["IdClient"].HeaderText = "ID";
                dataGridViewClients.Columns["FirstName"].HeaderText = "Имя";
                dataGridViewClients.Columns["LastName"].HeaderText = "Фамилия";
                dataGridViewClients.Columns["Sex"].HeaderText = "Пол";
                dataGridViewClients.Columns["BirthDate"].HeaderText = "Дата рождения";
                dataGridViewClients.Columns["PhoneNumber"].HeaderText = "Телефон";
                dataGridViewClients.Columns["Email"].HeaderText = "Электронная почта";
                
            }

            command.Dispose();
        }

        private void tabPageDiscount_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM discount;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewDiscount.DataSource = table;
                dataGridViewDiscount.Columns["Id"].HeaderText = "ID дисконта";
                dataGridViewDiscount.Columns["IdClient"].HeaderText = "ID клиента";
                dataGridViewDiscount.Columns["AmountOfPurchases"].HeaderText = "Кол-во покупок";
                dataGridViewDiscount.Columns["SumOfPurchases"].HeaderText = "Сумма всех покупок";
                dataGridViewDiscount.Columns["DateOfIssue"].HeaderText = "Дата выдачи";
                dataGridViewDiscount.Columns["DiscountSum"].HeaderText = "Размер скидки";

            }

            command.Dispose();
        }

        private void tabPagePurchase_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM purchase;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewPurchase.DataSource = table;
                dataGridViewPurchase.Columns["Id"].HeaderText = "ID покупки";
                dataGridViewPurchase.Columns["IdClient"].HeaderText = "ID клиента";
                dataGridViewPurchase.Columns["DateOfIssue"].HeaderText = "Дата покупки";
                dataGridViewPurchase.Columns["TimeOfIssue"].HeaderText = "Время покупки";
                dataGridViewPurchase.Columns["SumOfPurchase"].HeaderText = "Сумма покупки";

            }

            command.Dispose();
        }

        private void tabPageProduct_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM product;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewProduct.DataSource = table;
                dataGridViewProduct.Columns["Id"].HeaderText = "ID";
                dataGridViewProduct.Columns["Category"].HeaderText = "Категория";
                dataGridViewProduct.Columns["Name"].HeaderText = "Название";
                dataGridViewProduct.Columns["IdOther"].HeaderText = "ID др. товара";
                dataGridViewProduct.Columns["IdFlower"].HeaderText = "ID цветок";
                dataGridViewProduct.Columns["IdBouquet"].HeaderText = "ID букет";

            }

            command.Dispose();
        }

        private void tabPageBouquet_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM bouquet;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewBouquet.DataSource = table;
                dataGridViewBouquet.Columns["Id"].HeaderText = "ID";
                dataGridViewBouquet.Columns["Name"].HeaderText = "Название";
                dataGridViewBouquet.Columns["Amount"].HeaderText = "Количество";
                dataGridViewBouquet.Columns["Price"].HeaderText = "Цена";

            }

            command.Dispose();
        }

        private void tabPageFlower_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM flower;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader);
                dataGridViewFlower.DataSource = table;
                dataGridViewFlower.Columns["Id"].HeaderText = "ID";
                dataGridViewFlower.Columns["Name"].HeaderText = "Название";
                dataGridViewFlower.Columns["Amount"].HeaderText = "Количество";
                dataGridViewFlower.Columns["Price"].HeaderText = "Цена";

            }

            command.Dispose();
        }

        private void tabPageOther_Enter(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM other;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(dataReader); 
                dataGridViewOther.DataSource = table;
                dataGridViewOther.Columns["Id"].HeaderText = "ID";
                dataGridViewOther.Columns["Type"].HeaderText = "Тип";
                dataGridViewOther.Columns["Name"].HeaderText = "Название";
                dataGridViewOther.Columns["Price"].HeaderText = "Цена";

            }

            command.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageClients)
            {
                AddClientForm addClientForm = new AddClientForm();
                addClientForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageDiscount)
            {
                AddDiscountForm addDiscountForm = new AddDiscountForm();    
                addDiscountForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPagePurchase)
            {
                AddPurchaseForm addPurchaseForm = new AddPurchaseForm();
                addPurchaseForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageProduct)
            {
                AddProductForm addProductForm = new AddProductForm();
                addProductForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageBouquet)
            {
                AddBouquetForm addBouquetForm = new AddBouquetForm();
                addBouquetForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageFlower)
            {
                AddFlowerForm addFlowerForm = new AddFlowerForm();
                addFlowerForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageOther)
            {
                AddOtherForm addOtherForm = new AddOtherForm();
                addOtherForm.ShowDialog();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageClients)
            {
                UpdateClientForm updateClientForm = new UpdateClientForm();
                updateClientForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageDiscount)
            {
                UpdateDiscountForm updateDiscountForm = new UpdateDiscountForm();
                updateDiscountForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPagePurchase)
            {
                UpdatePurchaseForm updatePurchaseForm = new UpdatePurchaseForm();
                updatePurchaseForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageProduct)
            {
                UpdateProductForm updateProductForm = new UpdateProductForm();
                updateProductForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageBouquet)
            {
                UpdateBouquetForm updateBouquetForm = new UpdateBouquetForm();
                updateBouquetForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageFlower)
            {
                UpdateFlowerForm updateFlowerForm = new UpdateFlowerForm();
                updateFlowerForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageOther)
            {
                UpdateOtherForm updateOtherForm = new UpdateOtherForm();    
                updateOtherForm.ShowDialog();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageClients)
            {
                DeleteClientForm deleteClientForm = new DeleteClientForm();
                deleteClientForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageDiscount)
            {
                DeleteDiscountForm deleteDiscountForm = new DeleteDiscountForm();
                deleteDiscountForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPagePurchase)
            {
                DeletePurchaseForm deletePurchaseForm = new DeletePurchaseForm();
                deletePurchaseForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageProduct)
            {
                DeleteProductForm deleteProductForm = new DeleteProductForm();
                deleteProductForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageBouquet)
            {
                DeleteBouquetForm deleteBouquetForm = new DeleteBouquetForm();
                deleteBouquetForm.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPageFlower)
            {
                DeleteFlowerForm deleteFlowerForm = new DeleteFlowerForm(); 
                deleteFlowerForm.ShowDialog();  
            }
            else if (tabControl1.SelectedTab == tabPageOther)
            {
                DeleteOtherForm deleteOtherForm = new DeleteOtherForm();
                deleteOtherForm.ShowDialog();
            }
        }

        private void buttonClientSearch_Click(object sender, EventArgs e)
        {
            ClientSearchForm searchForm = new ClientSearchForm("buttonClientSearch_Click");
            searchForm.ShowDialog();
        }

        private void buttonAccounting_Click(object sender, EventArgs e)
        {
            DatePeriodForm datePeriodForm = new DatePeriodForm();
            datePeriodForm.ShowDialog();
        }

        private void buttonClientDiscount_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM client_discount_view;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns["IdClient"].ColumnName = "ID клиента";
            table.Columns["FirstName"].ColumnName = "Имя";
            table.Columns["LastName"].ColumnName = "Фамилия";
            table.Columns["DiscountSum"].ColumnName = "Сумма скидки";
            
            // Показываем результаты в новой форме
            ResultsForm resultsForm = new ResultsForm(table);
            resultsForm.ShowDialog();
        }

        private void buttonClientPurchases_Click(object sender, EventArgs e)
        {
            ClientIdInputForm clientIdInputForm = new ClientIdInputForm();
            clientIdInputForm.ShowDialog();
        }

        private void buttonProductPrice_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM product_with_price;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns["Id"].ColumnName = "ID товара";
            table.Columns["Name"].ColumnName = "Название";
            table.Columns["Category"].ColumnName = "Категория";
            table.Columns["Price"].ColumnName = "Стоимость";

            // Показываем результаты в новой форме
            ResultsForm resultsForm = new ResultsForm(table);
            resultsForm.ShowDialog();
        }

        private void buttonDiscountClient_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM client_discount_view;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns["IdClient"].ColumnName = "ID клиента";
            table.Columns["FirstName"].ColumnName = "Имя";
            table.Columns["LastName"].ColumnName = "Фамилия";
            table.Columns["DiscountSum"].ColumnName = "Сумма скидки";

            // Показываем результаты в новой форме
            ResultsForm resultsForm = new ResultsForm(table);
            resultsForm.ShowDialog();
        }

        private void buttonSearchDiscount_Click(object sender, EventArgs e)
        {
            ClientSearchForm searchForm = new ClientSearchForm("buttonSearchDiscount_Click");
            searchForm.ShowDialog();
        }

        private void buttonPurchaseClient_Click(object sender, EventArgs e)
        {
            ClientIdInputForm clientIdInputForm = new ClientIdInputForm();
            clientIdInputForm.ShowDialog();
        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {
            ProductSearchForm searchForm = new ProductSearchForm();
            searchForm.ShowDialog();
        }

        private void buttonBouquetSearch_Click(object sender, EventArgs e)
        {
            BouquetSearchForm searchForm = new BouquetSearchForm("buttonBouquetSearch_Click");
            searchForm.ShowDialog();
        }

        private void buttonSearchFlower_Click(object sender, EventArgs e)
        {
            BouquetSearchForm searchForm = new BouquetSearchForm("buttonSearchFlower_Click");
            searchForm.ShowDialog();
        }

        private void buttonSearchOther_Click(object sender, EventArgs e)
        {
            BouquetSearchForm searchForm = new BouquetSearchForm("buttonSearchOther_Click");
            searchForm.ShowDialog();
        }
    }
}
