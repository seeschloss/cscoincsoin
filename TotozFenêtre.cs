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

namespace CsoinCsoin
    {
    public partial class TotozFenêtre : Form
        {
        Totoz totoz;

        public TotozFenêtre ()
            {
            InitializeComponent ();
            }

        public void displayTotoz (Totoz totoz)
            {
            if (totoz == null || !totoz.valid)
                {
                Hide ();
                return;
                }
            else
                {
                try
                    {
                    this.totoz = totoz;

                    if (pictureBoite.Image != totoz.get_bitmap ())
                        {
                        pictureBoite.Image = (Image) totoz.get_bitmap ();

                        if (ImageAnimator.CanAnimate (pictureBoite.Image))
                            ImageAnimator.Animate (pictureBoite.Image, new EventHandler (onImageFrameChanged));
                        }

                    Show ();
                    Size = pictureBoite.Image.Size;

                    int x = 0;
                    int y = 0;

                    if (Cursor.Position.X - Size.Width - 5 > 0)
                        {
                        x = Cursor.Position.X - Size.Width - 5;
                        }
                    else
                        {
                        x = Cursor.Position.X + 5;
                        }

                    if (Cursor.Position.Y - Size.Height - 5 > 0)
                        {
                        y = Cursor.Position.Y - Size.Height - 5;
                        }
                    else
                        {
                        y = Cursor.Position.Y + 5;
                        }

                    Location = new Point (x, y);
                    }
                catch (Exception e)
                    {
                    if (Visible)
                        Hide ();
                    }
                }
            }

        private void onImageFrameChanged (object o, EventArgs a)
            {
            try
                {
                ImageAnimator.UpdateFrames (pictureBoite.Image);
                }
            catch (Exception e)
                {
                }
            }

        private void pictureBoite_Paint (object sender, PaintEventArgs e)
            {
            try
                {
                ImageAnimator.UpdateFrames (pictureBoite.Image);
                }
            catch (Exception ex)
                {
                }
            }
        }
    }