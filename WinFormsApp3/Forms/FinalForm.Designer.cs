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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            btnFechar = new Button();
            lblVitoria = new Label();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(156, 110);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "button1";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblVitoria
            // 
            lblVitoria.AutoSize = true;
            lblVitoria.Location = new Point(172, 50);
            lblVitoria.Name = "lblVitoria";
            lblVitoria.Size = new Size(38, 15);
            lblVitoria.TabIndex = 1;
            lblVitoria.Text = "label1";
            lblVitoria.Click += lblVitoria_Click;
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 186);
            Controls.Add(lblVitoria);
            Controls.Add(btnFechar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FinalForm";
            Text = "FinalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Label lblVitoria;
    }
}