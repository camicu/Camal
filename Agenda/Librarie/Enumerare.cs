using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{

    public enum Grup
    {
        Prieteni = 1,
        Familie = 2,
        Serviciu = 3,
        Necunoscut = 4,
    };
    public enum CampuriPersoana
    {
        ID = 0,
        NUME = 1,
        PRENUME = 2,
        EMAIL=3,
        NR_TELEFON=4,
        GRUP = 5,
        SOCIAL = 6,
        SALVARE=7,
        DATA_NASTERE=8,
        DATA_ACTUALIZARE=9
    };

}
