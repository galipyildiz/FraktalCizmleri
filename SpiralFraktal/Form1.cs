using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiralFraktal
{
    public partial class Form1 : Form
    {
        int pay=1;
        int adet=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCizimAlani_Paint(object sender, PaintEventArgs e)
        {
            Temizle(e.Graphics);
            //e.Graphics.DrawArc(Pens.Black, 200, 200, 100, 100,0,90);//0 dereceden başla 90 derece kadar çiz
            SpiralCiz(e.Graphics, 0, 0, pnlCizimAlani.Height,adet);
        }
        public void SpiralCiz(Graphics g,int x,int y,int cap,int adet)
        {
            if (adet < 1 || cap <= 1 || pay >= cap)
            {
                return;
            }
            Rectangle rct = new Rectangle(x, y, cap, cap);
            Rectangle rct2 = new Rectangle(x+(pay/2), y, cap - pay , cap - pay);
            g.DrawArc(Pens.Black, rct, 90.0f, 180.0f);
            g.DrawArc(Pens.Red, rct2, 270.0f, 180.0f);
            SpiralCiz(g, x + pay, y + pay, cap - (pay * 2), adet - 1);
        }

        private void tbaPay_Scroll(object sender, EventArgs e)
        {
            pay = tbaPay.Value;
            label1.Text = "Pay: " + tbaPay.Value.ToString();
            pnlCizimAlani.Refresh();
        }
        private static void Temizle(Graphics g)
        {
            g.Clear(Color.White);
        }

        private void tbaAdet_Scroll(object sender, EventArgs e)
        {
            adet = tbaAdet.Value;
            label2.Text = "Adet: " + tbaAdet.Value.ToString();
            pnlCizimAlani.Refresh();
        }
    }
}
