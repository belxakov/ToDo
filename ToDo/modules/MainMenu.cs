using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.modules
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Settings();
        }
        private void Settings()
        {
            // Styles
            this.Text = "ToDo | Главное меню";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonGoTasks_Click(object sender, EventArgs e)
        {
            modules.FormTasks formTasks = new modules.FormTasks();
            formTasks.ShowDialog();
        }

        private void buttonGoClients_Click(object sender, EventArgs e)
        {
            modules.FormClients formClients = new modules.FormClients();
            formClients.ShowDialog();
        }
    }
}
