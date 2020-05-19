using Librarie;
using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.IO;
namespace Agenda
{
    class Program
    {
        public const Grup GRUP = Grup.Necunoscut;
        static void Main(string[] args)
        {
            Persoana[] persoane;
            IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
            int nrPersoane;
           persoane = adminPersoane.GetPersoane(out nrPersoane);
            Persoana.IdUltimaPersoana = nrPersoane;
            bool ok = true;
            string opt;
            while (ok)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n------------------------------------------------------\n");
                Console.WriteLine("1) Adaugati un contact in agenda\n");
                Console.WriteLine("2) Afisati agenda\n");
                Console.WriteLine("3) Comparati doua persoane dupa nume si prenume\n");
                Console.WriteLine("4) Adaugare din tastarura cu functie string\n");
                Console.WriteLine("5) Modificati o persoana din agenda\n");
                Console.WriteLine("6) Iesire din meniu\n");
                Console.Write("\r\nAlegeti o optiune: ");

                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        {
                            Persoana s = new Persoana();
                            s = CitireTastatura();
                            persoane[nrPersoane] = s;
                            nrPersoane++;
                            adminPersoane.AddPersoana(s);
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            AfisarePersoane(persoane, nrPersoane);

                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            int id1;
                            int id2;
                            Console.WriteLine("Dati id-ul primei persoane care doreste a fi comparata");
                            id1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Dati id-ul celei de a doua persoana care doreste a fi comparata");
                            id2 = Int32.Parse(Console.ReadLine());

                            if (!IsEqualNumeComplet(persoane[id1], persoane[id2]))
                            {
                                Console.WriteLine("Numele si prenumele nu sunt egale!!\n");
                            }
                            else
                            {
                                Console.WriteLine("Numele si prenumelesunt egale!!\n");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Dati datele unei persoane, is formatul: nume; prenume; data nasterii; nr telefon; email\n");
                            Persoana s = new Persoana(Console.ReadLine());
                            Console.WriteLine("{0}\n", s.ConversieLaSir());
                            persoane[nrPersoane] = s;
                            nrPersoane++;
                            adminPersoane.AddPersoana(s);
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                        {
                            string _nume;
                            Console.WriteLine("Dati numele persoanei pe care o doriti sa se modifice:");
                            _nume = Console.ReadLine();

                            int id = CautPersoana(_nume, nrPersoane, persoane);
                            if (id != -1)
                            {
                                Persoana s = persoane[id];
                                ModificaPersoana(s, id);
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Se inchide programul");
                            ok = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Introduceti alta optiune:...");
                            Console.ReadKey();
                            break;
                        }

                }
            }

        }
        public static Persoana CitireTastatura()
        {
            Grup grup;
            Console.WriteLine("Introduceti numele persoanei:");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele persoanei:");
            string prenume = Console.ReadLine();
            Console.WriteLine("Introduceti nr de telefon:");
            int nr = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti email-ul persoanei:");
            string email = Console.ReadLine();
            Console.WriteLine("Introduceti data de nastere a persoanei:");
            string data = Console.ReadLine();
            Console.WriteLine("Selectati grupul in care apartile:...\n");
            Console.WriteLine("1) Prieteni\n");
            Console.WriteLine("2) Familie\n");
            Console.WriteLine("3) Serviciu\n");
            string grup1 = Console.ReadLine();
            Enum.TryParse(grup1, out grup);
            Persoana m = new Persoana(nume, prenume, nr, email);
            return m;

        }
        public static Persoana ModificaPersoana(Persoana a, int id)
        {
            Console.WriteLine("Selectati ce doriti sa modificati:\n");
            Console.WriteLine("1) Nume\n");
            Console.WriteLine("2) Prenume\n");
            Console.WriteLine("3) Email\n");
            Console.WriteLine("4) Data nasterii\n");
            Console.WriteLine("5) Nr Telefon\n");
            Console.WriteLine("6) Grupul\n");
            string optiune = Console.ReadLine();
            switch (optiune)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Dati numele nou:...");
                        string NUME = Console.ReadLine();
                        ModificaPersoana(id, 0, NUME);
                        a.Nume = NUME;
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Dati prenumele nou:...");
                        string PRENUME = Console.ReadLine();
                        ModificaPersoana(id, 1, PRENUME);
                        a.Prenume = PRENUME;
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Dati email-ul nou:...");
                        string EMAIL = Console.ReadLine();
                        ModificaPersoana(id, 2, EMAIL);
                        a.Email = EMAIL;
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Dati data de nastere noua:...");
                        string DATA = Console.ReadLine();
                        ModificaPersoana(id, 3, DATA);
                        //a.DataDeNastere = DATA;
                        Console.ReadKey();
                        break;
                    }
                case "5":
                    {
                        Console.Clear();
                        Console.WriteLine("Dati numarul de telefon nou:...");
                        string NR = Console.ReadLine();
                        a.NrDeTelefon = Int32.Parse(Console.ReadLine());
                        ModificaPersoana(id, 4, NR);
                        Console.ReadKey();
                        break;
                    }
                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine("Selectati grupul nou:\n");
                        Console.WriteLine("1) Prieteni\n");
                        Console.WriteLine("2) Familie\n");
                        Console.WriteLine("3) Serviciu\n");
                        string grup1 = Console.ReadLine();

                        if (grup1 == "1\n")
                        {
                            grup1 = "Prieteni";
                            a.Grupul = Grup.Prieteni;
                        }
                        if (grup1 == "2\n")
                        {
                            grup1 = "Familie\n";
                            a.Grupul = Grup.Familie;
                        }
                        if (grup1 == "3\n")
                        {
                            grup1 = "Serviciu";
                            a.Grupul = Grup.Serviciu;
                        }
                        if (grup1 != "1" && grup1 != "2" && grup1 != "3")
                        {
                            grup1 = "Necunoscut";
                            a.Grupul = Grup.Necunoscut;
                        }

                        ModificaPersoana(id, 5, grup1);
                        Console.ReadKey();
                        break;
                    }
            }

            return a;
        }
        public static void ModificaPersoana(int id, int id1, string n)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\NewUsername\source\repos\camicu\PIU\Agenda\Agenda\bin\Debug\netcoreapp3.1\Persoane.txt");
            List<string> newlines = new List<string>();
            int i = 0;
            foreach (string line in lines)
            {
                string[] temp = line.Split(';');
                if (i == id)
                {
                    if (id1 == 1)
                    {
                        newlines.Add(temp[0] + ";" + n + ";" + temp[2] + ";" + temp[3] + ";" + temp[4] + ";" + temp[5]);
                    }
                    else
                    {
                        if (id1 == 0)
                        {
                            newlines.Add(n + ";" + temp[1] + ";" + temp[2] + ";" + temp[3] + ";" + temp[4] + ";" + temp[5]);
                        }
                        else
                        {
                            if (id1 == 2)
                            {
                                newlines.Add(temp[0] + ";" + temp[1] + ";" + n + ";" + temp[3] + ";" + temp[4] + ";" + temp[5]);
                            }
                            else
                            {
                                if (id1 == 3)
                                {
                                    newlines.Add(temp[0] + ";" + temp[1] + ";" + temp[2] + ";" + n + ";" + temp[4] + ";" + temp[5]);
                                }
                                else
                                {
                                    if (id1 == 4)
                                    {
                                        newlines.Add(temp[0] + ";" + temp[1] + ";" + temp[2] + ";" + temp[3] + ";" + n + ";" + temp[5]);
                                    }
                                    else
                                    {
                                        if (id1 == 5)
                                        {
                                            newlines.Add(temp[0] + ";" + temp[1] + ";" + temp[2] + ";" + temp[3] + ";" + temp[4] + ";" + n);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    newlines.Add(temp[0] + ";" + temp[1] + ";" + temp[2] + ";" + temp[3] + ";" + temp[4] + ";" + temp[5]);

                }

                i++;
            }
            File.WriteAllLines(@"C:\Users\NewUsername\source\repos\camicu\PIU\Agenda\Agenda\bin\Debug\netcoreapp3.1\Persoane.txt", newlines.ToArray());
        }
        public static int CautPersoana(string nume, int nrPersoane, Persoana[] sir_persoane)
        {
            for (int i = 0; i < nrPersoane; i++)
            {
                if ((string.Equals(nume, sir_persoane[i].Nume)))
                {

                    return i;
                }
            }
            return -1;
        }

        public static void AfisarePersoane(Persoana[] persoane, int nrPersoane)
        {
            Console.WriteLine("Agenda este:...\n");
            for (int i = 0; i < nrPersoane; i++)
            {
                Console.WriteLine("\nPersonele sunt:\n{0}", persoane[i].ConversieLaSir());
            }
        }
        public static bool IsEqualNumeComplet(Persoana a, Persoana b)
        {
            if ((a.Nume == b.Nume) && (a.Prenume == b.Prenume))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
