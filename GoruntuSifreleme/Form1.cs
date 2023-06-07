using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuSifreleme
{
    public partial class Form1 : Form
    {
        int anahtar = 123;
        public Form1()
        {
            InitializeComponent();
        }

        private void pct_orijinalGoruntu_Click(object sender, EventArgs e)
        {
            OpenFileDialog secici = new OpenFileDialog();
            secici.Filter = "Jpeg Dosyası |*.jpg;*.jpeg";

            if (secici.ShowDialog() == DialogResult.OK)
            {
                pct_orijinalGoruntu.ImageLocation = secici.FileName;
            }
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            if (pct_orijinalGoruntu.Image == null) return;

            sifrele();
        }

        private void btn_desifrele_Click(object sender, EventArgs e)
        {
            if (pct_sonucGoruntu.Image == null) return;

            desifrele();
        }

        private void sifrele()
        {
            Bitmap orijinalGoruntu = (Bitmap)pct_orijinalGoruntu.Image;

            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color orijinalPiksel = orijinalGoruntu.GetPixel(x, y);

                    int r = (orijinalPiksel.R + x) % 256;
                    int g = (orijinalPiksel.G + y) % 256;
                    int b = (orijinalPiksel.B + x + y) % 256;

                    Color sonucPiksel = Color.FromArgb(r, g, b);

                    sonucGoruntu.SetPixel(x, y, sonucPiksel);
                }
            }

            pct_sonucGoruntu.Image = sonucGoruntu;
        }

        private void desifrele()
        {
            Bitmap sifreliGoruntu = (Bitmap)pct_sonucGoruntu.Image;

            int genislik = sifreliGoruntu.Width;
            int yukseklik = sifreliGoruntu.Height;

            Bitmap orijinalGoruntu = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                   Color sifreliPiksel = sifreliGoruntu.GetPixel(x, y);

                    int r = (sifreliPiksel.R - x + 256) % 256;
                    int g = (sifreliPiksel.G - y + 256) % 256;
                    int b = (sifreliPiksel.B - x - y + 256) % 256;

                    Color orijinalPiksel = Color.FromArgb(r, g, b);

                    orijinalGoruntu.SetPixel(x, y, orijinalPiksel); 
                }
            }

            pct_sonucGoruntu.Image = orijinalGoruntu;
        }

    }
}
