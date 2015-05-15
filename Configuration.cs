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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CsoinCsoin
    {
    partial class ConfigurationForm : Form
        {
        Tribioune tribioune;

        public ConfigurationForm (Tribioune t)
            {
            InitializeComponent ();
            this.Text += " - " + t.name;
            this.tribioune = t;
            serveurTextBox.Text = tribioune.serveur;
            backendTextBox.Text = tribioune.derrièreEnd;
            posterTextBox.Text = tribioune.postURL;
            cookieTextBox.Text = tribioune.coukie;
            tagsEncodésCheckBox.Checked = (tribioune.slip == slipType.tags_non_encodés);
            UTFCheckBox.Checked = tribioune.UTF;
            rilaudeTextBox.Text = tribioune.reload_delai.ToString ();
            maxPostsTextBox.Text = tribioune.taille_max.ToString ();
            pseudoTextBox.Text = tribioune.username;
            proxyTextBox.Text = tribioune.proxy;
            proxyLoginTextBox.Text = tribioune.proxyUser;
            proxyMotDePasseTextBox.Text = tribioune.proxyPass;

            rilaudeTextBox.KeyPress += new KeyPressEventHandler (rilaudeTextBox_KeyPress);
            maxPostsTextBox.KeyPress += new KeyPressEventHandler (maxPostsTextBox_KeyPress);

            utiliserProxyCheckBox.CheckedChanged += new EventHandler (utiliserProxyCheckBox_CheckedChanged);
            proxyIdentificationCheckBox.CheckedChanged += new EventHandler (proxyIdentificationCheckBox_CheckedChanged);

            utiliserProxyCheckBox.Checked = tribioune.proxy.Length > 0;
            proxyIdentificationCheckBox.Checked = tribioune.proxyUser.Length + tribioune.proxyPass.Length > 0;

            utiliserProxyCheckBox_CheckedChanged (null, null);
            proxyIdentificationCheckBox_CheckedChanged (null, null);
            }

        void maxPostsTextBox_KeyPress (object sender, KeyPressEventArgs e)
            {
            if (!Char.IsDigit (e.KeyChar))
                e.Handled = true;
            }

        void rilaudeTextBox_KeyPress (object sender, KeyPressEventArgs e)
            {
            if (!Char.IsDigit (e.KeyChar))
                e.Handled = true;
            }

        private void boutonOKConf_Click (object sender, EventArgs e)
            {
            tribioune.serveur = serveurTextBox.Text;
            tribioune.derrièreEnd = backendTextBox.Text;
            tribioune.postURL = posterTextBox.Text;
            tribioune.coukie = cookieTextBox.Text;
            tribioune.slip = tagsEncodésCheckBox.Checked ? slipType.tags_non_encodés : slipType.tags_encodés;
            tribioune.UTF = UTFCheckBox.Checked;
            tribioune.reload_delai = Int32.Parse (rilaudeTextBox.Text);
            tribioune.taille_max = Int32.Parse (maxPostsTextBox.Text);
            tribioune.username = pseudoTextBox.Text;

            if (utiliserProxyCheckBox.Checked)
                {
                tribioune.proxy = proxyTextBox.Text;

                if (proxyIdentificationCheckBox.Checked)
                    {
                    tribioune.proxyUser = proxyLoginTextBox.Text;
                    tribioune.proxyPass = proxyMotDePasseTextBox.Text;
                    }
                else
                    {
                    tribioune.proxyUser = "";
                    tribioune.proxyPass = "";
                    }
                }
            else
                {
                tribioune.proxy = "";
                tribioune.proxyUser = "";
                tribioune.proxyPass = "";
                }

            tribioune.updateProxy ();

            this.Close ();
            }

        private void boutonAnnulerConf_Click (object sender, EventArgs e)
            {
            this.Close ();
            }

        private void utiliserProxyCheckBox_CheckedChanged (object sender, EventArgs e)
            {
            groupBox1.Enabled = utiliserProxyCheckBox.Checked;
            }

        private void proxyIdentificationCheckBox_CheckedChanged (object sender, EventArgs e)
            {
            proxyLoginTextBox.Enabled = proxyIdentificationCheckBox.Checked;
            proxyMotDePasseTextBox.Enabled = proxyIdentificationCheckBox.Checked;
            }

        private void boutonLogin_Click (object sender, EventArgs e)
            {
            WebProxy proxyObject;

            if (utiliserProxyCheckBox.Checked)
                {
                proxyObject = new WebProxy (proxyTextBox.Text);

                if (proxyIdentificationCheckBox.Checked)
                    {
                    proxyObject.Credentials = new NetworkCredential (proxyLoginTextBox.Text, proxyMotDePasseTextBox.Text);
                    }
                }
            else
                {
                proxyObject = null;
                }

            List<string> usefulCookies = new List<string> ();
            usefulCookies.Add ("md5");
            usefulCookies.Add ("unique_id");

            //TribiouneLoginForm tlf = new TribiouneLoginForm ("http://linuxfr.org/login.html", "login=%l&passwd=%p&isauto=1", pseudoTextBox.Text, proxyObject, usefulCookies);
            //tlf.ShowDialog ();
            }
        }
    }
