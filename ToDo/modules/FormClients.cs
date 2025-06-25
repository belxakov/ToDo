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
        }
    }
}
