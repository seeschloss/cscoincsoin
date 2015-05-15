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
using System.Collections;

namespace CsoinCsoin
    {
    class Norloge
        {
        public String norloge;
        private String Repr;

        public String repr
            {	// Je sais pas si sai bien de mettre autant de code dans un getter, mais
                // comme ça j'ai pas à changer tout le code qui utilise repr, au moins
            get
                {
                if (petitChiffre == 0)
                    {
                    return Repr;
                    }
                else
                    {
                    string petitNombre = "";

                    switch (petitChiffre)
                        {
                    case 1:
                        petitNombre = "¹";
                        break;
                    case 2:
                        petitNombre = "²";
                        break;
                    case 3:
                        petitNombre = "³";
                        break;
                    default:
                        petitNombre = ":" + petitChiffre;
                        break;
                        }
                    return Repr + petitNombre;
                    }
                }
            set
                {
                Repr = value;
                }
            }
        public int id;
        private int petitUnOuDeuxOuTroisOuPlus = 0;

        public int petitChiffre
            {
            get
                {
                return petitUnOuDeuxOuTroisOuPlus;
                }
            set 
                {
                petitUnOuDeuxOuTroisOuPlus = value;

                if (!post.tribioune.norloges.ContainsKey(this.repr))
                    {
                    post.tribioune.norloges.Add (this.repr, new List<Norloge> (1));
                    }

                if (!post.tribioune.norloges.ContainsKey (this.Repr + ":" + this.petitChiffre))
                    {
                    post.tribioune.norloges.Add (this.Repr + ":" + this.petitChiffre, new List<Norloge> (1));
                    }


                if (!post.tribioune.norloges.ContainsKey (this.Repr + "^" + this.petitChiffre))
                    {
                    post.tribioune.norloges.Add (this.Repr + "^" + this.petitChiffre, new List<Norloge> (1));
                    }

                if (!post.tribioune.norloges[this.repr].Contains (this))
                    post.tribioune.norloges[this.repr].Add (this);

                if (!post.tribioune.norloges[this.Repr + ":" + this.petitChiffre].Contains (this))
                    post.tribioune.norloges[this.Repr + ":" + this.petitChiffre].Add (this);

                if (!post.tribioune.norloges[this.Repr + "^" + this.petitChiffre].Contains (this))
                    post.tribioune.norloges[this.Repr + "^" + this.petitChiffre].Add (this);
                }
            }

        public Post post;

        public readonly DateTime time;

        public Norloge (String norloge, int id, Post p, Norloge précédente)
            {
            this.post = p;
            this.norloge = norloge;
            time = new DateTime (int.Parse (norloge.Substring (0, 4)),
                int.Parse (norloge.Substring (4, 2)),
                int.Parse (norloge.Substring (6, 2)),
                int.Parse (norloge.Substring (8, 2)),
                int.Parse (norloge.Substring (10, 2)),
                int.Parse (norloge.Substring (12, 2)));
            repr = time.Hour.ToString ("00") + ":" + time.Minute.ToString ("00") + ":" + time.Second.ToString ("00");
            String repr_small = time.Hour.ToString ("00") + ":" + time.Minute.ToString ("00");
            this.id = id;

            if (time == précédente.time)
                {
                if (précédente.petitChiffre == 0)
                    précédente.petitChiffre = 1;

                petitChiffre = précédente.petitChiffre + 1;
                }
            else
                {
                if (!post.tribioune.norloges.ContainsKey (this.repr + "¹"))
                    {
                    post.tribioune.norloges.Add (this.repr + "¹", new List<Norloge> (1));
                    }

                if (!post.tribioune.norloges.ContainsKey (this.Repr + ":1"))
                    {
                    post.tribioune.norloges.Add (this.Repr + ":1", new List<Norloge> (1));
                    }


                if (!post.tribioune.norloges.ContainsKey (this.Repr + "^1"))
                    {
                    post.tribioune.norloges.Add (this.Repr + "^1", new List<Norloge> (1));
                    }

                if (!post.tribioune.norloges[this.repr + "¹"].Contains (this))
                    post.tribioune.norloges[this.repr + "¹"].Add (this);

                if (!post.tribioune.norloges[this.repr + ":1"].Contains (this))
                    post.tribioune.norloges[this.repr + ":1"].Add (this);

                if (!post.tribioune.norloges[this.repr + "^1"].Contains (this))
                    post.tribioune.norloges[this.repr + "^1"].Add (this);
                }

            if (!post.tribioune.norloges.ContainsKey (this.repr))
                {
                post.tribioune.norloges.Add (this.repr, new List<Norloge> (1));
                }

            if (!post.tribioune.norloges[this.repr].Contains (this))
                post.tribioune.norloges[this.repr].Add (this);

            if (!post.tribioune.norloges.ContainsKey (repr_small))
                {
                post.tribioune.norloges.Add (repr_small, new List<Norloge> (1));
                }

            if (!post.tribioune.norloges[repr_small].Contains (this))
                post.tribioune.norloges[repr_small].Add (this);
            }

        public Norloge (String norloge, int id, Post p)
            {
            this.post = p;

            this.norloge = norloge;
            time = new DateTime (int.Parse (norloge.Substring (0, 4)),
                int.Parse (norloge.Substring (4, 2)),
                int.Parse (norloge.Substring (6, 2)),
                int.Parse (norloge.Substring (8, 2)),
                int.Parse (norloge.Substring (10, 2)),
                int.Parse (norloge.Substring (12, 2)));
            repr = time.Hour.ToString ("00") + ":" + time.Minute.ToString ("00") + ":" + time.Second.ToString ("00");
            String repr_small = time.Hour.ToString ("00") + ":" + time.Minute.ToString ("00");

            this.id = id;

            if (!post.tribioune.norloges.ContainsKey (this.repr))
                {
                post.tribioune.norloges.Add (this.repr, new List<Norloge> (1));
                }

            if (!post.tribioune.norloges[this.repr].Contains (this))
                post.tribioune.norloges[this.repr].Add (this);

            if (!post.tribioune.norloges.ContainsKey (repr_small))
                {
                post.tribioune.norloges.Add (repr_small, new List<Norloge> (1));
                }

            if (!post.tribioune.norloges[repr_small].Contains (this))
                post.tribioune.norloges[repr_small].Add (this);
            }

        public List<Norloge> getNorloges (string repr)
            {
            if (post.tribioune.norloges.ContainsKey (repr))
                {
                return post.tribioune.norloges[repr];
                }
            else
                {
                return new List<Norloge> (); ;
                }
            }

        public void hasRefTo (string norloge)
            {
            List<Norloge> norloges = getNorloges (norloge);

            foreach (Norloge n in norloges)
                {
                if (!n.post.referencingPosts.Contains (this.post))
                    {
                    n.post.referencingPosts.Add (this.post);
                    }
                }
            }
        }
    }
