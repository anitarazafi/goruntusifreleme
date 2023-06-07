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

        private List<List<Point>> rows = new List<List<Point>>();

        private void sifrele()
        {
            Bitmap orijinalGoruntu = (Bitmap)pct_orijinalGoruntu.Image;

            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);

            Random random = new Random();

            for (int y = 0; y < yukseklik; y++)
            {
                List<Point> row = new List<Point>();

                for (int x = 0; x < genislik; x++)
                {
                   Color orijinalPiksel = orijinalGoruntu.GetPixel(x, y);

                    Point yeniPozisyon;

                    do
                    {
                        int yeniX = random.Next(genislik);
                        int yeniY = random.Next(yukseklik);

                        yeniPozisyon = new Point(yeniX, yeniY);
                    } while (row.Contains(yeniPozisyon));

                    row.Add(yeniPozisyon);
                    sonucGoruntu.SetPixel(yeniPozisyon.X, yeniPozisyon.Y, orijinalPiksel);
                }

                rows.Add(row);
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
                   Point sifreliPoint = rows[y][x];

                    Color sifreliPiksel = sifreliGoruntu.GetPixel(sifreliPoint.X, sifreliPoint.Y);

                    orijinalGoruntu.SetPixel(x, y, sifreliPiksel);
                }
            }

            pct_sonucGoruntu.Image = orijinalGoruntu;
        }

    }
}
