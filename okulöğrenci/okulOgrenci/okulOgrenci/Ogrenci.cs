using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulOgrenci
{
    public class Ogrenci
    {
        public string kurumAdi { get; set; }
        public string ogrenciResim { get; set; }
        public int id { get; set; }
        public string ogrenciAdSoyad { get; set; }
        public int ogrenciNumara { get; set; }

        public override string ToString()
        {
            return ogrenciAdSoyad;

        }



    }
}
