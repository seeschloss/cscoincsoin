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
using System.IO;
using System.Drawing;

namespace CsoinCsoin
    {
    public class Totoz
        {
        static string baseURL = "http://forum.hardware.fr/images/perso/%t.gif";

        public string url;
        public bool valid = true;

        private byte[] data;
        private Stream st;
        private Bitmap bitmap;

        static Dictionary<string, Totoz> totozList;

        public static Totoz get_totoz (string name, System.Net.WebProxy proxy)
            {
            if (totozList == null)
                {
                totozList = new Dictionary<string, Totoz> ();
                }

            if (totozList.ContainsKey (name))
                {
                return totozList[name];
                }
            else
                {
                Totoz totoz = new Totoz (name, proxy);

                totozList[name] = totoz;

                return totoz;
                }
            }

        public static Totoz get_image (string url, System.Net.WebProxy proxy)
            {
            if (totozList == null)
                {
                totozList = new Dictionary<string, Totoz> ();
                }

            if (totozList.ContainsKey (url))
                {
                return totozList[url];
                }
            else
                {
                Totoz totoz = new Totoz (url, proxy, true);

                totozList[url] = totoz;

                return totoz;
                }
            }

        public Totoz (string url, System.Net.WebProxy proxy, bool image)
            {
            this.url = url;

            try
                {
                System.Net.WebClient client = new System.Net.WebClient ();

                if (proxy != null)
                    {
                    client.Proxy = proxy;
                    }

                data = client.DownloadData (url);
                st = new MemoryStream (data);
                bitmap = new Bitmap (st);
                bitmap.Tag = st;
                //st.Close ();
                }
            catch (Exception e)
                {
                valid = false;
                }
            }

        public Totoz (string totozName, System.Net.WebProxy proxy)
            {
            if (totozName == "motodashi")
                { // _o/* paf !
                //valid = false;
                //return;

                totozName = "nemesiss"; // habile substitution
                }

            this.url = baseURL.Replace ("%t", totozName);

            try
                {
                System.Net.WebClient client = new System.Net.WebClient ();

                if (proxy != null)
                    {
                    client.Proxy = proxy;
                    }

                data = client.DownloadData (url);
                st = new MemoryStream (data);
                bitmap = new Bitmap (st);
                bitmap.Tag = st;
                //st.Close ();
                }
            catch (Exception e)
                {
                valid = false;
                }
            }

        private bool getThumbnailImageAbort ()
            {
            return false;
            }

        public Bitmap get_bitmap ()
            {
            return bitmap;
            }

        /*   private void download()
           {
               System.IO.FileInfo f = new System.IO.FileInfo(file);

               if (!f.Exists)
               {
                   System.Net.WebClient w = new System.Net.WebClient();
                   w.DownloadFile(url, file);
               }
           } */
        }
    }
