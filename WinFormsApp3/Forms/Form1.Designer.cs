namespace WinFormsApp3
{
    partial class SingInForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlogin = new Button();
            btnentrar = new Button();
            btnsair = new Button();
            txtnome = new TextBox();
            txtsenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelerro = new Label();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Teal;
            btnlogin.Location = new Point(50, 245);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(95, 35);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnentrar
            // 
            btnentrar.BackColor = Color.Green;
            btnentrar.Location = new Point(254, 245);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(95, 35);
            btnentrar.TabIndex = 1;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = false;
            btnentrar.Click += btnentrar_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Maroon;
            btnsair.Location = new Point(141, 301);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(116, 35);
            btnsair.TabIndex = 2;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(50, 64);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(168, 23);
            txtnome.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(50, 130);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(168, 23);
            txtsenha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(233, 67);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome De Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(254, 133);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Senha";
            // 
            // labelerro
            // 
            labelerro.AutoSize = true;
            labelerro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelerro.ForeColor = Color.FromArgb(50, 50, 50);
            labelerro.Location = new Point(50, 194);
            labelerro.Name = "labelerro";
            labelerro.Size = new Size(309, 20);
            labelerro.TabIndex = 7;
            labelerro.Text = "usuario ou senha incorretos tente novamente.";
            // 
            // SingInForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(400, 374);
            Controls.Add(labelerro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsenha);
            Controls.Add(txtnome);
            Controls.Add(btnsair);
            Controls.Add(btnentrar);
            Controls.Add(btnlogin);
            Name = "SingInForm1";
            Text = "Singin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnentrar;
        private Button btnsair;
        private TextBox txtnome;
        private TextBox txtsenha;
        private Label label1;
        private Label label2;
        private Label labelerro;
    }
}
