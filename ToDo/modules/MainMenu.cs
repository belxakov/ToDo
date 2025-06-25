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
        private Form activeForm;
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
