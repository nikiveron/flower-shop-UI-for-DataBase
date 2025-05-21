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
    public partial class AddOtherForm : Form
    {
        public AddOtherForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String Name = textBoxName.Text;
            String ProdType = textBoxType.Text;
            String PriceText = numericUpDownPrice.Text;
            decimal Price;
            if (decimal.TryParse(PriceText, out Price))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                MessageBox.Show("Введите корректное число для цены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO other (Type, Name, Price) VALUES (@t, @n, @p);", DB.GetConnection());
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@t", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ProdType;
            command.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Name;
            command.Parameters.Add("@p", NpgsqlTypes.NpgsqlDbType.Numeric).Value = Price;

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

        private void AddOtherForm_Load(object sender, EventArgs e)
        {

        }
    }
}
