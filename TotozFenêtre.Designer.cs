namespace CsoinCsoin
{
    partial class TotozFenêtre
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
        this.pictureBoite = new System.Windows.Forms.PictureBox ();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBoite)).BeginInit ();
        this.SuspendLayout ();
        // 
        // pictureBoite
        // 
        this.pictureBoite.BackColor = System.Drawing.Color.Transparent;
        this.pictureBoite.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pictureBoite.Location = new System.Drawing.Point (0, 0);
        this.pictureBoite.Name = "pictureBoite";
        this.pictureBoite.Size = new System.Drawing.Size (292, 273);
        this.pictureBoite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.pictureBoite.TabIndex = 0;
        this.pictureBoite.TabStop = false;
        this.pictureBoite.Paint += new System.Windows.Forms.PaintEventHandler (this.pictureBoite_Paint);
        // 
        // TotozFenêtre
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size (292, 273);
        this.Controls.Add (this.pictureBoite);
        this.DoubleBuffered = true;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "TotozFenêtre";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.Text = "Totoz";
        this.TopMost = true;
        ((System.ComponentModel.ISupportInitialize) (this.pictureBoite)).EndInit ();
        this.ResumeLayout (false);
        this.PerformLayout ();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoite;

    }
}