using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgacFraktal
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int dalArasiAci = 45;
        int iterasyon = 10;
        int sapmaAci = 30; // -180-+180
        float kisalmaOrani = 0.60f;//0-1 arasi değer
        int dalUzunluk = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizimAlani_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            AgacCiz(e.Graphics, pnlCizimAlani.Width / 2, pnlCizimAlani.Height, pnlCizimAlani.Height / 2);
        }
        public void ikiDalCiz(Graphics g, float x1, float y1, int aci, float uzunluk, int tekrar)
        {
            if (tekrar < 1 || uzunluk < 1)
            {
                return;
            }
            var renk = RenkHesapla(tekrar);
            var bitis1 = CizgiCizAciile(g, x1, y1, aci, uzunluk,renk);
            var bitis2 = CizgiCizAciile(g, x1, y1, aci + dalArasiAci, uzunluk,renk);
            ikiDalCiz(g, bitis1[0], bitis1[1], aci - sapmaAci, uzunluk * kisalmaOrani, tekrar - 1);
            ikiDalCiz(g, bitis2[0], bitis2[1], aci + sapmaAci, uzunluk * kisalmaOrani, tekrar - 1);
        }
        public void AgacCiz(Graphics g, float x1, float y1, int govdeUzunluk)
        {
            float x2 = x1;
            float y2 = y1 - govdeUzunluk;
            float[] renk = { 255, 0, 0 };
            CizgiCiz(g, x1, y1, x2, y2,renk);
            ikiDalCiz(g, x2, y2, (180 - dalArasiAci) / 2, dalUzunluk, iterasyon);
        }
        //p başlangıç noktası, aci yatay eksenle yaptığı açı, uzunluk çizgi uzunluğu
        public float[] CizgiCizAciile(Graphics g, float xBaslangic, float yBaslangic, double aci, float uzunluk,float[] renk)
        {
            var radyan = aci / 180 * Math.PI;
            float xBitis = xBaslangic + (float)Math.Cos(radyan) * uzunluk;
            float yBitis = yBaslangic - (float)Math.Sin(radyan) * uzunluk;
            float[] bitisler = { xBitis, yBitis };
            CizgiCiz(g, xBaslangic, yBaslangic, xBitis, yBitis,renk);
            return bitisler;
        }
        public void CizgiCiz(Graphics g, float x1, float y1, float x2, float y2,float[] renk)
        {
            Pen pen = new Pen(Color.FromArgb((int)renk[0], (int)renk[1], (int)renk[2]),iterasyon/2);
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private float[] RenkHesapla(int adet)
        {
            var oran = adet / iterasyon;
            var toran = 1 - oran;
            var r = 255 * oran;
            var g = 122;
            var b = 55 * toran;
            var a = 1 - toran * .1;
            float[] renkler = { r, g, b, (float)a };
            return renkler;
        }

        private void tbaDalArasiAci_Scroll(object sender, EventArgs e)
        {
            dalArasiAci = tbaDalArasiAci.Value;
            pnlCizimAlani.Refresh();
        }

        private void tbaIterasyon_Scroll(object sender, EventArgs e)
        {
            iterasyon = tbaIterasyon.Value;
            pnlCizimAlani.Refresh();
        }

        private void tbaSapmaAci_Scroll(object sender, EventArgs e)
        {
            sapmaAci = tbaSapmaAci.Value;
            pnlCizimAlani.Refresh();
        }

        private void tbaDalUzunluk_Scroll(object sender, EventArgs e)
        {
            dalUzunluk = tbaDalUzunluk.Value;
            pnlCizimAlani.Refresh();
        }
    }
}
