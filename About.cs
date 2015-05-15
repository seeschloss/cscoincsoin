using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CsoinCsoin
    {
    public partial class About : Form
        {
        private int clics = 0;

        public About ()
            {
            InitializeComponent ();

            fillInfos ();
            }

        private void fillInfos ()
            {
            String windowsVersion = System.Environment.OSVersion.VersionString;
            String pointNetVersion = System.Environment.Version.ToString ();

            textBoiteInfos.Text = "" + windowsVersion + System.Environment.NewLine + System.Environment.NewLine + ".Net version " + pointNetVersion;
            }

        private void About_Load (object sender, EventArgs e)
            {
            labelVersion.Text += Program.VERSION;
            }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
            {
            try
                {
                System.Diagnostics.Process.Start ("http://seeschloss.org/coin.html");
                }
            catch (Exception ex)
                {
                MessageBox.Show ("Impossible d'ouvrir l'url", "Impossible d'ouvrir l'[url]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void paClikai_Click (object sender, EventArgs e)
            {
            if (clics < 10)
                {
                MessageBox.Show ("Bon... ça ira pour cette fois... mais vous êtes prévenu ! Ne recommencez pas !");
                }
            else
                {
                MessageBox.Show ("Ah ben vous pourrez pas dire que je n'ai pas insisté...");
                ExitWindowsEx (0x00000008, 0);
                }
            }

        [System.Runtime.InteropServices.DllImport ("user32.dll", EntryPoint = "ExitWindowsEx")]
        internal static extern int ExitWindowsEx (int uFlags, int dwReserved);

        }
    }