using System;
using System.Text;
using System.Windows.Forms;

namespace Atividade10
{
    public partial class Form1 : Form
    {
       
        private int[,] matriz = new int[3, 5];

        private int linha = 0;
        private int coluna = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            positionMatriz.Text = "[0][0]:";
            matrizLabel.Text = ""; 
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(inputMatriz.Text, out int num))
            {
                MessageBox.Show("Digite um número inteiro válido!", "Erro");
                return;
            }

  
            matriz[linha, coluna] = num;

           
            inputMatriz.Clear();
            inputMatriz.Focus();



            coluna++;
            if (coluna == matriz.GetLength(1))
            {
                coluna = 0;
                linha++;
            }

           
            if (linha == matriz.GetLength(0))
            {
                int maior = matriz[0, 0];
                int linhaMaior = 0;
                int colunaMaior = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] > maior)
                        {
                            maior = matriz[i, j];
                            linhaMaior = i;
                            colunaMaior = j;
                        }
                    }
                }

              
                labelResult.Text = "Maior valor encontrado: " + maior + "\n" +
                    "Posição: Linha " + linhaMaior + " Coluna " + colunaMaior;

               
                matrizLabel.Text = MontarMatrizString();

                
                btnMatriz.Enabled = false;
          
                return;
            }

           
            positionMatriz.Text = "[" + linha + "][" + coluna + "]";
        }

       
        private string MontarMatrizString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sb.Append(matriz[i, j].ToString().PadLeft(4));
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

       
    }
}
