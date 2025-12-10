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
        private void btnCachorro_Click(object sender, EventArgs e)
        {
            Cachorro dog = new Cachorro();
            dog.Nome = txtNome.Text;

            lblSaida.Text = $"{dog.Nome}: {dog.EmitirSom()}";
        }

        private void btnGato_Click(object sender, EventArgs e)
        {
            Gato cat = new Gato();
            cat.Nome = txtNome.Text;

            lblSaida.Text = $"{cat.Nome}: {cat.EmitirSom()}";
        }


    }
}
