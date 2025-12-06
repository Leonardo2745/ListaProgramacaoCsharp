using System;
using System.Text;
using System.Windows.Forms;

namespace Atividade10
{
    public partial class Form1 : Form
    {
        // Matriz 3x5
        private int[,] matriz = new int[3, 5];

        // Índices da posição atual
        private int linha = 0;
        private int coluna = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa o label com a primeira posição
            positionMatriz.Text = "[0][0]";
            matrizLabel.Text = ""; // Label que exibirá a matriz
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Tenta converter o texto do TextBox
            if (!int.TryParse(inputMatriz.Text, out int num))
            {
                MessageBox.Show("Digite um número inteiro válido!", "Erro");
                return;
            }

            // Armazena o número na matriz
            matriz[linha, coluna] = num;

            // Limpa o TextBox
            inputMatriz.Clear();
            inputMatriz.Focus(); // Coloca o foco automaticamente no TextBox


            // Avança para a próxima posição
            coluna++;
            if (coluna == matriz.GetLength(1))
            {
                coluna = 0;
                linha++;
            }

            // Verifica se a matriz foi completamente preenchida
            if (linha == matriz.GetLength(0))
            {
                // Encontrar o maior valor
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

                // Exibe resultado
                labelResult.Text = "Maior valor encontrado: " + maior + "\n" +
                    "Posição: Linha " + linhaMaior + " Coluna " + colunaMaior +
                    "Resultado";

                // Exibe a matriz no Label
                matrizLabel.Text = MontarMatrizString();

                // Desativa botão
                btnMatriz.Enabled = false;
                positionMatriz.Text = "Matriz completa!";
                return;
            }

            // Atualiza o Label para a próxima posição
            positionMatriz.Text = $"[{linha}][{coluna}]";
        }

        // Função para montar uma string da matriz
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
