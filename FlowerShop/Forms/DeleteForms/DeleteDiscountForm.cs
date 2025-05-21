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
    public partial class DeleteDiscountForm : Form
    {
        public DeleteDiscountForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли первый элемент ("клиент")
            if (checkedListBox1.GetItemChecked(0))
            {
                int id;
                if (!int.TryParse(textBoxDiscountId.Text, out id))
                {
                    MessageBox.Show("Введите корректный числовой ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM discount WHERE IdClient = @ic;", DB.GetConnection());
                command.CommandType = CommandType.Text;

                command.Parameters.Add("@ic", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Клиент с таким ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Npgsql.PostgresException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка. Пожалуйста, попробуйте ещё раз.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                command.Dispose();
                this.Close();
            }

            // Проверяем, выбран ли второй элемент ("дисконт")
            if (checkedListBox1.GetItemChecked(1))
            {
                int id;
                if (!int.TryParse(textBoxDiscountId.Text, out id))
                {
                    MessageBox.Show("Введите корректный числовой ID дисконта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM discount WHERE Id = @ic;", DB.GetConnection());
                command.CommandType = CommandType.Text;

                command.Parameters.Add("@ic", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Дисконт с таким ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Npgsql.PostgresException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка. Пожалуйста, попробуйте ещё раз.\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                command.Dispose();
                this.Close();
            }
        }

        private void labelSelectDiscountId_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiscountId_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
