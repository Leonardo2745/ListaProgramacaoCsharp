namespace Atividade18
{
    partial class Form1
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
            txtNome = new TextBox();
            btnCachorro = new Button();
            btnGato = new Button();
            lblSaida = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(340, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // btnCachorro
            // 
            btnCachorro.Location = new Point(352, 104);
            btnCachorro.Name = "btnCachorro";
            btnCachorro.Size = new Size(75, 23);
            btnCachorro.TabIndex = 1;
            btnCachorro.Text = "Cachorro";
            btnCachorro.UseVisualStyleBackColor = true;
            btnCachorro.Click += btnCachorro_Click;
            // 
            // btnGato
            // 
            btnGato.Location = new Point(352, 143);
            btnGato.Name = "btnGato";
            btnGato.Size = new Size(75, 23);
            btnGato.TabIndex = 2;
            btnGato.Text = "Gato";
            btnGato.UseVisualStyleBackColor = true;
            btnGato.Click += btnGato_Click;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Location = new Point(381, 189);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(10, 15);
            lblSaida.TabIndex = 3;
            lblSaida.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaida);
            Controls.Add(btnGato);
            Controls.Add(btnCachorro);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnCachorro;
        private Button btnGato;
        private Label lblSaida;
    }
}
