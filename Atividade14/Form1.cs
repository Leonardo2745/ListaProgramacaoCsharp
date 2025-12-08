namespace Atividade14
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
           
            if (txtPeso.Text == "" || txtAltura.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

           
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            
            double imc = peso / (altura * altura);

            string classificacao;

            
            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 25.0)
                classificacao = "Peso normal";
            else if (imc < 30.0)
                classificacao = "Sobrepeso";
            else
                classificacao = "Obesidade";

            
            lblResultado.Text = $"IMC: {imc:F2} - {classificacao}";
        }

    }
}
