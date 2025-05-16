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
    public partial class UpdateFlowerForm : Form
    {
        public UpdateFlowerForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxFlowerId.Text, out id))
            {
                MessageBox.Show("Введите корректный числовой ID цветка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> updates = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            if (!string.IsNullOrWhiteSpace(textBoxFlowerName.Text))
            {
                updates.Add("Name = @n");
                command.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxFlowerName.Text;
            }
            if (!string.IsNullOrWhiteSpace(numericUpDownAmount.Text))
            {
                int Amount;
                if (int.TryParse(numericUpDownAmount.Text, out Amount))
                {
                    updates.Add("Amount = @a");
                    command.Parameters.Add("@a", NpgsqlTypes.NpgsqlDbType.Integer).Value = Amount;
                }
                else
                {
                    MessageBox.Show("Введите корректное число для количества.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }

            }
            if (!string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                decimal Price;
                if (decimal.TryParse(textBoxPrice.Text, out Price))
                {
                    updates.Add("Price = @p");
                    command.Parameters.Add("@p", NpgsqlTypes.NpgsqlDbType.Numeric).Value = textBoxPrice.Text;
                }
                else
                {
                    MessageBox.Show("Введите корректное число для цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }

            // Ничего не изменяется — отменяем
            if (updates.Count == 0)
            {
                MessageBox.Show("Заполните хотя бы одно поле для обновления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;
            string sql = "UPDATE flower SET " + string.Join(", ", updates) + " WHERE Id = @id";
            command.CommandText = sql;

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Цветок с указанным ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных клиента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
            this.Close();
        }
    }
}
