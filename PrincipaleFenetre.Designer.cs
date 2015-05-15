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
    partial class CsoinCsoin
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
        this.components = new System.ComponentModel.Container ();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (CsoinCsoin));
        this.meniouBande = new System.Windows.Forms.MenuStrip ();
        this.meniouCoinCoin = new System.Windows.Forms.ToolStripMenuItem ();
        this.meniouConfiguration = new System.Windows.Forms.ToolStripMenuItem ();
        this.meniouReloadTribioune = new System.Windows.Forms.ToolStripMenuItem ();
        this.meniouSeparateur = new System.Windows.Forms.ToolStripSeparator ();
        this.meniouPanPan = new System.Windows.Forms.ToolStripMenuItem ();
        this.meniouAilpe = new System.Windows.Forms.ToolStripMenuItem ();
        this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
        this.aboutCoinCoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
        this.rechercheComboBox = new System.Windows.Forms.ToolStripComboBox ();
        this.barDesTas = new System.Windows.Forms.StatusStrip ();
        this.laBelleDesTas = new System.Windows.Forms.ToolStripStatusLabel ();
        this.rilaudingProgress = new System.Windows.Forms.ToolStripProgressBar ();
        this.splitContainer1 = new System.Windows.Forms.SplitContainer ();
        this.richePrevioue = new RichTextBoxEx ();
        this.richeTribioune = new RichTextBoxEx ();
        this.momentBouton = new System.Windows.Forms.Button ();
        this.richeBoite = new System.Windows.Forms.TextBox ();
        this.teletypeBouton = new System.Windows.Forms.Button ();
        this.soulignéBouton = new System.Windows.Forms.Button ();
        this.barréBouton = new System.Windows.Forms.Button ();
        this.grasBouton = new System.Windows.Forms.Button ();
        this.rilaudeButton = new System.Windows.Forms.Button ();
        this.italiqueBouton = new System.Windows.Forms.Button ();
        this.sendingLED = new System.Windows.Forms.Button ();
        this.noteHiFIIcône = new System.Windows.Forms.NotifyIcon (this.components);
        this.contextuelMenuBande = new System.Windows.Forms.ContextMenuStrip (this.components);
        this.copierLURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
        this.meniouBande.SuspendLayout ();
        this.barDesTas.SuspendLayout ();
        this.splitContainer1.Panel1.SuspendLayout ();
        this.splitContainer1.Panel2.SuspendLayout ();
        this.splitContainer1.SuspendLayout ();
        this.contextuelMenuBande.SuspendLayout ();
        this.SuspendLayout ();
        // 
        // meniouBande
        // 
        this.meniouBande.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.meniouCoinCoin,
            this.meniouAilpe,
            this.aboutToolStripMenuItem,
            this.rechercheComboBox});
        this.meniouBande.Location = new System.Drawing.Point (0, 0);
        this.meniouBande.Name = "meniouBande";
        this.meniouBande.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        this.meniouBande.Size = new System.Drawing.Size (415, 25);
        this.meniouBande.TabIndex = 0;
        this.meniouBande.Text = "menuStrip1";
        // 
        // meniouCoinCoin
        // 
        this.meniouCoinCoin.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.meniouConfiguration,
            this.meniouReloadTribioune,
            this.meniouSeparateur,
            this.meniouPanPan});
        this.meniouCoinCoin.Name = "meniouCoinCoin";
        this.meniouCoinCoin.Size = new System.Drawing.Size (43, 21);
        this.meniouCoinCoin.Text = "\\&_o<";
        // 
        // meniouConfiguration
        // 
        this.meniouConfiguration.Name = "meniouConfiguration";
        this.meniouConfiguration.Size = new System.Drawing.Size (147, 22);
        this.meniouConfiguration.Text = "Configuration";
        this.meniouConfiguration.Click += new System.EventHandler (this.meniouConfiguration_Click);
        // 
        // meniouReloadTribioune
        // 
        this.meniouReloadTribioune.Name = "meniouReloadTribioune";
        this.meniouReloadTribioune.Size = new System.Drawing.Size (147, 22);
        this.meniouReloadTribioune.Text = "Reset tribioune";
        this.meniouReloadTribioune.Click += new System.EventHandler (this.meniouReloadTribioune_Click);
        // 
        // meniouSeparateur
        // 
        this.meniouSeparateur.Name = "meniouSeparateur";
        this.meniouSeparateur.Size = new System.Drawing.Size (144, 6);
        // 
        // meniouPanPan
        // 
        this.meniouPanPan.Name = "meniouPanPan";
        this.meniouPanPan.Size = new System.Drawing.Size (147, 22);
        this.meniouPanPan.Text = "--->[]";
        this.meniouPanPan.Click += new System.EventHandler (this.meniouPanPan_Click);
        // 
        // meniouAilpe
        // 
        this.meniouAilpe.Name = "meniouAilpe";
        this.meniouAilpe.ShowShortcutKeys = false;
        this.meniouAilpe.Size = new System.Drawing.Size (40, 21);
        this.meniouAilpe.Text = "&Help";
        this.meniouAilpe.Click += new System.EventHandler (this.meniouAilpe_Click);
        // 
        // aboutToolStripMenuItem
        // 
        this.aboutToolStripMenuItem.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.aboutCoinCoinToolStripMenuItem});
        this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        this.aboutToolStripMenuItem.Size = new System.Drawing.Size (48, 21);
        this.aboutToolStripMenuItem.Text = "&About";
        // 
        // aboutCoinCoinToolStripMenuItem
        // 
        this.aboutCoinCoinToolStripMenuItem.Name = "aboutCoinCoinToolStripMenuItem";
        this.aboutCoinCoinToolStripMenuItem.Size = new System.Drawing.Size (164, 22);
        this.aboutCoinCoinToolStripMenuItem.Text = "&About C#oinC#oin";
        this.aboutCoinCoinToolStripMenuItem.Click += new System.EventHandler (this.aboutCoinCoinToolStripMenuItem_Click);
        // 
        // rechercheComboBox
        // 
        this.rechercheComboBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        this.rechercheComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.rechercheComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.rechercheComboBox.BackColor = System.Drawing.SystemColors.Window;
        this.rechercheComboBox.Name = "rechercheComboBox";
        this.rechercheComboBox.Size = new System.Drawing.Size (121, 21);
        this.rechercheComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler (this.rechercheComboBox_KeyDown);
        // 
        // barDesTas
        // 
        this.barDesTas.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.laBelleDesTas,
            this.rilaudingProgress});
        this.barDesTas.Location = new System.Drawing.Point (0, 457);
        this.barDesTas.Name = "barDesTas";
        this.barDesTas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        this.barDesTas.Size = new System.Drawing.Size (415, 22);
        this.barDesTas.TabIndex = 2;
        this.barDesTas.Tag = "";
        // 
        // laBelleDesTas
        // 
        this.laBelleDesTas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.laBelleDesTas.Name = "laBelleDesTas";
        this.laBelleDesTas.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
        this.laBelleDesTas.Size = new System.Drawing.Size (298, 17);
        this.laBelleDesTas.Spring = true;
        this.laBelleDesTas.Text = "Coin ! Coin !";
        this.laBelleDesTas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // rilaudingProgress
        // 
        this.rilaudingProgress.Name = "rilaudingProgress";
        this.rilaudingProgress.Size = new System.Drawing.Size (100, 16);
        this.rilaudingProgress.Step = 1;
        this.rilaudingProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        // 
        // splitContainer1
        // 
        this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainer1.Location = new System.Drawing.Point (0, 25);
        this.splitContainer1.Name = "splitContainer1";
        this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        this.splitContainer1.Panel1.Controls.Add (this.richePrevioue);
        this.splitContainer1.Panel1.Controls.Add (this.richeTribioune);
        // 
        // splitContainer1.Panel2
        // 
        this.splitContainer1.Panel2.Controls.Add (this.momentBouton);
        this.splitContainer1.Panel2.Controls.Add (this.richeBoite);
        this.splitContainer1.Panel2.Controls.Add (this.teletypeBouton);
        this.splitContainer1.Panel2.Controls.Add (this.soulignéBouton);
        this.splitContainer1.Panel2.Controls.Add (this.barréBouton);
        this.splitContainer1.Panel2.Controls.Add (this.grasBouton);
        this.splitContainer1.Panel2.Controls.Add (this.rilaudeButton);
        this.splitContainer1.Panel2.Controls.Add (this.italiqueBouton);
        this.splitContainer1.Panel2.Controls.Add (this.sendingLED);
        this.splitContainer1.Panel2MinSize = 116;
        this.splitContainer1.Size = new System.Drawing.Size (415, 432);
        this.splitContainer1.SplitterDistance = 312;
        this.splitContainer1.TabIndex = 3;
        // 
        // richePrevioue
        // 
        this.richePrevioue.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.richePrevioue.BackColor = System.Drawing.Color.FloralWhite;
        this.richePrevioue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.richePrevioue.Cursor = System.Windows.Forms.Cursors.Arrow;
        this.richePrevioue.Font = new System.Drawing.Font ("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.richePrevioue.Location = new System.Drawing.Point (3, 3);
        this.richePrevioue.Name = "richePrevioue";
        this.richePrevioue.ReadOnly = true;
        this.richePrevioue.Size = new System.Drawing.Size (395, 65);
        this.richePrevioue.TabIndex = 1;
        this.richePrevioue.Text = "";
        this.richePrevioue.Visible = false;
        // 
        // richeTribioune
        // 
        this.richeTribioune.BackColor = System.Drawing.SystemColors.Window;
        this.richeTribioune.Cursor = System.Windows.Forms.Cursors.Default;
        this.richeTribioune.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richeTribioune.Font = new System.Drawing.Font ("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.richeTribioune.Location = new System.Drawing.Point (0, 0);
        this.richeTribioune.Name = "richeTribioune";
        this.richeTribioune.ReadOnly = true;
        this.richeTribioune.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
        this.richeTribioune.Size = new System.Drawing.Size (415, 312);
        this.richeTribioune.TabIndex = 0;
        this.richeTribioune.Text = "";
        this.richeTribioune.KeyDown += new System.Windows.Forms.KeyEventHandler (this.richeTribioune_KeyDown);
        this.richeTribioune.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.richeTribioune_KeyPress);
        this.richeTribioune.KeyUp += new System.Windows.Forms.KeyEventHandler (this.richeTribioune_KeyUp);
        // 
        // momentBouton
        // 
        this.momentBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.momentBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.momentBouton.Font = new System.Drawing.Font ("Verdana", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.momentBouton.Location = new System.Drawing.Point (330, 34);
        this.momentBouton.Name = "momentBouton";
        this.momentBouton.Size = new System.Drawing.Size (78, 22);
        this.momentBouton.TabIndex = 7;
        this.momentBouton.Text = "==>M<==";
        this.momentBouton.UseVisualStyleBackColor = true;
        this.momentBouton.Click += new System.EventHandler (this.momentBouton_Click);
        // 
        // richeBoite
        // 
        this.richeBoite.AcceptsTab = true;
        this.richeBoite.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.richeBoite.Font = new System.Drawing.Font ("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.richeBoite.Location = new System.Drawing.Point (3, 0);
        this.richeBoite.Multiline = true;
        this.richeBoite.Name = "richeBoite";
        this.richeBoite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.richeBoite.Size = new System.Drawing.Size (321, 112);
        this.richeBoite.TabIndex = 0;
        this.richeBoite.MouseClick += new System.Windows.Forms.MouseEventHandler (this.richeBoite_MouseClick);
        this.richeBoite.KeyDown += new System.Windows.Forms.KeyEventHandler (this.richeBoite_KeyDown);
        // 
        // teletypeBouton
        // 
        this.teletypeBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.teletypeBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.teletypeBouton.Font = new System.Drawing.Font ("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.teletypeBouton.Location = new System.Drawing.Point (358, 62);
        this.teletypeBouton.Name = "teletypeBouton";
        this.teletypeBouton.Size = new System.Drawing.Size (50, 22);
        this.teletypeBouton.TabIndex = 6;
        this.teletypeBouton.Text = "TT";
        this.teletypeBouton.UseVisualStyleBackColor = true;
        this.teletypeBouton.Click += new System.EventHandler (this.teletypeBouton_Click);
        // 
        // soulignéBouton
        // 
        this.soulignéBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.soulignéBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.soulignéBouton.Font = new System.Drawing.Font ("Verdana", 7.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.soulignéBouton.Location = new System.Drawing.Point (386, 90);
        this.soulignéBouton.Name = "soulignéBouton";
        this.soulignéBouton.Size = new System.Drawing.Size (22, 22);
        this.soulignéBouton.TabIndex = 4;
        this.soulignéBouton.Text = "U";
        this.soulignéBouton.UseVisualStyleBackColor = true;
        this.soulignéBouton.Click += new System.EventHandler (this.soulignéBouton_Click);
        // 
        // barréBouton
        // 
        this.barréBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.barréBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.barréBouton.Font = new System.Drawing.Font ("Verdana", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.barréBouton.Location = new System.Drawing.Point (358, 90);
        this.barréBouton.Name = "barréBouton";
        this.barréBouton.Size = new System.Drawing.Size (22, 22);
        this.barréBouton.TabIndex = 5;
        this.barréBouton.Text = "S";
        this.barréBouton.UseVisualStyleBackColor = true;
        this.barréBouton.Click += new System.EventHandler (this.barréBouton_Click);
        // 
        // grasBouton
        // 
        this.grasBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.grasBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.grasBouton.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.grasBouton.Location = new System.Drawing.Point (330, 90);
        this.grasBouton.Name = "grasBouton";
        this.grasBouton.Size = new System.Drawing.Size (22, 22);
        this.grasBouton.TabIndex = 2;
        this.grasBouton.Text = "B";
        this.grasBouton.UseVisualStyleBackColor = true;
        this.grasBouton.Click += new System.EventHandler (this.grasBouton_Click);
        // 
        // rilaudeButton
        // 
        this.rilaudeButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.rilaudeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.rilaudeButton.Location = new System.Drawing.Point (386, 2);
        this.rilaudeButton.Name = "rilaudeButton";
        this.rilaudeButton.Size = new System.Drawing.Size (22, 22);
        this.rilaudeButton.TabIndex = 0;
        this.rilaudeButton.Text = "R";
        this.rilaudeButton.UseVisualStyleBackColor = true;
        this.rilaudeButton.Click += new System.EventHandler (this.rilaudeButton_Click);
        // 
        // italiqueBouton
        // 
        this.italiqueBouton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.italiqueBouton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.italiqueBouton.Font = new System.Drawing.Font ("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.italiqueBouton.Location = new System.Drawing.Point (330, 62);
        this.italiqueBouton.Name = "italiqueBouton";
        this.italiqueBouton.Size = new System.Drawing.Size (22, 22);
        this.italiqueBouton.TabIndex = 3;
        this.italiqueBouton.Text = "I";
        this.italiqueBouton.UseVisualStyleBackColor = true;
        this.italiqueBouton.Click += new System.EventHandler (this.italiqueBouton_Click);
        // 
        // sendingLED
        // 
        this.sendingLED.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.sendingLED.Enabled = false;
        this.sendingLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.sendingLED.Location = new System.Drawing.Point (330, 2);
        this.sendingLED.Name = "sendingLED";
        this.sendingLED.Padding = new System.Windows.Forms.Padding (0, 0, 7, 0);
        this.sendingLED.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.sendingLED.Size = new System.Drawing.Size (50, 22);
        this.sendingLED.TabIndex = 1;
        this.sendingLED.Text = "0";
        this.sendingLED.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.sendingLED.UseVisualStyleBackColor = true;
        // 
        // noteHiFIIcône
        // 
        this.noteHiFIIcône.Icon = ((System.Drawing.Icon) (resources.GetObject ("noteHiFIIcône.Icon")));
        this.noteHiFIIcône.Text = "C#oin !";
        this.noteHiFIIcône.Visible = true;
        this.noteHiFIIcône.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler (this.noteHiFIIcône_MouseDoubleClick);
        // 
        // contextuelMenuBande
        // 
        this.contextuelMenuBande.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.copierLURLToolStripMenuItem});
        this.contextuelMenuBande.Name = "contextuelMenuBande";
        this.contextuelMenuBande.Size = new System.Drawing.Size (132, 26);
        this.contextuelMenuBande.Opening += new System.ComponentModel.CancelEventHandler (this.contextuelMenuBande_Opening);
        // 
        // copierLURLToolStripMenuItem
        // 
        this.copierLURLToolStripMenuItem.Name = "copierLURLToolStripMenuItem";
        this.copierLURLToolStripMenuItem.Size = new System.Drawing.Size (131, 22);
        this.copierLURLToolStripMenuItem.Text = "Copier l\'URL";
        this.copierLURLToolStripMenuItem.Click += new System.EventHandler (this.copierLURLToolStripMenuItem_Click);
        // 
        // CsoinCsoin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size (415, 479);
        this.Controls.Add (this.splitContainer1);
        this.Controls.Add (this.barDesTas);
        this.Controls.Add (this.meniouBande);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
        this.MainMenuStrip = this.meniouBande;
        this.Name = "CsoinCsoin";
        this.Text = "C#oin ! C#oin !";
        this.meniouBande.ResumeLayout (false);
        this.meniouBande.PerformLayout ();
        this.barDesTas.ResumeLayout (false);
        this.barDesTas.PerformLayout ();
        this.splitContainer1.Panel1.ResumeLayout (false);
        this.splitContainer1.Panel2.ResumeLayout (false);
        this.splitContainer1.Panel2.PerformLayout ();
        this.splitContainer1.ResumeLayout (false);
        this.contextuelMenuBande.ResumeLayout (false);
        this.ResumeLayout (false);
        this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meniouBande;
        private System.Windows.Forms.ToolStripMenuItem meniouCoinCoin;
        private System.Windows.Forms.ToolStripMenuItem meniouConfiguration;
        private System.Windows.Forms.ToolStripMenuItem meniouReloadTribioune;
        private System.Windows.Forms.ToolStripSeparator meniouSeparateur;
        private System.Windows.Forms.ToolStripMenuItem meniouPanPan;
        private System.Windows.Forms.ToolStripMenuItem meniouAilpe;
        private System.Windows.Forms.StatusStrip barDesTas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel laBelleDesTas;
        private System.Windows.Forms.Button momentBouton;
        private System.Windows.Forms.TextBox richeBoite;
        private System.Windows.Forms.Button teletypeBouton;
        private System.Windows.Forms.Button soulignéBouton;
        private System.Windows.Forms.Button barréBouton;
        private System.Windows.Forms.Button grasBouton;
        private System.Windows.Forms.Button rilaudeButton;
        private System.Windows.Forms.Button italiqueBouton;
        private System.Windows.Forms.Button sendingLED;
        private System.Windows.Forms.NotifyIcon noteHiFIIcône;
        private System.Windows.Forms.ContextMenuStrip contextuelMenuBande;
        private System.Windows.Forms.ToolStripMenuItem copierLURLToolStripMenuItem;
        private RichTextBoxEx richeTribioune;
        private RichTextBoxEx richePrevioue;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCoinCoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar rilaudingProgress;
        private System.Windows.Forms.ToolStripComboBox rechercheComboBox;
    }
}

