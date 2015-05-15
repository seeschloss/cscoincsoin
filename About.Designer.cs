namespace CsoinCsoin
    {
    partial class About
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel ();
            this.label1 = new System.Windows.Forms.Label ();
            this.labelVersion = new System.Windows.Forms.Label ();
            this.textBoiteInfos = new System.Windows.Forms.TextBox ();
            this.paClikai = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point (3, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size (116, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "C#oinC#oin homepage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (297, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "C#oinC#oin est un CoinCoin nouvelle génération, écrit en C#.";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point (3, 41);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size (66, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "C#oinC#oin ";
            // 
            // textBoiteInfos
            // 
            this.textBoiteInfos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoiteInfos.Location = new System.Drawing.Point (6, 107);
            this.textBoiteInfos.Multiline = true;
            this.textBoiteInfos.Name = "textBoiteInfos";
            this.textBoiteInfos.ReadOnly = true;
            this.textBoiteInfos.Size = new System.Drawing.Size (294, 110);
            this.textBoiteInfos.TabIndex = 2;
            // 
            // paClikai
            // 
            this.paClikai.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.paClikai.Location = new System.Drawing.Point (225, 65);
            this.paClikai.Name = "paClikai";
            this.paClikai.Size = new System.Drawing.Size (75, 23);
            this.paClikai.TabIndex = 3;
            this.paClikai.Text = "PACLIKAI !";
            this.paClikai.UseVisualStyleBackColor = true;
            this.paClikai.Click += new System.EventHandler (this.paClikai_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (307, 223);
            this.Controls.Add (this.paClikai);
            this.Controls.Add (this.textBoiteInfos);
            this.Controls.Add (this.labelVersion);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.linkLabel1);
            this.Name = "About";
            this.Text = "About C#oinC#oin";
            this.Load += new System.EventHandler (this.About_Load);
            this.ResumeLayout (false);
            this.PerformLayout ();

            }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoiteInfos;
        private System.Windows.Forms.Button paClikai;
        }
    }