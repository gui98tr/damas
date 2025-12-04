namespace WinFormsApp3.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            nometxt = new TextBox();
            senhatxt = new TextBox();
            btnvoltar = new Button();
            btnentrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblMensagem = new Label();
            lblMenssage2 = new Label();
            label4 = new Label();
            emailtxt = new TextBox();
            SuspendLayout();
            // 
            // nometxt
            // 
            nometxt.Location = new Point(44, 79);
            nometxt.Name = "nometxt";
            nometxt.Size = new Size(163, 23);
            nometxt.TabIndex = 0;
            // 
            // senhatxt
            // 
            senhatxt.Location = new Point(44, 147);
            senhatxt.Name = "senhatxt";
            senhatxt.Size = new Size(163, 23);
            senhatxt.TabIndex = 1;
            // 
            // btnvoltar
            // 
            btnvoltar.BackColor = Color.Maroon;
            btnvoltar.Font = new Font("Comic Sans MS", 9F);
            btnvoltar.Location = new Point(58, 228);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(95, 38);
            btnvoltar.TabIndex = 2;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = false;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.Green;
            btnentrar.Font = new Font("Comic Sans MS", 9F);
            btnentrar.Location = new Point(212, 228);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(95, 38);
            btnentrar.TabIndex = 3;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(238, 87);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome De Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(238, 155);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 26);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 6;
            label3.Text = "Cadastro";
            label3.Click += label3_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(58, 205);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 20);
            lblMensagem.TabIndex = 7;
            // 
            // lblMenssage2
            // 
            lblMenssage2.AutoSize = true;
            lblMenssage2.ForeColor = Color.Red;
            lblMenssage2.Location = new Point(58, 173);
            lblMenssage2.Name = "lblMenssage2";
            lblMenssage2.Size = new Size(0, 15);
            lblMenssage2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(238, 122);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Nome De Usuario";
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(44, 114);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(163, 23);
            emailtxt.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(397, 305);
            Controls.Add(label4);
            Controls.Add(emailtxt);
            Controls.Add(lblMenssage2);
            Controls.Add(lblMensagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnentrar);
            Controls.Add(btnvoltar);
            Controls.Add(senhatxt);
            Controls.Add(nometxt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nometxt;
        private TextBox senhatxt;
        private Button btnvoltar;
        private Button btnentrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMensagem;
        private Label lblMenssage2;
        private Label label4;
        private TextBox emailtxt;
    }
}