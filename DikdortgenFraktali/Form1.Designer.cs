
namespace FraktalCizimleriYigitHoca
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
            this.tbaPay = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbaAdet = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbaPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCizimAlani
            // 
            this.pnlCizimAlani.Location = new System.Drawing.Point(13, 13);
            this.pnlCizimAlani.Name = "pnlCizimAlani";
            this.pnlCizimAlani.Size = new System.Drawing.Size(427, 425);
            this.pnlCizimAlani.TabIndex = 0;
            this.pnlCizimAlani.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizimAlani_Paint);
            // 
            // tbaPay
            // 
            this.tbaPay.Location = new System.Drawing.Point(447, 48);
            this.tbaPay.Maximum = 100;
            this.tbaPay.Name = "tbaPay";
            this.tbaPay.Size = new System.Drawing.Size(341, 45);
            this.tbaPay.TabIndex = 1;
            this.tbaPay.Scroll += new System.EventHandler(this.tbaPay_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pay:";
            // 
            // tbaAdet
            // 
            this.tbaAdet.Location = new System.Drawing.Point(449, 121);
            this.tbaAdet.Maximum = 100;
            this.tbaAdet.Name = "tbaAdet";
            this.tbaAdet.Size = new System.Drawing.Size(339, 45);
            this.tbaAdet.TabIndex = 3;
            this.tbaAdet.Scroll += new System.EventHandler(this.tbaAdet_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(688, 415);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Resmi Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbaAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaPay);
            this.Controls.Add(this.pnlCizimAlani);
            this.Name = "Form1";
            this.Text = "Dikdörtgen Fraktalı";
            ((System.ComponentModel.ISupportInitialize)(this.tbaPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizimAlani;
        private System.Windows.Forms.TrackBar tbaPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbaAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
    }
}

