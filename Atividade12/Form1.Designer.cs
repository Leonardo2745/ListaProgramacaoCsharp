namespace Atividade12
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
            txtMatriz = new TextBox();
            txtLinha = new TextBox();
            btnSomar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtMatriz
            // 
            txtMatriz.Location = new Point(303, 94);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(100, 23);
            txtMatriz.TabIndex = 0;
            // 
            // txtLinha
            // 
            txtLinha.Location = new Point(303, 137);
            txtLinha.Name = "txtLinha";
            txtLinha.Size = new Size(100, 23);
            txtLinha.TabIndex = 1;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(316, 177);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 2;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(334, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(10, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnSomar);
            Controls.Add(txtLinha);
            Controls.Add(txtMatriz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatriz;
        private TextBox txtLinha;
        private Button btnSomar;
        private Label lblResultado;
    }
}
