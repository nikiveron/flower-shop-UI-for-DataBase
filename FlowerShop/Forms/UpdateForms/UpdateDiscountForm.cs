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
    public partial class UpdateDiscountForm : Form
    {
        public UpdateDiscountForm()
        {
            InitializeComponent();
        }

        private void UpdateDiscountForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Получаем ID скидки
            int discountId;
            if (!int.TryParse(textBoxDiscountId.Text, out discountId))
            {
                MessageBox.Show("Введите корректный числовой ID скидки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Список для обновляемых полей
            List<string> updates = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            // Проверка и добавление поля ClientId
            if (!string.IsNullOrWhiteSpace(textBoxClientId.Text))
            {
                int clientId;
                if (int.TryParse(textBoxClientId.Text, out clientId))
                {
                    updates.Add("ClientId = @clientId");
                    command.Parameters.Add("@clientId", NpgsqlTypes.NpgsqlDbType.Integer).Value = clientId;
                }
                else
                {
                    MessageBox.Show("Введите корректный числовой ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Проверка и добавление поля AmountPurchases
            if (!string.IsNullOrWhiteSpace(textBoxAmountPurchases.Text))
            {
                int amountPurchases;
                if (int.TryParse(textBoxAmountPurchases.Text, out amountPurchases))
                {
                    updates.Add("AmountOfPurchases = @amountPurchases");
                    command.Parameters.Add("@amountPurchases", NpgsqlTypes.NpgsqlDbType.Integer).Value = amountPurchases;
                }
                else
                {
                    MessageBox.Show("Введите корректное количество покупок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Проверка и добавление поля SumPurchases
            if (!string.IsNullOrWhiteSpace(textBoxSumPurchases.Text))
            {
                decimal sumPurchases;
                if (decimal.TryParse(textBoxSumPurchases.Text, out sumPurchases))
                {
                    updates.Add("SumOfPurchases = @sumPurchases");
                    command.Parameters.Add("@sumPurchases", NpgsqlTypes.NpgsqlDbType.Numeric).Value = sumPurchases;
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму покупок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Проверка и добавление поля DateOfIssue
            if (dateTimePickerDateOfIssue.Value != null)
            {
                updates.Add("DateOfIssue = @dateOfIssue");
                command.Parameters.Add("@dateOfIssue", NpgsqlTypes.NpgsqlDbType.Date).Value = dateTimePickerDateOfIssue.Value.Date;
            }

            // Проверка и добавление поля DiscountSum
            if (!string.IsNullOrWhiteSpace(textBoxDiscountSum.Text))
            {
                decimal discountSum;
                if (decimal.TryParse(textBoxDiscountSum.Text, out discountSum))
                {
                    updates.Add("DiscountSum = @discountSum");
                    command.Parameters.Add("@discountSum", NpgsqlTypes.NpgsqlDbType.Numeric).Value = discountSum;
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму скидки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Если никаких изменений не внесено — отменяем
            if (updates.Count == 0)
            {
                MessageBox.Show("Заполните хотя бы одно поле для обновления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Добавляем ID скидки для обновления
            command.Parameters.Add("@discountId", NpgsqlTypes.NpgsqlDbType.Integer).Value = discountId;

            // Строим SQL запрос для обновления
            string sql = "UPDATE discount SET " + string.Join(", ", updates) + " WHERE Id = @discountId";
            command.CommandText = sql;

            try
            {
                // Выполнение запроса
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Скидка с указанным ID не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Данные успешно обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show("Ошибка при обновлении данных скидки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
