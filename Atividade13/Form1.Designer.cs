namespace Atividade13
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
            txtValores = new TextBox();
            btnGerar = new Button();
            listaOriginal = new ListBox();
            listaTransposta = new ListBox();
            SuspendLayout();
            // 
            // txtValores
            // 
            txtValores.Location = new Point(320, 100);
            txtValores.Name = "txtValores";
            txtValores.Size = new Size(100, 23);
            txtValores.TabIndex = 0;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(426, 100);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "button1";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // listaOriginal
            // 
            listaOriginal.FormattingEnabled = true;
            listaOriginal.ItemHeight = 15;
            listaOriginal.Location = new Point(249, 205);
            listaOriginal.Name = "listaOriginal";
            listaOriginal.Size = new Size(120, 94);
            listaOriginal.TabIndex = 2;
            // 
            // listaTransposta
            // 
            listaTransposta.FormattingEnabled = true;
            listaTransposta.ItemHeight = 15;
            listaTransposta.Location = new Point(441, 205);
            listaTransposta.Name = "listaTransposta";
            listaTransposta.Size = new Size(120, 94);
            listaTransposta.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listaTransposta);
            Controls.Add(listaOriginal);
            Controls.Add(btnGerar);
            Controls.Add(txtValores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValores;
        private Button btnGerar;
        private ListBox listaOriginal;
        private ListBox listaTransposta;
    }
}
