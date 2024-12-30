using System.Security.Cryptography;
using System.IO;

namespace Sifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kadi;
        StreamWriter dosya;
        StreamWriter dosya2;
        int sayac = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen kullanýcý adýný giriniz!");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen þifrenizi giriniz!");
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen þifrenizi tekrar giriniz!");
                return;
            }
            kadi = textBox1.Text;
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Þifreler uyuþmamaktadýr");
                return;
            }

            if (kadi == "ismail" && textBox2.Text == "12345" && textBox2.Text == textBox3.Text)
            {
                dosya = File.AppendText("dogru.txt");
                dosya.WriteLine("Kullanýcý adi: " + textBox1.Text+" " + "Sifre: " + textBox2.Text + " " + DateTime.Now);
                dosya.Close();
                MessageBox.Show("Bilgiler Baþarýyla kaydedildi");

            }
            else
            {
                dosya2 = File.AppendText("yanlis.txt");
                dosya2.WriteLine("Kullanýcý adi: " + textBox1.Text+" " + "Sifre: " + textBox2.Text + " " + DateTime.Now);
                dosya2.Close();
                sayac = sayac - 1;
                MessageBox.Show("Yanlýþ kullanýcý adý veya þifre kalan hakkýnýz : " + sayac);
            }
            if (sayac == 0)
            {
                Application.Exit();
            }
        }
    }
}
