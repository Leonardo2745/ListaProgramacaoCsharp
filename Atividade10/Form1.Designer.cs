namespace Atividade10
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
            inputMatriz = new TextBox();
            btnMatriz = new Button();
            labelText = new Label();
            positionMatriz = new Label();
            matrizLabel = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // inputMatriz
            // 
            inputMatriz.Location = new Point(282, 112);
            inputMatriz.Name = "inputMatriz";
            inputMatriz.Size = new Size(150, 31);
            inputMatriz.TabIndex = 0;
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(438, 110);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(112, 34);
            btnMatriz.TabIndex = 1;
            btnMatriz.Text = "Salvar";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnInserir_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(282, 50);
            labelText.Name = "labelText";
            labelText.Size = new Size(143, 25);
            labelText.TabIndex = 2;
            labelText.Text = "Preenha a matriz";
            // 
            // positionMatriz
            // 
            positionMatriz.AutoSize = true;
            positionMatriz.Location = new Point(185, 110);
            positionMatriz.Name = "positionMatriz";
            positionMatriz.Size = new Size(16, 25);
            positionMatriz.TabIndex = 3;
            positionMatriz.Text = ".";
            // 
            // matrizLabel
            // 
            matrizLabel.Location = new Point(140, 180);
            matrizLabel.MaximumSize = new Size(200, 200);
            matrizLabel.MinimumSize = new Size(200, 200);
            matrizLabel.Name = "matrizLabel";
            matrizLabel.Size = new Size(200, 200);
            matrizLabel.TabIndex = 4;
            matrizLabel.Text = ".";
           
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(482, 238);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(59, 25);
            labelResult.TabIndex = 5;
            labelResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(matrizLabel);
            Controls.Add(positionMatriz);
            Controls.Add(labelText);
            Controls.Add(btnMatriz);
            Controls.Add(inputMatriz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputMatriz;
        private Button btnMatriz;
        private Label labelText;
        private Label positionMatriz;
        private Label matrizLabel;
        private Label labelResult;
    }
}
