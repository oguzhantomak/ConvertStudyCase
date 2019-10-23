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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnFarkBoluToplam_Click(object sender, EventArgs e)
        {

            //Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            string s1 = txt1.Text;
            string s2 = txt2.Text;


            //Burada direkt double dönüşümü yapabiliriz. Bir sorgu içinde birden fazla dönüşüm yapmak sağlıklı değil. Ama basit örnek olduğu için anlaşılması için önce int'e çevirdik.
            int toplam = Convert.ToInt32(s1) + Convert.ToInt32(s2);
            int fark = Convert.ToInt32(s1) - Convert.ToInt32(s2);


            //Daha sonra ondalıklı ifadeler de olabileceği için bir dönüşüm daha yapıp sonucu double bir değişkene çektik.(Çevirdik)
            double bolum = Convert.ToDouble(fark) /Convert.ToDouble(toplam);

            //Kullanıcıya değeri string fade olarak gösteriyoruz.
            MessageBox.Show(bolum.ToString());
            txt1.Clear();
            txt2.Clear();

        }

        private void BtnIslem2_Click(object sender, EventArgs e)
        {


            //Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?

            string s1 = txt1.Text;

            int onEksik = ((Convert.ToInt32(s1) - 10 + 20) % 2);
            int kare = onEksik * onEksik;

            MessageBox.Show(onEksik.ToString());
            txt1.Clear();
            txt2.Clear();

        }

        private void BtnKareArtiKareFark_Click(object sender, EventArgs e)
        {


            //Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?

            int s1 = Convert.ToInt32(txt1.Text);
            int s2 = Convert.ToInt32(txt2.Text);

            int kareToplam = (s1 * s1) + (s2 * s2);
            int kareFark = (s1 * s1) - (s2 * s2);
            int kareTopFark = kareToplam + kareFark;

            MessageBox.Show(kareTopFark.ToString());
            txt1.Clear();
            txt2.Clear();
        }

        private void BtnNotHesapla_Click(object sender, EventArgs e)
        {

            //Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?

            double vize = Convert.ToDouble(txt1.Text);
            double final = Convert.ToDouble(txt2.Text);
            double ortalama = (vize * 0.30) + (final * 0.70);

            MessageBox.Show(ortalama.ToString());
            txt1.Clear();
            txt2.Clear();
        }

        private void BtnMailOlustur_Click(object sender, EventArgs e)
        {

            // Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.

            string ad = txt1.Text;
            string soyad = txt2.Text;

            string mail = ad + "." + soyad + "@hotmail.com";

            MessageBox.Show("Mal Adresiniz : "+mail);
            txt1.Clear();
            txt2.Clear();
        }

       
    }
}
