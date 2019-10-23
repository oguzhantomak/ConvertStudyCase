using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatorler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = 10;
            int sayi2 = 15;
            int sonuc = sayi1 + sayi2;
            MessageBox.Show("Toplama sonucu :  " + sonuc );
            
        }

        private void BtnCikart_Click(object sender, EventArgs e)
        {
            int sayi1 = 100;
            int sayi2 = 25;
            int sonuc = sayi1 - sayi2;
            MessageBox.Show("Çıkartma Sonucu : " + sonuc );
        }

        private void BtnCarpma_Click(object sender, EventArgs e)
        {
            long sayi1 = 100;
            long sayi2 = 25;
            long sonuc = sayi1 * sayi2;

            MessageBox.Show("Çarpma sonucu : " + sonuc);
        }

        private void BtnBolme_Click(object sender, EventArgs e)
        {
            double sayi1 = 100;
            double sayi2 = 25;
            double sonuc = sayi1 / sayi2;
            MessageBox.Show("Bölme İşlemi Sonucu : " +sonuc);
        }

        private void BtnModAlma_Click(object sender, EventArgs e)
        {
            int sayi1 = 100;
            int sayi2 = 25;
            int kalan = sayi1 % sayi2;

            MessageBox.Show("Mod sonucu : " +kalan);
        }
    }
}
