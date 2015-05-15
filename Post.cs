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
using System.Text.RegularExpressions;
using System.Xml;
using System.Collections;
using System.IO.Compression;
using System.IO;


namespace CsoinCsoin
    {
    enum TypeMachin
        {
        queud,
        the_norloge,
        pseudo,
        norloge,
        totoz,
        url,
        UA
        }

    enum AïeLaïteLaiveul
        {
        nothing,
        answer,
        first,
        searchResult
        }

    class Machin
        {
        public Machin (Post post)
            {
            this.post = post;
            }

        public TypeMachin type;

        public int length
            {
            get { return end - start; }
            }

        public int charIndex
            {
            get { return post.charIndex + start; }
            }

        /// <summary>
        /// Position par rapport au post
        /// </summary>
        public int start;
        public int end;

        public string texte;
        public List<Norloge> norloges = null;
        public Totoz totoz = null;

        public Post post;
        }

    class Post
        {
        public Norloge norloge;
        public String pseudo;
        public String UA;
        public String displayedUA;
        private String post_string;
        //private byte[] post_data;
        //private byte[] temp_data;

        private Dictionary<string, string[]> urlTransform;

        public String post
            {
            get
                {
                //Stream s = new GZipStream (new MemoryStream (post_data), CompressionMode.Decompress);
                //temp_data = new byte[post_data.Length];
                //int size = s.Read (temp_data, 0, post_data.Length);
                //return System.Text.Encoding.UTF8.GetString (temp_data);
                return post_string;
                }
            set 
                {
                //temp_data = System.Text.Encoding.UTF8.GetBytes (value);
                //MemoryStream ms = new MemoryStream ();
                //Stream s = new GZipStream (ms, CompressionMode.Compress);
                //s.Write (temp_data, 0, temp_data.Length);
                //s.Close ();
                //post_data = ms.ToArray ();
                //post_string = "";
                //temp_data = new byte[0];
                post_string = value;
                }
            }

        public int charIndex;
        public int textStart;
        public int fin;
        public int finRtf;

        public AïeLaïteLaiveul aïeLaïteLaiveul;

        public bool aMoi;
        public bool raiePonce;

        public Tribioune tribioune;

        public List<Machin> machins;
        //public List<Norloge> norloges;

        public List<Post> referencingPosts;

        public Post (XmlNode noeud, Tribioune tribioune, Post précédent)
            {
            referencingPosts = new List<Post> ();
            urlTransform = new Dictionary<string, string[]> ();

            string[] pacliquai = { "goat.cx", "tubgirl" };
            urlTransform["pacliquai"] = pacliquai;
            string[] img = { ".jpg", ".gif", ".png", ".bmp", ".jpeg"};
            urlTransform["img"] = img;
            string[] wiki = { "wiki" };
            urlTransform["wiki"] = wiki;

            this.tribioune = tribioune;

            this.pseudo = parseXmlNode (noeud.SelectNodes ("login")[0]);
            this.post = Regex.Replace (parseXmlNode (noeud.SelectNodes ("message")[0]), " +", " ");
            this.UA = parseXmlNode (noeud.SelectNodes ("info")[0]);

            if (précédent == null)
                this.norloge = new Norloge (noeud.Attributes["time"].Value, int.Parse (noeud.Attributes["id"].Value), this);
            else
                this.norloge = new Norloge (noeud.Attributes["time"].Value, int.Parse (noeud.Attributes["id"].Value), this, précédent.norloge);


            if (UA.Length < 9)
                displayedUA = UA;
            else
                displayedUA = UA.Substring (0, 9) + "...";

            aMoi = this.pseudo == tribioune.username;

            this.charIndex = -1;

            machins = new List<Machin>(1);

            Machin m1 = new Machin (this);
            m1.type = TypeMachin.the_norloge;
            m1.start = 0;
            m1.end = norloge.repr.Length;
            m1.texte = norloge.repr;
            machins.Add (m1);

            if (pseudo.Length > 0 && pseudo != "Anonyme")
                {
                Machin m2 = new Machin (this);
                m2.type = TypeMachin.pseudo;
                m2.start = norloge.repr.Length + 1;
                m2.end = m2.start + pseudo.Length;
                m2.texte = pseudo;
                machins.Add (m2);

                textStart = m2.end + 2;
                }
            else
                {
                Machin m2 = new Machin (this);
                m2.type = TypeMachin.UA;
                m2.start = norloge.repr.Length + 1;
                m2.end = m2.start + displayedUA.Length;
                m2.texte = displayedUA;
                machins.Add (m2);

                textStart = m2.end + 2;
                }

            this.parse ();
            }

        public Machin getMachin (int index)
            {
            int i = index - charIndex;

            Machin m;

            foreach (Object o in machins)
                {
                m = (Machin)o;

                if (i >= m.start && i <= m.end)
                    return m;
                }

            m = new Machin (this);
            m.type = TypeMachin.queud;
            return m;
            }

        public int getLength ()
            {
            return fin - charIndex;
            }

        public bool containsChar (int index)
            {
            if (charIndex < 0)
                {
                return false;
                }
            else
                {
                return ((index >= charIndex) && (index < charIndex + this.getLength ()));
                }
            }

        /// <summary>
        /// Ajuste le charIndex et la fin du post, en cas de changement dans la richTextBox de la tribune
        /// </summary>
        /// <param name="offset">Offset à *ajouter*</param>
        public void setOffset (int offset)
            {
            charIndex += offset;
            fin += offset;
            }

        private string parseXmlNode (XmlNode node)
            {
            string text = "";

            switch (tribioune.slip)
                {
                case slipType.tags_encodés:
                    //node.InnerXml = node.InnerText;
                    //text = node.InnerText;                    
                    text = System.Web.HttpUtility.HtmlDecode (node.InnerText);
                    break;
                case slipType.tags_non_encodés:
                    //text = node.InnerXml;
                    text = System.Web.HttpUtility.HtmlDecode (node.InnerXml);
                    break;
                }

            return text;
            }

        private string getURLrepr (string url)
            {
            foreach (KeyValuePair<string,string[]> k in urlTransform)
                {
                string repr = k.Key;
                string[] matches = k.Value;

                foreach (string match in matches)
                    {
                    if (url.Contains (match))
                        {
                        return "[" + repr + "]";
                        }
                    }
                }

            return "[url]";
            }

        private void findURLs (string text)
            {
            int i = text.IndexOf ("<a href=\"");
            if (i == -1) return;

            int i2 = i + "<a href=\"".Length;
            int j = text.IndexOf ("\"", i2);

            string url = text.Substring (i2, j - i2);

            string urlRepr = getURLrepr (url);
            
            int k = text.IndexOf ("</a>", j) + "</a>".Length;

            text = text.Substring (0, i) + urlRepr + text.Substring (k);

            Machin m = new Machin (this);
            m.type = TypeMachin.url;
            m.texte = url;
            m.start = textStart + i;
            m.end = textStart + i + urlRepr.Length;

            if (url.EndsWith (".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                url.EndsWith (".gif", StringComparison.InvariantCultureIgnoreCase) ||
                url.EndsWith (".png", StringComparison.InvariantCultureIgnoreCase))
                {
                Totoz image = Totoz.get_image (m.texte, tribioune.proxyObject);
                m.totoz = image;
                }


            machins.Add (m);

            findURLs (text);
            }

        private void findNorloges (string text)
            {
            Match m = Regex.Match (text, "[0-2]?[0-9][:hH][0-5][0-9](:[0-5][0-9])?(([:^][0-9]+)|[¹²³])?");
            while (m.Success)
                {
                string n = m.Value;
                norloge.hasRefTo (n);
                Machin m3 = new Machin (this);
                m3.type = TypeMachin.norloge;
                m3.start = textStart + m.Index;
                m3.end = textStart + m.Index + m.Length;
                m3.texte = m.Value;
                if (tribioune.norloges.ContainsKey (n))
                    {
                    m3.norloges = tribioune.norloges[n];
                    }
                machins.Add (m3);

                List<Post> posts = tribioune.getPostsFromNorloge (n);

                foreach (Post post in posts)
                    {
                    if (post.aMoi)
                        {
                        this.raiePonce = true;
                        tribioune.nouvelleRaiePonce = true;
                        }
                    }

                m = m.NextMatch ();
                }
            }

        private void findTotoz (string text)
            {
            Match m = Regex.Match (text, @"\[:[^\]]+\]");

            while (m.Success)
                {
                string n = m.Value;

                n = n.Substring (2, n.Length - 3);

                Machin m3 = new Machin (this);
                m3.type = TypeMachin.totoz;
                m3.start = textStart + m.Index;
                m3.end = textStart + m.Index + m.Length;
                m3.texte = n;

                Totoz totoz = Totoz.get_totoz (n, tribioune.proxyObject);
                m3.totoz = totoz;

                machins.Add (m3);

                m = m.NextMatch ();
                }

            post = Regex.Replace (post, @"\[:[^\]]+\]", @"<totoz>$0</totoz>");
            }

        private void findAppel (string text)
            {
            if ((text.Contains ("moules<") || text.Contains (tribioune.username + "<")) ||
                (text.Contains ("moules&lt;") || text.Contains (tribioune.username + "&lt;")))
                {
                tribioune.nouvelleRaiePonce = true;
                }
            }

        private void replaceURLs ()
            {
            int i = post.IndexOf ("<a href=\"");
            if (i == -1) return;

            int i2 = i + "<a href=\"".Length;
            int j = post.IndexOf ("\"", i2);

            string url = post.Substring (i2, j - i2);

            string urlRepr = getURLrepr (url);

            int k = post.IndexOf ("</a>", j) + "</a>".Length;

            post = post.Substring (0, i) + "<url>" + urlRepr + "</url>" + post.Substring (k);

            replaceURLs ();
            }

        public string keepURLs (string text)
            {
            //text = Regex.Replace (text, "</?span[^>]*>", "");
            text = Regex.Replace (text, "<[^/a][^>]*>", "");
            return Regex.Replace (text, "</[^a][^>]*>", "");
            }

        private void parse ()
            {
            findURLs (keepURLs (post));
            //findURLs (post);
            replaceURLs ();

            findNorloges (keepURLs (post));
            findTotoz (keepURLs (post));
            findAppel (post);
            }
        }
    }
