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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String FirstName = textBoxClientName.Text;
            String LastName = textBoxClientLastname.Text;
            String Sex = comboBoxClientSex.Text;
            if (Sex == "Мужчина") Sex = "M";
            else Sex = "F";
                DateTime birthDate = dateTimePickerClientBirthdate.Value;
            String PhoneNumber = maskedTextBoxClientPhonenumber.Text;
            String Email = textBoxClientEmail.Text;

            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO clients (FirstName, LastName, Sex, BirthDate, PhoneNumber, Email) VALUES  (@fn, @ln, @s, @bd, @pn, @em);", DB.GetConnection());
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@fn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = FirstName;
            command.Parameters.Add("@ln", NpgsqlTypes.NpgsqlDbType.Varchar).Value = LastName;
            command.Parameters.Add("@s", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Sex;
            command.Parameters.Add("@bd", NpgsqlTypes.NpgsqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = PhoneNumber;
            command.Parameters.Add("@em", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Email;

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

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
