using Librarie;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfataUtilizator
{
    public partial class Contacte : Form
    {
        int Id;
        IStocareData adminPersoane;
        List<string> socialeSelectate = new List<string>();
        private Form activeForm = null;
        public Contacte()
        {
            InitializeComponent();
            panelLeft.Height = btnContacte.Height;
            panelLeft.Top = btnContacte.Top;
            adminPersoane = StocareFactory.GetAdministratorStocare();
            List<Persoana> persoane = adminPersoane.GetPersoane();
            AdaugaPersoaneInControlDataGridView(persoane);
            AdaugaPersoaneInControlListbox(persoane);
        }
        private void AdaugaPersoaneInControlListbox(List<Persoana> persoane)
        {
            lstAfisare.Items.Clear();

            foreach (Persoana s in persoane)
            {

                lstAfisare.Items.Add(s);

            }
        }
      
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnDashboard.Height;
            panelLeft.Top = btnDashboard.Top;
            panelLeft.Height = btnContacte.Height;
            panelLeft.Top = btnContacte.Top;
            this.Hide();
            Dashboard f2 = new Dashboard();
            f2.ShowDialog();
            this.Close();
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
        private void AdaugaPersoaneInControlDataGridView(List<Persoana> persoane)
        {

            dataGridPersoane.DataSource = null;
            dataGridPersoane.DataSource = persoane.Select(s => new { s.IdPersoana, s.Nume, s.Prenume, s.NrDeTelefon, s.Email, s.Grupul, Social = string.Join(",", s.Social),s.Salvare, s.DataNastere.Date, s.DataActualizare }).ToList();
        }

        private void lblAdauga_Click(object sender, EventArgs e)
        {
            openChildForm(new Adauga());
            
        }
        private void lblModifica_Click(object sender, EventArgs e)
        {           
            openChildForm(new Modifica());
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.Show();
            //activeForm.Hide();
            
        }
        private void CautaPersoaneInControlDataGridView(string cautare)
        {
            dataGridPersoane.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool result = false;
                foreach (DataGridViewRow row in dataGridPersoane.Rows)
                {                 
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        int rowIndex = row.Index;
                        dataGridPersoane.Rows[rowIndex].Selected = false;
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Equals(cautare))
                        {                         
                            dataGridPersoane.Rows[rowIndex].Selected = true;
                            result = true;
                            break;
                        }
                    }
                }
                if (!result)
                {
                    MessageBox.Show("Nu s-a gasit textul " + txtCauta.Text, "404 Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridPersoane_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   Persoana.ModificareId = dataGridPersoane.SelectedRows[0].Index +1;
                MessageBox.Show(Persoana.ModificareId.ToString());              
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {          
            CautaPersoaneInControlDataGridView( txtCauta.Text.ToUpper());
        }

        private void btnCautaData_Click(object sender, EventArgs e)
        {     
            string data = dtpData1.Value.Date.ToString();
            CautaPersoaneInControlDataGridView(data);
        }

        private void btnNumeComplet_Click(object sender, EventArgs e)
        {
            Persoana s = adminPersoane.GetPersoanaByIndex(Persoana.ModificareId);
            txtNumeComplet.Text = s.NumeComplet();
        }
    }
}
