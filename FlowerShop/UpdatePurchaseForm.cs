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
    public partial class UpdatePurchaseForm : Form
    {
        public UpdatePurchaseForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Получаем ID покупки для обновления
            int purchaseId;
            if (!int.TryParse(textBoxPurchaseId.Text, out purchaseId))
            {
                MessageBox.Show("Введите корректный числовой ID покупки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Список для обновляемых полей
            List<string> updates = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            // Проверка и добавление поля IdClient
            if (!string.IsNullOrWhiteSpace(textBoxIdClient.Text))
            {
                int idClient;
                if (int.TryParse(textBoxIdClient.Text, out idClient))
                {
                    updates.Add("IdClient = @idClient");
                    command.Parameters.Add("@idClient", NpgsqlTypes.NpgsqlDbType.Integer).Value = idClient;
                }
                else
                {
                    MessageBox.Show("Введите корректное число для ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }

            // Проверка и добавление поля DateOfIssue
            if (dateTimePickerDateOfIssue.Value != DateTime.MinValue)
            {
                updates.Add("DateOfIssue = @dateOfIssue");
                command.Parameters.Add("@dateOfIssue", NpgsqlTypes.NpgsqlDbType.Date).Value = dateTimePickerDateOfIssue.Value.Date;
            }

            // Проверка и добавление поля TimeOfIssue
            if (dateTimePickerTimeOfIssue.Value != DateTime.MinValue)
            {
                updates.Add("TimeOfIssue = @timeOfIssue");
                command.Parameters.Add("@timeOfIssue", NpgsqlTypes.NpgsqlDbType.Time).Value = dateTimePickerTimeOfIssue.Value.TimeOfDay;
            }

            // Проверка и добавление поля SumOfPurchase
            if (!string.IsNullOrWhiteSpace(textBoxSumOfPurchase.Text))
            {
                decimal sumOfPurchase;
                if (decimal.TryParse(textBoxSumOfPurchase.Text, out sumOfPurchase))
                {
                    updates.Add("SumOfPurchase = @sumOfPurchase");
                    command.Parameters.Add("@sumOfPurchase", NpgsqlTypes.NpgsqlDbType.Numeric).Value = sumOfPurchase;
                }
                else
                {
                    MessageBox.Show("Введите корректное число для суммы покупки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = purchaseId;

            // Строим SQL запрос для обновления
            string sql = "UPDATE purchase SET " + string.Join(", ", updates) + " WHERE Id = @id";
            command.CommandText = sql;

            try
            {
                // Выполнение запроса
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Покупка с указанным ID не найдена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Данные успешно обновлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void UpdatePurchaseForm_Load(object sender, EventArgs e)
        {

        }


    }
}
