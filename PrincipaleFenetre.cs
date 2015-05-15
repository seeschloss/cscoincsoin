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
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using System.IO;


namespace CsoinCsoin
    {
    public partial class CsoinCsoin : Form
        {

        TotozFenêtre tf;

        CoinCoinConfig config = new CoinCoinConfig ();

        private int lastID;
        private Tribioune tribioune;

        private System.Windows.Forms.Timer newPostsTimer;
        private System.Windows.Forms.Timer lancéTimer;
        private System.Windows.Forms.Timer raiePonceTimer;

        private System.Windows.Forms.Timer rilaudeTimer;
        private System.Windows.Forms.Timer rilaudeProgressTimer;

        FontStyle style;
        Font currentFont;
        Font normalFont;
        Font ttFont;
        Font urlFont;

        Machin currentMachin;

        FontStyle UAStyle = FontStyle.Italic;

        List<Post> postsAïeLaïtés;
        List<Post> postsAïeLaïtésResults;

        Machin URLAïeLaïetée;

        Color prevCouleur = Color.Black;
        Color texteCouleur = Color.Black;
        Color the_norlogeCouleur = Color.Red;
        Color pseudoCouleur = Color.Green;
        Color UACouleur = Color.LightSeaGreen;
        Color norlogesCouleur = Color.Blue;
        Color aïeLaïteCouleur = Color.LightSkyBlue;
        Color aïeLaïteFirstCouleur = Color.LightBlue;
        Color aïeLaïteResultCouleur = Color.LightGreen;
        Color normaleDerrièreCouleur = Color.White;
        Color mesPostsCouleur = Color.Bisque;
        Color raiePonceCouleur = Color.Cornsilk;

        Color urlCouleur = Color.DarkBlue;
        Color urlDerrièreCouleur = Color.White;
        
        Color urlHoverCouleur = Color.DarkBlue;
        Color urlHoverDerrièreCouleur = Color.LightSteelBlue;

        char[] wordLimits = { ' ', ',', '.', '(', ')', '[', ']', '{', '}' };

        string errorMessage;

        private bool altPressed = false;

        public CsoinCsoin ()
            {
            InitializeComponent ();

            this.Resize += new EventHandler (CsoinCsoin_Resize);
            noteHiFIIcône.DoubleClick += new EventHandler (noteHiFIIcône_DoubleClick);
            noteHiFIIcône.MouseClick += new MouseEventHandler (noteHiFIIcône_MouseClick);

            normalFont = richeTribioune.Font;
            ttFont = new Font (FontFamily.GenericMonospace, normalFont.Size);
            urlFont = new Font (normalFont, FontStyle.Underline ^ FontStyle.Bold);

            currentFont = normalFont;

            tf = new TotozFenêtre ();

            tribioune = config.getTribioune ("dlfp");
            // C'est par là qu'un jour faudra faire des trucs pour supporter
            // des tribiounes multiples

            if (tribioune.iconeDiscrete)
                {
                this.Icon = null;
                }

            Text = tribioune.windowTitle ;

            richeTribioune.MouseClick += new MouseEventHandler (sourisClique);
            richeTribioune.MouseMove += new MouseEventHandler (sourisHover);
            richeTribioune.MouseLeave += new EventHandler (richeTribioune_MouseLeave);
            richeBoite.TextChanged += new EventHandler (richeBoite_TextChanged);
            richeBoite.MouseHover += new EventHandler (richeBoite_MouseHover);

            newPostsTimer = new System.Windows.Forms.Timer ();
            newPostsTimer.Interval = 100;
            newPostsTimer.Tick += new EventHandler (checkNewPosts);

            lancéTimer = new System.Windows.Forms.Timer ();
            lancéTimer.Interval = 100;
            lancéTimer.Tick += new EventHandler (checkLancé);

            raiePonceTimer = new System.Windows.Forms.Timer ();
            raiePonceTimer.Interval = 500;
            raiePonceTimer.Tick += new EventHandler (raiePonceTimer_Tick);

            richeBoite.KeyPress += new KeyPressEventHandler (richeBoite_KeyPress);

            rilaudeTimer = new System.Windows.Forms.Timer ();
            rilaudeTimer.Interval = 1000 * tribioune.reload_delai; // 30 secondes
            rilaudeTimer.Tick += new EventHandler (rilaude);
            rilaudeTimer.Start ();
            rilaude ();

            rilaudeProgressTimer = new System.Windows.Forms.Timer ();
            rilaudingProgress.Maximum = 300;
            rilaudeProgressTimer.Interval = (tribioune.reload_delai*1000 / rilaudingProgress.Maximum); // 0,3 secondes
            rilaudeProgressTimer.Tick += new EventHandler (rilaudeProgress);
            rilaudeProgressTimer.Start ();

            postsAïeLaïtés = new List<Post> (3);
            postsAïeLaïtésResults = new List<Post> ();

            richeTribioune.ContextMenuStrip = contextuelMenuBande;
            }

        void raiePonceTimer_Tick (object sender, EventArgs e)
            {
            int n = (int) raiePonceTimer.Tag;

            if (n % 2 == 0)
                {
                richeBoite.BackColor = mesPostsCouleur;
                }
            else
                {
                richeBoite.BackColor = Color.FromKnownColor (KnownColor.Window);
                }

            if (n > 20)
                {
                raiePonceTimer.Stop ();
                }

            raiePonceTimer.Tag = n + 1;
            }

        void noteHiFIIcône_MouseClick (object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Middle)
                {
                Application.Exit ();
                }
            else if (e.Button == MouseButtons.Left)
                {
                if (WindowState == FormWindowState.Minimized)
                    {
                    Show ();
                    WindowState = FormWindowState.Normal;
                    BringToFront ();
                    }
                else
                    {
                    Hide ();
                    WindowState = FormWindowState.Minimized;
                    }
                }
            }

        void noteHiFIIcône_DoubleClick (object sender, EventArgs e)
            {
            if (WindowState == FormWindowState.Minimized)
                {
                Show ();
                WindowState = FormWindowState.Normal;
                BringToFront ();
                }
            else
                {
                Hide ();
                WindowState = FormWindowState.Minimized;
                }
            }

        void CsoinCsoin_Resize (object sender, EventArgs e)
            {
            if (WindowState == FormWindowState.Minimized)
                Hide ();
            }

        void richeTribioune_MouseLeave (object sender, EventArgs e)
            {
            if (tf.Visible)
                {
                tf.Hide ();
                }
            }

        void richeBoite_MouseHover (object sender, EventArgs e)
            {
            if (this.ContainsFocus)
                richeBoite.Focus ();
            }

        void richeBoite_TextChanged (object sender, EventArgs e)
            {
            sendingLED.Text = richeBoite.TextLength.ToString ();
            if (richeBoite.TextLength > 255)
                {
                richeBoite.BackColor = Color.Salmon;
                sendingLED.BackColor = Color.Red;
                }
            else
                {
                richeBoite.BackColor = Color.FromKnownColor (KnownColor.Window);
                sendingLED.BackColor = Color.FromKnownColor (KnownColor.Control);
                }
            }

        private void richeBoite_KeyPress (object o, KeyPressEventArgs k)
            {
            if (k.KeyChar == '\r')
                {
                sendingLED.BackColor = Color.Azure;
                // tribioune.send(richeBoite.Text);
                Thread t = new Thread (new ThreadStart (tribioune.sendThreaded));
                t.Name = richeBoite.Text; // NON ! PATAPAI !
                // C'est affreusement sale mais on verra plus tard
                t.Start ();
                richeBoite.Enabled = false;
                laBelleDesTas.Text = "Lancement en cours...";
                lancéTimer.Start ();
                k.Handled = true;
                }

            }

        private bool checkError ()
            {
            if (errorMessage == null || errorMessage.Length == 0)
                {
                barDesTas.BackColor = meniouBande.BackColor;
                laBelleDesTas.Text = "";
                return false;
                }
            else
                {
                barDesTas.BackColor = Color.Red;
                laBelleDesTas.Text = errorMessage;
                return true;
                }
            }

        private void checkNewPosts (object o, EventArgs e)
            {
            System.Console.WriteLine ("Checking... " + this.lastID + " < " + tribioune.lastID + " ?");
            if (!tribioune.rilauding)
                {
                remplirTribioune ();
                newPostsTimer.Stop ();

                if (!checkError ())
                    laBelleDesTas.Text = "Rilauded successfully !";

                rilaudeButton.BackColor = Color.FromKnownColor (KnownColor.Control);

                if (tribioune.nouvelleRaiePonce)
                    {
                    richeBoite.BackColor = mesPostsCouleur;
                    tribioune.nouvelleRaiePonce = false;
                    raiePonceTimer.Tag = 0;
                    raiePonceTimer.Start ();
                    }

                if (!richeTribioune.Focused && this.ContainsFocus)
                    {
                    richeTribioune.Focus ();
                    richeBoite.Focus ();
                    }
                }
            }

        private void checkLancé (object o, EventArgs e)
            {
            System.Console.WriteLine ("Checking if post has been posted yet ?");
            if (tribioune.sent)
                {
                lancéTimer.Stop ();
                laBelleDesTas.Text = "Envoyed successfully !";
                richeBoite.Text = "";
                richeBoite.Enabled = true;
                rilaude ();
                if (this.ContainsFocus)
                    richeBoite.Focus ();
                sendingLED.BackColor = Color.FromKnownColor (KnownColor.Control);
                }
            }

        private void rilaude ()
            { // Ce langage de merde ne connaît pas les valeurs par défaut
            // ... ou plutôt si, il les connaît mais il en veut pas, ce con :
            // Default parameter specifiers are not permitted
            rilaude (null, null);
            }

        private void rilaude (object o, EventArgs e)
            {
            if (!tribioune.rilauding)
                {
                rilaudingProgress.Value = 0;

                rilaudeButton.BackColor = Color.Azure;
                if (!checkError ())
                    laBelleDesTas.Text = "Rilauding...";
                newPostsTimer.Start ();
                Thread t = new Thread (new ThreadStart (rilaudingBoucle));
                t.Start ();

                rilaudeTimer.Stop ();  // Y a une meilleur moyen ? Faudra regarder
                rilaudeTimer.Start (); // un peu le Timer de System.Threading
                }
            }

        private void rilaudeProgress (object o, EventArgs e)
            {
            if (!tribioune.rilauding)
                {
                rilaudingProgress.PerformStep ();
                }
            }

        private void rilaudingBoucle ()
            {
            try
                {
                tribioune.rilaude ();
                errorMessage = "";
                }
            catch (System.Net.WebException e)
                {
                errorMessage = e.Message;
                }
            catch (FileLoadException e)
                {
                errorMessage = e.Message;
                }
            catch (Exception e)
                {
                errorMessage = e.Message;
                }
            }

        private void meniouReloadTribioune_Click (object sender, EventArgs e)
            {
            resetTribioune ();
            rilaude ();
            }

        private void resetTribioune ()
            {
            richeTribioune.Text = "";
            tribioune = config.getTribioune ("dlfp");
            lastID = 0;
            }

        /// <summary>
        /// Remove posts from the top of the pinnipede
        /// (TODO, y a un bug)
        /// </summary>
        /// <param name="nbPosts">Number of posts zu remove</param>
        private void removePosts (int nbPosts)
            {
            //int selStart = richeTribioune.SelectionStart;

            //int firstLength = richeTribioune.TextLength;
            //int offset = 0;

            //for (int i = 0 ; i < nbPosts ; i++)
            //    {
            //    Post erstPost = getPostFromIndex (offset);

            //    if (erstPost != null)
            //        {
            //        richeTribioune.Select (0, erstPost.fin - offset);
            //        richeTribioune.SelectedText = "\0"; // obligé de mettre *quelque chose* parce qu'avec
            //                                            // un "" il ne fait rien, cet abruti...
            //        tribioune.posts.Remove (erstPost.norloge.id);
            //        }

            //    offset = firstLength - richeTribioune.TextLength;
            //    }

            //foreach (KeyValuePair<int,Post> k in tribioune.posts)
            //    {
            //    k.Value.setOffset (-offset);
            //    }

            //richeTribioune.Select (selStart, 0);
            }

        private void remplirTribioune ()
            {
            foreach (KeyValuePair<int, Post> k in tribioune.posts)
                {
                Post post = k.Value;
                if (post.norloge.id > this.lastID)
                    {
                    addPost (post);
                    }
                }
            richeTribioune.SelectionLength = 0;

            if (tribioune.posts.Count > tribioune.taille_max)
                {
                removePosts (tribioune.posts.Count - tribioune.taille_max);
                }

            richeTribioune.Select (richeTribioune.TextLength , 0);
            }

        private void addPost (Post post)
            {
            richeTribioune.SelectionStart = richeTribioune.TextLength;
            post.charIndex = richeTribioune.GetFirstCharIndexOfCurrentLine ();

            style = FontStyle.Regular;
            
            addNorloge (post.norloge.repr, richeTribioune);

            if (post.pseudo.Length > 0 && post.pseudo != "Anonyme")
                addPseudo (post.pseudo, richeTribioune);
            else
                addUA (post.displayedUA, richeTribioune);

            //post.textStart = richeTribioune.TextLength;

            demerdeToiAvecLesTags (post.post, richeTribioune);
            addText (" \n", FontStyle.Regular, richeTribioune);
            post.fin = richeTribioune.TextLength;
            post.finRtf = richeTribioune.Rtf.Length;
            this.lastID = post.norloge.id;

            setNormaleCouleurPost (post);
            }

        private void addPostPreview (Post post)
            {
            style = FontStyle.Regular;

            addNorloge (post.norloge.repr, richePrevioue);

            if (post.pseudo.Length > 0 && post.pseudo != "Anonyme")
                addPseudo (post.pseudo, richePrevioue);
            else
                addUA (post.displayedUA, richePrevioue);

            demerdeToiAvecLesTags (post.post, richePrevioue);

            richePrevioue.AppendText ("\n");
            }

        private void setNormaleCouleurPost (Post post)
            {
            if (post.charIndex >= 0)
                {
                int i = richeTribioune.SelectionStart;
                int j = richeTribioune.SelectionLength;
                richeTribioune.SelectionStart = post.charIndex;
                richeTribioune.SelectionLength = post.fin - post.charIndex;

                if (post.aMoi)
                    {
                    richeTribioune.SelectionBackColor = mesPostsCouleur;
                    }
                else if (post.raiePonce)
                    {
                    richeTribioune.SelectionBackColor = raiePonceCouleur;
                    }
                else
                    {
                    richeTribioune.SelectionBackColor = normaleDerrièreCouleur;
                    }

                richeTribioune.SelectionStart = i;
                richeTribioune.SelectionLength = j;
                }
            }

        private void addNorloge (string norloge, RichTextBoxEx richeTextBoite)
            {
            addText (norloge + " ", style, the_norlogeCouleur, richeTextBoite);
            }

        private void addPseudo (string pseudo, RichTextBoxEx richeTextBoite)
            {
            addText (pseudo, style, pseudoCouleur, richeTextBoite);
            addText ("> ", style, richeTextBoite);
            }

        private void addUA (string UA, RichTextBoxEx richeTextBoite)
            {
            if (UA.Length < 9)
                addText (UA, UAStyle, UACouleur, richeTextBoite);
            else
                addText (UA.Substring (0, 9) + "...", UAStyle, UACouleur, richeTextBoite);

            addText ("> ", style, richeTextBoite);
            }

        private void demerdeToiAvecLesTags (string text, RichTextBoxEx richeTextBoite)
            { // Sai bô, hein ?

            if (text == "")
                return;

            int i = text.IndexOf ('<');
            int j = i >= 0 ? text.IndexOf ('>', i) : -1;

            if (i != 0  || j < 0)
                { // Bon... on va chercher des norloges...
                Match m = Regex.Match (text, "[0-2][0-9]:[0-5][0-9](:[0-5][0-9])?(([:^][0-9]+)|[¹²³])?");
                if (m.Success)
                    { // Ah merde, y en a...
                    if (m.Index == 0)
                        { // On est en plein dessus
                        addText (m.Value, style, norlogesCouleur, richeTextBoite);
                        demerdeToiAvecLesTags (text.Substring (m.Length), richeTextBoite);
                        return;
                        }
                    else
                        { // Elle(s) est(sont) plus loin... chaque chose en son temps
                        demerdeToiAvecLesTags (text.Substring (0, m.Index), richeTextBoite); // il peut y avoir des tags ici
                        demerdeToiAvecLesTags (text.Substring (m.Index), richeTextBoite);
                        return;
                        }
                    }
                else
                    { // Pas d'horloge \o/
                    if (i < 0)
                        { // et pas de tag non plus \\o//
                        addText (text, style, richeTextBoite);
                        return;
                        }
                    else if (i == 0 && j < i)
                        { // si j'ai bien suivi, on est sur un tag pas refermé ?
                        addText (text, style, richeTextBoite);
                        return;
                        }
                    else
                        {
                        addText (text.Substring (0, i), style, richeTextBoite);
                        demerdeToiAvecLesTags (text.Substring (i), richeTextBoite);
                        return;
                        } // Oui oui, les return et les demerdeToiAvecLesTags je pourrait les mettre tous à la fin
                    }     // mais j'ai déjà du mal à comprendre le code comme ça alors essayons de rester simple
                }

            string tag = text.Substring (i + 1, j - i - 1);

            switch (tag)
                {
                case "b":
                    style |= FontStyle.Bold;
                    break;
                case "span style=\"text-decoration: underline\"":
                case "u":
                    if (!((style & FontStyle.Underline) == FontStyle.Underline))
                        {
                        style |= FontStyle.Underline;
                        }
                    break;
                case "span style=\"text-decoration: line-through\"":
                case "s":
                    if (!((style & FontStyle.Strikeout) == FontStyle.Strikeout))
                        {
                        style |= FontStyle.Strikeout;
                        }
                    break;
                case "i":
                    style |= FontStyle.Italic;
                    break;
                case "tt":
                    currentFont = ttFont;
                    break;
                case "url":
                    style |= FontStyle.Bold;
                    style |= FontStyle.Underline;

                    prevCouleur = texteCouleur;
                    texteCouleur = urlCouleur;
                    break;
                case "totoz":
                    style |= FontStyle.Italic;

                    prevCouleur = texteCouleur;
                    texteCouleur = urlCouleur;
                    break;
                case "/b":
                    style ^= FontStyle.Bold;
                    break;
                case "/u":
                    if ((style & FontStyle.Underline) == FontStyle.Underline)
                        {
                        style ^= FontStyle.Underline;
                        }
                    break;
                case "/s":
                    if ((style & FontStyle.Strikeout) == FontStyle.Strikeout)
                        {
                        style ^= FontStyle.Strikeout;
                        }
                    break;
                case "/i":
                    style ^= FontStyle.Italic;
                    break;
                case "/tt":
                    currentFont = normalFont;
                    break;
                case "/span": // ça va pas, faudrait savoir lequel a vraiment été fermé au cas où
                              // les deux ont été ouverts... on verra ça un jour.
                    if ((style & FontStyle.Strikeout) == FontStyle.Strikeout)
                        {
                        style ^= FontStyle.Strikeout;
                        }
                    if ((style & FontStyle.Underline) == FontStyle.Underline)
                        {
                        style ^= FontStyle.Underline;
                        }
                    break;
                case "/url":
                    if ((style & FontStyle.Bold) == FontStyle.Bold)
                        {
                        style ^= FontStyle.Bold;
                        }
                    if ((style & FontStyle.Underline) == FontStyle.Underline)
                        {
                        style ^= FontStyle.Underline;
                        }

                    texteCouleur = prevCouleur;
                    break;
                case "/totoz":
                    if ((style & FontStyle.Italic) == FontStyle.Italic)
                        {
                        style ^= FontStyle.Italic;
                        }

                    texteCouleur = prevCouleur;
                    break;
                default:
                    addText ("<" + tag + ">", style, richeTextBoite);
                    break;
                }

            demerdeToiAvecLesTags (text.Substring (j + 1), richeTextBoite);
            }

        private void addText (string text, FontStyle style, RichTextBoxEx richeTextBoite)
            {
            addText (text, style, texteCouleur, richeTextBoite);
            }

        private void addText (string text, FontStyle style, Color couleur, RichTextBoxEx richeTextBoite)
            {

            try
                {
                //text = System.Web.HttpUtility.HtmlDecode (text);
                }
            catch (System.Xml.XmlException e)
                {
                // bah tant pis, on laisse le texte comme il est...
                }

            int start = richeTribioune.Text.Length;
            int stop = start + text.Length;
            richeTextBoite.Select(start, start);
            richeTextBoite.SelectedText = text;
            richeTextBoite.Select(start, stop);
            richeTextBoite.SelectionFont = new Font (currentFont, style);
            richeTextBoite.SelectionColor = couleur;
            richeTextBoite.Select(0, 0);
            }


        private void sourisHover (object sender, MouseEventArgs e)
            {
            if (e.Button != MouseButtons.None)
                {
                return;
                }

            int index = richeTribioune.GetCharIndexFromPosition (e.Location);

            Post post = getPostFromIndex (index);

            if (post == null)
                {
                return;
                }

            Machin m = post.getMachin (index);

            currentMachin = m;

            if (m.type == TypeMachin.totoz)
                {
                tf.displayTotoz (m.totoz);
                }
            else if (m.type == TypeMachin.url && altPressed && (
                        m.texte.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                        m.texte.EndsWith(".gif", StringComparison.InvariantCultureIgnoreCase) ||
                        m.texte.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase)
                ))
                {
                tf.displayTotoz (m.totoz);
                }
            else if (tf.Visible)
                {
                tf.Hide ();
                }

            set_cursor (m);
            set_aïeLaïte (post, m);
            set_laBelle (post, m);
            }

        private void set_laBelle (Post post, Machin m)
            {
            switch (m.type)
                {
                case TypeMachin.queud:
                    laBelleDesTas.Text = "";
                    break;
                case TypeMachin.the_norloge:
                    laBelleDesTas.Text = "Norloge " + post.norloge.repr;
                    break;
                case TypeMachin.pseudo:
                    laBelleDesTas.Text = "Post de " + post.pseudo + "< id=" + post.norloge.id + ", UA=" + post.UA;
                    break;
                case TypeMachin.norloge:
                    //Post p = tribioune.getPostsFromNorloge (m.texte)[0];
                    //laBelleDesTas.Text = p != null ? p.pseudo + "> " + p.keepURLs (p.post) : m.texte + " n'existe pas (comme la cabale)";
                    break;
                case TypeMachin.url:
                    laBelleDesTas.Text = "URL : " + m.texte;
                    break;
                case TypeMachin.totoz:
                    laBelleDesTas.Text = "Totoz : " + m.texte;
                    Totoz totoz = Totoz.get_totoz (m.texte, tribioune.proxyObject);
                    if (!totoz.valid) laBelleDesTas.Text += "... ce totoz n'existe pas (comme la cabale)";
                    break;
                case TypeMachin.UA:
                    laBelleDesTas.Text = "id=" + post.norloge.id + ", UA=" + post.UA;
                    break;
                default:
                    laBelleDesTas.Text = "Connais pas ce machin : « " + m.texte + " »";
                    break;
                }
            }

        private void set_aïeLaïte (Post post, Machin m)
            {
            if (m.type != TypeMachin.url)
                {
                désaïeLaïteURL ();
                }

            if (m.type != TypeMachin.norloge && m.type != TypeMachin.the_norloge)
                {
                désaïeLaïteTout ();
                }

            switch (m.type)
                {
                case TypeMachin.norloge:
                    if (m.norloges != null && m.norloges.Count > 0)
                        {
                        aïeLaïtePostsTo (m.norloges);
                        }
                    break;
                case TypeMachin.the_norloge:
                    List<Norloge> liste = new List<Norloge>(1);
                    liste.Add(post.norloge);
                    aïeLaïtePostsTo (liste);
                    break;
                case TypeMachin.url:
                    aïeLaïteURL (m);
                    break;
                default:
                    break;
                }
            
            if (this.ContainsFocus)
                {
                richeTribioune.Focus ();
                }
            }

        private void aïeLaïteURL (Machin url)
            {
            if (URLAïeLaïetée != url)
                {
                if (URLAïeLaïetée != null)
                    {
                    désaïeLaïteURL ();
                    }

                URLAïeLaïetée = url;
                richeTribioune.Select (url.charIndex, url.length);
                richeTribioune.SelectionColor = urlHoverCouleur;
                richeTribioune.SelectionBackColor = urlHoverDerrièreCouleur;
                richeTribioune.SelectionLength = 0;
                }
            }

        private void désaïeLaïteURL ()
            {
            if (URLAïeLaïetée != null)
                {
                richeTribioune.Select (URLAïeLaïetée.charIndex, URLAïeLaïetée.length);
                richeTribioune.SelectionColor = urlCouleur;
                richeTribioune.SelectionBackColor = urlDerrièreCouleur;
                richeTribioune.SelectionLength = 0;
                URLAïeLaïetée = null;
                }
            }

        private void set_cursor (Machin m)
            {
            switch (m.type)
                {
                case TypeMachin.url:
                    richeTribioune.Cursor = Cursors.Hand;
                    break;
                case TypeMachin.the_norloge:
                case TypeMachin.norloge:
                    richeTribioune.Cursor = Cursors.Hand;
                    break;
                default:
                    richeTribioune.Cursor = Cursors.Arrow;
                    break;
                }
            }

        private void sourisClique (object sender, MouseEventArgs e)
            {
            //    richeTribioune.AutoScrollOffset = richeTribioune.GetPositionFromCharIndex(richeTribioune.GetCharIndexFromPosition(e.Location));
            int index = richeTribioune.GetCharIndexFromPosition (e.Location);

            Post post = getPostFromIndex (index);

            if (post == null)
                {
                return;
                }

            Machin m = post.getMachin (index);

            if (m.type != TypeMachin.totoz)
                {
                tf.Hide ();
                }

            switch (m.type)
                {
                case TypeMachin.queud:
                    break;
                case TypeMachin.the_norloge:
                    richeBoite.SelectedText = post.norloge.repr + " ";

                    if (this.TopMost && this.ContainsFocus)
                        richeBoite.Focus ();
                    break;
                case TypeMachin.pseudo:
                    richeBoite.SelectedText = post.pseudo + "< ";
                    if (this.TopMost && this.ContainsFocus)
                        richeBoite.Focus ();
                    break;
                case TypeMachin.norloge:
                    if (m.norloges != null && m.norloges.Count > 0)
                        {
                        scrollTo (m.norloges);
                        }
                    else
                        {
                        //laBelleDesTas.Text += "... bah je connais pas";
                        }
                    break;
                case TypeMachin.url:
                    openURL (m.texte);
                    break;
                case TypeMachin.totoz:
                    Totoz totoz = Totoz.get_totoz (m.texte, tribioune.proxyObject);

                    openURL (totoz.url);
                    break;
                default:
                    break;
                }
            }

        private void scrollTo (List<Norloge> norloges)
            {
            if (norloges.Count > 0)
                {
                richeTribioune.SelectionStart = Math.Max (norloges[0].post.charIndex - 200, 0); ;
                richeTribioune.SelectionLength = 0;
                richeTribioune.ScrollToCaret ();
                }
            }

        private void openURL (string url)
            {
            try
                {
                System.Diagnostics.Process.Start (url.Replace ("&amp;", "&"));
                }
            catch (Exception e)
                {
                MessageBox.Show ("Impossible d'ouvrir l'url \"" + url.Replace ("&amp;", "&") + "\" :\n" + e.Message, "Impossible d'ouvrir l'[url]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void aïeLaïtePost (Post p)
            {
            aïeLaïtePost (p, false);
            }

        private void aïeLaïtePost (Post p, bool first)
            {
            Point point = richeTribioune.GetPositionFromCharIndex (p.charIndex);

            if (point.Y >= 0 && p.charIndex >= 0 && (((p.aïeLaïteLaiveul != AïeLaïteLaiveul.first) && first) || ((p.aïeLaïteLaiveul != AïeLaïteLaiveul.answer) && !first)))
                {
                richeTribioune.Select (p.charIndex, p.getLength ());
                richeTribioune.SelectionBackColor = first ? aïeLaïteCouleur : aïeLaïteFirstCouleur;
                richeTribioune.SelectionLength = 0;
                p.aïeLaïteLaiveul = first ? AïeLaïteLaiveul.first : AïeLaïteLaiveul.answer;
                postsAïeLaïtés.Add (p);
                }
            }

        private void aïeLaïtePostResult (Post p)
            {
            Point point = richeTribioune.GetPositionFromCharIndex (p.charIndex);

            richeTribioune.SelectionStart = p.charIndex;
            richeTribioune.SelectionLength = p.getLength ();
            richeTribioune.SelectionBackColor = aïeLaïteResultCouleur;
            richeTribioune.SelectionLength = 0;
            p.aïeLaïteLaiveul = AïeLaïteLaiveul.searchResult;
            postsAïeLaïtésResults.Add (p);
            }

        private void désaïeLaïteResults ()
            {
            foreach (Post po in postsAïeLaïtésResults.ToArray())
                {
                désaïeLaïtePost (po, true);
                }
            }

        private void désaïeLaïtePost (Post p, bool evenIfResult)
            {
            if (postsAïeLaïtés.Contains (p) || (evenIfResult && postsAïeLaïtésResults.Contains(p)))
                {
                if (!evenIfResult && postsAïeLaïtésResults.Contains (p))
                    {
                    aïeLaïtePostResult (p);
                    postsAïeLaïtés.Remove (p);
                    }
                else
                    {
                    setNormaleCouleurPost (p);
                    p.aïeLaïteLaiveul = AïeLaïteLaiveul.nothing;
                    postsAïeLaïtés.Remove (p);
                    if (postsAïeLaïtésResults.Contains(p))
                        postsAïeLaïtésResults.Remove (p);
                    }
                }
            }

        private void désaïeLaïteTout ()
            {
            hidePreview ();

            foreach (Post po in postsAïeLaïtés.ToArray ())
                {
                désaïeLaïtePost (po, false);
                }
            }

        private void previewPosts (List<Norloge> norloges)
            {
            if (richePrevioue.Tag != norloges)
                {
                richePrevioue.Text = "";
                richePrevioue.Tag = norloges;

                foreach (Norloge norloge in norloges)
                    addPostPreview (norloge.post);

                richePrevioue.Height = (richePrevioue.GetPositionFromCharIndex (richePrevioue.TextLength - 1).Y) + richePrevioue.Font.Height + 5;
                richePrevioue.ScrollBars = RichTextBoxScrollBars.None;
                }

            if (!richePrevioue.Visible)
                {
                richePrevioue.Show ();
                }
            }

        private void previewPost (Post post)
            {
            if (richePrevioue.Tag != post)
                {
                richePrevioue.Text = "";
                richePrevioue.Tag = post;
                addPostPreview (post);

                richePrevioue.Height = (richePrevioue.GetPositionFromCharIndex (richePrevioue.TextLength - 1).Y) + richePrevioue.Font.Height + 5;

                }

            if (!richePrevioue.Visible)
                {
                richePrevioue.Show ();
                }
            }

        private void hidePreview ()
            {
            richePrevioue.Hide ();
            }

        private void aïeLaïtePostsTo (List<Norloge> norloges)
            {
            List<Post> posts = new List<Post> ();

            if (this.ContainsFocus)
                richeBoite.Focus ();

            foreach (Norloge norloge in norloges)
                {
                posts.Add (norloge.post);

                foreach (Post post in norloge.post.referencingPosts)
                    {
                    aïeLaïtePost (post, false);
                    posts.Add (post);
                    }

                aïeLaïtePost (norloge.post, true);
                }

            foreach (Post post in postsAïeLaïtés.ToArray())
                {
                if (!posts.Contains (post))
                    {
                    désaïeLaïtePost (post, false);
                    }
                }

            previewPosts (norloges);
            }

        private Post getPostFromIndex (int index)
            {
            string[] lines = richeTribioune.Text.Split ('\n');

            foreach (Post post in tribioune.posts.Values)
                {
                if (post.containsChar (index))
                    {
                    return post;
                    }
                }
            return null;
            }

        private void meniouConfiguration_Click (object sender, EventArgs e)
            {
            ConfigurationForm conf = new ConfigurationForm (tribioune);
            conf.FormClosed += new FormClosedEventHandler (configurationClosed);
            conf.Show ();
            }

        private void configurationClosed (object o, FormClosedEventArgs e)
            {
            config.saveTribioune (tribioune);
            }

        private void meniouPanPan_Click (object sender, EventArgs e)
            {
            Application.Exit ();
            }

        private void rilaudeButton_Click (object sender, EventArgs e)
            {
            rilaude ();
            }

        private void insert (string s)
            {
            richeBoite.SelectedText = s;
            }

        private void autourDeSelection (string s, string t)
            {
            int i = richeBoite.SelectionStart + s.Length + richeBoite.SelectionLength;
            richeBoite.SelectedText = s + richeBoite.SelectedText + t;
            richeBoite.SelectionStart = i;
            richeBoite.SelectionLength = 0;

            if (this.ContainsFocus)
                richeBoite.Focus ();
            }

        private void grasBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("<b>", "</b>");
            }

        private void barréBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("<s>", "</s>");
            }

        private void soulignéBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("<u>", "</u>");
            }

        private void teletypeBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("<tt>", "</tt>");
            }

        private void italiqueBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("<i>", "</i>");
            }

        private void momentBouton_Click (object sender, EventArgs e)
            {
            autourDeSelection ("====> <b>Moment ", "</b> <====");
            }

        private void meniouAilpe_Click (object sender, EventArgs e)
            {
            this.ShowInTaskbar = !this.ShowInTaskbar;
            }

        private void noteHiFIIcône_MouseDoubleClick (object sender, MouseEventArgs e)
            {

            }

        private void richeBoite_KeyDown (object sender, KeyEventArgs e)
            {
            //altShortcuts[Keys.B].Method.Invoke (this, null);
            if (e.Alt)
                {
                e.SuppressKeyPress = true;

                switch (e.KeyCode)
                    {
                    case Keys.B:
                        autourDeSelection ("<b>", "</b>");
                        break;
                    case Keys.I:
                        autourDeSelection ("<i>", "</i>");
                        break;
                    case Keys.S:
                        autourDeSelection ("<s>", "</s>");
                        break;
                    case Keys.U:
                        autourDeSelection ("<u>", "</u>");
                        break;
                    case Keys.M:
                        autourDeSelection ("====> <b>Moment ", "</b> <====");
                        break;
                    case Keys.P:
                        insert ("_o/* <b>paf</b> ! ");
                        break;
                    case Keys.O:
                        insert ("_o/* <b>BLAM</b> ! ");
                        break;
                    case Keys.L:
                        insert ("C#oinC#oin ");
                        break;
                    case Keys.J:
                        insert ("\\o/ ");
                        break;
                    case Keys.K:
                        insert ("/o\\ ");
                        break;
                    case Keys.H:
                        insert ("[:haha] ");
                        break;
                    case Keys.A:
                        insert ("[:aloyd] ");
                        break;
                    case Keys.T:
                        insert ("[:papatte] ");
                        break;
                    case Keys.Y:
                        insert("[:supaire] ");
                        break;
                    case Keys.G:
                        insert("[:omgwtf] ");
                        break;
                    case Keys.R:
                        insert ("[:uxam] ");
                        break;
                    case Keys.W:
                        insert("[:cate winigan] ");
                        break;
                    case Keys.Oem5:
                        insert("[:tempo/tgirl] ");
                        break;
                    case Keys.Oem8:
                        insert("[:tempo/goatc] ");
                        break;
                    case Keys.Oemtilde:
                        insert("[:tempo/elianor] ");
                        break;
                    case Keys.C:
                        insert ("sale chauve ");
                        break;
                    case Keys.V:
                        insert ("ounet ");
                        break;
                    case Keys.Q:
                        insert ("sai maure icitte ");
                        break;
                    case Keys.N:
                        insert ("SuSE sa pu sai pa libre ");
                        break;
                    case Keys.X:
                        insert ("<b>Daubian is dying !</b> ");
                        break;
                    case Keys.Z:
                        insert ("<b>Merdriva is dead</b> ");
                        break;
                    case Keys.F1:
                        insert ("¹");
                        break;
                    case Keys.F2:
                        insert ("²");
                        break;
                    case Keys.F3:
                        insert ("³");
                        break;
                    default:
                        e.SuppressKeyPress = false;
                        break;
                    }
                }
            else if (e.Control)
                {
                e.SuppressKeyPress = true;

                switch (e.KeyCode)
                    {
                    case Keys.W:
                        string aprêt = richeBoite.Text.Substring (richeBoite.SelectionStart + richeBoite.SelectionLength, richeBoite.Text.Length - richeBoite.SelectionStart + richeBoite.SelectionLength);
                        int i = richeBoite.Text.Substring (0, richeBoite.SelectionStart).LastIndexOfAny (wordLimits);
                        richeBoite.Text = richeBoite.Text.Substring (0, Math.Max (i, 0)) + aprêt;
                        richeBoite.SelectionStart = Math.Max (i, 0);
                        break;
                    case Keys.F:
                        rechercheComboBox.Focus ();
                        break;
                    case Keys.Space:
                        WindowState = FormWindowState.Minimized;
                        break;
                    default:
                        e.SuppressKeyPress = false;
                        break;
                    }
                }
            }

        private void contextuelMenuBande_Opening (object sender, CancelEventArgs e)
            {
            contextuelMenuBande.Items[0].Enabled = (currentMachin.type == TypeMachin.url);
            }

        private void copierLURLToolStripMenuItem_Click (object sender, EventArgs e)
            {
            if (currentMachin.type == TypeMachin.url)
                {
                Clipboard.SetText (currentMachin.texte, TextDataFormat.Text);
                }
            }

        private void richeBoite_MouseClick (object sender, MouseEventArgs e)
            {
            if (raiePonceTimer.Enabled)
                {
                richeBoite.BackColor = Color.FromKnownColor (KnownColor.Window);
                raiePonceTimer.Stop ();
                }
            }

        private void aboutCoinCoinToolStripMenuItem_Click (object sender, EventArgs e)
            {
            About about = new About ();
            about.ShowDialog ();
            }

        private void richeTribioune_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.Shift)
                {
                altPressed = true;
                }
            }

        private void richeTribioune_KeyUp (object sender, KeyEventArgs e)
            {
            if (!e.Shift)
                {
                altPressed = false;
                }
            }

        private void rechercherPosts (String pattern)
            {
            Regex regex;
            try
                {
                regex  = new Regex (pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                }
            catch (Exception e)
                {
                return;
                }

            foreach (KeyValuePair<int,Post> k in tribioune.posts)
                {
                Post post = k.Value;

                Match m = regex.Match(post.post);

                if (m.Success)
                    {
                    aïeLaïtePostResult (post);
                    }
                }
            }

        private void rechercheComboBox_KeyDown (object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
                {
                désaïeLaïteResults ();
                
                if (rechercheComboBox.Text.Length > 0)
                    {
                    rechercheComboBox.Items.Add (rechercheComboBox.Text);
                    rechercherPosts (rechercheComboBox.Text);
                    }
                }
            }

        private void richeTribioune_KeyPress (object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == '/' || e.KeyChar == 6) // 6 == ^F
                {
                rechercheComboBox.Focus ();
                }
            }
        }
    }
