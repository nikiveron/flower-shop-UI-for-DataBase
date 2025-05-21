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
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String IdClient = comboBoxIdClient.Text;
            String AmountText = numericUpDownAmountOfPurchases.Text;
            int Amount;
            if (int.TryParse(AmountText, out Amount))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для количества.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }
            String SumOfPurText = numericUpDownSumOfPurchases.Text;
            decimal SumOfPur;
            if (decimal.TryParse(SumOfPurText, out SumOfPur))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для суммы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }
            DateTime DateOfIssue = dateTimePickerDateOfIssue.Value;
            
            String SumDiscountText = numericUpDownDiscountSum.Text;
            decimal SumDiscount;
            if (decimal.TryParse(SumDiscountText, out SumDiscount))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для суммы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO discount (IdClient, AmountOfPurchases, SumOfPurchases, DateOfIssue, DiscountSum) VALUES (@idc, @a, @sp, @doi, @sd);", DB.GetConnection());
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@idc", NpgsqlTypes.NpgsqlDbType.Varchar).Value = IdClient;
            command.Parameters.Add("@a", NpgsqlTypes.NpgsqlDbType.Integer).Value = Amount;
            command.Parameters.Add("@sp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = SumOfPur;
            command.Parameters.Add("@doi", NpgsqlTypes.NpgsqlDbType.Date).Value = DateOfIssue;
            command.Parameters.Add("@sd", NpgsqlTypes.NpgsqlDbType.Numeric).Value = SumDiscount;


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

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {

        }

    }
}
