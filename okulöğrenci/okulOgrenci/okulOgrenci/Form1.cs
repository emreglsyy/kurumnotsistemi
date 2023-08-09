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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbListeDoldur();
        }
        void cmbListeDoldur()
        {
            foreach (var item in okulDatabase.okulTablo)
            {
                cmbKurumAdi.Items.Add(item);
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cmbKurumAdi.Text == "Ege Üniversitesi")
            {
                EgekurumOzel newForm = new EgekurumOzel();
                newForm.ShowDialog();


            }

        }


    }
}
