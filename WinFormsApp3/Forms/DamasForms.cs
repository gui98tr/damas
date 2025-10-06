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

        PictureBox[,] tabuleiro = new PictureBox[ALTURA, LARGURA];
        PictureBox pecaSelecionada = null; // Nova variável para controlar a peça selecionada

        public DamasForms()
        {
            InitializeComponent();

            // Inicializar o contador de lances
            LP1.Text = "1";

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
                    tabuleiro[i, j].Click += posicao_Click;
                }
            }
        }

        private void posicao_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            PictureBox pictureBox_clicada = (PictureBox)sender;
            Point posicao = recuperarPosicaoNoTabuleiro(pictureBox_clicada);

            int turno = Convert.ToInt32(LP1.Text) % 2; // 1 = branco, 0 = preto

            // Se não há peça selecionada, tenta selecionar uma
            if (pecaSelecionada == null)
            {
                // Verifica se clicou em uma casa preta
                if (pictureBox_clicada.BackColor != Color.Black)
                {
                    return;
                }

                // Verifica se a peça pertence ao jogador da vez
                bool ehPecaBranca = Util.CompararImagem(pictureBox_clicada.Image, P1.Image);
                bool ehPecaPreta = Util.CompararImagem(pictureBox_clicada.Image, P2.Image);

                if ((turno == 1 && ehPecaBranca) || (turno == 0 && ehPecaPreta))
                {
                    pecaSelecionada = pictureBox_clicada;
                    MostrarMovimentosPossiveis(posicao);
                }
            }
            else
            {
                // Já há uma peça selecionada, tenta mover para a posição clicada
                if (pictureBox_clicada.BackColor == Color.Yellow ||
                    pictureBox_clicada.BackColor == Color.Purple ||
                    pictureBox_clicada.BackColor == Color.Red ||
                    pictureBox_clicada.BackColor == Color.DarkRed ||
                    pictureBox_clicada.BackColor == Color.Firebrick ||
                    pictureBox_clicada.BackColor == Color.Maroon)
                {
                    // Movimento válido - executa
                    MovimentarPeça(posicao);
                }
                else
                {
                    // Clicou em outra peça do mesmo jogador - reseleciona
                    bool ehPecaBranca = Util.CompararImagem(pictureBox_clicada.Image, P1.Image);
                    bool ehPecaPreta = Util.CompararImagem(pictureBox_clicada.Image, P2.Image);

                    if ((turno == 1 && ehPecaBranca) || (turno == 0 && ehPecaPreta))
                    {
                        pecaSelecionada = pictureBox_clicada;
                        ResetarCores();
                        MostrarMovimentosPossiveis(posicao);
                    }
                    else
                    {
                        // Clicou em lugar inválido - desseleciona
                        pecaSelecionada = null;
                        ResetarCores();
                    }
                }
            }
        }

        private void MostrarMovimentosPossiveis(Point posicao, bool ehCombo = false, 
            bool red = true, bool darkred = true, bool fire = true, bool maroon = true)
        {
            ResetarCores();

            UtilCompImg Util = new UtilCompImg();
            int x = posicao.X;
            int y = posicao.Y;
            int turno = Convert.ToInt32(LP1.Text) % 2;

            bool temCaptura = false;

            // Brancas (P1) - turno ímpar (1)
            if (turno == 1 && Util.CompararImagem(tabuleiro[x, y].Image, P1.Image))
            {
                // Verifica primeiro se tem capturas obrigatórias
                // Movimento diagonal esquerda-cima (y aumenta = sobe)
                try
                {
                    PictureBox esquerda = tabuleiro[x - 1, y + 1];
                    if (Util.CompararImagem(esquerda.Image, P2.Image))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x - 2, y + 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) && red)
                            {
                                destino.BackColor = Color.Red;
                                temCaptura = true;
                            }
                            if(ehCombo && fire)
                            {
                                PictureBox destinob = tabuleiro[x - 2, y - 2];
                                if (!Util.CompararImagem(destinob.Image, P1.Image) &&
                                    !Util.CompararImagem(destinob.Image, P2.Image))
                                {
                                    destinob.BackColor = Color.Firebrick;
                                    temCaptura = true;
                                }
                            }
                            
                        }
                        catch { }
                    }
                }
                catch { }

                // Movimento diagonal direita-cima
                try
                {
                    PictureBox direita = tabuleiro[x + 1, y + 1];
                    if (Util.CompararImagem(direita.Image, P2.Image))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x + 2, y + 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) && darkred)
                            {
                                destino.BackColor = Color.DarkRed;
                                temCaptura = true;
                            }
                            if (ehCombo && maroon)
                            {
                                PictureBox destinob = tabuleiro[x + 2, y - 2];
                                if (!Util.CompararImagem(destinob.Image, P1.Image) &&
                                    !Util.CompararImagem(destinob.Image, P2.Image))
                                {
                                    destinob.BackColor = Color.Maroon;
                                    temCaptura = true;
                                }
                            }
                        }
                        catch { }
                    }
                }
                catch { }

                // Se não tem captura obrigatória, mostra movimentos simples
                if (!temCaptura)
                {
                    try
                    {
                        PictureBox esquerda = tabuleiro[x - 1, y + 1];
                        if (!Util.CompararImagem(esquerda.Image, P1.Image) &&
                            !Util.CompararImagem(esquerda.Image, P2.Image))
                        {
                            esquerda.BackColor = Color.Yellow;
                        }
                    }
                    catch { }

                    try
                    {
                        PictureBox direita = tabuleiro[x + 1, y + 1];
                        if (!Util.CompararImagem(direita.Image, P1.Image) &&
                            !Util.CompararImagem(direita.Image, P2.Image))
                        {
                            direita.BackColor = Color.Purple;
                        }
                    }
                    catch { }
                }
            }

            // Pretas (P2) - turno par (0)
            if (turno == 0 && Util.CompararImagem(tabuleiro[x, y].Image, P2.Image))
            {
                // Verifica primeiro se tem capturas obrigatórias
                // Movimento diagonal esquerda-baixo (y diminui = desce)
                try
                {
                    PictureBox esquerda = tabuleiro[x - 1, y - 1];
                    if (Util.CompararImagem(esquerda.Image, P1.Image))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x - 2, y - 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) && red)
                            {
                                destino.BackColor = Color.Red;
                                temCaptura = true;
                            }
                            if (ehCombo && fire)
                            {
                                PictureBox destinoc = tabuleiro[x - 2, y + 2];
                                if (!Util.CompararImagem(destinoc.Image, P1.Image) &&
                                    !Util.CompararImagem(destinoc.Image, P2.Image))
                                {
                                    destinoc.BackColor = Color.Firebrick;
                                    temCaptura = true;
                                }
                            }
                        }
                        catch { }
                    }
                }
                catch { }

                // Movimento diagonal direita-baixo
                try
                {
                    PictureBox direita = tabuleiro[x + 1, y - 1];
                    if (Util.CompararImagem(direita.Image, P1.Image))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x + 2, y - 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) && darkred)
                            {
                                destino.BackColor = Color.DarkRed;
                                temCaptura = true;
                            }
                            if (ehCombo && fire)
                            {
                                PictureBox destinoc = tabuleiro[x + 2, y + 2];
                                if (!Util.CompararImagem(destinoc.Image, P1.Image) &&
                                    !Util.CompararImagem(destinoc.Image, P2.Image))
                                {
                                    destinoc.BackColor = Color.Firebrick;
                                    temCaptura = true;
                                }
                            }
                        }
                        catch { }
                    }
                }
                catch { }

                // Se não tem captura obrigatória, mostra movimentos simples
                if (!temCaptura)
                {
                    try
                    {
                        PictureBox esquerda = tabuleiro[x - 1, y - 1];
                        if (!Util.CompararImagem(esquerda.Image, P1.Image) &&
                            !Util.CompararImagem(esquerda.Image, P2.Image))
                        {
                            esquerda.BackColor = Color.Purple;
                        }
                    }
                    catch { }

                    try
                    {
                        PictureBox direita = tabuleiro[x + 1, y - 1];
                        if (!Util.CompararImagem(direita.Image, P1.Image) &&
                            !Util.CompararImagem(direita.Image, P2.Image))
                        {
                            direita.BackColor = Color.Yellow;
                        }
                    }
                    catch { }
                }
            }
        }

        private void MovimentarPeça(Point destino)
        {
            if (pecaSelecionada == null) return;

            Point origem = recuperarPosicaoNoTabuleiro(pecaSelecionada);
            UtilCompImg Util = new UtilCompImg();

            int xOrigem = origem.X;
            int yOrigem = origem.Y;
            int xDestino = destino.X;
            int yDestino = destino.Y;

            PictureBox casaDestino = tabuleiro[xDestino, yDestino];

            // Movimento simples (distância 1)
            if (Math.Abs(xDestino - xOrigem) == 1)
            {
                casaDestino.Image = pecaSelecionada.Image;
                pecaSelecionada.Image = null;
                pecaSelecionada = null;
                ResetarCores();
                ProximoTurno();
            }
            // Captura (distância 2)
            else if (Math.Abs(xDestino - xOrigem) == 2)
            {

                // Remove a peça capturada
                int xMeio = (xOrigem + xDestino) / 2;
                int yMeio = (yOrigem + yDestino) / 2;
                tabuleiro[xMeio, yMeio].Image = null;
               
                

                // Move a peça
                casaDestino.Image = pecaSelecionada.Image;
                pecaSelecionada.Image = null;

                // Verifica se pode capturar novamente
                pecaSelecionada = casaDestino;
                ResetarCores();
                bool podeCapturarNovamente = VerificarCapturaDisponivel(destino);

                if (podeCapturarNovamente)
                {
                    // Mostra as capturas disponíveis
                    if (xOrigem - 1 == xMeio && yOrigem + 1 == yMeio)
                        MostrarMovimentosPossiveis(destino, true ,false,true,true,true);
                    else
                    if (xOrigem + 1 == xMeio && yOrigem - 1 == yMeio)
                        MostrarMovimentosPossiveis(destino, true, true, true, false, true);
                    else
                    if (xOrigem + 1 == xMeio && yOrigem + 1 == yMeio)
                        MostrarMovimentosPossiveis(destino, true, true, false, true, true);
                    else
                    if (xOrigem - 1 == xMeio && yOrigem - 1 == yMeio)
                        MostrarMovimentosPossiveis(destino, true, true, true, true, false);
                }
                else
                {
                    pecaSelecionada = null;
                    ProximoTurno();
                }
            }
        }

        private bool VerificarCapturaDisponivel(Point posicao)
        {
            UtilCompImg Util = new UtilCompImg();
            int x = posicao.X;
            int y = posicao.Y;
            int turno = Convert.ToInt32(LP1.Text) % 2;

            // Verifica as 4 direções diagonais
            int[][] direcoes = new int[][]
            {
                new int[] {-1, -1}, new int[] {-1, +1},
                new int[] {+1, -1}, new int[] {+1, +1}
            };

            foreach (var dir in direcoes)
            {
                try
                {
                    int xMeio = x + dir[0];
                    int yMeio = y + dir[1];
                    int xDestino = x + 2 * dir[0];
                    int yDestino = y + 2 * dir[1];

                    PictureBox meio = tabuleiro[xMeio, yMeio];
                    PictureBox destinoBox = tabuleiro[xDestino, yDestino];

                    // Verifica se há peça adversária no meio e destino vazio
                    bool meioPecaAdversaria = false;
                    if (turno == 1)
                    {
                        meioPecaAdversaria = Util.CompararImagem(meio.Image, P2.Image);
                    }
                    else
                    {
                        meioPecaAdversaria = Util.CompararImagem(meio.Image, P1.Image);
                    }

                    bool destinoVazio = !Util.CompararImagem(destinoBox.Image, P1.Image) &&
                                       !Util.CompararImagem(destinoBox.Image, P2.Image);

                    if (meioPecaAdversaria && destinoVazio)
                    {
                        return true;
                    }
                }
                catch { }
            }

            return false;
        }

        private void ResetarCores()
        {
            // Reseta todas as cores para preto nas casas jogáveis
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

        private void ProximoTurno()
        {
            int turnoAtual = Convert.ToInt32(LP1.Text);
            LP1.Text = (turnoAtual + 1).ToString();
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
    }
}