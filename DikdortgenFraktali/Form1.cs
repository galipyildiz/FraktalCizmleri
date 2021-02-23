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

namespace FraktalCizimleriYigitHoca
{
    public partial class Form1 : Form
    {
        int pay;
        int adet;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizimAlani_Paint(object sender, PaintEventArgs e)
        {
            Temizle(e.Graphics);
            DikdortgenlerCiz(e.Graphics, 0, 0, pnlCizimAlani.Width, pnlCizimAlani.Height, adet);
        }

        public void DikdortgenCiz(Graphics g, int x, int y, int genislik, int yukselik)
        {
            Pen pen = new Pen(Color.FromArgb(255, rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255)), 1.0f);
            g.DrawRectangle(pen, x, y, genislik, yukselik);
        }
        public void DikdortgenlerCiz(Graphics g, int x, int y, int width, int height,int adet)
        {
            if (adet < 1 || width < 1)
            {
                return;
            }
            DikdortgenCiz(g, x, y, width, height);
            DikdortgenlerCiz(g, x + pay, y + pay, width - (2 * pay), height - (2 * pay), adet - 1);
        }

        private void tbaPay_Scroll(object sender, EventArgs e)
        {
            pay = tbaPay.Value;
            pnlCizimAlani.Refresh();
        }

        private static void Temizle(Graphics g)
        {
            g.Clear(Color.White);
        }

        private void tbaAdet_Scroll(object sender, EventArgs e)
        {
            adet = tbaAdet.Value;
            pnlCizimAlani.Refresh();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image(*.jpeg) | *.jpeg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pnlCizimAlani.Width, pnlCizimAlani.Height);
                pnlCizimAlani.DrawToBitmap(bmp, new Rectangle(0, 0, pnlCizimAlani.Width, pnlCizimAlani.Height));
                bmp.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
