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
                A1.BackColor = SystemColors.ActiveCaption;
                A3.BackColor = Color.Black;
                A5.BackColor = Color.Black;
                A6.BackColor = Color.Black;
                A8.BackColor = Color.Black;
                B1.BackColor = Color.Black;
                B3.BackColor = Color.Black;
                B5.BackColor = Color.Black;
                B7.BackColor = Color.Black;
                C2.BackColor = Color.Black;
                C4.BackColor = Color.Black;
                C6.BackColor = Color.Black;
                C8.BackColor = Color.Black;
                D2.BackColor = Color.Black;
                D3.BackColor = Color.Black;
                D5.BackColor = Color.Black;
                D7.BackColor = Color.Black;
                E2.BackColor = Color.Black;
                E4.BackColor = Color.Black;
                E6.BackColor = Color.Black;
                E8.BackColor = Color.Black;
                F1.BackColor = Color.Black;
                F3.BackColor = Color.Black;
                F5.BackColor = Color.Black;
                F7.BackColor = Color.Black;
                G2.BackColor = Color.Black;
                G4.BackColor = Color.Black;
                G6.BackColor = Color.Black;
                G8.BackColor = Color.Black;
                H1.BackColor = Color.Black;
                H3.BackColor = Color.Black;
                H5.BackColor = Color.Black;
                H7.BackColor = Color.Black;
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

        private void G4_Click(object sender, EventArgs e)
        {

        }
    }
}
