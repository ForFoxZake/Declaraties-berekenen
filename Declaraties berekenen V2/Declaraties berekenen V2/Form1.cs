using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declaraties_berekenen_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btn_home.Height;
            sidePanel.Top = btn_home.Top;
            homeUserControl1.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_home.Height;
            sidePanel.Top = btn_home.Top;
            homeUserControl1.BringToFront();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_add.Height;
            sidePanel.Top = btn_add.Top;
            addUserControl1.BringToFront();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_database.Height;
            sidePanel.Top = btn_database.Top;
            
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_settings.Height;
            sidePanel.Top = btn_settings.Top;   
        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
