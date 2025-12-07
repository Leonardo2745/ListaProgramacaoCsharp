namespace Atividade11
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
            lblPositivos = new Label();
            lblNegativos = new Label();
            lblZeros = new Label();
            btnCalcular = new Button();
            txtValores = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPositivos
            // 
            lblPositivos.AutoSize = true;
            lblPositivos.Location = new Point(264, 145);
            lblPositivos.Name = "lblPositivos";
            lblPositivos.Size = new Size(10, 15);
            lblPositivos.TabIndex = 0;
            lblPositivos.Text = ".";
            // 
            // lblNegativos
            // 
            lblNegativos.AutoSize = true;
            lblNegativos.Location = new Point(264, 173);
            lblNegativos.Name = "lblNegativos";
            lblNegativos.Size = new Size(10, 15);
            lblNegativos.TabIndex = 1;
            lblNegativos.Text = ".";
            // 
            // lblZeros
            // 
            lblZeros.AutoSize = true;
            lblZeros.Location = new Point(264, 201);
            lblZeros.Name = "lblZeros";
            lblZeros.Size = new Size(10, 15);
            lblZeros.TabIndex = 2;
            lblZeros.Text = ".";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(260, 254);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValores
            // 
            txtValores.Location = new Point(264, 98);
            txtValores.Name = "txtValores";
            txtValores.Size = new Size(100, 23);
            txtValores.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 62);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 5;
            label1.Text = "Digite 12 números com espaço entre eles:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtValores);
            Controls.Add(btnCalcular);
            Controls.Add(lblZeros);
            Controls.Add(lblNegativos);
            Controls.Add(lblPositivos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPositivos;
        private Label lblNegativos;
        private Label lblZeros;
        private Button btnCalcular;
        private TextBox txtValores;
        private Label label1;
    }
}
