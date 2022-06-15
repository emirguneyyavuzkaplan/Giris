using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> araclar = new List<string>();
            araclar.Add("Tofas");
            araclar.Add("Bmw");
            araclar.Add("Mercedes");
            araclar.Add("Subaru");

            foreach (var araba in araclar)
            {
                listBox1.Items.Add(araba);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Rastgele 50 sayi olusturunuz.
            // Tek sayilari listbox1'e 
            // Cift Sayilari listbox2'ye 
            // hem 3 hemde 5 bolunenleride ayri bir
            // listeye atiniz.
            Random rnd = new Random();
            int sayi = 0;
            for (int i = 0; i < 50; i++)
            {
                sayi = rnd.Next(100);
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);

                }
                if (sayi % 15 == 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int elemanSayisi = int.Parse(deger);
            int[] sayilar = new int[elemanSayisi];
            Random rnd = new Random();
            int[] frekans = new int[11];
            // Girilen eleman sayisi kadar 1-10
            // arasinda sayi uretisin.
            for (int i = 0; i < elemanSayisi; i++)
            {
                sayilar[i] = rnd.Next(11);
            }

            // Olusturulan dizideki sayilarin
            // frekansi nedir ? (Tekrar Sayisi)

            for (int i = 0; i < elemanSayisi; i++)
            {
                switch (sayilar[i])
                {
                    case 0:
                        frekans[0]++;
                        break;
                    case 1:
                        frekans[1]++;
                        break;
                    case 2:
                        frekans[2]++;
                        break;
                    case 3:
                        frekans[3]++;
                        break;
                    case 4:
                        frekans[4]++;
                        break;
                    case 5:
                        frekans[5]++;
                        break;
                    case 6:
                        frekans[6]++;
                        break;
                    case 7:
                        frekans[7]++;
                        break;
                    case 8:
                        frekans[8]++;
                        break;
                    case 9:
                        frekans[9]++;

                        break;
                    case 10:
                        frekans[10]++;
                        break;

                }
            }
            // Sonuclari Listbox'a yaziniz.

            for (int i = 0; i < frekans.Length; i++)
            {
                listBox1.Items.Add(i + " =>" + frekans[i]);
            }

            //1-Random Degerler atayin

            //2- Frekans heabi yapilacak

            //3-ListBox'a eklenecek 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Icerigine sizin karar vereceginiz bir sayisal
            // dizi olusturun ve bu dizinin en kucuk - en buyuk
            // elemanýný MessageBox'la gosterin..
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100);
                listBox1.Items.Add(sayilar[i]);
            }
            int enKucuk = sayilar[0], enBuyuk = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (enKucuk > sayilar[i])
                {
                    enKucuk = sayilar[i];
                }
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk = sayilar[i];
                }
            }
            listBox2.Items.Add("En Kucuk:" + enKucuk);
            listBox2.Items.Add("En Buyuk:" + enBuyuk);

        }
    }
}