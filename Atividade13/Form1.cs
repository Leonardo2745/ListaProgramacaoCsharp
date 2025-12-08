namespace Atividade13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Lê e separa os valores digitados
            string[] entrada = txtValores.Text.Split(' ', ',', ';');

            // Verifica se tem valores suficientes
            if (entrada.Length < 6)
            {
                MessageBox.Show("Digite 6 valores para preencher a matriz 2x3.");
                return;
            }

            // Cria matriz 2x3
            int[,] matriz = new int[2, 3];
            int index = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = int.Parse(entrada[index]);
                    index++;
                }
            }

            // Cria matriz transposta 3x2
            int[,] transposta = new int[3, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    transposta[j, i] = matriz[i, j];

            // Exibe matriz original
            listaOriginal.Items.Clear();
            for (int i = 0; i < 2; i++)
            {
                string linha = "";
                for (int j = 0; j < 3; j++)
                    linha += matriz[i, j] + " ";

                listaOriginal.Items.Add(linha);
            }

            // Exibe matriz transposta
            listaTransposta.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                string linha = "";
                for (int j = 0; j < 2; j++)
                    linha += transposta[i, j] + " ";

                listaTransposta.Items.Add(linha);
            }

            MessageBox.Show("Matriz preenchida e transposta gerada com sucesso!");
        }

    }
}
