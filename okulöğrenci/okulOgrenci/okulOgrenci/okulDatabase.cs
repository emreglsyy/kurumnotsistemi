using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulOgrenci
{
    internal class okulDatabase
    {
        public static List<okulListe> okulTablo = new List<okulListe>()
        {

            new okulListe()
            {
                okulAdi="Ege Üniversitesi"
            },
            new okulListe()
            {
                okulAdi="Dokuz Eylül Üniversitesi"
            },
            new okulListe()
            {
                okulAdi="Yaşar Üniversitesi"
            }
        };
    }
}
