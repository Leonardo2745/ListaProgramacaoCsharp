namespace Atividade9
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
            labelTitle = new Label();
            matrizOutput = new Label();
            resultOutput = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(343, 58);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(65, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Matriz:";
            // 
            // matrizOutput
            // 
            matrizOutput.AutoSize = true;
            matrizOutput.Location = new Point(280, 119);
            matrizOutput.MaximumSize = new Size(200, 200);
            matrizOutput.MinimumSize = new Size(200, 200);
            matrizOutput.Name = "matrizOutput";
            matrizOutput.Size = new Size(200, 200);
            matrizOutput.TabIndex = 1;
            matrizOutput.Text = ".";
            // 
            // resultOutput
            // 
            resultOutput.AutoSize = true;
            resultOutput.Location = new Point(305, 319);
            resultOutput.Name = "resultOutput";
            resultOutput.Size = new Size(16, 25);
            resultOutput.TabIndex = 2;
            resultOutput.Text = ".";
            resultOutput.Click += resultOutput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultOutput);
            Controls.Add(matrizOutput);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label matrizOutput;
        private Label resultOutput;
    }
}
