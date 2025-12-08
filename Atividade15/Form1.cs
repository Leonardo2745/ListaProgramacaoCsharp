namespace Atividade15
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
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Verifica se o TextBox está preenchido
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Digite um número inteiro positivo!");
                return;
            }

            int N = int.Parse(txtNumero.Text);

            // Números menores que 2 não são primos
            if (N < 2)
            {
                lblResultado.Text = "false";
                return;
            }

            bool primo = true;

            // Verificação de divisor
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            // Exibe somente true ou false
            lblResultado.Text = primo.ToString();
        }

    }
}
