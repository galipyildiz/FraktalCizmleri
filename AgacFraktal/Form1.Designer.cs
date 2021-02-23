
namespace AgacFraktal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCizimAlani = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbaDalArasiAci = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbaIterasyon = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbaSapmaAci = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbaDalUzunluk = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbaDalArasiAci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaIterasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaSapmaAci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaDalUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCizimAlani
            // 
            this.pnlCizimAlani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCizimAlani.Location = new System.Drawing.Point(13, 13);
            this.pnlCizimAlani.Name = "pnlCizimAlani";
            this.pnlCizimAlani.Size = new System.Drawing.Size(444, 492);
            this.pnlCizimAlani.TabIndex = 0;
            this.pnlCizimAlani.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizimAlani_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dal Arası Açı:";
            // 
            // tbaDalArasiAci
            // 
            this.tbaDalArasiAci.Location = new System.Drawing.Point(467, 43);
            this.tbaDalArasiAci.Maximum = 180;
            this.tbaDalArasiAci.Minimum = -180;
            this.tbaDalArasiAci.Name = "tbaDalArasiAci";
            this.tbaDalArasiAci.Size = new System.Drawing.Size(321, 45);
            this.tbaDalArasiAci.TabIndex = 2;
            this.tbaDalArasiAci.Value = 45;
            this.tbaDalArasiAci.Scroll += new System.EventHandler(this.tbaDalArasiAci_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İterasyon:";
            // 
            // tbaIterasyon
            // 
            this.tbaIterasyon.Location = new System.Drawing.Point(467, 121);
            this.tbaIterasyon.Maximum = 30;
            this.tbaIterasyon.Minimum = 1;
            this.tbaIterasyon.Name = "tbaIterasyon";
            this.tbaIterasyon.Size = new System.Drawing.Size(321, 45);
            this.tbaIterasyon.TabIndex = 2;
            this.tbaIterasyon.Value = 10;
            this.tbaIterasyon.Scroll += new System.EventHandler(this.tbaIterasyon_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sapma Açısı";
            // 
            // tbaSapmaAci
            // 
            this.tbaSapmaAci.Location = new System.Drawing.Point(467, 199);
            this.tbaSapmaAci.Maximum = 180;
            this.tbaSapmaAci.Minimum = -180;
            this.tbaSapmaAci.Name = "tbaSapmaAci";
            this.tbaSapmaAci.Size = new System.Drawing.Size(321, 45);
            this.tbaSapmaAci.TabIndex = 2;
            this.tbaSapmaAci.Value = 30;
            this.tbaSapmaAci.Scroll += new System.EventHandler(this.tbaSapmaAci_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dal uzunluk:";
            // 
            // tbaDalUzunluk
            // 
            this.tbaDalUzunluk.Location = new System.Drawing.Point(466, 278);
            this.tbaDalUzunluk.Maximum = 300;
            this.tbaDalUzunluk.Minimum = 10;
            this.tbaDalUzunluk.Name = "tbaDalUzunluk";
            this.tbaDalUzunluk.Size = new System.Drawing.Size(322, 45);
            this.tbaDalUzunluk.TabIndex = 2;
            this.tbaDalUzunluk.Value = 100;
            this.tbaDalUzunluk.Scroll += new System.EventHandler(this.tbaDalUzunluk_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.tbaDalUzunluk);
            this.Controls.Add(this.tbaSapmaAci);
            this.Controls.Add(this.tbaIterasyon);
            this.Controls.Add(this.tbaDalArasiAci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCizimAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbaDalArasiAci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaIterasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaSapmaAci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaDalUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizimAlani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbaDalArasiAci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbaIterasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbaSapmaAci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbaDalUzunluk;
    }
}

