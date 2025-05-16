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
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxClientId.Text, out id))
            {
                MessageBox.Show("Введите корректный числовой ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> updates = new List<string>();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DB.GetConnection();

            if (!string.IsNullOrWhiteSpace(textBoxClientName.Text))
            {
                updates.Add("FirstName = @fn");
                command.Parameters.Add("@fn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxClientName.Text;
            }
            if (!string.IsNullOrWhiteSpace(textBoxClientLastname.Text))
            {
                updates.Add("LastName = @ln");
                command.Parameters.Add("@ln", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxClientLastname.Text;
            }
            if (!string.IsNullOrWhiteSpace(maskedTextBoxClientPhonenumber.Text) && maskedTextBoxClientPhonenumber.MaskFull)
            {
                updates.Add("PhoneNumber = @pn");
                command.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = maskedTextBoxClientPhonenumber.Text;
            }
            if (!string.IsNullOrWhiteSpace(textBoxClientEmail.Text))
            {
                updates.Add("Email = @em");
                command.Parameters.Add("@em", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxClientEmail.Text;
            }

            // Ничего не изменяется — отменяем
            if (updates.Count == 0)
            {
                MessageBox.Show("Заполните хотя бы одно поле для обновления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;
            string sql = "UPDATE clients SET " + string.Join(", ", updates) + " WHERE IdClient = @id";
            command.CommandText = sql;

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Клиент с указанным ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
