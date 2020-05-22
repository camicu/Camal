 using Librarie;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public class AdministrarePersoane_FisierText : IStocareData
    {
        private const int ID_PRIMA_PERSOANA = 1;
        private const int INCREMENT = 1;
        private const int PAS_ALOCARE = 10;

        string NumeFisier { get; set; }
        public AdministrarePersoane_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public Persoana[] GetPersoane(out int nrPersoane)
        {
            Persoana[] persoane = new Persoana[PAS_ALOCARE];

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrPersoane = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        persoane[nrPersoane++] = new Persoana(line);
                        if (nrPersoane == PAS_ALOCARE)
                        {
                            Array.Resize(ref persoane, nrPersoane + PAS_ALOCARE);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }
        public void AddPersoana(Persoana s)
        {
            s.IdPersoana = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(s.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void GetPersoana(Persoana persoana)
        {

            persoana.IdPersoana = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {

                    swFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public List<Persoana> GetPersoane()
        {
            List<Persoana> persoane = new List<Persoana>();

            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana s = new Persoana(line);
                        persoane.Add(s);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }

        public Persoana GetPersoana(string nume, string prenume)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana persoana = new Persoana(line);
                        if (persoana.Nume.Equals(nume) && persoana.Prenume.Equals(prenume))
                            return persoana;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public Persoana GetPersoanaByIndex(int index)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana persoana = new Persoana(line);
                        if (persoana.IdPersoana == index)
                            return persoana;

                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdatePersoana(Persoana persoanaActualizata)
        {
            List<Persoana> persoane = GetPersoane();
            bool actualizareCuSucces = false;
            try
            {       
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Persoana pers in persoane)
                    {
                        if (pers.IdPersoana != persoanaActualizata.IdPersoana)
                        {
                            swFisierText.WriteLine(pers.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(persoanaActualizata.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdPersoana = ID_PRIMA_PERSOANA;
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;                  
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana s = new Persoana(line);
                        IdPersoana = s.IdPersoana + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdPersoana;


        }
    }
}
