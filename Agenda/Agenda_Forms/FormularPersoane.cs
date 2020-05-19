﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Librarie;
using NivelAccesDate;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Agenda_Forms
{
    public partial class FormularPersoane : Form
    {

        IStocareData adminPersoane;
        List<string> socialeSelectate = new List<string>();

        public FormularPersoane()
        {
            InitializeComponent();
            adminPersoane = StocareFactory.GetAdministratorStocare();
            this.Width = 500;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text,  txtEmail.Text,txtNrTelefon.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Persoana s = new Persoana(txtNume.Text, txtPrenume.Text)
                {
                    Email = txtEmail.Text,
                    NrDeTelefon = Int32.Parse(txtNrTelefon.Text),
                    Grupul = GetGrupSelectat(),
                    Social = new List<string>()
                };
                s.Social.AddRange(socialeSelectate);
                s.DataActualizare = DateTime.Now;
                s.DataNastere = dtpDataNastere.Value;
                adminPersoane.AddPersoana(s);
                //lblMesaj.Text = "Studentul a fost adaugat";

                //resetarea controalelor pentru a introduce datele unui student nou
                ResetareControale();
            }
        }
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtEmail.Text =txtNrTelefon.Text= string.Empty;
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
           // lblMesaj.Text = string.Empty;
            lblID.Text = String.Empty;
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
            // verificare ca este cel putin un program studiu selectat
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
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblNrTelefon.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblGrup.ForeColor = Color.Black;
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

        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Persoana s = null;
            try
            {
                s = adminPersoane.GetPersoanaByIndex(lstAfisare.SelectedIndex);
            }
            catch (Exception ex)
            {
                //lblMesaj.Text = "Eroare: " + ex.Message;
            }

            if (s != null)
            {
                lblID.Text = s.IdPersoana.ToString();

                txtNume.Text = s.Nume;
                txtPrenume.Text = s.Prenume;

                foreach (var gp in gpbGrup.Controls)
                {
                    if (gp is RadioButton)
                    {
                        var gpBox = gp as RadioButton;
                        if (gpBox.Text == s.Grupul.ToString())
                        {
                            gpBox.Checked = true;
                        }
                    }
                }

                foreach (var social in gpbSocial.Controls)
                {
                    if (social is CheckBox)
                    {
                        var socialBox = social as CheckBox;
                        foreach (String soc in s.Social)
                            if (socialBox.Text.Equals(soc))
                                socialBox.Checked = true;
                    }
                }

                cmbSalvare.Text = s.Salvare;
            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.Width = 1330;
            List<Persoana> persoane = adminPersoane.GetPersoane();

            AdaugaPersoaneInControlListbox(persoane);
            AdaugaPersoaneInControlDataGridView(persoane);
        }
        private void AdaugaPersoaneInControlListbox(List<Persoana> persoane)
        {
            lstAfisare.Items.Clear();

            foreach (Persoana s in persoane)
            {

                lstAfisare.Items.Add(s);
                
            }
        }
        private void AdaugaPersoaneInControlDataGridView(List<Persoana> persoane)
        {
            
            dataGridPersoane.DataSource = null;

            dataGridPersoane.DataSource = persoane.Select(s => new { s.IdPersoana, s.Nume, s.Prenume, s.NrDeTelefon,s.Email,s.Grupul, Social = string.Join(",", s.Social), s.DataNastere, s.DataActualizare }).ToList();
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
    }
}
