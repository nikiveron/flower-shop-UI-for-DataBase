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
    public partial class DeleteProductForm : Form
    {
        public DeleteProductForm()
        {
            InitializeComponent();
        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxProductId.Text, out id))
            {
                MessageBox.Show("Введите корректный числовой ID товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NpgsqlCommand command = new NpgsqlCommand("DELETE FROM product WHERE Id = @ic;", DB.GetConnection());
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@ic", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

            try
            {
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows == 0)
                {
                    MessageBox.Show("Товар с таким ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
