
namespace SpiralFraktal
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
            this.tbaAdet = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbaPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCizimAlani
            // 
            this.pnlCizimAlani.Location = new System.Drawing.Point(13, 13);
            this.pnlCizimAlani.Name = "pnlCizimAlani";
            this.pnlCizimAlani.Size = new System.Drawing.Size(400, 400);
            this.pnlCizimAlani.TabIndex = 0;
            this.pnlCizimAlani.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizimAlani_Paint);
            // 
            // tbaPay
            // 
            this.tbaPay.Location = new System.Drawing.Point(453, 44);
            this.tbaPay.Maximum = 75;
            this.tbaPay.Minimum = 1;
            this.tbaPay.Name = "tbaPay";
            this.tbaPay.Size = new System.Drawing.Size(335, 45);
            this.tbaPay.TabIndex = 1;
            this.tbaPay.Value = 1;
            this.tbaPay.Scroll += new System.EventHandler(this.tbaPay_Scroll);
            // 
            // tbaAdet
            // 
            this.tbaAdet.Location = new System.Drawing.Point(453, 137);
            this.tbaAdet.Maximum = 250;
            this.tbaAdet.Minimum = 1;
            this.tbaAdet.Name = "tbaAdet";
            this.tbaAdet.Size = new System.Drawing.Size(335, 45);
            this.tbaAdet.TabIndex = 2;
            this.tbaAdet.Value = 1;
            this.tbaAdet.Scroll += new System.EventHandler(this.tbaAdet_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pay: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaAdet);
            this.Controls.Add(this.tbaPay);
            this.Controls.Add(this.pnlCizimAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbaPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizimAlani;
        private System.Windows.Forms.TrackBar tbaPay;
        private System.Windows.Forms.TrackBar tbaAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

