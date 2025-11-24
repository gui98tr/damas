using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Properties;
using WinFormsApp3.Util;

namespace WinFormsApp3.Forms
{
    public partial class DamasForms : Form
    {
        Usuario usuario;
        // novas func da dama localizar alvo para matar otr peca
        PictureBox alvoRainha = null;
        //localizar caminho da dama para colorir de preto
        List<PictureBox> caminhoRainha = new List<PictureBox>();

        int segundosPretas = 0;
        int segundosBrancas = 0;

        const int ALTURA = 8;
        const int LARGURA = 8;

        int pecasBrancas = 12;
        int pecasPretas = 12;

        PictureBox[,] tabuleiro = new PictureBox[ALTURA, LARGURA];
        int[,] tabuleiroCode = new int[ALTURA, LARGURA];

        PictureBox pecaSelecionada = null; // Nova variável para controlar a peça selecionada



        public DamasForms(Usuario _usuario = null)
        {
            usuario = _usuario;

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

        private void AtualizarTabuleiroCode()
        {
            UtilCompImg Util = new UtilCompImg();

            for (int i = 0; i < ALTURA; i++)
            {
                for (int j = 0; j < LARGURA; j++)
                {
                    if (Util.CompararImagem(tabuleiro[i, j].Image, P1.Image))
                    {
                        tabuleiroCode[i, j] = 0;
                    }
                    else if (Util.CompararImagem(tabuleiro[i, j].Image, P2.Image))
                    {
                        tabuleiroCode[i, j] = 1;
                    }
                    else if (Util.CompararImagem(tabuleiro[i, j].Image, DamaB()))
                    {
                        tabuleiroCode[i, j] = 2;
                    }
                    else if (Util.CompararImagem(tabuleiro[i, j].Image, DamaP()))
                    {
                        tabuleiroCode[i, j] = 3;
                    }
                    else if (Util.CompararImagem(tabuleiro[i, j].Image, A8.Image))
                    {
                        tabuleiroCode[i, j] = 4;
                    }
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
                bool ehPecaBranca = Util.CompararImagem(pictureBox_clicada.Image, P1.Image) || Util.CompararImagem(pictureBox_clicada.Image, DamaB());
                bool ehPecaPreta = Util.CompararImagem(pictureBox_clicada.Image, P2.Image) || Util.CompararImagem(pictureBox_clicada.Image, DamaP());

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
                    pictureBox_clicada.BackColor == Color.Maroon ||
                    pictureBox_clicada.BackColor == Color.Green ||
                    pictureBox_clicada.BackColor == Color.DarkGreen)
                {
                    // Movimento válido - executa
                    MovimentarPeça(posicao);
                }
                else
                {
                    // Clicou em outra peça do mesmo jogador - reseleciona
                    bool ehPecaBranca = Util.CompararImagem(pictureBox_clicada.Image, DamaB()) || Util.CompararImagem(pictureBox_clicada.Image, P1.Image);
                    bool ehPecaPreta = Util.CompararImagem(pictureBox_clicada.Image, P2.Image) || Util.CompararImagem(pictureBox_clicada.Image, DamaP());

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

        private void MostrarMovimentosPossiveis(Point posicao, bool ehCombo = false)
        {
            ResetarCores();

            UtilCompImg Util = new UtilCompImg();
            int x = posicao.X;
            int y = posicao.Y;
            int turno = Convert.ToInt32(LP1.Text) % 2;

            bool temCaptura = false;

            // Brancas (P1) - turno ímpar (1)
            if (turno == 1 && (Util.CompararImagem(tabuleiro[x, y].Image, P1.Image) || Util.CompararImagem(tabuleiro[x, y].Image, DamaB())))
            {
                // Verifica primeiro se tem capturas obrigatórias
                // Movimento diagonal esquerda-cima (y aumenta = sobe)
                try
                {
                    PictureBox esquerda = tabuleiro[x - 1, y + 1];
                    if (Util.CompararImagem(esquerda.Image, P2.Image) || Util.CompararImagem(esquerda.Image, DamaP()))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x - 2, y + 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) &&
                                !Util.CompararImagem(destino.Image, DamaB()) &&
                                !Util.CompararImagem(destino.Image, DamaP()))
                            {
                                destino.BackColor = Color.Red;
                                temCaptura = true;
                            }
                            if (ehCombo)
                            {
                                PictureBox destinob = tabuleiro[x - 2, y - 2];
                                if (!Util.CompararImagem(destinob.Image, P1.Image) &&
                                    !Util.CompararImagem(destinob.Image, P2.Image) &&
                                !Util.CompararImagem(destino.Image, DamaB()) &&
                                !Util.CompararImagem(destino.Image, DamaP()))
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
                    if (Util.CompararImagem(direita.Image, P2.Image) || Util.CompararImagem(direita.Image, DamaP()))
                    {
                        // Pode capturar
                        try
                        {
                            PictureBox destino = tabuleiro[x + 2, y + 2];
                            if (!Util.CompararImagem(destino.Image, P1.Image) &&
                                !Util.CompararImagem(destino.Image, P2.Image) &&
                                !Util.CompararImagem(destino.Image, DamaB()) &&
                                !Util.CompararImagem(destino.Image, DamaP()))
                            {
                                destino.BackColor = Color.DarkRed;
                                temCaptura = true;
                            }
                            if (ehCombo)
                            {
                                PictureBox destinob = tabuleiro[x + 2, y - 2];
                                if (!Util.CompararImagem(destinob.Image, P1.Image) &&
                                    !Util.CompararImagem(destinob.Image, P2.Image) &&
                                !Util.CompararImagem(destinob.Image, DamaB()) &&
                                !Util.CompararImagem(destinob.Image, DamaP()))
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
                            !Util.CompararImagem(esquerda.Image, P2.Image) &&
                            Util.CompararImagem(tabuleiro[x, y].Image, P1.Image))
                        {
                            esquerda.BackColor = Color.Yellow;
                        }
                    }
                    catch { }

                    try
                    {
                        PictureBox direita = tabuleiro[x + 1, y + 1];
                        if (!Util.CompararImagem(direita.Image, P1.Image) &&
                            !Util.CompararImagem(direita.Image, P2.Image) &&
                            Util.CompararImagem(tabuleiro[x, y].Image, P1.Image))
                        {
                            direita.BackColor = Color.Purple;
                        }
                    }
                    catch { }
                }
                if (Util.CompararImagem(tabuleiro[x, y].Image, DamaB()))
                {
                    // Verificando todas as posicoes da rainha
                    bool dc = true;
                    bool dd = true;
                    bool ec = true;
                    bool ed = true;
                    // Verificando todas as posicoes da rainha
                    for (int i = 1; i <= 7; i++)
                    {

                        if (dc)
                        {
                            try
                            {
                                PictureBox direitac = tabuleiro[x + i, y + i];
                                if (Util.CompararImagem(direitac.Image, P1.Image) ||
                                   Util.CompararImagem(direitac.Image, P2.Image))
                                {
                                    if(Util.CompararImagem(direitac.Image, P1.Image))
                                        dc = false;
                                    else if(Util.CompararImagem(direitac.Image, P2.Image) || Util.CompararImagem(direitac.Image, DamaP()))
                                    {
                                        alvoRainha = tabuleiro[x + i, y + i];
                                        PictureBox direitac2 = tabuleiro[x + i + 1, y + i + 1];
                                        direitac2.BackColor = Color.DarkGreen;
                                        dc = false;
                                    }
                                }
                                else
                                {
                                    direitac.BackColor = Color.Green;
                                    caminhoRainha.Add(direitac);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (dd)
                        {
                            try
                            {
                                PictureBox direitad = tabuleiro[x + i, y - i];
                                if (Util.CompararImagem(direitad.Image, P1.Image) ||
                                   Util.CompararImagem(direitad.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(direitad.Image, P1.Image))
                                        dd = false;
                                    else if (Util.CompararImagem(direitad.Image, P2.Image) || Util.CompararImagem(direitad.Image, DamaP()))
                                    {
                                        PictureBox direitad2 = tabuleiro[x + i + 1, y - i - 1];
                                        direitad2.BackColor = Color.DarkGreen;
                                        dd = false;
                                    }
                                }
                                else
                                {
                                    direitad.BackColor = Color.Green;
                                    caminhoRainha.Add(direitad);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (ed)
                        {
                            try
                            {
                                PictureBox esquerdab = tabuleiro[x - i, y - i];

                                if (Util.CompararImagem(esquerdab.Image, P1.Image) ||
                                   Util.CompararImagem(esquerdab.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(esquerdab.Image, P1.Image))
                                        ed = false;
                                    else if (Util.CompararImagem(esquerdab.Image, P2.Image) || Util.CompararImagem(esquerdab.Image, DamaP()))
                                    {
                                        PictureBox esquerdab2 = tabuleiro[x - i - 1, y - i - 1];
                                        esquerdab2.BackColor = Color.DarkGreen;
                                        ed = false;
                                    }
                                }
                                else 
                                {
                                    esquerdab.BackColor = Color.Green;
                                    caminhoRainha.Add(esquerdab);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (ec)
                        {
                            try
                            {
                                PictureBox esquerdac = tabuleiro[x - i, y + i];

                                if (Util.CompararImagem(esquerdac.Image, P1.Image) ||
                                   Util.CompararImagem(esquerdac.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(esquerdac.Image, P1.Image))
                                        ec = false;
                                    else if (Util.CompararImagem(esquerdac.Image, P2.Image) || Util.CompararImagem(esquerdac.Image, DamaP()))
                                    {
                                        PictureBox esquerdac2 = tabuleiro[x - i - 1, y + i + 1];
                                        esquerdac2.BackColor = Color.DarkGreen;
                                        ec = false;
                                    }
                                }
                                else 
                                {
                                    esquerdac.BackColor = Color.Green;
                                    caminhoRainha.Add(esquerdac);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }

            // Pretas (P2) - turno par (0)
            if (turno == 0 &&(Util.CompararImagem(tabuleiro[x, y].Image, DamaP())  || Util.CompararImagem(tabuleiro[x, y].Image, P2.Image)))
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
                                !Util.CompararImagem(destino.Image, P2.Image) &&
                                !Util.CompararImagem(destino.Image, DamaB()) &&
                                !Util.CompararImagem(destino.Image, DamaP()))
                            {
                                destino.BackColor = Color.Red;
                                temCaptura = true;
                            }
                            if (ehCombo)
                            {
                                PictureBox destinoc = tabuleiro[x - 2, y + 2];
                                if (!Util.CompararImagem(destinoc.Image, P1.Image) &&
                                    !Util.CompararImagem(destinoc.Image, P2.Image) &&
                                !Util.CompararImagem(destinoc.Image, DamaB()) &&
                                !Util.CompararImagem(destinoc.Image, DamaP()))
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
                                !Util.CompararImagem(destino.Image, P2.Image) &&
                                !Util.CompararImagem(destino.Image, DamaB()) &&
                                !Util.CompararImagem(destino.Image, DamaP()))
                            {
                                destino.BackColor = Color.DarkRed;
                                temCaptura = true;
                            }
                            if (ehCombo)
                            {
                                PictureBox destinoc = tabuleiro[x + 2, y + 2];
                                if (!Util.CompararImagem(destinoc.Image, P1.Image) &&
                                    !Util.CompararImagem(destinoc.Image, P2.Image) &&
                                !Util.CompararImagem(destinoc.Image, DamaB()) &&
                                !Util.CompararImagem(destinoc.Image, DamaP()))
                                {
                                    destinoc.BackColor = Color.Maroon;
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
                            !Util.CompararImagem(esquerda.Image, P2.Image) &&
                                !Util.CompararImagem(esquerda.Image, DamaB()) &&
                                !Util.CompararImagem(esquerda.Image, DamaP()))
                        {
                            esquerda.BackColor = Color.Purple;
                        }
                    }
                    catch { }

                    try
                    {
                        PictureBox direita = tabuleiro[x + 1, y - 1];
                        if (!Util.CompararImagem(direita.Image, P1.Image) &&
                            !Util.CompararImagem(direita.Image, P2.Image) &&
                                !Util.CompararImagem(direita.Image, DamaB()) &&
                                !Util.CompararImagem(direita.Image, DamaP()))
                        {
                            direita.BackColor = Color.Yellow;
                        }
                    }
                    catch { }
                }
                //Dama
                if (Util.CompararImagem(tabuleiro[x, y].Image, DamaP()))
                {
                    bool dc = true;
                    bool dd = true;
                    bool ec = true;
                    bool ed = true;
                    // Verificando todas as posicoes da rainha
                    for (int i = 1; i <= 7; i++)
                    {

                        if (dc)
                        {
                            try
                            {
                                PictureBox direitac = tabuleiro[x + i, y + i];
                                if (Util.CompararImagem(direitac.Image, P1.Image) ||
                                   Util.CompararImagem(direitac.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(direitac.Image, P2.Image))
                                        dc = false;
                                    else if (Util.CompararImagem(direitac.Image, P1.Image) || Util.CompararImagem(direitac.Image, DamaB()))
                                    {
                                        alvoRainha = tabuleiro[x + i, y + i];
                                        PictureBox direitac2 = tabuleiro[x + i + 1, y + i + 1];
                                        direitac2.BackColor = Color.DarkGreen;
                                        dc = false;
                                    }
                                }
                                else
                                {
                                    direitac.BackColor = Color.Green;
                                    caminhoRainha.Add(direitac);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (dd)
                        {
                            try
                            {
                                PictureBox direitad = tabuleiro[x + i, y - i];
                                
                                if (Util.CompararImagem(direitad.Image, P1.Image) ||
                                   Util.CompararImagem(direitad.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(direitad.Image, P2.Image))
                                        dd = false;
                                    else if (Util.CompararImagem(direitad.Image, P1.Image) || Util.CompararImagem(direitad.Image, DamaB()))
                                    {
                                        PictureBox direitad2 = tabuleiro[x + i + 1, y - i - 1];
                                        direitad2.BackColor = Color.DarkGreen;
                                        dd = false;
                                    }
                                }
                                else
                                {
                                    direitad.BackColor = Color.Green;
                                    caminhoRainha.Add(direitad);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (ed)
                        {
                            try
                            {
                                PictureBox esquerdab = tabuleiro[x - i, y - i];
                                esquerdab.BackColor = Color.Green;
                                caminhoRainha.Add(esquerdab);
                                if (Util.CompararImagem(esquerdab.Image, P1.Image) ||
                                   Util.CompararImagem(esquerdab.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(esquerdab.Image, P2.Image))
                                        ed = false;
                                    else if (Util.CompararImagem(esquerdab.Image, P1.Image) || Util.CompararImagem(esquerdab.Image, DamaB()))
                                    {
                                        PictureBox esquerdab2 = tabuleiro[x - i - 1, y - i - 1];
                                        esquerdab2.BackColor = Color.DarkGreen;
                                        ed = false;
                                    }
                                }
                                else
                                {
                                    esquerdab.BackColor = Color.Green;
                                    caminhoRainha.Add(esquerdab);
                                }
                            }
                            catch
                            {

                            }
                        }
                        if (ec)
                        {
                            try
                            {
                                PictureBox esquerdac = tabuleiro[x - i, y + i];
                                esquerdac.BackColor = Color.Green;
                                caminhoRainha.Add(esquerdac);
                                if (Util.CompararImagem(esquerdac.Image, P1.Image) ||
                                   Util.CompararImagem(esquerdac.Image, P2.Image))
                                {
                                    if (Util.CompararImagem(esquerdac.Image, P2.Image))
                                        ec = false;
                                    else if (Util.CompararImagem(esquerdac.Image, P1.Image) || Util.CompararImagem(esquerdac.Image, DamaB()))
                                    {
                                        PictureBox esquerdac2 = tabuleiro[x - i - 1, y + i + 1];
                                        esquerdac2.BackColor = Color.DarkGreen;
                                        ec = false;
                                    }
                                }

                            }
                            catch
                            {

                            }
                        }
                    }
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
                //Brancas chegaram no Final
                if (recuperarPosicaoNoTabuleiro(casaDestino).Y == 7 && Convert.ToInt32(LP1.Text) % 2 == 1)
                {
                    //Graduar B
                    // G7.Image = (Image)resources.GetObject("G7.Image");

                    casaDestino.Image = DamaB();
                    pecaSelecionada.Image = null;
                    pecaSelecionada = null;

                    ResetarCores();
                    ProximoTurno();
                }
                //Pretas chegaram no Final
                else if (recuperarPosicaoNoTabuleiro(casaDestino).Y == 0 && Convert.ToInt32(LP1.Text) % 2 != 1)
                {
                    //Graduar P

                    casaDestino.Image = DamaP();
                    pecaSelecionada.Image = null;
                    pecaSelecionada = null;

                    ResetarCores();
                    ProximoTurno();

                }
                // Caso normal
                else
                {
                    casaDestino.Image = pecaSelecionada.Image;
                    pecaSelecionada.Image = null;
                    pecaSelecionada = null;

                    ResetarCores();
                    ProximoTurno();
                }
            }
            // Captura (distância 2)
            else if (Math.Abs(xDestino - xOrigem) == 2)
            {

                // Remove a peça capturada
                // TENTATIVA DE COMER COM A RAINHA
                int xMeio = (xOrigem + xDestino) / 2;
                int yMeio = (yOrigem + yDestino) / 2;

                tabuleiro[xMeio, yMeio].Image = null;


                // Move a peça
                casaDestino.Image = pecaSelecionada.Image;
                pecaSelecionada.Image = null;

                string ganhou = Vitoria();
                if(ganhou != null)
                {
                    FinalForm finalForm = new FinalForm(ganhou);
                    finalForm.ShowDialog();
                }
                // Verifica se pode capturar novamente
                pecaSelecionada = casaDestino;
                ResetarCores();
                bool podeCapturarNovamente = VerificarCapturaDisponivel(destino);

                if (podeCapturarNovamente)
                {
                    // Mostra as capturas disponíveis
                    MostrarMovimentosPossiveis(destino, true);
                    tabuleiro[xOrigem, yOrigem].BackColor = Color.Black;
                    tabuleiro[xMeio, yMeio].BackColor = Color.Black;
                }
                else
                {
                    pecaSelecionada = null;
                    //Brancas chegaram no Final
                    if (recuperarPosicaoNoTabuleiro(casaDestino).Y == 7 && Convert.ToInt32(LP1.Text) % 2 == 1)
                    {
                        //Graduar B
                        // G7.Image = (Image)resources.GetObject("G7.Image");

                        casaDestino.Image = DamaB();
                        pecaSelecionada = null;

                        ResetarCores();
                        ProximoTurno();
                    }
                    //Pretas chegaram no Final
                    else if (recuperarPosicaoNoTabuleiro(casaDestino).Y == 0 && Convert.ToInt32(LP1.Text) % 2 != 1)
                    {
                        //Graduar P

                        casaDestino.Image = DamaP();
                        pecaSelecionada = null;

                        ResetarCores();
                        ProximoTurno();

                    }
                    ProximoTurno();
                }
            }
            else if (Util.CompararImagem(pecaSelecionada.Image, DamaB()) || Util.CompararImagem(pecaSelecionada.Image, DamaP()))
            {
                if (alvoRainha != null)
                {
                    alvoRainha.Image = null;
                }
                casaDestino.Image = pecaSelecionada.Image;
                pecaSelecionada.Image = null;
                foreach(PictureBox picPosicao in caminhoRainha)
                {
                    picPosicao.BackColor = Color.Black;
                }
                caminhoRainha.Clear();
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
            // Vez das pretas
            if (turnoAtual % 2 == 0)
            {
                timerPretas.Start();
                timerBrancas.Stop();
            }
            // Vez das brancas
            else
            {
                timerBrancas.Start();
                timerPretas.Stop();
            }
            if(usuario == null)
                LP1.Text = (turnoAtual + 1).ToString();
            // se eu entrei nesse else, é pq estou jogando remoto
            else
            {
                LP1.Text = (turnoAtual + 1).ToString();
                // preciso atualizar a flag do turno no banco
                /*
                 *
                 * PartidaRepositorio pR = new PartidaRepositorio();
                 * pR.AtualizarTurnoPartida(LP1.Text);
                 * 
                 */
            }


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

        private void timerBrancas_Tick(object sender, EventArgs e)
        {
            segundosBrancas++;
            lblBrancasTempo.Text = "Tempo: " + segundosBrancas.ToString();
        }

        private void timerPretas_Tick(object sender, EventArgs e)
        {
            segundosPretas++;
            lblPretasTempo.Text = "Tempo: " + segundosPretas.ToString();
        }
        private string Vitoria()
        {
            UtilCompImg Util = new UtilCompImg();
            // Tem Peça Branca
            if (   Util.CompararImagem(A1.Image, P1.Image) == false
                && Util.CompararImagem(A3.Image, P1.Image) == false
                && Util.CompararImagem(A5.Image, P1.Image) == false
                && Util.CompararImagem(A7.Image, P1.Image) == false
                && Util.CompararImagem(C1.Image, P1.Image) == false
                && Util.CompararImagem(C3.Image, P1.Image) == false
                && Util.CompararImagem(C5.Image, P1.Image) == false
                && Util.CompararImagem(C7.Image, P1.Image) == false
                && Util.CompararImagem(B2.Image, P1.Image) == false
                && Util.CompararImagem(B4.Image, P1.Image) == false
                && Util.CompararImagem(B6.Image, P1.Image) == false
                && Util.CompararImagem(B8.Image, P1.Image) == false
                && Util.CompararImagem(D2.Image, P1.Image) == false
                && Util.CompararImagem(D4.Image, P1.Image) == false
                && Util.CompararImagem(D6.Image, P1.Image) == false
                && Util.CompararImagem(D8.Image, P1.Image) == false
                && Util.CompararImagem(E1.Image, P1.Image) == false
                && Util.CompararImagem(E3.Image, P1.Image) == false
                && Util.CompararImagem(E5.Image, P1.Image) == false
                && Util.CompararImagem(E7.Image, P1.Image) == false
                && Util.CompararImagem(F2.Image, P1.Image) == false
                && Util.CompararImagem(F4.Image, P1.Image) == false
                && Util.CompararImagem(F6.Image, P1.Image) == false
                && Util.CompararImagem(F8.Image, P1.Image) == false
                && Util.CompararImagem(G1.Image, P1.Image) == false
                && Util.CompararImagem(G3.Image, P1.Image) == false
                && Util.CompararImagem(G5.Image, P1.Image) == false
                && Util.CompararImagem(G7.Image, P1.Image) == false
                && Util.CompararImagem(H2.Image, P1.Image) == false
                && Util.CompararImagem(H4.Image, P1.Image) == false
                && Util.CompararImagem(H6.Image, P1.Image) == false
                && Util.CompararImagem(H8.Image, P1.Image) == false)
            {
                return "Pretas ganharam";
            }
            //Tem Peça Preta
            if (Util.CompararImagem(A1.Image, P2.Image) == false
                && Util.CompararImagem(A3.Image, P2.Image) == false
                && Util.CompararImagem(A5.Image, P2.Image) == false
                && Util.CompararImagem(A7.Image, P2.Image) == false
                && Util.CompararImagem(C1.Image, P2.Image) == false
                && Util.CompararImagem(C3.Image, P2.Image) == false
                && Util.CompararImagem(C5.Image, P2.Image) == false
                && Util.CompararImagem(C7.Image, P2.Image) == false
                && Util.CompararImagem(B2.Image, P2.Image) == false
                && Util.CompararImagem(B4.Image, P2.Image) == false
                && Util.CompararImagem(B6.Image, P2.Image) == false
                && Util.CompararImagem(B8.Image, P2.Image) == false
                && Util.CompararImagem(D2.Image, P2.Image) == false
                && Util.CompararImagem(D4.Image, P2.Image) == false
                && Util.CompararImagem(D6.Image, P2.Image) == false
                && Util.CompararImagem(D8.Image, P2.Image) == false
                && Util.CompararImagem(E1.Image, P2.Image) == false
                && Util.CompararImagem(E3.Image, P2.Image) == false
                && Util.CompararImagem(E5.Image, P2.Image) == false
                && Util.CompararImagem(E7.Image, P2.Image) == false
                && Util.CompararImagem(F2.Image, P2.Image) == false
                && Util.CompararImagem(F4.Image, P2.Image) == false
                && Util.CompararImagem(F6.Image, P2.Image) == false
                && Util.CompararImagem(F8.Image, P2.Image) == false
                && Util.CompararImagem(G1.Image, P2.Image) == false
                && Util.CompararImagem(G3.Image, P2.Image) == false
                && Util.CompararImagem(G5.Image, P2.Image) == false
                && Util.CompararImagem(G7.Image, P2.Image) == false
                && Util.CompararImagem(H2.Image, P2.Image) == false
                && Util.CompararImagem(H4.Image, P1.Image) == false
                && Util.CompararImagem(H6.Image, P1.Image) == false
                && Util.CompararImagem(H8.Image, P1.Image) == false)
            {
                return "Brancas ganharam";
            }
            return null;
        }
        private Image DamaB()
        {
            Image imagem = (Image)resources.GetObject("D_branco");
            return imagem;
        }
        private Image DamaP()
        {
            Image imagem = (Image)resources.GetObject("D_preto");
            return imagem;
        }
    }
}