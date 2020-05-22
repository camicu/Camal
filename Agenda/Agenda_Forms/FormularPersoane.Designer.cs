namespace Agenda_Forms
{
    partial class FormularPersoane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblGrup = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.gpbGrup = new System.Windows.Forms.GroupBox();
            this.rdbServiciu = new System.Windows.Forms.RadioButton();
            this.rdbFamilie = new System.Windows.Forms.RadioButton();
            this.rdbPrieteni = new System.Windows.Forms.RadioButton();
            this.lblSalvare = new System.Windows.Forms.Label();
            this.cmbSalvare = new System.Windows.Forms.ComboBox();
            this.lblSocial = new System.Windows.Forms.Label();
            this.gpbSocial = new System.Windows.Forms.GroupBox();
            this.ckbSnapchat = new System.Windows.Forms.CheckBox();
            this.ckbTikTok = new System.Windows.Forms.CheckBox();
            this.ckbReddit = new System.Windows.Forms.CheckBox();
            this.ckbWhatsApp = new System.Windows.Forms.CheckBox();
            this.ckbInstagram = new System.Windows.Forms.CheckBox();
            this.ckbFacebook = new System.Windows.Forms.CheckBox();
            this.lblDataNastere = new System.Windows.Forms.Label();
            this.dtpDataNastere = new System.Windows.Forms.DateTimePicker();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.dataGridPersoane = new System.Windows.Forms.DataGridView();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNrTelefon = new System.Windows.Forms.Label();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.gpbGrup.SuspendLayout();
            this.gpbSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(60, 45);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(60, 68);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.Location = new System.Drawing.Point(65, 129);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(30, 13);
            this.lblGrup.TabIndex = 2;
            this.lblGrup.Text = "Grup";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(127, 42);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(310, 20);
            this.txtNume.TabIndex = 3;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(127, 65);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(310, 20);
            this.txtPrenume.TabIndex = 4;
            // 
            // gpbGrup
            // 
            this.gpbGrup.Controls.Add(this.rdbServiciu);
            this.gpbGrup.Controls.Add(this.rdbFamilie);
            this.gpbGrup.Controls.Add(this.rdbPrieteni);
            this.gpbGrup.Location = new System.Drawing.Point(127, 118);
            this.gpbGrup.Name = "gpbGrup";
            this.gpbGrup.Size = new System.Drawing.Size(310, 55);
            this.gpbGrup.TabIndex = 5;
            this.gpbGrup.TabStop = false;
            // 
            // rdbServiciu
            // 
            this.rdbServiciu.AutoSize = true;
            this.rdbServiciu.Location = new System.Drawing.Point(197, 11);
            this.rdbServiciu.Name = "rdbServiciu";
            this.rdbServiciu.Size = new System.Drawing.Size(63, 17);
            this.rdbServiciu.TabIndex = 2;
            this.rdbServiciu.TabStop = true;
            this.rdbServiciu.Text = "Serviciu";
            this.rdbServiciu.UseVisualStyleBackColor = true;
            // 
            // rdbFamilie
            // 
            this.rdbFamilie.AutoSize = true;
            this.rdbFamilie.Location = new System.Drawing.Point(102, 11);
            this.rdbFamilie.Name = "rdbFamilie";
            this.rdbFamilie.Size = new System.Drawing.Size(57, 17);
            this.rdbFamilie.TabIndex = 1;
            this.rdbFamilie.TabStop = true;
            this.rdbFamilie.Text = "Familie";
            this.rdbFamilie.UseVisualStyleBackColor = true;
            // 
            // rdbPrieteni
            // 
            this.rdbPrieteni.AutoSize = true;
            this.rdbPrieteni.Location = new System.Drawing.Point(6, 11);
            this.rdbPrieteni.Name = "rdbPrieteni";
            this.rdbPrieteni.Size = new System.Drawing.Size(60, 17);
            this.rdbPrieteni.TabIndex = 0;
            this.rdbPrieteni.TabStop = true;
            this.rdbPrieteni.Text = "Prieteni";
            this.rdbPrieteni.UseVisualStyleBackColor = true;
            // 
            // lblSalvare
            // 
            this.lblSalvare.AutoSize = true;
            this.lblSalvare.Location = new System.Drawing.Point(60, 319);
            this.lblSalvare.Name = "lblSalvare";
            this.lblSalvare.Size = new System.Drawing.Size(43, 13);
            this.lblSalvare.TabIndex = 6;
            this.lblSalvare.Text = "Salvare";
            // 
            // cmbSalvare
            // 
            this.cmbSalvare.FormattingEnabled = true;
            this.cmbSalvare.Items.AddRange(new object[] {
            "Cartela SIM",
            "Telefon",
            "Drive"});
            this.cmbSalvare.Location = new System.Drawing.Point(127, 311);
            this.cmbSalvare.Name = "cmbSalvare";
            this.cmbSalvare.Size = new System.Drawing.Size(310, 21);
            this.cmbSalvare.TabIndex = 7;
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(49, 214);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(68, 13);
            this.lblSocial.TabIndex = 8;
            this.lblSocial.Text = "Social Media";
            // 
            // gpbSocial
            // 
            this.gpbSocial.Controls.Add(this.ckbSnapchat);
            this.gpbSocial.Controls.Add(this.ckbTikTok);
            this.gpbSocial.Controls.Add(this.ckbReddit);
            this.gpbSocial.Controls.Add(this.ckbWhatsApp);
            this.gpbSocial.Controls.Add(this.ckbInstagram);
            this.gpbSocial.Controls.Add(this.ckbFacebook);
            this.gpbSocial.Location = new System.Drawing.Point(127, 205);
            this.gpbSocial.Name = "gpbSocial";
            this.gpbSocial.Size = new System.Drawing.Size(310, 100);
            this.gpbSocial.TabIndex = 9;
            this.gpbSocial.TabStop = false;
            // 
            // ckbSnapchat
            // 
            this.ckbSnapchat.AutoSize = true;
            this.ckbSnapchat.Location = new System.Drawing.Point(188, 55);
            this.ckbSnapchat.Name = "ckbSnapchat";
            this.ckbSnapchat.Size = new System.Drawing.Size(72, 17);
            this.ckbSnapchat.TabIndex = 5;
            this.ckbSnapchat.Text = "Snapchat";
            this.ckbSnapchat.UseVisualStyleBackColor = true;
            this.ckbSnapchat.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // ckbTikTok
            // 
            this.ckbTikTok.AutoSize = true;
            this.ckbTikTok.Location = new System.Drawing.Point(102, 55);
            this.ckbTikTok.Name = "ckbTikTok";
            this.ckbTikTok.Size = new System.Drawing.Size(60, 17);
            this.ckbTikTok.TabIndex = 4;
            this.ckbTikTok.Text = "TikTok";
            this.ckbTikTok.UseVisualStyleBackColor = true;
            this.ckbTikTok.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // ckbReddit
            // 
            this.ckbReddit.AutoSize = true;
            this.ckbReddit.Location = new System.Drawing.Point(15, 55);
            this.ckbReddit.Name = "ckbReddit";
            this.ckbReddit.Size = new System.Drawing.Size(57, 17);
            this.ckbReddit.TabIndex = 3;
            this.ckbReddit.Text = "Reddit";
            this.ckbReddit.UseVisualStyleBackColor = true;
            this.ckbReddit.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // ckbWhatsApp
            // 
            this.ckbWhatsApp.AutoSize = true;
            this.ckbWhatsApp.Location = new System.Drawing.Point(188, 18);
            this.ckbWhatsApp.Name = "ckbWhatsApp";
            this.ckbWhatsApp.Size = new System.Drawing.Size(76, 17);
            this.ckbWhatsApp.TabIndex = 2;
            this.ckbWhatsApp.Text = "WhatsApp";
            this.ckbWhatsApp.UseVisualStyleBackColor = true;
            this.ckbWhatsApp.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // ckbInstagram
            // 
            this.ckbInstagram.AutoSize = true;
            this.ckbInstagram.Location = new System.Drawing.Point(102, 19);
            this.ckbInstagram.Name = "ckbInstagram";
            this.ckbInstagram.Size = new System.Drawing.Size(72, 17);
            this.ckbInstagram.TabIndex = 1;
            this.ckbInstagram.Text = "Instagram";
            this.ckbInstagram.UseVisualStyleBackColor = true;
            this.ckbInstagram.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // ckbFacebook
            // 
            this.ckbFacebook.AutoSize = true;
            this.ckbFacebook.Location = new System.Drawing.Point(15, 18);
            this.ckbFacebook.Name = "ckbFacebook";
            this.ckbFacebook.Size = new System.Drawing.Size(74, 17);
            this.ckbFacebook.TabIndex = 0;
            this.ckbFacebook.Text = "Facebook";
            this.ckbFacebook.UseVisualStyleBackColor = true;
            this.ckbFacebook.CheckedChanged += new System.EventHandler(this.ckbSociale_CheckedChanged);
            // 
            // lblDataNastere
            // 
            this.lblDataNastere.AutoSize = true;
            this.lblDataNastere.Location = new System.Drawing.Point(34, 344);
            this.lblDataNastere.Name = "lblDataNastere";
            this.lblDataNastere.Size = new System.Drawing.Size(83, 13);
            this.lblDataNastere.TabIndex = 10;
            this.lblDataNastere.Text = "Data de nastere";
            // 
            // dtpDataNastere
            // 
            this.dtpDataNastere.Location = new System.Drawing.Point(127, 338);
            this.dtpDataNastere.Name = "dtpDataNastere";
            this.dtpDataNastere.Size = new System.Drawing.Size(201, 20);
            this.dtpDataNastere.TabIndex = 11;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(123, 365);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(140, 23);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(297, 365);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(140, 23);
            this.btnAfiseaza.TabIndex = 13;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(123, 398);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(140, 23);
            this.btnCauta.TabIndex = 14;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(297, 398);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(140, 23);
            this.btnModifica.TabIndex = 15;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // dataGridPersoane
            // 
            this.dataGridPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersoane.Location = new System.Drawing.Point(768, 42);
            this.dataGridPersoane.Name = "dataGridPersoane";
            this.dataGridPersoane.Size = new System.Drawing.Size(402, 346);
            this.dataGridPersoane.TabIndex = 32;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(462, 42);
            this.lstAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(301, 342);
            this.lstAfisare.TabIndex = 33;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 182);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // lblNrTelefon
            // 
            this.lblNrTelefon.AutoSize = true;
            this.lblNrTelefon.Location = new System.Drawing.Point(44, 92);
            this.lblNrTelefon.Name = "lblNrTelefon";
            this.lblNrTelefon.Size = new System.Drawing.Size(77, 13);
            this.lblNrTelefon.TabIndex = 36;
            this.lblNrTelefon.Text = "Numar Telefon";
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Location = new System.Drawing.Point(127, 89);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(310, 20);
            this.txtNrTelefon.TabIndex = 37;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(442, 45);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "Id";
            this.lblID.Visible = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(477, 27);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 39;
            // 
            // FormularPersoane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.lblNrTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.dataGridPersoane);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dtpDataNastere);
            this.Controls.Add(this.lblDataNastere);
            this.Controls.Add(this.gpbSocial);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.cmbSalvare);
            this.Controls.Add(this.lblSalvare);
            this.Controls.Add(this.gpbGrup);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblGrup);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Name = "FormularPersoane";
            this.Text = "Form1";
            this.gpbGrup.ResumeLayout(false);
            this.gpbGrup.PerformLayout();
            this.gpbSocial.ResumeLayout(false);
            this.gpbSocial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblGrup;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.GroupBox gpbGrup;
        private System.Windows.Forms.RadioButton rdbServiciu;
        private System.Windows.Forms.RadioButton rdbFamilie;
        private System.Windows.Forms.RadioButton rdbPrieteni;
        private System.Windows.Forms.Label lblSalvare;
        private System.Windows.Forms.ComboBox cmbSalvare;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.GroupBox gpbSocial;
        private System.Windows.Forms.CheckBox ckbSnapchat;
        private System.Windows.Forms.CheckBox ckbTikTok;
        private System.Windows.Forms.CheckBox ckbReddit;
        private System.Windows.Forms.CheckBox ckbWhatsApp;
        private System.Windows.Forms.CheckBox ckbInstagram;
        private System.Windows.Forms.CheckBox ckbFacebook;
        private System.Windows.Forms.Label lblDataNastere;
        private System.Windows.Forms.DateTimePicker dtpDataNastere;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DataGridView dataGridPersoane;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNrTelefon;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMesaj;
    }
}

