namespace WinFormsApp3.Forms
{
    partial class FinalForm
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
            lblVitoria = new Label();
            btnsair = new Button();
            SuspendLayout();
            // 
            // lblVitoria
            // 
            lblVitoria.AutoSize = true;
            lblVitoria.Location = new Point(133, 54);
            lblVitoria.Name = "lblVitoria";
            lblVitoria.Size = new Size(38, 15);
            lblVitoria.TabIndex = 1;
            lblVitoria.Text = "label1";
            lblVitoria.Click += lblVitoria_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.Maroon;
            btnsair.Location = new Point(133, 115);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(116, 35);
            btnsair.TabIndex = 3;
            btnsair.Text = "Fechar";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 186);
            Controls.Add(btnsair);
            Controls.Add(lblVitoria);
            Name = "FinalForm";
            Text = "FinalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVitoria;
        private Button btnsair;
    }
}