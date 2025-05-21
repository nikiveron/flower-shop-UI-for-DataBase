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
using System.Windows.Forms.VisualStyles;

namespace FlowerShop
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            String loginUser = loginTextBox.Text;
            String passwordUser = passwordTextBox.Text;

            DB dB = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @ul AND password = @up", DB.GetConnection());
            command.Parameters.Add("@ul", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUser;
            command.Parameters.Add("@up", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                if (loginUser == "admin" && passwordUser == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    RegularForm regularForm = new RegularForm();
                    regularForm.Show();
                }
            }
            else MessageBox.Show("Ошибка! Введен неверный логин или пароль.", "Ошибка пользователя", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               Environment.Exit(0);
            }
        }
    }   
}
