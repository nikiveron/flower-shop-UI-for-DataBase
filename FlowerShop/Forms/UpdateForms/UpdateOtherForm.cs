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
    public partial class UpdateOtherForm : Form
    {
        public UpdateOtherForm()
        {
            InitializeComponent();
        }

        private void UpdateOtherForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Получаем ID объекта для обновления
            int otherId;
            if (!int.TryParse(textBoxOtherId.Text, out otherId))
            {
                MessageBox.Show("Введите корректный числовой ID товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Список для обновляемых полей
            List<string> updates = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            // Проверка и добавление поля OtherType
            if (!string.IsNullOrWhiteSpace(textBoxOtherType.Text))
            {
                updates.Add("Type = @type");
                command.Parameters.Add("@type", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxOtherType.Text;
            }

            // Проверка и добавление поля OtherName
            if (!string.IsNullOrWhiteSpace(textBoxOtherName.Text))
            {
                updates.Add("Name = @name");
                command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxOtherName.Text;
            }

            // Проверка и добавление поля OtherPrice
            if (!string.IsNullOrWhiteSpace(textBoxOtherPrice.Text))
            {
                decimal price;
                if (decimal.TryParse(textBoxOtherPrice.Text, out price))
                {
                    updates.Add("Price = @price");
                    command.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
                }
                else
                {
                    MessageBox.Show("Введите корректное число для цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }

            // Если ничего не изменяется — отменяем
            if (updates.Count == 0)
            {
                MessageBox.Show("Заполните хотя бы одно поле для обновления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Добавляем ID для обновления
            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = otherId;

            // Строим SQL запрос для обновления
            string sql = "UPDATE other SET " + string.Join(", ", updates) + " WHERE Id = @id";
            command.CommandText = sql;

            try
            {
                // Выполнение запроса
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Товар с указанным ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Закрытие соединения
            command.Dispose();
            this.Close();
        }

    }
}
