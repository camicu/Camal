using Librarie;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddPersoana(Persoana s);
        List<Persoana> GetPersoane();
        Persoana GetPersoanaByIndex(int index);
        Persoana[] GetPersoane(out int nrPersoane);
        Persoana GetPersoana(string nume, string prenume);
        bool UpdatePersoana(Persoana s);

    }
}
