using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Util;

namespace WinFormsApp3.Forms
{
    public partial class DamasForms : Form
    {
        const int ALTURA = 8;
        const int LARGURA = 8;

        //List<List<PictureBox>> tabuleiro;

        PictureBox[,] tabuleiro = new PictureBox[ALTURA, LARGURA];

        public DamasForms()
        {
            InitializeComponent();

            tabuleiro[0, 0] = A1;
            tabuleiro[0, 1] = A2;
            tabuleiro[0, 2] = A3;
            tabuleiro[0, 3] = A4;
            tabuleiro[0, 4] = A5;
            tabuleiro[0, 5] = A6;
            tabuleiro[0, 6] = A7;
            tabuleiro[0, 7] = A8;
            tabuleiro[1, 0] = B1;
            tabuleiro[1, 1] = B2;
            tabuleiro[1, 2] = B3;
            tabuleiro[1, 3] = B4;
            tabuleiro[1, 4] = B5;
            tabuleiro[1, 5] = B6;
            tabuleiro[1, 6] = B7;
            tabuleiro[1, 7] = B8;
            tabuleiro[2, 0] = C1;
            tabuleiro[2, 1] = C2;
            tabuleiro[2, 2] = C3;
            tabuleiro[2, 3] = C4;
            tabuleiro[2, 4] = C5;
            tabuleiro[2, 5] = C6;
            tabuleiro[2, 6] = C7;
            tabuleiro[2, 7] = C8;
            tabuleiro[3, 0] = D1;
            tabuleiro[3, 1] = D2;
            tabuleiro[3, 2] = D3;
            tabuleiro[3, 3] = D4;
            tabuleiro[3, 4] = D5;
            tabuleiro[3, 5] = D6;
            tabuleiro[3, 6] = D7;
            tabuleiro[3, 7] = D8;
            tabuleiro[4, 0] = E1;
            tabuleiro[4, 1] = E2;
            tabuleiro[4, 2] = E3;
            tabuleiro[4, 3] = E4;
            tabuleiro[4, 4] = E5;
            tabuleiro[4, 5] = E6;
            tabuleiro[4, 6] = E7;
            tabuleiro[4, 7] = E8;
            tabuleiro[5, 0] = F1;
            tabuleiro[5, 1] = F2;
            tabuleiro[5, 2] = F3;
            tabuleiro[5, 3] = F4;
            tabuleiro[5, 4] = F5;
            tabuleiro[5, 5] = F6;
            tabuleiro[5, 6] = F7;
            tabuleiro[5, 7] = F8;
            tabuleiro[6, 0] = G1;
            tabuleiro[6, 1] = G2;
            tabuleiro[6, 2] = G3;
            tabuleiro[6, 3] = G4;
            tabuleiro[6, 4] = G5;
            tabuleiro[6, 5] = G6;
            tabuleiro[6, 6] = G7;
            tabuleiro[6, 7] = G8;
            tabuleiro[7, 0] = H1;
            tabuleiro[7, 1] = H2;
            tabuleiro[7, 2] = H3;
            tabuleiro[7, 3] = H4;
            tabuleiro[7, 4] = H5;
            tabuleiro[7, 5] = H6;
            tabuleiro[7, 6] = H7;
            tabuleiro[7, 7] = H8;

            for (int i = 0; i < ALTURA; i++)
            {
                for (int j = 0; j < LARGURA; j++)
                {
                    tabuleiro[i, j].MouseDoubleClick += posicao_DoubleClick;
                }
            }
        }

        private void posicao_DoubleClick(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();

            PictureBox pictureBox_clicada = (PictureBox)sender;

            Point posicao = recuperarPosicaoNoTabuleiro(pictureBox_clicada);
            if (pictureBox_clicada.BackColor != Color.Black)
            {
                MovimentarPeça(posicao);
            }
            A1.BackColor = Color.Black;
            A3.BackColor = Color.Black;
            A5.BackColor = Color.Black;
            A7.BackColor = Color.Black;
            B2.BackColor = Color.Black;
            B4.BackColor = Color.Black;
            B6.BackColor = Color.Black;
            B8.BackColor = Color.Black;
            C1.BackColor = Color.Black;
            C3.BackColor = Color.Black;
            C5.BackColor = Color.Black;
            C7.BackColor = Color.Black;
            D2.BackColor = Color.Black;
            D4.BackColor = Color.Black;
            D6.BackColor = Color.Black;
            D8.BackColor = Color.Black;
            E1.BackColor = Color.Black;
            E3.BackColor = Color.Black;
            E5.BackColor = Color.Black;
            F2.BackColor = Color.Black;
            F4.BackColor = Color.Black;
            F6.BackColor = Color.Black;
            F8.BackColor = Color.Black;
            G1.BackColor = Color.Black;
            G3.BackColor = Color.Black;
            G5.BackColor = Color.Black;
            G7.BackColor = Color.Black;
            H2.BackColor = Color.Black;
            H4.BackColor = Color.Black;
            H6.BackColor = Color.Black;
            H8.BackColor = Color.Black;
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 && Util.CompararImagem(pictureBox_clicada.Image, P1.Image) /* branco */)
            {
                int x = posicao.X;
                int y = posicao.Y;

                try
                {
                    PictureBox esquerda = tabuleiro[x - 1, y + 1];
                    if (Util.CompararImagem(esquerda.Image, P1.Image) == false && Util.CompararImagem(esquerda.Image, P2.Image) == false)
                        esquerda.BackColor = Color.Yellow;
                    else
                    {
                        Point posicao2 = recuperarPosicaoNoTabuleiro(esquerda);
                        int X = posicao2.X;
                        int Y = posicao2.Y;
                        PictureBox esquerda2 = tabuleiro[X - 1, Y + 1];
                        if (Util.CompararImagem(esquerda.Image, P1.Image) == false && Util.CompararImagem(esquerda.Image, P2.Image) == false)
                            esquerda2.BackColor = Color.Red;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    PictureBox direita = tabuleiro[x + 1, y + 1];
                    if (Util.CompararImagem(direita.Image, P1.Image) == false && Util.CompararImagem(direita.Image, P2.Image) == false)
                        direita.BackColor = Color.Purple;
                    else
                    {
                        Point posicao2 = recuperarPosicaoNoTabuleiro(direita);
                        int X = posicao2.X;
                        int Y = posicao2.Y;
                        PictureBox direita2 = tabuleiro[X + 1, Y + 1];
                        if (Util.CompararImagem(direita.Image, P1.Image) == false && Util.CompararImagem(direita.Image, P2.Image) == false)
                            direita2.BackColor = Color.DarkRed;
                    }
                }
                catch (Exception ex) { }


            }
            else if (Convert.ToInt32(LP1.Text) % 2 == 1 && Util.CompararImagem(pictureBox_clicada.Image, P2.Image) /* preto */)
            {
                int x = posicao.X;
                int y = posicao.Y;

                try
                {
                    PictureBox esquerda = tabuleiro[x - 1, y - 1];
                    if (Util.CompararImagem(esquerda.Image, P1.Image) == false && Util.CompararImagem(esquerda.Image, P2.Image) == false)
                        esquerda.BackColor = Color.Purple;
                    else
                    {
                        Point posicao2 = recuperarPosicaoNoTabuleiro(esquerda);
                        int X = posicao2.X;
                        int Y = posicao2.Y;
                        PictureBox esquerda2 = tabuleiro[X - 1, Y - 1];
                        if (Util.CompararImagem(esquerda.Image, P2.Image) == false && Util.CompararImagem(esquerda.Image, P2.Image) == false)
                            esquerda2.BackColor = Color.DarkRed;
                    }
                }
                catch (Exception ex) { }
                try
                {
                    PictureBox direita = tabuleiro[x + 1, y - 1];
                    if (Util.CompararImagem(direita.Image, P1.Image) == false && Util.CompararImagem(direita.Image, P2.Image) == false)
                        direita.BackColor = Color.Yellow;
                    else
                    {
                        Point posicao2 = recuperarPosicaoNoTabuleiro(direita);
                        int X = posicao2.X;
                        int Y = posicao2.Y;
                        PictureBox direita2 = tabuleiro[X + 1, Y - 1];
                        if (Util.CompararImagem(direita.Image, P2.Image) == false && Util.CompararImagem(direita.Image, P2.Image) == false)
                            direita2.BackColor = Color.Red;
                    }
                }
                catch (Exception ex) { }
            }


        }

        private PictureBox PodeComer(Point pictureBox)
        {
            UtilCompImg Util = new UtilCompImg();
            int x = pictureBox.X;
            int y = pictureBox.Y;
            PictureBox Ps1 = tabuleiro[x - 1, y - 1];
            PictureBox Ps2 = tabuleiro[x + 1, y + 1];
            PictureBox Ps3 = tabuleiro[x + 1, y - 1];
            PictureBox Ps4 = tabuleiro[x - 1, y + 1];
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 && Util.CompararImagem(Ps1.Image, P1.Image) == false)
            {
                return Ps1;
            }
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 && Util.CompararImagem(Ps2.Image, P1.Image))
            {
                return Ps2;
            }
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 && Util.CompararImagem(Ps3.Image, P1.Image))
            {
                return Ps3;
            }
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 && Util.CompararImagem(Ps4.Image, P1.Image))
            {
                return Ps4;
            }
            return tabuleiro[x, y];
        }

        private Point recuperarPosicaoNoTabuleiro(PictureBox pictureBox)
        {
            for (int i = 0; i < ALTURA; i++)
            {
                for (int j = 0; j < LARGURA; j++)
                {
                    if (pictureBox == tabuleiro[i, j])
                    {
                        return new Point(i, j);
                    }
                }
            }

            return new Point(0, 0);
        }

        private void MovimentarPeça(Point pictureBox) 
        {
            int x = pictureBox.X;
            int y = pictureBox.Y;
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0/* branco */)
            {
                try
                {
                    PictureBox Ps1 = tabuleiro[x, y];
                    if (Ps1.BackColor == Color.Purple)
                    {
                        PictureBox Ps2 = tabuleiro[x - 1, y - 1];
                        if (Util.CompararImagem(Ps2.Image, P1.Image))
                        {
                            Ps1.Image = Ps2.Image;
                            Ps2.Image = A8.Image;
                            LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                        }
                    }
                    if (Ps1.BackColor == Color.Yellow)
                    {
                        PictureBox Ps2 = tabuleiro[x + 1, y - 1];
                        if (Util.CompararImagem(Ps2.Image, P1.Image))
                        {
                            Ps1.Image = Ps2.Image;
                            Ps2.Image = A8.Image;
                            LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                        }
                    }
                    if (Ps1.BackColor == Color.Red)
                    {

                        PictureBox Ps3 = tabuleiro[x + 2, y - 2];
                        PictureBox Ps4 = tabuleiro[x + 1, y - 1];
                        Ps1.Image = Ps3.Image;
                        Ps3.Image = A8.Image;
                        Ps4.Image = A8.Image;
                        while (true)
                        {
                            Point point = new Point(x, y);
                            PictureBox Ps5 = PodeComer(point);
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            x++;
                            y++;
                        }
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (Ps1.BackColor == Color.DarkRed)
                    {
                        PictureBox Ps3 = tabuleiro[x - 2, y - 2];
                        PictureBox Ps4 = tabuleiro[x - 1, y - 1];
                        Ps1.Image = Ps3.Image;
                        Ps3.Image = A8.Image;
                        Ps4.Image = A8.Image;
                        while (true)
                        {
                            Point point = new Point(x, y);
                            PictureBox Ps5 = PodeComer(point);
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            x++;
                            y++;
                        }
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                catch { }
            }
            else //preto
            {
                try
                {
                    PictureBox Ps1 = tabuleiro[x, y];
                    if (Ps1.BackColor == Color.Yellow)
                    {
                        PictureBox Ps2 = tabuleiro[x - 1, y + 1];
                        if (Util.CompararImagem(Ps2.Image, P2.Image))
                        {
                            Ps1.Image = Ps2.Image;
                            Ps2.Image = A8.Image;
                            LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                        }
                    }
                    if (Ps1.BackColor == Color.Purple)
                    {
                        PictureBox Ps2 = tabuleiro[x + 1, y + 1];
                        if (Util.CompararImagem(Ps2.Image, P2.Image))
                        {
                            Ps1.Image = Ps2.Image;
                            Ps2.Image = A8.Image;
                            LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                        }
                    }
                    if (Ps1.BackColor == Color.Red)
                    {
                        PictureBox Ps3 = tabuleiro[x - 2, y + 2];
                        PictureBox Ps4 = tabuleiro[x - 1, y + 1];
                        Ps1.Image = Ps3.Image;
                        Ps3.Image = A8.Image;
                        Ps4.Image = A8.Image;
                        while (true)
                        {
                            Point point = new Point(x, y);
                            PictureBox Ps5 = PodeComer(point);
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            x++;
                            y++;
                        }
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (Ps1.BackColor == Color.DarkRed)
                    {
                        PictureBox Ps3 = tabuleiro[x + 2, y + 2];
                        PictureBox Ps4 = tabuleiro[x + 1, y + 1];
                        Ps1.Image = Ps3.Image;
                        Ps3.Image = A8.Image;
                        Ps4.Image = A8.Image;
                        while (true)
                        {
                            Point point = new Point(x, y);
                            PictureBox Ps5 = PodeComer(point);
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y + 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y + 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x + 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X + 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            if (Util.CompararImagem(Ps5.Image, Ps1.Image) == false && recuperarPosicaoNoTabuleiro(Ps5).X == x - 1 && recuperarPosicaoNoTabuleiro(Ps5).Y == y - 1)
                            {
                                PictureBox Ps6 = tabuleiro[recuperarPosicaoNoTabuleiro(Ps5).X - 1, recuperarPosicaoNoTabuleiro(Ps5).Y - 1];
                                Ps6.Image = Ps1.Image;
                                Ps5.Image = A8.Image;
                                Ps1.Image = A8.Image;
                            }
                            x++;
                            y++;
                        }
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                catch { }

            }
        }

       private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {
            /*
            UtilCompImg Util = new UtilCompImg();

            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 )
            {
                    if (A3.BackColor == Color.Yellow)
                    {
                        A3.Image = B2.Image;
                        A3.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (A3.BackColor == Color.Red)
                    {
                        A3.Image = C1.Image;
                        A3.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
            }
            else // vez das pretas
            {
                    if (A3.BackColor == Color.Purple)
                    {
                        A3.Image = B4.Image;
                        A3.BackColor = Color.Black;
                        B4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (A3.BackColor == Color.DarkRed)
                    {
                        A3.Image = C5.Image;
                        A3.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        B4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
            }

            */
        }

        private void B4_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                

                    if (B4.BackColor == Color.Purple)
                    {
                        B4.Image = A3.Image;
                        B4.BackColor = Color.Black;
                        A3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B4.BackColor == Color.Yellow)
                    {
                        B4.Image = C3.Image;
                        B4.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                   if (B4.BackColor == Color.DarkRed)
                   {
                        B4.Image = D6.Image;
                        B4.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                   }
                A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(B4.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(A3.Image, P1.Image) == false && Util.CompararImagem(A3.Image, P2.Image) == false)
                    {
                        A3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C3.Image, P1.Image) == false && Util.CompararImagem(C3.Image, P2.Image) == false)
                    {
                        C3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (B4.BackColor == Color.Purple)
                    {
                        B4.Image = C5.Image;
                        B4.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B4.BackColor == Color.Yellow)
                    {
                        B4.Image = A5.Image;
                        B4.BackColor = Color.Black;
                        A5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B4.BackColor == Color.DarkRed)
                    {
                        B4.Image = C1.Image;
                        B4.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(C3.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D4.Image, P1.Image) == false && Util.CompararImagem(D4.Image, P2.Image) == false)
                    {
                        D4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(B4.Image, P1.Image) == false && Util.CompararImagem(B4.Image, P2.Image) == false)
                    {
                        B4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C3.BackColor == Color.Purple)
                    {
                        C3.Image = B2.Image;
                        C3.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C3.BackColor == Color.Yellow)
                    {
                        C3.Image = D2.Image;
                        C3.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C3.BackColor == Color.DarkRed)
                    {
                        C3.Image = C1.Image;
                        C3.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C3.BackColor == Color.Red)
                    {
                        C3.Image = C1.Image;
                        C3.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(C3.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B2.Image, P1.Image) == false && Util.CompararImagem(B2.Image, P2.Image) == false)
                    {
                        B2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D2.Image, P1.Image) == false && Util.CompararImagem(D2.Image, P2.Image) == false)
                    {
                        D2.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C3.BackColor == Color.Purple)
                    {
                        C3.Image = D4.Image;
                        D4.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C3.BackColor == Color.Yellow)
                    {
                        C3.Image = B4.Image;
                        B4.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(E3.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F4.Image, P1.Image) == false && Util.CompararImagem(F4.Image, P2.Image) == false)
                    {
                        F4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D4.Image, P1.Image) == false && Util.CompararImagem(D4.Image, P2.Image) == false)
                    {
                        D4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E3.BackColor == Color.Purple)
                    {
                        E3.Image = D2.Image;
                        E3.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E3.BackColor == Color.Yellow)
                    {
                        E3.Image = F2.Image;
                        E3.BackColor = Color.Black;
                        F2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(E3.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D2.Image, P1.Image) == false && Util.CompararImagem(D2.Image, P2.Image) == false)
                    {
                        D2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F2.Image, P1.Image) == false && Util.CompararImagem(F2.Image, P2.Image) == false)
                    {
                        F2.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E3.BackColor == Color.Purple)
                    {
                        E3.Image = F4.Image;
                        E3.BackColor = Color.Black;
                        F4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E3.BackColor == Color.Yellow)
                    {
                        E3.Image = D4.Image;
                        E3.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void G3_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(G3.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(H4.Image, P1.Image) == false && Util.CompararImagem(H4.Image, P2.Image) == false)
                    {
                        H4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F4.Image, P1.Image) == false && Util.CompararImagem(F4.Image, P2.Image) == false)
                    {
                        F4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G3.BackColor == Color.Purple)
                    {
                        G3.Image = F2.Image;
                        G3.BackColor = Color.Black;
                        F2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G3.BackColor == Color.Yellow)
                    {
                        G3.Image = H2.Image;
                        G3.BackColor = Color.Black;
                        H2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(G3.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F2.Image, P1.Image) == false && Util.CompararImagem(F2.Image, P2.Image) == false)
                    {
                        F2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(H2.Image, P1.Image) == false && Util.CompararImagem(H2.Image, P2.Image) == false)
                    {
                        H2.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G3.BackColor == Color.Purple)
                    {
                        G3.Image = H4.Image;
                        G3.BackColor = Color.Black;
                        H4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G3.BackColor == Color.Yellow)
                    {
                        G3.Image = F4.Image;
                        G3.BackColor = Color.Black;
                        F4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(D4.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E5.Image, P1.Image) == false && Util.CompararImagem(E5.Image, P2.Image) == false)
                    {
                        E5.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C5.Image, P1.Image) == false && Util.CompararImagem(C5.Image, P2.Image) == false)
                    {
                        C5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D4.BackColor == Color.Purple)
                    {
                        D4.Image = C3.Image;
                        D4.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D4.BackColor == Color.Yellow)
                    {
                        D4.Image = E3.Image;
                        D4.BackColor = Color.Black;
                        E3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(D4.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C3.Image, P1.Image) == false && Util.CompararImagem(C3.Image, P2.Image) == false)
                    {
                        C3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E3.Image, P1.Image) == false && Util.CompararImagem(E3.Image, P2.Image) == false)
                    {
                        E3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D4.BackColor == Color.Purple)
                    {
                        D4.Image = E5.Image;
                        D4.BackColor = Color.Black;
                        E5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D4.BackColor == Color.Yellow)
                    {
                        D4.Image = C5.Image;
                        D4.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void F4_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(F4.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G5.Image, P1.Image) == false && Util.CompararImagem(G5.Image, P2.Image) == false)
                    {
                        G5.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E5.Image, P1.Image) == false && Util.CompararImagem(E5.Image, P2.Image) == false)
                    {
                        E5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F4.BackColor == Color.Purple)
                    {
                        F4.Image = E3.Image;
                        F4.BackColor = Color.Black;
                        E3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F4.BackColor == Color.Yellow)
                    {
                        F4.Image = G3.Image;
                        F4.BackColor = Color.Black;
                        G3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(F4.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E3.Image, P1.Image) == false && Util.CompararImagem(E3.Image, P2.Image) == false)
                    {
                        E3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(G3.Image, P1.Image) == false && Util.CompararImagem(G3.Image, P2.Image) == false)
                    {
                        G3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F4.BackColor == Color.Purple)
                    {
                        F4.Image = G5.Image;
                        F4.BackColor = Color.Black;
                        G5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F4.BackColor == Color.Yellow)
                    {
                        F4.Image = E5.Image;
                        F4.BackColor = Color.Black;
                        E5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void H4_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(H4.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G5.Image, P1.Image) == false && Util.CompararImagem(G5.Image, P2.Image) == false)
                    {
                        G5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (H4.BackColor == Color.Purple)
                    {
                        H4.Image = G3.Image;
                        H4.BackColor = Color.Black;
                        G3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(H4.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G3.Image, P1.Image) == false && Util.CompararImagem(G3.Image, P2.Image) == false)
                    {
                        G3.BackColor = Color.Purple;
                    }
                }
                else
                {
                    if (H4.BackColor == Color.Yellow)
                    {
                        H4.Image = G5.Image;
                        H4.BackColor = Color.Black;
                        G5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(B2.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C3.Image, P1.Image) == false && Util.CompararImagem(C3.Image, P2.Image) == false)
                    {
                        C3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(A3.Image, P1.Image) == false && Util.CompararImagem(A3.Image, P2.Image) == false)
                    {
                        A3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (B2.BackColor == Color.Purple)
                    {
                        B2.Image = A1.Image;
                        B2.BackColor = Color.Black;
                        A1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B2.BackColor == Color.Yellow)
                    {
                        B2.Image = C1.Image;
                        B2.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(B2.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(A1.Image, P1.Image) == false && Util.CompararImagem(A1.Image, P2.Image) == false)
                    {
                        A1.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C1.Image, P1.Image) == false && Util.CompararImagem(C1.Image, P2.Image) == false)
                    {
                        C1.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (B2.BackColor == Color.Purple)
                    {
                        B2.Image = C3.Image;
                        B2.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B2.BackColor == Color.Yellow)
                    {
                        B2.Image = A3.Image;
                        B2.BackColor = Color.Black;
                        A3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(D2.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E3.Image, P1.Image) == false && Util.CompararImagem(E3.Image, P2.Image) == false)
                    {
                        E3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C3.Image, P1.Image) == false && Util.CompararImagem(C3.Image, P2.Image) == false)
                    {
                        C3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D2.BackColor == Color.Purple)
                    {
                        D2.Image = C1.Image;
                        D2.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D2.BackColor == Color.Yellow)
                    {
                        D2.Image = E1.Image;
                        D2.BackColor = Color.Black;
                        E1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(D2.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C1.Image, P1.Image) == false && Util.CompararImagem(C1.Image, P2.Image) == false)
                    {
                        C1.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E1.Image, P1.Image) == false && Util.CompararImagem(E1.Image, P2.Image) == false)
                    {
                        E1.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D2.BackColor == Color.Purple)
                    {
                        D2.Image = E3.Image;
                        D2.BackColor = Color.Black;
                        E3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D2.BackColor == Color.Yellow)
                    {
                        D2.Image = C3.Image;
                        D2.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void F2_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(F2.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G3.Image, P1.Image) == false && Util.CompararImagem(G3.Image, P2.Image) == false)
                    {
                        G3.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E3.Image, P1.Image) == false && Util.CompararImagem(E3.Image, P2.Image) == false)
                    {
                        E3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F2.BackColor == Color.Purple)
                    {
                        F2.Image = E1.Image;
                        F2.BackColor = Color.Black;
                        E1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F2.BackColor == Color.Yellow)
                    {
                        F2.Image = G1.Image;
                        F2.BackColor = Color.Black;
                        G1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(F2.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E1.Image, P1.Image) == false && Util.CompararImagem(E1.Image, P2.Image) == false)
                    {
                        E1.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(G1.Image, P1.Image) == false && Util.CompararImagem(G1.Image, P2.Image) == false)
                    {
                        G1.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F2.BackColor == Color.Purple)
                    {
                        F2.Image = G3.Image;
                        F2.BackColor = Color.Black;
                        G3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F2.BackColor == Color.Yellow)
                    {
                        F2.Image = E3.Image;
                        F2.BackColor = Color.Black;
                        E3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void H2_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(H2.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G3.Image, P1.Image) == false && Util.CompararImagem(G3.Image, P2.Image) == false)
                    {
                        G3.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (H2.BackColor == Color.Purple)
                    {
                        H2.Image = G1.Image;
                        H2.BackColor = Color.Black;
                        G1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(H2.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G1.Image, P1.Image) == false && Util.CompararImagem(G1.Image, P2.Image) == false)
                    {
                        G1.BackColor = Color.Purple;
                    }
                }
                else
                {
                    if (H2.BackColor == Color.Yellow)
                    {
                        H2.Image = G3.Image;
                        H2.BackColor = Color.Black;
                        G3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(A1.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B2.Image, P1.Image) == false && Util.CompararImagem(B2.Image, P2.Image) == false)
                    {
                        B2.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(A1.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {
                    if (A1.BackColor == Color.Yellow)
                    {
                        A1.Image = B2.Image;
                        A1.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(C1.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D2.Image, P1.Image) == false && Util.CompararImagem(D2.Image, P2.Image) == false)
                    {
                        D2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(B2.Image, P1.Image) == false && Util.CompararImagem(B2.Image, P2.Image) == false)
                    {
                        B2.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(C1.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {
                    if (C1.BackColor == Color.Purple)
                    {
                        C1.Image = B2.Image;
                        C1.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C1.BackColor == Color.Yellow)
                    {
                        C1.Image = B2.Image;
                        C1.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(E1.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F2.Image, P1.Image) == false && Util.CompararImagem(F2.Image, P2.Image) == false)
                    {
                        F2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D2.Image, P1.Image) == false && Util.CompararImagem(D2.Image, P2.Image) == false)
                    {
                        D2.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(E1.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {
                    if (E1.BackColor == Color.Purple)
                    {
                        E1.Image = F2.Image;
                        E1.BackColor = Color.Black;
                        F2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E1.BackColor == Color.Yellow)
                    {
                        E1.Image = D2.Image;
                        E1.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void G1_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(G1.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(H2.Image, P1.Image) == false && Util.CompararImagem(H2.Image, P2.Image) == false)
                    {
                        H2.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F2.Image, P1.Image) == false && Util.CompararImagem(F2.Image, P2.Image) == false)
                    {
                        F2.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(G1.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {
                    if (G1.BackColor == Color.Purple)
                    {
                        G1.Image = H2.Image;
                        G1.BackColor = Color.Black;
                        H2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G1.BackColor == Color.Yellow)
                    {
                        G1.Image = F2.Image;
                        G1.BackColor = Color.Black;
                        F2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(A5.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B6.Image, P1.Image) == false && Util.CompararImagem(B6.Image, P2.Image) == false)
                    {
                        B6.BackColor = Color.Purple;
                    }
                }
                else
                {

                    if (A5.BackColor == Color.Yellow)
                    {
                        A5.Image = B4.Image;
                        A5.BackColor = Color.Black;
                        B4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(A5.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B4.Image, P1.Image) == false && Util.CompararImagem(B4.Image, P2.Image) == false)
                    {
                        B4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (A5.BackColor == Color.Purple)
                    {
                        A5.Image = B6.Image;
                        A5.BackColor = Color.Black;
                        B6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(A5.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D6.Image, P1.Image) == false && Util.CompararImagem(D6.Image, P2.Image) == false)
                    {
                        D6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(B6.Image, P1.Image) == false && Util.CompararImagem(B6.Image, P2.Image) == false)
                    {
                        B6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C5.BackColor == Color.Purple)
                    {
                        C5.Image = B4.Image;
                        C5.BackColor = Color.Black;
                        B4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C5.BackColor == Color.Yellow)
                    {
                        C5.Image = D4.Image;
                        C5.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C5.BackColor == Color.Red)
                    {
                        C5.Image = A3.Image;
                        C5.BackColor = Color.Black;
                        A3.Image = A8.Image;
                        B4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(C5.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B4.Image, P1.Image) == false && Util.CompararImagem(B4.Image, P2.Image) == false)
                    {
                        B4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D4.Image, P1.Image) == false && Util.CompararImagem(D4.Image, P2.Image) == false)
                    {
                        D4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C5.BackColor == Color.Purple)
                    {
                        C5.Image = D6.Image;
                        C5.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C5.BackColor == Color.Yellow)
                    {
                        C5.Image = B6.Image;
                        C5.BackColor = Color.Black;
                        B6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            //E5 == pictureBox43 esqueci de trocar a name//
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(E5.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F6.Image, P1.Image) == false && Util.CompararImagem(F6.Image, P2.Image) == false)
                    {
                        F6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D6.Image, P1.Image) == false && Util.CompararImagem(D6.Image, P2.Image) == false)
                    {
                        D6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E5.BackColor == Color.Purple)
                    {
                        E5.Image = D4.Image;
                        E5.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E5.BackColor == Color.Yellow)
                    {
                        E5.Image = F4.Image;
                        E5.BackColor = Color.Black;
                        F4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(E5.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D4.Image, P1.Image) == false && Util.CompararImagem(D4.Image, P2.Image) == false)
                    {
                        D4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F4.Image, P1.Image) == false && Util.CompararImagem(F4.Image, P2.Image) == false)
                    {
                        F4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E5.BackColor == Color.Purple)
                    {
                        E5.Image = F6.Image;
                        E5.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E5.BackColor == Color.Yellow)
                    {
                        E5.Image = D6.Image;
                        E5.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void G5_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(G5.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(H6.Image, P1.Image) == false && Util.CompararImagem(H6.Image, P2.Image) == false)
                    {
                        H6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F6.Image, P1.Image) == false && Util.CompararImagem(F6.Image, P2.Image) == false)
                    {
                        F6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G5.BackColor == Color.Purple)
                    {
                        G5.Image = F4.Image;
                        G5.BackColor = Color.Black;
                        F4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G5.BackColor == Color.Yellow)
                    {
                        G5.Image = H4.Image;
                        G3.BackColor = Color.Black;
                        H4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(G5.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F4.Image, P1.Image) == false && Util.CompararImagem(F4.Image, P2.Image) == false)
                    {
                        F4.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(H4.Image, P1.Image) == false && Util.CompararImagem(H4.Image, P2.Image) == false)
                    {
                        H4.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G5.BackColor == Color.Purple)
                    {
                        G5.Image = H6.Image;
                        G5.BackColor = Color.Black;
                        H6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G5.BackColor == Color.Yellow)
                    {
                        G5.Image = F6.Image;
                        G5.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(B6.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C7.Image, P1.Image) == false && Util.CompararImagem(C7.Image, P2.Image) == false)
                    {
                        C7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(A7.Image, P1.Image) == false && Util.CompararImagem(A7.Image, P2.Image) == false)
                    {
                        A7.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (B6.BackColor == Color.Purple)
                    {
                        B6.Image = A5.Image;
                        B6.BackColor = Color.Black;
                        A5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B6.BackColor == Color.Yellow)
                    {
                        B6.Image = C5.Image;
                        B6.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(B6.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(A5.Image, P1.Image) == false && Util.CompararImagem(A5.Image, P2.Image) == false)
                    {
                        A5.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C5.Image, P1.Image) == false && Util.CompararImagem(C5.Image, P2.Image) == false)
                    {
                        C5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (B6.BackColor == Color.Purple)
                    {
                        B6.Image = C7.Image;
                        B6.BackColor = Color.Black;
                        C7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B6.BackColor == Color.Yellow)
                    {
                        B6.Image = A7.Image;
                        B6.BackColor = Color.Black;
                        A7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void D6_Click(object sender, EventArgs e)
        {
            /*UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(D6.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E7.Image, P1.Image) == false && Util.CompararImagem(E7.Image, P2.Image) == false)
                    {
                        E7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C7.Image, P1.Image) == false && Util.CompararImagem(C7.Image, P2.Image) == false)
                    {
                        C7.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D6.BackColor == Color.Purple)
                    {
                        D6.Image = C5.Image;
                        D6.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D6.BackColor == Color.Yellow)
                    {
                        D6.Image = E5.Image;
                        D6.BackColor = Color.Black;
                        E5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else //vez das pretas
            {
                if (Util.CompararImagem(D6.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C5.Image, P1.Image) == false && Util.CompararImagem(C5.Image, P2.Image) == false)
                    {
                        C5.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E5.Image, P1.Image) == false && Util.CompararImagem(E5.Image, P2.Image) == false)
                    {
                        E5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (D6.BackColor == Color.Purple)
                    {
                        D6.Image = E7.Image;
                        D6.BackColor = Color.Black;
                        E7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D6.BackColor == Color.Yellow)
                    {
                        D6.Image = C7.Image;
                        D6.BackColor = Color.Black;
                        C7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            */
        }

        private void F6_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(F6.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G7.Image, P1.Image) == false && Util.CompararImagem(G7.Image, P2.Image) == false)
                    {
                        G7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E7.Image, P1.Image) == false && Util.CompararImagem(E7.Image, P2.Image) == false)
                    {
                        E7.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F6.BackColor == Color.Purple)
                    {
                        F6.Image = E5.Image;
                        F6.BackColor = Color.Black;
                        E5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F6.BackColor == Color.Yellow)
                    {
                        F6.Image = G5.Image;
                        F6.BackColor = Color.Black;
                        G5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(F6.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E5.Image, P1.Image) == false && Util.CompararImagem(E5.Image, P2.Image) == false)
                    {
                        E5.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(G5.Image, P1.Image) == false && Util.CompararImagem(G5.Image, P2.Image) == false)
                    {
                        G5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F6.BackColor == Color.Purple)
                    {
                        F6.Image = G7.Image;
                        F6.BackColor = Color.Black;
                        G7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F6.BackColor == Color.Yellow)
                    {
                        F6.Image = E7.Image;
                        F6.BackColor = Color.Black;
                        E7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void H6_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(H6.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G7.Image, P1.Image) == false && Util.CompararImagem(G7.Image, P2.Image) == false)
                    {
                        G7.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (H6.BackColor == Color.Purple)
                    {
                        H6.Image = G5.Image;
                        H6.BackColor = Color.Black;
                        G5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(H6.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G5.Image, P1.Image) == false && Util.CompararImagem(G5.Image, P2.Image) == false)
                    {
                        G5.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (F6.BackColor == Color.Purple)
                    {
                        F6.Image = G7.Image;
                        F6.BackColor = Color.Black;
                        G7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (F6.BackColor == Color.Yellow)
                    {
                        F6.Image = E7.Image;
                        F6.BackColor = Color.Black;
                        E7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void A7_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(A7.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B8.Image, P1.Image) == false && Util.CompararImagem(B8.Image, P2.Image) == false)
                    {
                        B8.BackColor = Color.Purple;
                    }
                }
                else
                {

                    if (A7.BackColor == Color.Yellow)
                    {
                        A7.Image = B6.Image;
                        A7.BackColor = Color.Black;
                        B6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(A7.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B6.Image, P1.Image) == false && Util.CompararImagem(B6.Image, P2.Image) == false)
                    {
                        B6.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    if (A7.BackColor == Color.Purple)
                    {
                        A7.Image = B8.Image;
                        A7.BackColor = Color.Black;
                        B8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(C7.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D8.Image, P1.Image) == false && Util.CompararImagem(D8.Image, P2.Image) == false)
                    {
                        D8.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(B8.Image, P1.Image) == false && Util.CompararImagem(B8.Image, P2.Image) == false)
                    {
                        B8.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C7.BackColor == Color.Purple)
                    {
                        C7.Image = B6.Image;
                        C7.BackColor = Color.Black;
                        B6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C7.BackColor == Color.Yellow)
                    {
                        C7.Image = D6.Image;
                        C7.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(C7.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(B6.Image, P1.Image) == false && Util.CompararImagem(B6.Image, P2.Image) == false)
                    {
                        B6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D6.Image, P1.Image) == false && Util.CompararImagem(D6.Image, P2.Image) == false)
                    {
                        D6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (C7.BackColor == Color.Purple)
                    {
                        C7.Image = D8.Image;
                        C7.BackColor = Color.Black;
                        D8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (C7.BackColor == Color.Yellow)
                    {
                        C7.Image = B8.Image;
                        C7.BackColor = Color.Black;
                        B8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void E7_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(E7.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F8.Image, P1.Image) == false && Util.CompararImagem(F8.Image, P2.Image) == false)
                    {
                        F8.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(D8.Image, P1.Image) == false && Util.CompararImagem(D8.Image, P2.Image) == false)
                    {
                        D8.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E7.BackColor == Color.Purple)
                    {
                        E7.Image = D6.Image;
                        E7.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E7.BackColor == Color.Yellow)
                    {
                        E7.Image = F6.Image;
                        E7.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(E7.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(D6.Image, P1.Image) == false && Util.CompararImagem(D6.Image, P2.Image) == false)
                    {
                        D6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F6.Image, P1.Image) == false && Util.CompararImagem(F6.Image, P2.Image) == false)
                    {
                        F6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (E7.BackColor == Color.Purple)
                    {
                        E7.Image = F8.Image;
                        E7.BackColor = Color.Black;
                        F8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (E7.BackColor == Color.Yellow)
                    {
                        E7.Image = D8.Image;
                        E7.BackColor = Color.Black;
                        D8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void G7_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(G7.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(H8.Image, P1.Image) == false && Util.CompararImagem(H8.Image, P2.Image) == false)
                    {
                        H8.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(F8.Image, P1.Image) == false && Util.CompararImagem(F8.Image, P2.Image) == false)
                    {
                        F8.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G7.BackColor == Color.Purple)
                    {
                        G7.Image = F6.Image;
                        G7.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G7.BackColor == Color.Yellow)
                    {
                        G7.Image = H6.Image;
                        G7.BackColor = Color.Black;
                        H6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(G7.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(F6.Image, P1.Image) == false && Util.CompararImagem(F6.Image, P2.Image) == false)
                    {
                        F6.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(H6.Image, P1.Image) == false && Util.CompararImagem(H6.Image, P2.Image) == false)
                    {
                        H6.BackColor = Color.Yellow;
                    }
                }
                else
                {

                    if (G7.BackColor == Color.Purple)
                    {
                        G7.Image = H8.Image;
                        G7.BackColor = Color.Black;
                        H8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (G7.BackColor == Color.Yellow)
                    {
                        G7.Image = F8.Image;
                        G7.BackColor = Color.Black;
                        F8.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(B5.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {

                    if (B8.BackColor == Color.Purple)
                    {
                        B8.Image = A7.Image;
                        B8.BackColor = Color.Black;
                        A7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (B8.BackColor == Color.Yellow)
                    {
                        B8.Image = C7.Image;
                        B8.BackColor = Color.Black;
                        C7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(B8.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(A7.Image, P1.Image) == false && Util.CompararImagem(A7.Image, P2.Image) == false)
                    {
                        A7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(C7.Image, P1.Image) == false && Util.CompararImagem(C7.Image, P2.Image) == false)
                    {
                        C7.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void D8_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(D8.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {

                    if (D8.BackColor == Color.Purple)
                    {
                        D8.Image = C7.Image;
                        D8.BackColor = Color.Black;
                        C7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    if (D8.BackColor == Color.Yellow)
                    {
                        D8.Image = E7.Image;
                        D8.BackColor = Color.Black;
                        E7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(D8.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(C7.Image, P1.Image) == false && Util.CompararImagem(C7.Image, P2.Image) == false)
                    {
                        C7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(E7.Image, P1.Image) == false && Util.CompararImagem(E7.Image, P2.Image) == false)
                    {
                        E7.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void F8_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(F8.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {

                    if (F8.BackColor == Color.Purple)
                    {
                        F8.Image = E7.Image;
                        F8.BackColor = Color.Black;
                        E7.Image = A8.Image;
                    }
                    if (F8.BackColor == Color.Yellow)
                    {
                        F8.Image = G7.Image;
                        F8.BackColor = Color.Black;
                        G7.Image = A8.Image;
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(F8.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(E7.Image, P1.Image) == false && Util.CompararImagem(E7.Image, P2.Image) == false)
                    {
                        E7.BackColor = Color.Purple;
                    }
                    if (Util.CompararImagem(G7.Image, P1.Image) == false && Util.CompararImagem(G7.Image, P2.Image) == false)
                    {
                        G7.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }

        private void H8_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(H8.Image, P1.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
                else
                {

                    if (H8.BackColor == Color.Purple)
                    {
                        H8.Image = G7.Image;
                        H8.BackColor = Color.Black;
                        G7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) + 1);
                    }
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
            else /*vez das pretas*/
            {
                if (Util.CompararImagem(H8.Image, P2.Image))
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                    if (Util.CompararImagem(G7.Image, P1.Image) == false && Util.CompararImagem(G7.Image, P2.Image) == false)
                    {
                        G7.BackColor = Color.Purple;
                    }
                }
                else
                {
                    A1.BackColor = Color.Black;
                    A3.BackColor = Color.Black;
                    A5.BackColor = Color.Black;
                    A7.BackColor = Color.Black;
                    B2.BackColor = Color.Black;
                    B4.BackColor = Color.Black;
                    B6.BackColor = Color.Black;
                    B8.BackColor = Color.Black;
                    C1.BackColor = Color.Black;
                    C3.BackColor = Color.Black;
                    C5.BackColor = Color.Black;
                    C7.BackColor = Color.Black;
                    D2.BackColor = Color.Black;
                    D4.BackColor = Color.Black;
                    D6.BackColor = Color.Black;
                    D8.BackColor = Color.Black;
                    E1.BackColor = Color.Black;
                    E3.BackColor = Color.Black;
                    E5.BackColor = Color.Black;
                    F2.BackColor = Color.Black;
                    F4.BackColor = Color.Black;
                    F6.BackColor = Color.Black;
                    F8.BackColor = Color.Black;
                    G1.BackColor = Color.Black;
                    G3.BackColor = Color.Black;
                    G5.BackColor = Color.Black;
                    G7.BackColor = Color.Black;
                    H2.BackColor = Color.Black;
                    H4.BackColor = Color.Black;
                    H6.BackColor = Color.Black;
                    H8.BackColor = Color.Black;
                }
            }
        }
    }
}
