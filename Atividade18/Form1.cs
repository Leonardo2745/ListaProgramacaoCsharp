namespace Atividade18
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
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // Vetor de Animal com polimorfismo
            Animal[] animais = new Animal[3];

            animais[0] = new Cachorro() { Nome = "Pablo" };
            animais[1] = new Gato() { Nome = "Natan" };
            animais[2] = new Cachorro() { Nome = "Kauan" };

            // String que vai acumular o resultado
            string resultado = "";

            foreach (Animal a in animais)
            {
                resultado += $"{a.Nome}: {a.EmitirSom()}\n";
            }

            lblSaida.Text = resultado;
        }



    }
}
