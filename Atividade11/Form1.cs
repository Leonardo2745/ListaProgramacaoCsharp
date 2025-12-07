namespace Atividade11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê os valores digitados no TextBox
            string entrada = txtValores.Text;

            // Quebra os valores por espaço, vírgula ou quebra de linha
            string[] valores = entrada.Split(new char[] { ' ', ',', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Verifica se o usuário digitou 12 valores (4x3)
            if (valores.Length != 12)
            {
                MessageBox.Show("Digite exatamente 12 números!");
                return;
            }

            int[,] matriz = new int[4, 3];
            int index = 0;

            // Preenche a matriz com os números digitados
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = int.Parse(valores[index]);
                    index++;
                }
            }

            int positivos = 0, negativos = 0, zeros = 0;

            // Conta números da matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] > 0) positivos++;
                    else if (matriz[i, j] < 0) negativos++;
                    else zeros++;
                }
            }

            // Exibe o resultado
            lblPositivos.Text = $"Positivos: {positivos}";
            lblNegativos.Text = $"Negativos: {negativos}";
            lblZeros.Text = $"Zeros: {zeros}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
