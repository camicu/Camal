using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librarie;
using NivelAccesDate;

namespace InterfataUtilizator
{
    public partial class Adauga : Form
    {

        IStocareData adminPersoane;
        List<string> socialeSelectate = new List<string>();
        public Adauga()
        {
            InitializeComponent();
            adminPersoane = StocareFactory.GetAdministratorStocare();
        }
      
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text, txtEmail.Text, txtNrTelefon.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Persoana s = new Persoana(txtNume.Text, txtPrenume.Text);
                s.Email = txtEmail.Text;
                s.NrDeTelefon = Int32.Parse(txtNrTelefon.Text);
                s.Grupul = GetGrupSelectat();
                s.Social = new List<string>();
                s.Social.AddRange(socialeSelectate);
                s.Salvare = cmbSalvare.Text;
                s.DataActualizare = DateTime.Now;
                s.DataNastere = dtpDataNastere.Value;

                adminPersoane.AddPersoana(s);
                ResetareControale();
                MessageBox.Show("Contactul a fost Adaugat");
            }


            }
        private void ckbSociale_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string socialSelectat = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                socialeSelectate.Add(socialSelectat);
            else
                socialeSelectate.Remove(socialSelectat);
        }
        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                lblPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.EMAIL_INCORECT) == CodEroare.EMAIL_INCORECT)
            {
                lblEmail.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NO_GRUP) == CodEroare.NO_GRUP)
            {
                lblGrup.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NRTELEFON_INCORECT) == CodEroare.NRTELEFON_INCORECT)
            {
                lblNrTelefon.ForeColor = Color.Red;
            }
        }
        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = Color.Silver;
            lblPrenume.ForeColor = Color.Silver;
            lblNrTelefon.ForeColor = Color.Silver;
            lblEmail.ForeColor = Color.Silver;
            lblGrup.ForeColor = Color.Silver;
        }
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtEmail.Text = txtNrTelefon.Text = string.Empty;
            rdbServiciu.Checked = false;
            rdbFamilie.Checked = false;
            rdbPrieteni.Checked = false;
            ckbSnapchat.Checked = false;
            ckbFacebook.Checked = false;
            ckbInstagram.Checked = false;
            ckbTikTok.Checked = false;
            ckbReddit.Checked = false;
            ckbWhatsApp.Checked = false;
            socialeSelectate.Clear();
        }
        private Grup GetGrupSelectat()
        {
            if (rdbServiciu.Checked)
                return Grup.Serviciu;
            if (rdbFamilie.Checked)
                return Grup.Familie;
            if (rdbPrieteni.Checked)
                return Grup.Prieteni;
            return Grup.Necunoscut;
        }
        private CodEroare Validare(string nume, string prenume, string email, string nrtelefon)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (prenume == string.Empty)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }
            if (email == string.Empty)
            {
                rezultatValidare |= CodEroare.EMAIL_INCORECT;
            }
            if (nrtelefon == string.Empty)
            {
                rezultatValidare |= CodEroare.NRTELEFON_INCORECT;
            }
            int grupSelectat = 0;
            foreach (var control in gpbGrup.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    grupSelectat = 1;
            }
            if (grupSelectat == 0)
                rezultatValidare |= CodEroare.NO_GRUP;

            return rezultatValidare;
        }
    }
}
