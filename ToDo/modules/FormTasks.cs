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
    public partial class FormTasks : Form
    {
        private readonly string connectionString = sql.SqlConnection.connectionString;
        public FormTasks()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
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
                    dataGridView1.DataSource = table;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertTask()
        {
            string tasksName = boxTasksName.Text;
            string tasksDescription = boxTasksDescription.Text;
            string queryInsert = $@"INSERT INTO tasks (TasksName, TasksDescription, isCompleted)
                                   VALUES ('{tasksName}', '{tasksDescription}', '2')";
            try
            {
                if (!string.IsNullOrEmpty(tasksName))
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
                            MessageBox.Show("Задача добавлена!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: укажите заголовок задачи!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearBoxes()
        {
            boxTasksName.Text = null;
            boxTasksDescription.Text = null;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            InsertTask();
        }
    }
}
