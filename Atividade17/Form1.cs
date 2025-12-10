namespace Atividade17
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
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Preco = double.Parse(txtPreco.Text);
            produto.QuantidadeEmEstoque = int.Parse(txtQuantidade.Text);

            double valorTotal = produto.CalcularValorTotalEmEstoque();

            lblResultado.Text = $"Valor total em estoque: R$ {valorTotal:F2}";
        }

    }
}
