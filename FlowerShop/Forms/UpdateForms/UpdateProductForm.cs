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
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Получаем ID объекта для обновления
            int Id;
            if (!int.TryParse(textBoxProductId.Text, out Id))
            {
                MessageBox.Show("Введите корректный числовой ID товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            // Проверка и добавление поля название
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                command.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxName.Text;
            }

            // Добавляем ID для обновления
            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Id;

            // Строим SQL запрос для обновления
            string sql = "UPDATE product SET Name = @n WHERE Id = @id";
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

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
