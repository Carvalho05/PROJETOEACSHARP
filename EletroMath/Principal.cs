namespace EletroMath
{
    public partial class Principal : Form
    {
        private string idiomaAtual;
        public Principal()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            idiomaAtual = "portugues";
            // Criar uma instância do formulário MenuPT
            MenuPT menuPT = new MenuPT(idiomaAtual);

            // Mostrar o formulário MenuPT
            menuPT.Show();

            // Opcionalmente, você pode ocultar o formulário atual (Principal)
            this.Hide();
            // Associar o idiomaAtual ao valor desejado quando pictureBox1 for clicado
            
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idiomaAtual = "ingles";
            // Criar uma instância do formulário MenuPT
            MenuPT menuPT = new MenuPT(idiomaAtual);

            // Mostrar o formulário MenuPT
            menuPT.Show();

            // Opcionalmente, você pode ocultar o formulário atual (Principal)
            this.Hide();
            // Associar o idiomaAtual ao valor desejado quando pictureBox1 for clicado
            
    }
    }
}
