
namespace SierpinskiUcgeniFraktal
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
            this.tbaAdet = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCizimAlani
            // 
            this.pnlCizimAlani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCizimAlani.Location = new System.Drawing.Point(12, 76);
            this.pnlCizimAlani.Name = "pnlCizimAlani";
            this.pnlCizimAlani.Size = new System.Drawing.Size(434, 362);
            this.pnlCizimAlani.TabIndex = 0;
            this.pnlCizimAlani.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCizimAlani_Paint);
            // 
            // tbaAdet
            // 
            this.tbaAdet.Location = new System.Drawing.Point(12, 25);
            this.tbaAdet.Maximum = 12;
            this.tbaAdet.Minimum = 1;
            this.tbaAdet.Name = "tbaAdet";
            this.tbaAdet.Size = new System.Drawing.Size(342, 45);
            this.tbaAdet.TabIndex = 1;
            this.tbaAdet.Value = 1;
            this.tbaAdet.Scroll += new System.EventHandler(this.tbaAdet_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaAdet);
            this.Controls.Add(this.pnlCizimAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbaAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCizimAlani;
        private System.Windows.Forms.TrackBar tbaAdet;
        private System.Windows.Forms.Label label1;
    }
}

