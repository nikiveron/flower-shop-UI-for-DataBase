using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class AddPurchaseForm : Form
    {
        public AddPurchaseForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String IdClientText = comboBoxIdClient.Text;
            int IdClient;
            if (int.TryParse(IdClientText, out IdClient))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для количества.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }

            DateTime DateOfIssue = dateTimePickerDateOfIssue.Value;
            DateTime TimeOfIssue = dateTimePickerTimeOfIssue.Value;

            String SumOfPurText = numericUpDownSumOfPur.Text;
            decimal SumOfPur;
            if (decimal.TryParse(SumOfPurText, out SumOfPur))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для количества.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO purchase (IdClient, DateOfIssue, TimeOfIssue, SumOfPurchase) VALUES (@idc, @doi, @toi, @sop);", DB.GetConnection());
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@idc", NpgsqlTypes.NpgsqlDbType.Integer).Value = IdClient;
            command.Parameters.Add("@doi", NpgsqlTypes.NpgsqlDbType.Date).Value = DateOfIssue;
            command.Parameters.Add("@toi", NpgsqlTypes.NpgsqlDbType.Time).Value = TimeOfIssue;
            command.Parameters.Add("@sop", NpgsqlTypes.NpgsqlDbType.Numeric).Value = SumOfPur;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException ex)
            {
                // PostgreSQL специфичная ошибка (например, нарушено ограничение)
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Общая ошибка (например, проблема с соединением)
                MessageBox.Show("Произошла ошибка. Пожалуйста, попробуйте ещё раз.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
            this.Close();
        }

        private void AddPurchaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
