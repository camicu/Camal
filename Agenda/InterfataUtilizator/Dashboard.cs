using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            panelLeft.Height = btnDashboard.Height;
            panelLeft.Top = btnDashboard.Top;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnDashboard.Height;
            panelLeft.Top = btnDashboard.Top;
        }

        private void btnContacte_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnContacte.Height;
            panelLeft.Top = btnContacte.Top;
            this.Hide();
            Contacte f2 = new Contacte();
            f2.ShowDialog();
            this.Close();

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnCalendar.Height;
            panelLeft.Top = btnCalendar.Top;
        }

        private void btnSocialMedia_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnSocialMedia.Height;
            panelLeft.Top = btnSocialMedia.Top;
        }
    }
    
    
    }
