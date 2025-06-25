using MySql.Data.MySqlClient;
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
    public partial class MainMenu : Form
    {
        private readonly string connectionString = sql.SqlConnection.connectionString;
        private Form activeForm;
        public MainMenu()
        {
            InitializeComponent();
            Settings();
            CountTasks();
            LoadTasks();
            LoadClients();
        }
        private void Settings() =>
            this.StartPosition = FormStartPosition.CenterScreen;

        private void OpenDesktopForm(Form desktopForm, object buttonSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = desktopForm;
            desktopForm.TopLevel = false;
            desktopForm.FormBorderStyle = FormBorderStyle.None;
            desktopForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(desktopForm);
            this.panelDesktop.Tag = desktopForm;
            desktopForm.BringToFront();
            desktopForm.Show();
        }

        private void LoadTasks()
        {
            string queryLoad = @"SELECT t.TasksID AS 'ID', concat_ws(' | ', t.TasksName, t.TasksDescription) AS 'Задача', c.CompleteStatusName AS 'Статус' FROM tasks t
                                 LEFT JOIN complete_status c ON t.isCompleted = c.CompleteStatusID";
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();
                    MySqlCommand cmdLoad = new MySqlCommand(queryLoad, connect);
                    MySqlDataAdapter adLoad = new MySqlDataAdapter(cmdLoad);
                    DataTable table = new DataTable();
                    adLoad.Fill(table);
                    gridTasks.DataSource = table;
                    gridTasks.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClients()
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
                    gridClients.DataSource = table;
                    gridClients.Columns["ClientsID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountTasks()
        {
            string queryGetAllCount = "SELECT COUNT(TasksID) FROM tasks";
            string queryGetCompletedTasks = "SELECT COUNT(*) FROM tasks WHERE isCompleted LIKE 1";
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    connect.Open();
                    MySqlCommand cmdGetAllCount = new MySqlCommand(queryGetAllCount, connect);
                    long resultGetAllCount = (long)cmdGetAllCount.ExecuteScalar();
                    allCountTasks.Text = $"Всего: {resultGetAllCount.ToString()}";

                    MySqlCommand cmdGetCompletedTasks = new MySqlCommand(queryGetCompletedTasks, connect);
                    long resultGetCompletedTasks = (long)cmdGetCompletedTasks.ExecuteScalar();
                    completeTasks.Text = $"Выполнено: {resultGetCompletedTasks.ToString()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoTasks_Click(object sender, EventArgs e)
        {
            OpenDesktopForm(new modules.FormTasks(), sender);
        }

        private void buttonGoClients_Click(object sender, EventArgs e)
        {
            OpenDesktopForm(new modules.FormClients(), sender);
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
