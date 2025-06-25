using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ToDo.modules
{
    public partial class FormClients : Form
    {
        private readonly string connectionString = sql.SqlConnection.connectionString;
        public FormClients()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string queryLoad = "SELECT * FROM clients";
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();
                    MySqlCommand cmdLoad = new MySqlCommand(queryLoad, connect);
                    MySqlDataAdapter adLoad = new MySqlDataAdapter(cmdLoad);
                    DataTable table = new DataTable();
                    adLoad.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns["ClientsID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertClient()
        {
            string clientsSurname = boxClientSurname.Text;
            string clientsName = boxClientName.Text;
            string clientsPatronymic = boxClientPatronymic.Text;
            string clientsPhoneNumber = boxClientPhoneNumber.Text;
            string queryInsert = $@"INSERT INTO clients (ClientsSurname, ClientsName, ClientsPatronymic, ClientsPhoneNumber)
                                    VALUES ('{clientsSurname}', '{clientsName}', '{clientsPatronymic}', '{clientsPhoneNumber}')";
            try
            {
                if (!string.IsNullOrEmpty(clientsSurname) && !string.IsNullOrEmpty(clientsName) && !string.IsNullOrEmpty(clientsPhoneNumber))
                {
                    using (MySqlConnection connect = new MySqlConnection(connectionString))
                    {
                        connect.Open();
                        MySqlCommand cmdInsert = new MySqlCommand(queryInsert, connect);
                        int resultInsert = cmdInsert.ExecuteNonQuery();
                        if (resultInsert > 0)
                        {
                            LoadData();
                            ClearBoxes();
                            MessageBox.Show("Клиент добавлен!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: заполните обязательные поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearBoxes()
        {
            boxClientSurname.Text = null;
            boxClientName.Text = null;
            boxClientPatronymic.Text = null;
            boxClientPhoneNumber.Text = null;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            InsertClient();
        }

        private void buttonCloseApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите завершить процесс?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
