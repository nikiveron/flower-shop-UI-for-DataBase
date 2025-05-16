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
    public partial class BouquetSearchForm : Form
    {
        string formType = string.Empty;
        public BouquetSearchForm(string formType)
        {
            InitializeComponent();
            this.formType = formType;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (formType == "buttonBouquetSearch_Click")
            {
                string bouquetName = textBoxName.Text.Trim();

                List<string> conditions = new List<string>();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.GetConnection();

                if (!string.IsNullOrWhiteSpace(bouquetName))
                {
                    conditions.Add("Name ILIKE @Name");
                    command.Parameters.AddWithValue("@Name", "%" + bouquetName + "%");
                    string sql = "SELECT * FROM bouquet WHERE " + string.Join(" AND ", conditions);

                    command.CommandText = sql;

                    try
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        table.Columns["Id"].ColumnName = "ID букета";
                        table.Columns["Name"].ColumnName = "Название";
                        table.Columns["Amount"].ColumnName = "Количество";
                        table.Columns["Price"].ColumnName = "Стоимость";

                        // Показываем результаты в новой форме
                        ResultsForm resultsForm = new ResultsForm(table);
                        resultsForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (formType == "buttonSearchFlower_Click")
            {
                string bouquetName = textBoxName.Text.Trim();

                List<string> conditions = new List<string>();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.GetConnection();

                if (!string.IsNullOrWhiteSpace(bouquetName))
                {
                    conditions.Add("Name ILIKE @Name");
                    command.Parameters.AddWithValue("@Name", "%" + bouquetName + "%");
                    string sql = "SELECT * FROM flower WHERE " + string.Join(" AND ", conditions);

                    command.CommandText = sql;

                    try
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        table.Columns["Id"].ColumnName = "ID цветка";
                        table.Columns["Name"].ColumnName = "Название";
                        table.Columns["Amount"].ColumnName = "Количество";
                        table.Columns["Price"].ColumnName = "Стоимость";

                        // Показываем результаты в новой форме
                        ResultsForm resultsForm = new ResultsForm(table);
                        resultsForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (formType == "buttonSearchOther_Click")
            {
                string bouquetName = textBoxName.Text.Trim();

                List<string> conditions = new List<string>();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.GetConnection();

                if (!string.IsNullOrWhiteSpace(bouquetName))
                {
                    conditions.Add("Name ILIKE @Name");
                    command.Parameters.AddWithValue("@Name", "%" + bouquetName + "%");
                    string sql = "SELECT * FROM other WHERE " + string.Join(" AND ", conditions);

                    command.CommandText = sql;

                    try
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        table.Columns["Id"].ColumnName = "ID товара";
                        table.Columns["Name"].ColumnName = "Название";
                        table.Columns["Amount"].ColumnName = "Количество";
                        table.Columns["Price"].ColumnName = "Стоимость";

                        // Показываем результаты в новой форме
                        ResultsForm resultsForm = new ResultsForm(table);
                        resultsForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
