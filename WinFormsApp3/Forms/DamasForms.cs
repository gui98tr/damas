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
        public DamasForms()
        {
            InitializeComponent();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();

            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0 /*vez das brancas*/)
            {
                if (Util.CompararImagem(A3.Image,P1.Image))
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
                    pictureBox43.BackColor = Color.Black;
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
                }
                else
                {
                    
                    if (A3.BackColor == Color.Yellow)
                    {
                        A3.Image = B2.Image;
                        A3.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                if (Util.CompararImagem(A3.Image, P2.Image))
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
                    pictureBox43.BackColor = Color.Black;
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
                    
                    if (A3.BackColor == Color.Purple)
                    {
                        A3.Image = B2.Image;
                        A3.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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

        private void B4_Click(object sender, EventArgs e)
        {
            UtilCompImg Util = new UtilCompImg();
            if (Convert.ToInt32(LP1.Text) % 2 != 1 || Convert.ToInt32(LP1.Text) == 0)
            {
                if (Util.CompararImagem(B4.Image, P1.Image))
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
                    pictureBox43.BackColor = Color.Black;
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
                    if (Util.CompararImagem(A5.Image, P1.Image) == false && Util.CompararImagem(A5.Image, P2.Image) == false)
                    {
                        A5.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    
                    if (B4.BackColor == Color.Purple)
                    {
                        B4.Image = A3.Image;
                        B4.BackColor = Color.Black;
                        A3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (B4.BackColor == Color.Yellow)
                    {
                        B4.Image = C3.Image;
                        B4.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text) );
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (C3.BackColor == Color.Yellow)
                    {
                        C3.Image = D2.Image;
                        C3.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (E3.BackColor == Color.Yellow)
                    {
                        E3.Image = D2.Image;
                        E3.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        G3.Image = E2.Image;
                        G3.BackColor = Color.Black;
                        B2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (G3.BackColor == Color.Yellow)
                    {
                        G3.Image = H2.Image;
                        G3.BackColor = Color.Black;
                        D2.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (D4.BackColor == Color.Yellow)
                    {
                        D4.Image = E3.Image;
                        D4.BackColor = Color.Black;
                        E3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (F4.BackColor == Color.Yellow)
                    {
                        F4.Image = C3.Image;
                        F4.BackColor = Color.Black;
                        C3.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (B2.BackColor == Color.Yellow)
                    {
                        B2.Image = C1.Image;
                        B2.BackColor = Color.Black;
                        C1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (D2.BackColor == Color.Yellow)
                    {
                        D2.Image = E1.Image;
                        D2.BackColor = Color.Black;
                        E1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (F2.BackColor == Color.Yellow)
                    {
                        F2.Image = G1.Image;
                        F2.BackColor = Color.Black;
                        G1.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (C5.BackColor == Color.Yellow)
                    {
                        C5.Image = D4.Image;
                        C5.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                if (Util.CompararImagem(pictureBox43.Image, P1.Image))
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
                    pictureBox43.BackColor = Color.Black;
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
                    
                    if (pictureBox43.BackColor == Color.Purple)
                    {
                        pictureBox43.Image = D4.Image;
                        pictureBox43.BackColor = Color.Black;
                        D4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (pictureBox43.BackColor == Color.Yellow)
                    {
                        pictureBox43.Image = F4.Image;
                        pictureBox43.BackColor = Color.Black;
                        F4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (G5.BackColor == Color.Yellow)
                    {
                        G5.Image = H4.Image;
                        G3.BackColor = Color.Black;
                        H4.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (B6.BackColor == Color.Yellow)
                    {
                        B6.Image = C5.Image;
                        B6.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
            UtilCompImg Util = new UtilCompImg();
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
                    pictureBox43.BackColor = Color.Black;
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
                    if (Util.CompararImagem(D7.Image, P1.Image) == false && Util.CompararImagem(D7.Image, P2.Image) == false)
                    {
                        D7.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    
                    if (D6.BackColor == Color.Purple)
                    {
                        D6.Image = C5.Image;
                        D6.BackColor = Color.Black;
                        C5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (D6.BackColor == Color.Yellow)
                    {
                        D6.Image = E5.Image;
                        D6.BackColor = Color.Black;
                        E5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (F6.BackColor == Color.Yellow)
                    {
                        F6.Image = G5.Image;
                        F6.BackColor = Color.Black;
                        G5.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (C7.BackColor == Color.Yellow)
                    {
                        C7.Image = D6.Image;
                        C7.BackColor = Color.Black;
                        D6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (E7.BackColor == Color.Yellow)
                    {
                        E7.Image = F6.Image;
                        E7.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                    
                    if (E7.BackColor == Color.Purple)
                    {
                        E7.Image = F6.Image;
                        E7.BackColor = Color.Black;
                        F6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (E7.BackColor == Color.Yellow)
                    {
                        E7.Image = H6.Image;
                        E7.BackColor = Color.Black;
                        H6.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (B8.BackColor == Color.Yellow)
                    {
                        B8.Image = C7.Image;
                        B8.BackColor = Color.Black;
                        C7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
                    }
                    if (D8.BackColor == Color.Yellow)
                    {
                        D8.Image = E7.Image;
                        D8.BackColor = Color.Black;
                        E7.Image = A8.Image;
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        F8.Image = C7.Image;
                        F8.BackColor = Color.Black;
                        C7.Image = A8.Image;
                    }
                    if (F8.BackColor == Color.Yellow)
                    {
                        F8.Image = E7.Image;
                        F8.BackColor = Color.Black;
                        E7.Image = A8.Image;
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
                    pictureBox43.BackColor = Color.Black;
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
                    pictureBox43.BackColor = Color.Black;
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
                        LP1.Text = Convert.ToString(Convert.ToInt32(LP1.Text));
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
                    pictureBox43.BackColor = Color.Black;
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
