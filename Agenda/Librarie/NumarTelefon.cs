using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public static class NumarTelefon
    {
        public const int NUMAR_MINIM = 700000000;
        public const int NUMAR_MAXIM = 799999999;

        public static bool ValideazaNumarul(int numar)
        {
            if (numar >= NUMAR_MINIM && numar <= NUMAR_MAXIM)
                return true;
            return false;
        }
    }
}