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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlowerShop
{
    public partial class ClientIdInputForm : Form
    {

        public ClientIdInputForm()
        {
            InitializeComponent();
            NpgsqlCommand command = new NpgsqlCommand("SELECT IdClient FROM clients ORDER BY IdClient;", DB.GetConnection());
            command.CommandType = CommandType.Text;
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            adapter.Fill(table);
            List<int> ids = new List<int>();
            foreach (DataRow id in table.Rows) 
            {
                ids.Add(int.Parse(id[0].ToString()));
                comboBoxClientId.Items.Add(int.Parse(id[0].ToString()));
            }
        }  
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxClientId.Text, out int id) && DateTime.TryParse(dateTimePickerStart.Text, out DateTime dtS) && DateTime.TryParse(dateTimePickerEnd.Text, out DateTime dtE))
            {
                NpgsqlCommand command = new NpgsqlCommand("SELECT PurchaseId, DateOfIssue, TimeOfIssue, SumOfPurchase FROM client_purchase_view WHERE IdClient = @idClient AND DateOfIssue BETWEEN @startDate AND @endDate ORDER BY DateOfIssue, TimeOfIssue;", DB.GetConnection());
                command.CommandType = CommandType.Text;

                command.Parameters.Add("@idClient", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;
                command.Parameters.Add("@startDate", NpgsqlTypes.NpgsqlDbType.Date).Value = dtS;
                command.Parameters.Add("@endDate", NpgsqlTypes.NpgsqlDbType.Date).Value = dtE;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                table.Columns["PurchaseId"].ColumnName = "ID покупки";
                table.Columns["DateOfIssue"].ColumnName = "Дата выдачи";
                table.Columns["TimeOfIssue"].ColumnName = "Время выдачи";
                table.Columns["SumOfPurchase"].ColumnName = "Сумма покупки";

                // Показываем результаты в новой форме
                ResultsForm resultsForm = new ResultsForm(table);
                resultsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Введите корректный ID клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientIdInputForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}
