namespace Atividade12
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
        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            string entrada = txtMatriz.Text;

            
            string[] valores = entrada.Split(new char[] { ' ', ',', ';', '\n', '\r' },
                                             StringSplitOptions.RemoveEmptyEntries);

            
            if (valores.Length != 12)
            {
                MessageBox.Show("Digite exatamente 12 números para formar a matriz 3x4!");
                return;
            }

            
            int[,] matriz = new int[3, 4];
            int index = 0;

         
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = int.Parse(valores[index]);
                    index++;
                }
            }

            
            if (!int.TryParse(txtLinha.Text, out int linha) || linha < 0 || linha > 2)
            {
                MessageBox.Show("Digite um índice de linha válido (0, 1 ou 2).");
                return;
            }

            int soma = 0;

            
            for (int coluna = 0; coluna < 4; coluna++)
            {
                soma += matriz[linha, coluna];
            }

            
            lblResultado.Text = $"Soma da linha {linha}: {soma}";
        }

    }
}
