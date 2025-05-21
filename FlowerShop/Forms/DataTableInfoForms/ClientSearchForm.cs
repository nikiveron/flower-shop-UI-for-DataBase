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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlowerShop
{
    public partial class ClientSearchForm : Form
    {
        string formType = "";
        public ClientSearchForm(string formType)
        {
            InitializeComponent();
            this.formType = formType;
        }

        private void ClientSearchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {   
            if (formType == "buttonClientSearch_Click") 
            {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();
                string phone = textBoxPhone.Text.Trim();

                List<string> conditions = new List<string>();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.GetConnection();

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    conditions.Add("FirstName ILIKE @firstName");
                    command.Parameters.AddWithValue("@firstName", "%" + firstName + "%");
                }

                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    conditions.Add("LastName ILIKE @lastName");
                    command.Parameters.AddWithValue("@lastName", "%" + lastName + "%");
                }

                if (!string.IsNullOrWhiteSpace(phone))
                {
                    conditions.Add("PhoneNumber ILIKE @phone");
                    command.Parameters.AddWithValue("@phone", "%" + phone + "%");
                }

                if (conditions.Count == 0)
                {
                    MessageBox.Show("Введите хотя бы одно поле для поиска.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "SELECT * FROM clients WHERE " + string.Join(" AND ", conditions);
                command.CommandText = sql;

                try
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    table.Columns["IdClient"].ColumnName = "ID клиента";
                    table.Columns["FirstName"].ColumnName = "Имя";
                    table.Columns["LastName"].ColumnName = "Фамилия";
                    table.Columns["Sex"].ColumnName = "Пол";
                    table.Columns["BirthDate"].ColumnName = "Дата рождения";
                    table.Columns["PhoneNumber"].ColumnName = "Номер телефона";
                    table.Columns["Email"].ColumnName = "Электронная почта";

                    // Показываем результаты в новой форме
                    ResultsForm resultsForm = new ResultsForm(table);
                    resultsForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (formType == "buttonSearchDiscount_Click")
            {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();
                string phone = textBoxPhone.Text.Trim();

                List<string> conditions = new List<string>();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DB.GetConnection();

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    conditions.Add("FirstName ILIKE @firstName");
                    command.Parameters.AddWithValue("@firstName", "%" + firstName + "%");
                }

                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    conditions.Add("LastName ILIKE @lastName");
                    command.Parameters.AddWithValue("@lastName", "%" + lastName + "%");
                }

                if (!string.IsNullOrWhiteSpace(phone))
                {
                    conditions.Add("PhoneNumber ILIKE @phone");
                    command.Parameters.AddWithValue("@phone", "%" + phone + "%");
                }

                if (conditions.Count == 0)
                {
                    MessageBox.Show("Введите хотя бы одно поле для поиска.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Используем представление client_discount_extended_view
                string sql = "SELECT * FROM client_discount_extended_view WHERE " + string.Join(" AND ", conditions);
                command.CommandText = sql;

                try
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Клиент со скидкой не найден.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Переименовываем столбцы для отображения
                    table.Columns["IdClient"].ColumnName = "ID клиента";
                    table.Columns["FirstName"].ColumnName = "Имя";
                    table.Columns["LastName"].ColumnName = "Фамилия";
                    table.Columns["PhoneNumber"].ColumnName = "Телефон";
                    table.Columns["Id"].ColumnName = "ID дисконта";
                    table.Columns["AmountOfPurchases"].ColumnName = "Кол-во покупок";
                    table.Columns["SumOfPurchases"].ColumnName = "Сумма покупок";
                    table.Columns["DateOfIssue"].ColumnName = "Дата выдачи дисконта";
                    table.Columns["DiscountSum"].ColumnName = "Скидка";

                    // Показываем результаты в форме
                    ResultsForm resultsForm = new ResultsForm(table);
                    resultsForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при поиске скидки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private async void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            //if (isSuggestionSelected)
            //{
            //    isSuggestionSelected = false;
            //    return;
            //}

            //if (textBoxLastName.ForeColor == SystemColors.GrayText)
            //{
            //    suggestionsListBox.Visible = false;
            //    return;
            //}

            //// Убрали проверку на пустую строку здесь, так как теперь она обрабатывается в SearchInDatabase

            //if (textBoxLastName.Text.Length < 2 && !string.IsNullOrWhiteSpace(textBoxLastName.Text))
            //{
            //    dataGridView1.DataSource = null;
            //    suggestionsListBox.Visible = false;
            //    return;
            //}

            //var currentTime = DateTime.Now;
            //if ((currentTime - lastSearchTime).TotalMilliseconds < SearchDelayMs)
            //    return;

            //lastSearchTime = currentTime;

            //await ShowSuggestionsAsync(textBoxLastName.Text);
            //await PerformSearchAsync(); // Теперь при пустой строке будет возвращать все данные
        }
        private async Task ShowSuggestionsAsync(string searchText)
        {
            //try
            //{
            //    if (!searchConfig.ContainsKey(currentSearchType) || string.IsNullOrWhiteSpace(searchText))
            //    {
            //        suggestionsListBox.Visible = false;
            //        return;
            //    }

            //    var config = searchConfig[currentSearchType];
            //    var suggestions = new List<string>();

            //    await Task.Run(async () =>
            //    {
            //        try
            //        {
            //            using (var tempConnection = new NpgsqlConnection(connectionString))
            //            {
            //                await tempConnection.OpenAsync();

            //                // Формируем правильный запрос в зависимости от типа поиска
            //                string query;
            //                if (currentSearchType == "Фамилия")
            //                {
            //                    query = "SELECT LastName FROM clients WHERE title ILIKE @searchText LIMIT 10";
            //                }
            //                else if (currentSearchType == "Имя")
            //                {
            //                    query = "SELECT CONCAT(firstname, ' ', lastname, ' ', surname) FROM writers WHERE CONCAT(firstname, ' ', lastname, ' ', surname) ILIKE @searchText LIMIT 10";
            //                }
            //                else if (currentSearchType == "Телефон")
            //                {
            //                    query = "SELECT CONCAT(firstname, ' ', lastname, ' ', surname) " +
            //                            "FROM writers WHERE CONCAT(firstname, ' ', lastname, ' ', surname) ILIKE @searchText LIMIT 10";
            //                }
            //                else
            //                {
            //                    query = $"{config.AutoCompleteQuery} WHERE {config.SearchField} ILIKE @searchText LIMIT 10";
            //                }

            //                using (var cmd = new NpgsqlCommand(query, tempConnection))
            //                {
            //                    cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");

            //                    using (var reader = await cmd.ExecuteReaderAsync())
            //                    {
            //                        while (await reader.ReadAsync())
            //                        {
            //                            suggestions.Add(reader[0].ToString());
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            // Логируем ошибку, но не прерываем выполнение
            //            Console.WriteLine($"Ошибка выполнения запроса: {ex.Message}");
            //        }
            //    });

            //    // Обновляем UI в основном потоке
            //    this.Invoke((MethodInvoker)delegate
            //    {
            //        suggestionsListBox.Items.Clear();
            //        foreach (var item in suggestions)
            //        {
            //            suggestionsListBox.Items.Add(item);
            //        }

            //        suggestionsListBox.Visible = suggestionsListBox.Items.Count > 0;
            //        if (suggestionsListBox.Visible)
            //        {
            //            suggestionsListBox.SelectedIndex = 0;
            //        }
            //    });
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Общая ошибка в ShowSuggestionsAsync: {ex.Message}");
            //}
        }

        private async Task PerformSearchAsync()
        {
            //string searchText = textBoxLastName.Text.Trim();
            //Cursor = Cursors.WaitCursor;

            //try
            //{
            //    SearchResults = await Task.Run(() => SearchInDatabase(searchText));
            //    dataGridView1.DataSource = SearchResults;
            //    SearchTerm = searchText;

            //    // Переименовываем заголовки столбцов на русский
            //    TranslateColumnHeaders();

            //    if (SearchResults.Rows.Count == 0 && currentSearchType == "книги по автору")
            //    {
            //        MessageBox.Show("Книги данного автора не найдены", "Информация",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ошибка поиска: {ex.Message}",
            //        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    Cursor = Cursors.Default;
            //}
        }


    }
}

