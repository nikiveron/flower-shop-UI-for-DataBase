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

namespace FlowerShop
{
    public partial class ProductSearchForm : Form
    {
        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string productName = textBoxName.Text.Trim();

            List<string> conditions = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            if (!string.IsNullOrWhiteSpace(productName))
            {
                conditions.Add("Name ILIKE @Name");
                command.Parameters.AddWithValue("@Name", "%" + productName + "%");
            }

            var selectedCategories = checkedListBox1.CheckedItems.Cast<string>().ToList();
            if (selectedCategories.Count > 0)
            {
                // Строим список параметров для IN (...)
                List<string> categoryParams = new List<string>();
                for (int i = 0; i < selectedCategories.Count; i++)
                {
                    string paramName = "@category" + i;
                    categoryParams.Add(paramName);
                    command.Parameters.AddWithValue(paramName, NpgsqlTypes.NpgsqlDbType.Varchar, selectedCategories[i]);
                }

                string sql = "SELECT * FROM product WHERE " + string.Join(" AND ", conditions);
                sql += " AND Category IN (" + string.Join(", ", categoryParams) + ")";

                command.CommandText = sql;

                try
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    table.Columns["Id"].ColumnName = "ID товара";
                    table.Columns["Category"].ColumnName = "Категория";
                    table.Columns["Name"].ColumnName = "Название";
                    table.Columns["IdOther"].ColumnName = "ID другое";
                    table.Columns["IdFlower"].ColumnName = "ID цветок";
                    table.Columns["IdBouquet"].ColumnName = "ID букет";

                    // Показываем результаты в новой форме
                    ResultsForm resultsForm = new ResultsForm(table);
                    resultsForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите хотя бы один пункт категорий");
            }
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
