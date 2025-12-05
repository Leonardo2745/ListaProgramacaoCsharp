namespace Atividade9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matriz =
            {
                { 1,  2,  3,  4 },
                { 5,  6,  7,  8 },
                { 9, 10, 11, 12 },
                {13, 14, 15, 16 }
            };

            int somaMatrizDP = 0;
            int somaMatrizDS = 0;
            int N = matriz.GetLength(0);


            for (int i = 0; i < N; i++)
            {
                somaMatrizDP += matriz[i, i];
            }


            for (int i = 0; i < N; i++)
            {
                somaMatrizDS += matriz[i, N - 1 - i];
            }


            matrizOutput.Text = "";


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrizOutput.Text += matriz[i, j].ToString().PadLeft(4);
                }
                matrizOutput.Text += "\n";
            }

            resultOutput.Text = "Soma da diagonal Principal: " + somaMatrizDP +
                 "\nSoma da diagonal Secundária: " + somaMatrizDS;
        }

        private void resultOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
