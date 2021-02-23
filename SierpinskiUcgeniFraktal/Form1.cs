using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SierpinskiUcgeniFraktal
{
    public partial class Form1 : Form
    {
        int adet;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizimAlani_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            SierpinskiCiz(e.Graphics, 0, 0, pnlCizimAlani.Height, adet);
        }
        public void SierpinskiCiz(Graphics g, int x, int y, int genislik, int adet)
        {
            if (adet < 1)
            {
                return;
            }
            var yukseklik = UcgenGiz(g, x, y, genislik);
            SierpinskiCiz(g, x + (genislik / 4), y, genislik / 2, adet - 1);
            SierpinskiCiz(g, x, y + ((int)yukseklik / 2), genislik / 2, adet - 1);
            SierpinskiCiz(g, x + (genislik / 2), y + ((int)yukseklik / 2), genislik / 2, adet - 1);
        }
        public double UcgenGiz(Graphics g, int x, int y, int genislik)
        {
            var yukseklik = genislik / 2 * Math.Sqrt(3);
            Point p1 = new Point(x, y + (int)yukseklik);
            Point p2 = new Point(x + genislik, y + (int)yukseklik);
            Point p3 = new Point(x + genislik / 2, y);
            CizgiCiz(g, p1, p2);
            CizgiCiz(g, p2, p3);
            CizgiCiz(g, p3, p1);
            return yukseklik;
        }
        public void CizgiCiz(Graphics g, Point p1, Point p2)
        {
            Pen pen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
            g.DrawLine(pen, p1, p2);
        }

        private void tbaAdet_Scroll(object sender, EventArgs e)
        {
            adet = tbaAdet.Value;
            pnlCizimAlani.Refresh();
        }
    }
}
