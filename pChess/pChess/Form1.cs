using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/***********************|*********.*********|*********.*********|***********************
 *                                                                                     *
 *                      /---------------------------------------\                      *
 *                      | Praetox Online Chess Client :: pChess |                      *
 *                      \---------------------------------------/                      *
 *                                                                                     *
 *                                Program documentation                                *
 *                                                                                     *
 *  0 Clear                                                                            *
 *  1 Rook                                                                             *
 *  2 Knight                                                                           *
 *  3 Bishop                                                                           *
 *  4 Queen                                                                            *
 *  5 King                                                                             *
 *  6 Pawn                                                                             *
 *                                                                                     *
 ***************************************************************************************/

namespace pChess
{
    public partial class Form1 : Form
    {
        int[] TileData = new int[64]; int sprSelected = -1; bool isWhite = true;
        PBoxArray pSpr;    public static PictureBox sprClicked; public static int sprClickedNum;
        LabelArray lTiles; public static Label tileClicked;     public static int tileClickedNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void sprClick(PictureBox spr)
        {
            if (spr.BackColor != Color.Black)
            {
                if (((isWhite) && (TileData[sprClickedNum] <= 15)) ||
                    ((!isWhite) && (TileData[sprClickedNum] >= 16)))
                {
                    Redraw();
                    spr.BackColor = Color.Black;
                    sprSelected = sprClickedNum-1;
                }
                else
                {
                    if (sprSelected == -1) return;
                    pSpr[sprSelected].Location = spr.Location;
                    spr.Dispose();
                    sprSelected = -1;
                    Redraw();
                }
            }
            else
            {
                sprSelected = -1;
                Redraw();
            }
        }
        private void tileClick(Label tile)
        {
            if (sprSelected==-1) return;
            TileData[sprSelected] = 0;
            pSpr[sprSelected].Location = tile.Location;
            sprSelected = -1;
            Redraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show(); Application.DoEvents();
            lTiles = new LabelArray(this);
            pSpr = new PBoxArray(this);
            for (int y = 1; y <= 8; y++)
            {
                for (int x = 1; x <= 8; x++)
                {
                    int thisTile = tileArrayFromXY(x, y);
                    lTiles.NewLabel();
                    try
                    {
                        TileData[thisTile] = 0;
                        lTiles[thisTile].Size = new Size(64, 64);
                        lTiles[thisTile].Location = tilePointFromXY(x, y); //diff66 offs1 dist2
                        lTiles[thisTile].Text = "";
                        lTiles[thisTile].SendToBack();
                    }
                    catch
                    {
                        MessageBox.Show("Uh-oh... Maketile-error on " + thisTile);
                    }
                }
            }
            for (int y = 1; y <= 4; y++)
            {
                for (int x = 1; x <= 8; x++)
                {
                    int thisSpr = tileArrayFromXY(x, y);
                    pSpr.NewPBox();
                    try
                    {
                        pSpr[thisSpr].Size = new Size(64, 64);
                        pSpr[thisSpr].Location = sprPointFromXY(x, y);
                        pSpr[thisSpr].SizeMode = PictureBoxSizeMode.StretchImage;
                        pSpr[thisSpr].BringToFront();
                    }
                    catch
                    {
                        MessageBox.Show("Uh-oh... Makesprite-error on " + thisSpr);
                    }
                }
            }

            //////// Black ////////
            pSpr[0].Image = picB1.Image;
            pSpr[1].Image = picB2.Image;
            pSpr[2].Image = picB3.Image;
            pSpr[3].Image = picB4.Image;
            pSpr[4].Image = picB5.Image;
            pSpr[5].Image = picB3.Image;
            pSpr[6].Image = picB2.Image;
            pSpr[7].Image = picB1.Image;
            for (int a = 0; a <= 14; a++)
                TileData[a] = a;
            for (int a = 8; a <= 15; a++)
                pSpr[a].Image = picB6.Image;

            //////// White ////////
            for (int a = 16; a <= 31; a++)
                TileData[a] = a;
            for (int a = 16; a <= 23; a++)
                pSpr[a].Image = picW6.Image;
            pSpr[24].Image = picW1.Image;
            pSpr[25].Image = picW2.Image;
            pSpr[26].Image = picW3.Image;
            pSpr[27].Image = picW4.Image;
            pSpr[28].Image = picW5.Image;
            pSpr[29].Image = picW3.Image;
            pSpr[30].Image = picW2.Image;
            pSpr[31].Image = picW1.Image;
            
            Redraw();
        }

        private void Redraw()
        {
            bool LightColor = false;
            for (int y = 1; y <= 8; y++)
            {
                for (int x = 1; x <= 8; x++)
                {
                    int thisTile = tileArrayFromXY(x, y);
                    try
                    {
                        LightColor = !LightColor;
                        if (LightColor) lTiles[thisTile].BackColor = Color.FromArgb(253, 252, 192);
                        if (!LightColor) lTiles[thisTile].BackColor = Color.FromArgb(190, 168, 138);
                    }
                    catch
                    {
                        MessageBox.Show("Uh-oh... Redraw-error on " + thisTile);
                    }
                    for (int spr = 0; spr < 32; spr++)
                    {
                        if (pSpr[spr].Location == tilePointFromXY(x, y))
                            pSpr[spr].BackColor = lTiles[thisTile].BackColor;
                    }
                }
                LightColor = !LightColor;
            }
        }

        private Point tilePointFromXY(int x, int y)
        {
            return new Point((x * 66) - 64, (y * 66) - 64);
        }
        private int tileArrayFromXY(int x, int y)
        {
            return ((y * 8) - 8) + x - 1;
        }
        private int sprArrayFromXY(int x, int y)
        {
            if (y > 2) y -= 4;
            return ((y * 8) - 8) + x - 1;
        }
        private Point sprPointFromXY(int x, int y)
        {
            if (y > 2) y += 4;
            return new Point((x * 66) - 64, (y * 66) - 64);
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            tMain.Stop();
            if (sprClicked != null)
            {
                sprClick(sprClicked);
                sprClicked = null;
            }
            if (tileClicked != null)
            {
                tileClick(tileClicked);
                tileClicked = null;
            }
            tMain.Start();
        }
    }
}