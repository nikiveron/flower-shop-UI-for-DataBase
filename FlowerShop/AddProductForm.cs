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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String Category = textBoxCategory.Text;
            String Name = textBoxName.Text;
            String IdBouText = comboBoxBouquet.Text;
            int IdBou;
            if (int.TryParse(IdBouText, out IdBou))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                if (!string.IsNullOrEmpty(IdBouText))
                {
                    MessageBox.Show("Введите корректное число для ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }
            String IdFlowerText = comboBoxFlower.Text;
            int IdFlower;
            if (int.TryParse(IdFlowerText, out IdFlower))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                if (!string.IsNullOrEmpty(IdFlowerText))
                {
                    MessageBox.Show("Введите корректное число для ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }
            String IdOthText = comboBoxOther.Text;
            int IdOth;
            if (int.TryParse(IdOthText, out IdOth))
            {
                // Успешно преобразовано — можно использовать amount
            }
            else
            {
                if (!string.IsNullOrEmpty(IdOthText))
                {
                    MessageBox.Show("Введите корректное число для ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Прерываем выполнение, если ввод некорректный
                }
            }

            NpgsqlCommand command = new NpgsqlCommand();


            if (!string.IsNullOrEmpty(IdBouText) && string.IsNullOrEmpty(IdFlowerText) && string.IsNullOrEmpty(IdOthText))
            {
                command = new NpgsqlCommand("INSERT INTO product (Category, Name, IdBouquet) VALUES (@c, @n, @id);", DB.GetConnection());
                command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = IdBou;
            }
            else if (string.IsNullOrEmpty(IdBouText) && !string.IsNullOrEmpty(IdFlowerText) && string.IsNullOrEmpty(IdOthText))
            {
                command = new NpgsqlCommand("INSERT INTO product (Category, Name, IdFlower) VALUES (@c, @n, @id);", DB.GetConnection());
                command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = IdFlower;
            }
            else if (string.IsNullOrEmpty(IdBouText) && string.IsNullOrEmpty(IdFlowerText) && !string.IsNullOrEmpty(IdOthText))
            {
                command = new NpgsqlCommand("INSERT INTO product (Category, Name, IdOther) VALUES (@c, @n, @id);", DB.GetConnection());
                command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = IdOth;
            }
            else
            {
                MessageBox.Show("Может быть заполнено только одно поле для ID! Товар не может быть нескольких типов одновременно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если ввод некорректный
            }
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@c", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Category;
            command.Parameters.Add("@n", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Name;

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

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
