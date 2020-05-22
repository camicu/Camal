using Librarie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace NivelAccesDate
{
    public class AdministrarePersoane_FisierBinar : IStocareData
    {
        private const int ID_PRIMA_PERSOANA = 1;
        private const int INCREMENT = 1;
        string NumeFisier { get; set; }
        public AdministrarePersoane_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();
        }
        public Persoana[] GetPersoane(out int nrPersoane)
        {
            throw new Exception("Optiunea GetPersoane nu este implementata");
        }
        public List<Persoana> GetPersoane()
        {
            List<Persoana> persoane = new List<Persoana>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        persoane.Add((Persoana)b.Deserialize(sBinFile));
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
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    b.Serialize(sBinFile, s);
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

        public Persoana GetPersoanaByIndex(int index)
        {
            Persoana s = null;
            List<Persoana> persoane = new List<Persoana>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        s = (Persoana)b.Deserialize(sBinFile);
                        persoane.Add((Persoana)b.Deserialize(sBinFile));
                        if (s.IdPersoana == index)
                            break;
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

            return s;
        }


        public Persoana GetPersoana(string nume, string prenume)
        {
            Persoana s = null;
            List<Persoana> persoane = new List<Persoana>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        s = (Persoana)b.Deserialize(sBinFile);
                        persoane.Add((Persoana)b.Deserialize(sBinFile));
                        if (s.Nume == nume & s.Prenume == prenume)
                        {
                            break;
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

            return s;
        }
       
        public bool UpdatePersoana(Persoana s)
        {
            bool ok = false;
            List<Persoana> persoane = GetPersoane();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Truncate, FileAccess.Write))
                {
                    foreach (var pers in persoane)
                    {
                        if (pers.IdPersoana == s.IdPersoana)
                        {
                            b.Serialize(sBinFile, s);
                        }
                        else
                            b.Serialize(sBinFile, pers);
                    }
                    ok = true;

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
            return ok;
        }
        private int GetId()
        {


            int IdPersoana = ID_PRIMA_PERSOANA;
            try
            {
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        Persoana s = (Persoana)b.Deserialize(sBinFile);
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
