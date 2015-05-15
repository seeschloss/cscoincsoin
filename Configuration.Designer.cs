/***********************************************************************
 *          DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE                *
 *                    Version 2, December 2004                         *
 *                                                                     *
 * Copyright (C) 2006 SeeSchloss                                       *
 *                                                                     *
 * Everyone is permitted  to copy and distribute  verbatim or modified *
 * copies of this license document, and changing it is allowed as long *
 * as the name is changed.                                             *
 *                                                                     *
 *            DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE              *
 *   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION   *
 *                                                                     *
 *  0. You just DO WHAT THE FUCK YOU WANT TO.                          *
 ***********************************************************************/

namespace CsoinCsoin
{
    partial class ConfigurationForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (ConfigurationForm));
        this.cookieLabel = new System.Windows.Forms.Label ();
        this.cookieTextBox = new System.Windows.Forms.TextBox ();
        this.serveurTextBox = new System.Windows.Forms.TextBox ();
        this.serveurLabel = new System.Windows.Forms.Label ();
        this.backendTextBox = new System.Windows.Forms.TextBox ();
        this.backendLabel = new System.Windows.Forms.Label ();
        this.posterTextBox = new System.Windows.Forms.TextBox ();
        this.posterLabel = new System.Windows.Forms.Label ();
        this.boutonOKConf = new System.Windows.Forms.Button ();
        this.boutonAnnulerConf = new System.Windows.Forms.Button ();
        this.UTFCheckBox = new System.Windows.Forms.CheckBox ();
        this.tagsEncodésCheckBox = new System.Windows.Forms.CheckBox ();
        this.label1 = new System.Windows.Forms.Label ();
        this.label2 = new System.Windows.Forms.Label ();
        this.rilaudeTextBox = new System.Windows.Forms.TextBox ();
        this.maxPostsTextBox = new System.Windows.Forms.TextBox ();
        this.pseudoTextBox = new System.Windows.Forms.TextBox ();
        this.label3 = new System.Windows.Forms.Label ();
        this.groupBox1 = new System.Windows.Forms.GroupBox ();
        this.label6 = new System.Windows.Forms.Label ();
        this.proxyIdentificationCheckBox = new System.Windows.Forms.CheckBox ();
        this.label5 = new System.Windows.Forms.Label ();
        this.proxyLoginTextBox = new System.Windows.Forms.TextBox ();
        this.proxyMotDePasseTextBox = new System.Windows.Forms.TextBox ();
        this.proxyTextBox = new System.Windows.Forms.TextBox ();
        this.label4 = new System.Windows.Forms.Label ();
        this.utiliserProxyCheckBox = new System.Windows.Forms.CheckBox ();
        this.boutonLogin = new System.Windows.Forms.Button ();
        this.groupBox1.SuspendLayout ();
        this.SuspendLayout ();
        // 
        // cookieLabel
        // 
        this.cookieLabel.AutoSize = true;
        this.cookieLabel.Location = new System.Drawing.Point (12, 9);
        this.cookieLabel.Name = "cookieLabel";
        this.cookieLabel.Size = new System.Drawing.Size (46, 13);
        this.cookieLabel.TabIndex = 0;
        this.cookieLabel.Text = "Cookie :";
        // 
        // cookieTextBox
        // 
        this.cookieTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.cookieTextBox.Location = new System.Drawing.Point (64, 6);
        this.cookieTextBox.Name = "cookieTextBox";
        this.cookieTextBox.Size = new System.Drawing.Size (250, 20);
        this.cookieTextBox.TabIndex = 1;
        this.cookieTextBox.Text = "md5=;unique_id=";
        // 
        // serveurTextBox
        // 
        this.serveurTextBox.AcceptsTab = true;
        this.serveurTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.serveurTextBox.Location = new System.Drawing.Point (107, 67);
        this.serveurTextBox.Name = "serveurTextBox";
        this.serveurTextBox.Size = new System.Drawing.Size (273, 20);
        this.serveurTextBox.TabIndex = 3;
        this.serveurTextBox.Text = "linuxfr.org";
        // 
        // serveurLabel
        // 
        this.serveurLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.serveurLabel.AutoSize = true;
        this.serveurLabel.Location = new System.Drawing.Point (12, 70);
        this.serveurLabel.Name = "serveurLabel";
        this.serveurLabel.Size = new System.Drawing.Size (76, 13);
        this.serveurLabel.TabIndex = 3;
        this.serveurLabel.Text = "Serveur HTTP";
        // 
        // backendTextBox
        // 
        this.backendTextBox.AcceptsTab = true;
        this.backendTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.backendTextBox.Location = new System.Drawing.Point (107, 93);
        this.backendTextBox.Name = "backendTextBox";
        this.backendTextBox.Size = new System.Drawing.Size (273, 20);
        this.backendTextBox.TabIndex = 4;
        this.backendTextBox.Text = "/board/remote.xml";
        // 
        // backendLabel
        // 
        this.backendLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.backendLabel.AutoSize = true;
        this.backendLabel.Location = new System.Drawing.Point (12, 96);
        this.backendLabel.Name = "backendLabel";
        this.backendLabel.Size = new System.Drawing.Size (89, 13);
        this.backendLabel.TabIndex = 5;
        this.backendLabel.Text = "URL du backend";
        // 
        // posterTextBox
        // 
        this.posterTextBox.AcceptsTab = true;
        this.posterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.posterTextBox.Location = new System.Drawing.Point (107, 119);
        this.posterTextBox.Name = "posterTextBox";
        this.posterTextBox.Size = new System.Drawing.Size (273, 20);
        this.posterTextBox.TabIndex = 5;
        this.posterTextBox.Text = "/board/add.php";
        // 
        // posterLabel
        // 
        this.posterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.posterLabel.AutoSize = true;
        this.posterLabel.Location = new System.Drawing.Point (12, 122);
        this.posterLabel.Name = "posterLabel";
        this.posterLabel.Size = new System.Drawing.Size (85, 13);
        this.posterLabel.TabIndex = 7;
        this.posterLabel.Text = "URL pour poster";
        // 
        // boutonOKConf
        // 
        this.boutonOKConf.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.boutonOKConf.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.boutonOKConf.Location = new System.Drawing.Point (206, 331);
        this.boutonOKConf.Name = "boutonOKConf";
        this.boutonOKConf.Size = new System.Drawing.Size (84, 24);
        this.boutonOKConf.TabIndex = 10;
        this.boutonOKConf.Text = "OK";
        this.boutonOKConf.UseVisualStyleBackColor = true;
        this.boutonOKConf.Click += new System.EventHandler (this.boutonOKConf_Click);
        // 
        // boutonAnnulerConf
        // 
        this.boutonAnnulerConf.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.boutonAnnulerConf.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.boutonAnnulerConf.Location = new System.Drawing.Point (296, 331);
        this.boutonAnnulerConf.Name = "boutonAnnulerConf";
        this.boutonAnnulerConf.Size = new System.Drawing.Size (84, 24);
        this.boutonAnnulerConf.TabIndex = 11;
        this.boutonAnnulerConf.Text = "Annuler";
        this.boutonAnnulerConf.UseVisualStyleBackColor = true;
        this.boutonAnnulerConf.Click += new System.EventHandler (this.boutonAnnulerConf_Click);
        // 
        // UTFCheckBox
        // 
        this.UTFCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.UTFCheckBox.AutoSize = true;
        this.UTFCheckBox.Location = new System.Drawing.Point (213, 147);
        this.UTFCheckBox.Name = "UTFCheckBox";
        this.UTFCheckBox.Size = new System.Drawing.Size (134, 17);
        this.UTFCheckBox.TabIndex = 8;
        this.UTFCheckBox.Text = "Moderne (donc UTF-8)";
        this.UTFCheckBox.UseVisualStyleBackColor = true;
        // 
        // tagsEncodésCheckBox
        // 
        this.tagsEncodésCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.tagsEncodésCheckBox.AutoSize = true;
        this.tagsEncodésCheckBox.Location = new System.Drawing.Point (213, 170);
        this.tagsEncodésCheckBox.Name = "tagsEncodésCheckBox";
        this.tagsEncodésCheckBox.Size = new System.Drawing.Size (165, 17);
        this.tagsEncodésCheckBox.TabIndex = 9;
        this.tagsEncodésCheckBox.Text = "Slip sale (donc tags encodés)";
        this.tagsEncodésCheckBox.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point (12, 148);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size (139, 13);
        this.label1.TabIndex = 15;
        this.label1.Text = "Période de rafraîchissement";
        // 
        // label2
        // 
        this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point (12, 171);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size (109, 13);
        this.label2.TabIndex = 16;
        this.label2.Text = "Max tro^H^H^Hposts";
        // 
        // rilaudeTextBox
        // 
        this.rilaudeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.rilaudeTextBox.Location = new System.Drawing.Point (158, 146);
        this.rilaudeTextBox.Name = "rilaudeTextBox";
        this.rilaudeTextBox.Size = new System.Drawing.Size (49, 20);
        this.rilaudeTextBox.TabIndex = 6;
        // 
        // maxPostsTextBox
        // 
        this.maxPostsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
        this.maxPostsTextBox.Location = new System.Drawing.Point (158, 172);
        this.maxPostsTextBox.Name = "maxPostsTextBox";
        this.maxPostsTextBox.Size = new System.Drawing.Size (49, 20);
        this.maxPostsTextBox.TabIndex = 7;
        // 
        // pseudoTextBox
        // 
        this.pseudoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.pseudoTextBox.Location = new System.Drawing.Point (64, 32);
        this.pseudoTextBox.Name = "pseudoTextBox";
        this.pseudoTextBox.Size = new System.Drawing.Size (316, 20);
        this.pseudoTextBox.TabIndex = 2;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point (12, 35);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size (49, 13);
        this.label3.TabIndex = 19;
        this.label3.Text = "Pseudo :";
        // 
        // groupBox1
        // 
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add (this.label6);
        this.groupBox1.Controls.Add (this.proxyIdentificationCheckBox);
        this.groupBox1.Controls.Add (this.label5);
        this.groupBox1.Controls.Add (this.proxyLoginTextBox);
        this.groupBox1.Controls.Add (this.proxyMotDePasseTextBox);
        this.groupBox1.Controls.Add (this.proxyTextBox);
        this.groupBox1.Controls.Add (this.label4);
        this.groupBox1.Location = new System.Drawing.Point (15, 222);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size (365, 103);
        this.groupBox1.TabIndex = 20;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Proxy";
        // 
        // label6
        // 
        this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point (174, 69);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size (71, 13);
        this.label6.TabIndex = 41;
        this.label6.Text = "Mot de passe";
        // 
        // proxyIdentificationCheckBox
        // 
        this.proxyIdentificationCheckBox.AutoSize = true;
        this.proxyIdentificationCheckBox.Location = new System.Drawing.Point (82, 43);
        this.proxyIdentificationCheckBox.Name = "proxyIdentificationCheckBox";
        this.proxyIdentificationCheckBox.Size = new System.Drawing.Size (86, 17);
        this.proxyIdentificationCheckBox.TabIndex = 40;
        this.proxyIdentificationCheckBox.Text = "Identification";
        this.proxyIdentificationCheckBox.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point (212, 43);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size (33, 13);
        this.label5.TabIndex = 38;
        this.label5.Text = "Login";
        // 
        // proxyLoginTextBox
        // 
        this.proxyLoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.proxyLoginTextBox.Location = new System.Drawing.Point (251, 40);
        this.proxyLoginTextBox.Name = "proxyLoginTextBox";
        this.proxyLoginTextBox.Size = new System.Drawing.Size (93, 20);
        this.proxyLoginTextBox.TabIndex = 37;
        // 
        // proxyMotDePasseTextBox
        // 
        this.proxyMotDePasseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.proxyMotDePasseTextBox.Location = new System.Drawing.Point (251, 66);
        this.proxyMotDePasseTextBox.Name = "proxyMotDePasseTextBox";
        this.proxyMotDePasseTextBox.Size = new System.Drawing.Size (93, 20);
        this.proxyMotDePasseTextBox.TabIndex = 36;
        // 
        // proxyTextBox
        // 
        this.proxyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.proxyTextBox.Location = new System.Drawing.Point (57, 14);
        this.proxyTextBox.Name = "proxyTextBox";
        this.proxyTextBox.Size = new System.Drawing.Size (287, 20);
        this.proxyTextBox.TabIndex = 34;
        // 
        // label4
        // 
        this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point (6, 17);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size (45, 13);
        this.label4.TabIndex = 35;
        this.label4.Text = "Adresse";
        // 
        // utiliserProxyCheckBox
        // 
        this.utiliserProxyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.utiliserProxyCheckBox.AutoSize = true;
        this.utiliserProxyCheckBox.Location = new System.Drawing.Point (15, 199);
        this.utiliserProxyCheckBox.Name = "utiliserProxyCheckBox";
        this.utiliserProxyCheckBox.Size = new System.Drawing.Size (132, 17);
        this.utiliserProxyCheckBox.TabIndex = 39;
        this.utiliserProxyCheckBox.Text = "Utiliser un proxy HTTP";
        this.utiliserProxyCheckBox.UseVisualStyleBackColor = true;
        // 
        // boutonLogin
        // 
        this.boutonLogin.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.boutonLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.boutonLogin.Location = new System.Drawing.Point (320, 6);
        this.boutonLogin.Name = "boutonLogin";
        this.boutonLogin.Size = new System.Drawing.Size (60, 21);
        this.boutonLogin.TabIndex = 10;
        this.boutonLogin.Text = "Login";
        this.boutonLogin.UseVisualStyleBackColor = true;
        this.boutonLogin.Click += new System.EventHandler (this.boutonLogin_Click);
        // 
        // ConfigurationForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size (392, 362);
        this.Controls.Add (this.groupBox1);
        this.Controls.Add (this.pseudoTextBox);
        this.Controls.Add (this.utiliserProxyCheckBox);
        this.Controls.Add (this.label3);
        this.Controls.Add (this.maxPostsTextBox);
        this.Controls.Add (this.rilaudeTextBox);
        this.Controls.Add (this.label2);
        this.Controls.Add (this.label1);
        this.Controls.Add (this.tagsEncodésCheckBox);
        this.Controls.Add (this.UTFCheckBox);
        this.Controls.Add (this.boutonAnnulerConf);
        this.Controls.Add (this.boutonLogin);
        this.Controls.Add (this.boutonOKConf);
        this.Controls.Add (this.posterTextBox);
        this.Controls.Add (this.posterLabel);
        this.Controls.Add (this.backendTextBox);
        this.Controls.Add (this.backendLabel);
        this.Controls.Add (this.serveurTextBox);
        this.Controls.Add (this.serveurLabel);
        this.Controls.Add (this.cookieTextBox);
        this.Controls.Add (this.cookieLabel);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size (400, 260);
        this.Name = "ConfigurationForm";
        this.Text = "Configuration";
        this.groupBox1.ResumeLayout (false);
        this.groupBox1.PerformLayout ();
        this.ResumeLayout (false);
        this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label cookieLabel;
        private System.Windows.Forms.TextBox cookieTextBox;
        private System.Windows.Forms.TextBox serveurTextBox;
        private System.Windows.Forms.Label serveurLabel;
        private System.Windows.Forms.TextBox backendTextBox;
        private System.Windows.Forms.Label backendLabel;
        private System.Windows.Forms.TextBox posterTextBox;
        private System.Windows.Forms.Label posterLabel;
        private System.Windows.Forms.Button boutonOKConf;
        private System.Windows.Forms.Button boutonAnnulerConf;
        private System.Windows.Forms.CheckBox UTFCheckBox;
        private System.Windows.Forms.CheckBox tagsEncodésCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rilaudeTextBox;
        private System.Windows.Forms.TextBox maxPostsTextBox;
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox proxyIdentificationCheckBox;
        private System.Windows.Forms.CheckBox utiliserProxyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proxyLoginTextBox;
        private System.Windows.Forms.TextBox proxyMotDePasseTextBox;
        private System.Windows.Forms.TextBox proxyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonLogin;
    }
}