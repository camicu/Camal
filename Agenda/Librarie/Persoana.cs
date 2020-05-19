using System;
using System.Collections.Generic;

namespace Librarie
{
	[Serializable]
	public class Persoana
	{
		//constante
		private const string SEPARATOR_AFISARE = " ";
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';
		private const char SEPARATOR_SECUNDAR_FISIER = ' ';
		//lista de parametrii
		public static int IdUltimaPersoana { get; set; } = 0;
		public int IdPersoana { get; set; }
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public int NrDeTelefon { get; set; }
		public string Email { get; set; }
		public List<string> Social { get; set; }
		public DateTime DataNastere { get; set; }
		public DateTime DataActualizare { get; set; }
		public Grup Grupul { get; set; }
		public string Salvare { get; set; }

		//Constructor fara parametrii
		public Persoana()
		{
			Nume = string.Empty;
			Prenume = string.Empty;
			NrDeTelefon = 0;
		}
		//Constructor cu parametrii
		public Persoana(string _nume, string _prenume)
		{
			Nume = _nume;
			Prenume = _prenume;
		
		}
		public Persoana(string _nume, string _prenume, string _email)
		{
			Nume = _nume;
			Prenume = _prenume;
			Email = _email;
		}
		public Persoana(string linieFisier)
		{
			var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

			//ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
			IdPersoana = Convert.ToInt32(dateFisier[(int)CampuriPersoana.ID]);
			Nume = dateFisier[(int)CampuriPersoana.NUME];
			Prenume = dateFisier[(int)CampuriPersoana.PRENUME];
			Email = dateFisier[(int)CampuriPersoana.EMAIL];
			NrDeTelefon = Int32.Parse(dateFisier[(int)CampuriPersoana.NR_TELEFON]);
			Grupul = (Grup)Enum.Parse(typeof(Grup), dateFisier[(int)CampuriPersoana.GRUP]);
			Social = new List<string>();
			//adauga mai multe elemente in lista de discipline
			Social.AddRange(dateFisier[(int)CampuriPersoana.SOCIAL].Split(SEPARATOR_SECUNDAR_FISIER));
			Salvare =dateFisier[(int)CampuriPersoana.SALVARE];
		}
		public string SocialeaString
		{
			get
			{
				string sSociale = string.Empty;

				foreach (string social in Social)
				{
					if (sSociale != string.Empty)
					{
						sSociale += SEPARATOR_SECUNDAR_FISIER;
					}
					sSociale += social;
				}

				return sSociale;
			}
		}
		public string ConversieLaSir_PentruFisier()
		{
			
			string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
				SEPARATOR_PRINCIPAL_FISIER, IdPersoana.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (Email ?? " NECUNOSCUT "), NrDeTelefon, Grupul, SocialeaString, Salvare, DataNastere, DataActualizare);

			return s;
		}
		public string ConversieLaSir()
		{

			string sir = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
				SEPARATOR_PRINCIPAL_FISIER, IdPersoana.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "),  (Email ?? " NECUNOSCUT "), NrDeTelefon,Grupul, SocialeaString, Salvare, DataNastere, DataActualizare);

			return sir;
		}

		public override string ToString()
		{
			return ConversieLaSir_PentruFisier();
		}
	}
}


