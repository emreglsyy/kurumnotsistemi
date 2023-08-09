using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okulOgrenci
{
    public partial class EgekurumOzel : Form 
    {
        public EgekurumOzel()
        {
            InitializeComponent();
        }

        private void EgekurumOzel_Load(object sender, EventArgs e)
        {
            listboxDoldur();
        }


        void listboxDoldur()
        {
            foreach (var item in ogrenciDatabase.EgeOgrenciTablo)
            {
                OgrenciList.Items.Add(item);

            }
        }

        private void OgrenciList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lbox = (ListBox)sender;
            Ogrenci o1 = (Ogrenci)lbox.SelectedItem;

            pictureBox1.Image = Image.FromFile(o1.ogrenciResim);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;

            txtKurumAdi.Text = o1.kurumAdi;
            txtAdSoyad.Text = o1.ogrenciAdSoyad;
            TxtNumara.Text = o1.ogrenciNumara.ToString();
            
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            double ortalamam=ortalamaHesapla(Convert.ToDouble(txtVize.Text), Convert.ToDouble(txtFinal.Text));
            txtOrtalama.Text = Convert.ToString(ortalamam) ;


        }

        private void btnHarfNot_Click(object sender, EventArgs e)
        {
            //0<not<45 ff kaldı
            //45<not<60 fd geçti
            //60<=not<=75 cc geçti
            //75<not<=100 aa geçti
            double result = ortalamaHesapla(Convert.ToDouble(txtVize.Text), Convert.ToDouble(txtFinal.Text));
            if (result<45)
            {
                MessageBox.Show("Harf Notunuz FF,Kaldınız", "Harf Not", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result > 45 && result < 60)
            {
                MessageBox.Show("Harf Notunuz FD,Kaldınız", "Harf Not", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result >= 60 && result <=75)
            {
                MessageBox.Show("Harf Notunuz CC,Geçtiniz", "Harf Not", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Harf Notunuz AA,Geçtiniz", "Harf Not", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtVize.Clear();
            txtFinal.Clear();
            

        }

        double ortalamaHesapla(double not1,double not2)
        {
            double ortalama=(not1+not2)/2;
            return ortalama;
            
        }
    }
}
