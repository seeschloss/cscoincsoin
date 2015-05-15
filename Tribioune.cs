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
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Threading;
using System.Text.RegularExpressions;
using System.Web;
using System.Collections;

namespace CsoinCsoin
    {
    enum slipType
        {
        tags_encodés,       // Comme DLFP
        tags_non_encodés    // Comme tout le reste...
        }

    class Tribioune
        {
        public String name;
        public String coukie;
        public bool UTF;
        public slipType slip;
        public String serveur;
        public String derrièreEnd;
        public String postURL;
        public String formatPost;
        public String userAgent;

        public String proxy;
        public String proxyUser;
        public String proxyPass;

        public WebProxy proxyObject;

        public String windowTitle;
        public bool iconeDiscrete;

        public String username;

        public int reload_delai;
        public int taille_max;

        public bool nouvelleRaiePonce = false;


        public int lastID = 0;

        public bool rilauding = false, sent = true;

        XmlDocument contenu;

        public Dictionary<int, Post> posts;

        public Dictionary<string, List<Norloge>> norloges;

        public Tribioune ()
            {
            posts = new Dictionary<int, Post> ();
            norloges = new Dictionary<string, List<Norloge>> ();
            }

        public Tribioune (
            String name,
            String serveur,
            String derrièreEnd,
            String postURL,
            String formatPost,
            String coukie,
            String userAgent,
            int reload_delai,
            int taille_max,
            bool UTF,
            slipType slip,
            String pseudo,
            String proxy,
            String proxyUser,
            String proxyPass,
            String windowTitle,
            bool iconeDiscrete)
            {
            this.name = name;
            this.serveur = serveur;
            this.derrièreEnd = derrièreEnd;
            this.postURL = postURL;
            this.formatPost = formatPost;
            this.coukie = coukie;
            this.userAgent = userAgent;
            this.reload_delai = reload_delai;
            this.taille_max = taille_max;
            this.UTF = UTF;
            this.slip = slip;
            this.username = pseudo;
            this.proxy = proxy;
            this.proxyUser = proxyUser;
            this.proxyPass = proxyPass;
            this.windowTitle = windowTitle.Replace("%t", name);
            this.iconeDiscrete = iconeDiscrete;

            posts = new Dictionary<int, Post> ();
            norloges = new Dictionary<string, List<Norloge>> ();

            updateProxy ();
            }

        public void updateProxy ()
            {
            if (proxy.Length > 0)
                {
                proxyObject = new WebProxy(proxy);

                if (proxyUser.Length > 0 && proxyPass.Length > 0)
                    {
                    proxyObject.Credentials = new NetworkCredential(proxyUser, proxyPass);
                    }
                }
            else
                {
                proxyObject = null;
                }
            }

        public void rilaude ()
            {
            bool webOK = true;
            bool parseOK = true;
            rilauding = true;
            webOK = loadTribioune ();

            if (webOK)
                parseOK = parse ();

            rilauding = false;

            if (!webOK)
                {
                throw new WebException ("Impossible de télécharger le backend");
                }
            else if (!parseOK)
                {
                throw new FileLoadException ("Impossible de parser le backend");
                }
            }

        /// <summary>
        /// Télécharge le backend
        /// </summary>
        /// <returns>Réussite de l'opération</returns>
        public bool loadTribioune ()
            {
            contenu = new XmlDocument ();
            string uri = "http://" + serveur + derrièreEnd;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create (uri);
            req.UserAgent = "C#oinC#oin/" + Program.VERSION;

            if (proxyObject != null)
                {
                req.Proxy = proxyObject;
                }

            Stream restream;
            HttpWebResponse res;

            try
                {
                res = (HttpWebResponse) req.GetResponse ();
                restream = res.GetResponseStream ();

                StreamReader sr = new StreamReader (restream, this.UTF ? Encoding.UTF8 : Encoding.GetEncoding("ISO-8859-15"));

                string text = "";

                foreach (char c in sr.ReadToEnd ())
                    {
                    if (char.IsControl (c) && c != '\n' && c != '\t')
                        {
                        text += "&#" + ((int) c).ToString () + ";";
                        }
                    else
                        {
                        text += c;
                        }
                    }

                contenu.LoadXml (text);
                }
            catch (Exception e)
                {
                return false;
                }

            return true;
            }

        public void sendThreaded ()
            {
            try
                {
                send (Thread.CurrentThread.Name); //o\\
                }
            catch (Exception e)
                {
                sent = true; // :-/
                System.Console.WriteLine ("Exception while sending post: " + e.Message);
                }
            }

        public List<Post> getPostsFromNorloge (string repr)
            {
            List<Post> liste = new List<Post> (1);

            if (norloges.ContainsKey (repr))
                {
                foreach (Norloge n in norloges[repr])
                    {
                    liste.Add (n.post);
                    }
                }

            return liste;
            }

        public void send (string text)
            {
            sent = false;

            int i = 0;

            byte[] t;
            if (!UTF)
                {
                for (i = 0 ; i < text.Length ; i++)
                    {
                    if (text[i] > 0x00FF)
                        {
                        String representation = "&#" + ((int) text[i]).ToString () + ";";

                        text = text.Substring (0, i) + representation + text.Substring (i + 1);
                        }
                    }

                //t = Encoding.ASCII.GetBytes (text);
                t = Encoding.Convert (Encoding.UTF8, Encoding.GetEncoding ("iso-8859-1"), Encoding.UTF8.GetBytes (text));
                }
            else
                {
                t = Encoding.UTF8.GetBytes (text);
                }

            text = HttpUtility.UrlEncode (t);
            text = formatPost.Replace ("%m", text);
            byte[] postData = Encoding.ASCII.GetBytes (text);

            string uri = "http://" + serveur + postURL;

            System.Net.ServicePointManager.Expect100Continue = false;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create (uri);
            req.UserAgent = userAgent.Replace ("%v", Program.VERSION);
            req.Headers.Add ("Cookie", coukie);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = postData.Length;
            req.Referer = uri;
            req.KeepAlive = false;

            if (proxyObject != null)
                {
                req.Proxy = proxyObject;
                }

            Stream stream = req.GetRequestStream ();
            stream.Write (postData, 0, postData.Length);
            stream.Close ();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse ();
            Stream restream = res.GetResponseStream ();

            StringBuilder sb = new StringBuilder ();
            string s;
            byte[] boeuf = new byte[8192];
            i = 0;
            do
                {
                i = restream.Read (boeuf, 0, boeuf.Length);

                if (i != 0)
                    {
                    s = Encoding.UTF8.GetString (boeuf, 0, i);

                    sb.Append (s);
                    }
                } while (i > 0);

            s = sb.ToString ();

            Console.WriteLine ("OK");

            sent = true;
            }

        /// <summary>
        /// Parse le backend
        /// </summary>
        /// <returns>TODO : Réussite de l'opération (toujours true pour l'instant)</returns>
        public bool parse ()
            {
            XmlNodeList liste = contenu.SelectNodes ("/board/post[@id > " + lastID + "]");
            XmlNode[] listeDeNoeuds = new XmlNode[liste.Count];

            int i = 0;
            Post dernier = null;

            // Quel bordel juste pour créer les posts dans le bon ordre (pour que les ²³ aillent bien)...
            foreach (XmlNode noeud in liste)
                {
                listeDeNoeuds[i++] = noeud;
                }

            Array.Reverse (listeDeNoeuds);

            i = 0;

            foreach (XmlNode noeud in listeDeNoeuds)
                {
                Post p = new Post (noeud, this, dernier);
                dernier = p;

                posts[p.norloge.id] = p;

                if (p.norloge.id > this.lastID)
                    this.lastID = p.norloge.id;
                }

            return true;
            }
        }
    }
