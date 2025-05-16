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
    public partial class DatePeriodForm : Form
    {
        public DatePeriodForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Проверка диапазона дат
            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты конца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Начальный SQL-запрос
                string sql = "SELECT * FROM get_product_sales_by_period(@startDate, @endDate)";

                // Подготовим параметры
                var cmd = new NpgsqlCommand();
                cmd.Connection = DB.GetConnection();
                cmd.Parameters.AddWithValue("startDate", NpgsqlTypes.NpgsqlDbType.Date, startDate);
                cmd.Parameters.AddWithValue("endDate", NpgsqlTypes.NpgsqlDbType.Date, endDate);

                // Обработка выбранных категорий
                var selectedCategories = checkedListBox1.CheckedItems.Cast<string>().ToList();
                if (selectedCategories.Count > 0)
                {
                    // Строим список параметров для IN (...)
                    List<string> categoryParams = new List<string>();
                    for (int i = 0; i < selectedCategories.Count; i++)
                    {
                        string paramName = "@category" + i;
                        categoryParams.Add(paramName);
                        cmd.Parameters.AddWithValue(paramName, NpgsqlTypes.NpgsqlDbType.Varchar, selectedCategories[i]);
                    }

                    sql += " WHERE out_product_category IN (" + string.Join(", ", categoryParams) + ")";
                }

                cmd.CommandText = sql;

                // Получение и отображение данных
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {

                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);


                    // Суммы
                    int totalQuantity = 0;
                    decimal totalSales = 0;

                    // Проход по строкам таблицы
                    foreach (DataRow row in resultTable.Rows)
                    {
                        if (row["out_total_quantity_sold"] != DBNull.Value)
                            totalQuantity += Convert.ToInt32(row["out_total_quantity_sold"]);

                        if (row["out_total_sales_sum"] != DBNull.Value)
                            totalSales += Convert.ToDecimal(row["out_total_sales_sum"]);
                    }

                    // Вывод в строку
                    string summary = $"Всего продано товаров: {totalQuantity}\n  Общая сумма продаж: {totalSales:C}";


                    resultTable.Columns["out_product_id"].ColumnName = "ID товара";
                    resultTable.Columns["out_product_name"].ColumnName = "Название";
                    resultTable.Columns["out_total_quantity_sold"].ColumnName = "Продано";
                    resultTable.Columns["out_total_sales_sum"].ColumnName = "Сумма проданного";


                    ResultsForm resultsForm = new ResultsForm(resultTable, summary);
                    resultsForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
