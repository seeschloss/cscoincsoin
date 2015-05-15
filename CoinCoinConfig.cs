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

using Nini.Config;

namespace CsoinCsoin
    {
    class CoinCoinConfig
        {
        static string CONF_FILE = "coin.ini";
        string conf_path;

        public IConfigSource source;

        public CoinCoinConfig ()
            {
            conf_path = CONF_FILE;
            if (!File.Exists (conf_path))
                File.Create (conf_path).Close ();

            Nini.Ini.IniDocument id = new Nini.Ini.IniDocument (conf_path, Nini.Ini.IniFileType.WindowsStyle);

            source = new IniConfigSource (conf_path);
            }

        public CoinCoinConfig (string file)
            {
            if (!File.Exists (file))
                File.Create (file).Close ();

            source = new IniConfigSource (file);
            }

        public void saveTribioune (Tribioune t)
            {
            source.Configs[t.name].Set ("serveur", t.serveur);
            source.Configs[t.name].Set ("derriere_end", esc (t.derrièreEnd));
            source.Configs[t.name].Set ("post_url", esc (t.postURL));
            source.Configs[t.name].Set ("format", esc (t.formatPost));
            source.Configs[t.name].Set ("cookie", esc (t.coukie));
            source.Configs[t.name].Set ("pseudo", esc (t.username));
            source.Configs[t.name].Set ("UA", esc (t.userAgent));
            source.Configs[t.name].Set ("riload", t.reload_delai);
            source.Configs[t.name].Set ("max", t.taille_max);
            source.Configs[t.name].Set ("UTF", t.UTF);
            source.Configs[t.name].Set ("slip", t.slip == slipType.tags_encodés ? "tags_encodes" : "tags_non_encodes");
            source.Configs[t.name].Set ("proxy", esc(t.proxy));
            source.Configs[t.name].Set ("proxyUser", esc(t.proxyUser));
            source.Configs[t.name].Set ("proxyPass", esc(t.proxyPass));
            source.Save();
            }

        private string esc (string s)
            {
            return s.Replace (";", "<point-virgule>"); //o\\
            // Mais comment on échape un ; dans du .ini ?
            // Nini met pas de guillemets automatiquement, mais peut-être que
            // ça marche si je les mets moi-même ? Faudra voir ça un jour

            //return "\"" + s + "\"";
            // Avec des guillemets les ; passent mais plus les guillemets évidemment...
            // et pas moyen de les échapper avec des \ :(
            }

        private string unesc (string s)
            {
            return s.Replace ("<point-virgule>", ";");
            }

        public Tribioune getTribioune (string name)
            {
            if (source.Configs[name] == null)
                source.AddConfig (name);

            string serveur = source.Configs[name].GetString ("serveur", "linuxfr.org");
            string derrièreEnd = unesc (source.Configs[name].GetString ("derriere_end", "/board/remote.xml"));
            string postURL = unesc (source.Configs[name].GetString ("post_url", "/board/add.html"));
            string formatPost = unesc (source.Configs[name].GetString ("format", "message=%m&section=1"));
            string coukie = unesc (source.Configs[name].GetString ("cookie", esc ("unique_id=;md5=")));
            string pseudo = unesc (source.Configs[name].GetString ("pseudo", ""));
            string userAgent = unesc (source.Configs[name].GetString ("UA", "C#oinC#oin/%v"));
            int reload_delai = source.Configs[name].GetInt ("riload", 30);
            int taille_max = source.Configs[name].GetInt ("max", 255);
            string proxy = unesc (source.Configs[name].GetString ("proxy", ""));
            string proxyUser = unesc (source.Configs[name].GetString ("proxyUser", ""));
            string proxyPass = unesc (source.Configs[name].GetString ("proxyPass", ""));

            string windowTitle = unesc (source.Configs[name].GetString ("titre_fenetre", "%t - C#oin ! C#oin !"));
            bool iconeDiscrete = source.Configs[name].GetBoolean  ("icone_discrete", false);
            
            bool UTF = source.Configs[name].GetBoolean ("UTF", false);

            string slipTypeStr = source.Configs[name].GetString ("slip", "tags_encodes");

            slipType slip;
            if (slipTypeStr == "tags_encodes")
                slip = slipType.tags_encodés;
            else
                slip = slipType.tags_non_encodés;

            Tribioune t = new Tribioune (name, serveur, derrièreEnd, postURL, formatPost,
                                coukie, userAgent, reload_delai, taille_max, UTF, slip, pseudo,
                                proxy, proxyUser, proxyPass, windowTitle, iconeDiscrete);

            return t;
            }
        }
    }
