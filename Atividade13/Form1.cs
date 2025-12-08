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
           
            string[] entrada = txtValores.Text.Split(' ', ',', ';');

            
            if (entrada.Length < 6)
            {
                MessageBox.Show("Digite 6 valores para preencher a matriz 2x3.");
                return;
            }

            
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

           
            int[,] transposta = new int[3, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    transposta[j, i] = matriz[i, j];

          
            listaOriginal.Items.Clear();
            for (int i = 0; i < 2; i++)
            {
                string linha = "";
                for (int j = 0; j < 3; j++)
                    linha += matriz[i, j] + " ";

                listaOriginal.Items.Add(linha);
            }

          
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
