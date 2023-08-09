using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulOgrenci
{
    internal class ogrenciDatabase
    {
        public static List<Ogrenci> EgeOgrenciTablo = new List<Ogrenci>()
        {

            new Ogrenci()
            {
                ogrenciAdSoyad="Emre Gülsoy",
                id=1,
                kurumAdi="Ege Üniversitesi",
                ogrenciNumara=11111,
                ogrenciResim=@"C:\Users\Monster\Desktop\okulöğrenci\images\ogrenci1.png"

            },
            new Ogrenci()
            {
                ogrenciAdSoyad="Ahmet Ahmet",
                id=2,
                kurumAdi="Ege Üniversitesi",
                ogrenciNumara=22222,
                ogrenciResim=@"C:\Users\Monster\Desktop\okulöğrenci\images\ogrenci2.png"

            },
            new Ogrenci()
            {
                ogrenciAdSoyad="Mehmet Mehmet",
                id=3,
                kurumAdi="Ege Üniversitesi",
                ogrenciNumara=33333,
                ogrenciResim=@"C:\Users\Monster\Desktop\okulöğrenci\images\ogrenci3.png"

            }
        };
        public static List<Ogrenci> DeuOgrenciTablo = new List<Ogrenci>()
        {
            new Ogrenci()
            {
                id=1,
                kurumAdi="Dokuz Eylül Üniversitesi",
                ogrenciAdSoyad="Ayşe Ayşe",
                ogrenciNumara=111111
            },
            new Ogrenci()
            {
                id=2,
                kurumAdi="Dokuz Eylül Üniversitesi",
                ogrenciAdSoyad="Mustafa Mustafa",
                ogrenciNumara=222222
            },
            new Ogrenci()
            {
                id=3,
                kurumAdi="Dokuz Eylül Üniversitesi",
                ogrenciAdSoyad="Caner Caner",
                ogrenciNumara=333333
            }
        };
        public static List<Ogrenci> YasarOgrenciTablo = new List<Ogrenci>()
        {
            new Ogrenci()
            {
                id=1,
                kurumAdi="Yaşar Üniversitesi",
                ogrenciAdSoyad="Adem Adem",
                ogrenciNumara=111
            },
            new Ogrenci()
            {
                id=2,
                kurumAdi="Yaşar Üniversitesi",
                ogrenciAdSoyad="Ayşe Ayşe",
                ogrenciNumara=222
            },
            new Ogrenci()
            {
                id=3,
                kurumAdi="Yaşar Üniversitesi",
                ogrenciAdSoyad="Buse Buse",
                ogrenciNumara=333
            }
        };
    }
}
