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
            // Criar uma inst�ncia do formul�rio MenuPT
            MenuPT menuPT = new MenuPT(idiomaAtual);

            // Mostrar o formul�rio MenuPT
            menuPT.Show();

            // Opcionalmente, voc� pode ocultar o formul�rio atual (Principal)
            this.Hide();
            // Associar o idiomaAtual ao valor desejado quando pictureBox1 for clicado
            
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idiomaAtual = "ingles";
            // Criar uma inst�ncia do formul�rio MenuPT
            MenuPT menuPT = new MenuPT(idiomaAtual);

            // Mostrar o formul�rio MenuPT
            menuPT.Show();

            // Opcionalmente, voc� pode ocultar o formul�rio atual (Principal)
            this.Hide();
            // Associar o idiomaAtual ao valor desejado quando pictureBox1 for clicado
            
    }
    }
}
