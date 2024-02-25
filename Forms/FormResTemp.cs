using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;

namespace EletroMath.Forms
{
    public partial class FormResTemp : Form
    {
        #region Misc

        private string idiomaCoeficiente;
        public FormResTemp(string idiomaAtual)
        {
            InitializeComponent();
            LoadTheme();
            labelResultado1.ForeColor = ThemeColor.PrimaryColor;

            //Associação da Variável Geral de Idioma do Form Coeficiente com a do Programa
            this.idiomaCoeficiente = idiomaAtual;

            //Função para trocar o Idioma das Caixas de Texto conforme o Idioma Selecionado
            AtualizarTextos();

            //Esconder Label
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            labelResultado1.Visible = false;
            labelResultado2.Visible = false;

            //Esconder TextBox
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            //Esconder Botões
            btnCal.Visible = false;
            btnLimpar.Visible = false;

            //Esconder ComboBoxMaterial
            comboBoxMaterial.Visible = false;         

            //Desativa TextBox1
            textBox1.Enabled = false;

            //Opções da comboBoxMaterial e ComboBox Resistividade
            if (idiomaCoeficiente == "portugues")
            {
                comboBoxMaterial.Items.Add("Cobre");
                comboBoxMaterial.Items.Add("Alumínio");
                comboBoxMaterial.Items.Add("Ferro");
                comboBoxMaterial.Items.Add("Níquel");
                comboBoxMaterial.Items.Add("Vidro");
                comboBoxMaterial.Items.Add("Teflon (PTFE)");
                comboBoxMaterial.Items.Add("Prata");
                comboBoxMaterial.Items.Add("Ouro");
                comboBoxMaterial.Items.Add("Bronze");
                comboBoxMaterial.Items.Add("Aço inoxidável");
                comboBoxMaterial.Items.Add("Poliestireno");
                comboBoxMaterial.Items.Add("Polipropileno");
                comboBoxMaterial.Items.Add(" PVC (Policloreto de Vinila)");

                comboBoxResistividade.Items.Add("Cobre");
                comboBoxResistividade.Items.Add("Alumínio");
                comboBoxResistividade.Items.Add("Ouro");
                comboBoxResistividade.Items.Add("Prata");
                comboBoxResistividade.Items.Add("Ferro");
                comboBoxResistividade.Items.Add("Níquel");
                comboBoxResistividade.Items.Add("Carbono");
                comboBoxResistividade.Items.Add("Tungstênio");
                comboBoxResistividade.Items.Add("Zinco");
                comboBoxResistividade.Items.Add("Platina");
                comboBoxResistividade.Items.Add("Constantan");
                comboBoxResistividade.Items.Add("Silício");
                comboBoxResistividade.Items.Add("Vidro");
            }
            else if (idiomaCoeficiente == "ingles")
            {
                comboBoxMaterial.Items.Add("Copper");
                comboBoxMaterial.Items.Add("Aluminum");
                comboBoxMaterial.Items.Add("Iron");
                comboBoxMaterial.Items.Add("Nickel");
                comboBoxMaterial.Items.Add("Glass");
                comboBoxMaterial.Items.Add("Teflon (PTFE)");
                comboBoxMaterial.Items.Add("Silver");
                comboBoxMaterial.Items.Add("Gold");
                comboBoxMaterial.Items.Add("Bronze");
                comboBoxMaterial.Items.Add("Stainless steel");
                comboBoxMaterial.Items.Add("Polystyrene");
                comboBoxMaterial.Items.Add("Polypropylene");
                comboBoxMaterial.Items.Add("PVC (Polyvinyl Chloride)");

                comboBoxResistividade.Items.Add("Copper");
                comboBoxResistividade.Items.Add("Aluminum");
                comboBoxResistividade.Items.Add("Gold");
                comboBoxResistividade.Items.Add("Silver");
                comboBoxResistividade.Items.Add("Iron");
                comboBoxResistividade.Items.Add("Nickel");
                comboBoxResistividade.Items.Add("Carbon (graphite)");
                comboBoxResistividade.Items.Add("Tungsten");
                comboBoxResistividade.Items.Add("Zinc");
                comboBoxResistividade.Items.Add("Platinum");
                comboBoxResistividade.Items.Add("Constantan");
                comboBoxResistividade.Items.Add("Silicon");
                comboBoxResistividade.Items.Add("Glass");
            }

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxMaterial.SelectedIndex = -1;
            comboBoxResistividade.SelectedIndex = -1;

        }

        //Aplicar Tema de Cores aos Botões
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }

            labelResultado1.ForeColor = ThemeColor.PrimaryColor;
            labelResultado2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void AtualizarTextos()
        {
            if (idiomaCoeficiente == "portugues")
            {
                this.Text = "Resistividade e Coeficiente de Temperatura";
                labelCoeficiente.Text = "Coeficiente de Temperatura";
                labelResultado1.Text = "O Resultado é:";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                button1.Text = "Calcular α";
                button2.Text = "Calcular R2";
                label5.Text = "Comprimento (em m)";
                label6.Text = "Área (em m2)";
                button3.Text = "Calcular";
                btnLimparRes.Text = "Limpar";
                labelResistividade.Text = "Resistividade";

            }
            else if (idiomaCoeficiente == "ingles")
            {
                this.Text = "Resistivity and Temperature Coefficient";
                labelCoeficiente.Text = "Temperature Coefficient";
                labelResultado1.Text = "The result is:";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                button1.Text = "Calculate α";
                button2.Text = "Calculate R2";
                label5.Text = "Length (in m)";
                label6.Text = "Area (in m2)";
                button3.Text = "Calculate";
                btnLimparRes.Text = "Clear";
                labelResistividade.Text = "Resistivity";
            }
        }

        private void FormResTemp_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion Misc

        #region Coeficiente

        #region Cálculo

        #region Cálcular Alpha
        private void InserirAlpha()
        {
            //Retirar Invisibilidade
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            btnCal.Visible = true;
            btnLimpar.Visible = true;

            //Esconder ComboBoxMaterial
            comboBoxMaterial.Visible = false;

            //Ativa TextBox1
            textBox1.Enabled = true;

            //Inserir Frase nas Labels
            if (idiomaCoeficiente == "portugues")
            {
                label1.Text = "Digite o Valor de R1";
                label2.Text = "Digite o Valor de T1";
                label3.Text = "Digite o Valor de R2";
                label4.Text = "Digite o Valor de T2";

                //Ajuste nas Posições
                textBox1.Location = new Point(935, 197);
                textBox2.Location = new Point(935, 243);
                textBox3.Location = new Point(935, 293);
                textBox4.Location = new Point(935, 338);

                label1.Location = new Point(805, 197);
                label2.Location = new Point(805, 243);
                label3.Location = new Point(805, 293);
                label4.Location = new Point(805, 338);
            }
            else if (idiomaCoeficiente == "ingles")
            {
                label1.Text = "Enter the Value of R1";
                label2.Text = "Enter the Value of T1";
                label3.Text = "Enter the Value of R2";
                label4.Text = "Enter the Value of T2";

                //Ajuste nas Posições
                textBox1.Location = new Point(930, 197);
                textBox2.Location = new Point(930, 243);
                textBox3.Location = new Point(930, 293);
                textBox4.Location = new Point(930, 338);

                label1.Location = new Point(790, 197);
                label2.Location = new Point(790, 243);
                label3.Location = new Point(790, 293);
                label4.Location = new Point(790, 338);

                //Ajuste nas Margens
                labelResultado2.Padding = new Padding(15, 0, 0, 0);
            }

        }

        private void CalcularAlpha(TextBox textBoxResultado)
        {
            double R1 = 0, T1 = 0, R2 = 0, T2 = 0, alpha = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out R1) ||
                !double.TryParse(textBox2.Text, out T1) ||
                !double.TryParse(textBox3.Text, out R2) ||
                !double.TryParse(textBox4.Text, out T2))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaCoeficiente == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCoeficiente == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado2.Visible = false;
                textBox6.Visible = false;
                return;
            }

            //Cálculo Seguindo a Respetiva Formúla
            alpha = (R2 - R1) / R1 * (T2 - T1);

            //Imprime o Resultado
            textBoxResultado.Text = alpha.ToString("0.####") + " Ω/ºC";
            labelResultado2.Visible = true;
            textBox6.Visible = true;

        }
        #endregion Cálcular Alpha

        #region R2
        private void InserirR2()
        {
            //Retirar Invisibilidade 
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            btnCal.Visible = true;
            btnLimpar.Visible = true;
            comboBoxMaterial.Visible = true;

            //Desativa TextBox1
            textBox1.Enabled = false;

            //Inserir Frase nas Labels
            if (idiomaCoeficiente == "portugues")
            {
                label1.Text = "Digite o Valor de α";
                label2.Text = "Digite o Valor de R1";
                label3.Text = "Digite o Valor de T1";
                label4.Text = "Digite o Valor de T2";

                //Ajuste nas Posições
                comboBoxMaterial.Location = new Point(935, 197);
                textBox2.Location = new Point(935, 243);
                textBox3.Location = new Point(935, 293);
                textBox4.Location = new Point(935, 338);

                label1.Location = new Point(805, 197);
                label2.Location = new Point(805, 243);
                label3.Location = new Point(805, 293);
                label4.Location = new Point(805, 338);
            }
            else if (idiomaCoeficiente == "ingles")
            {
                label1.Text = "Enter the Value of α";
                label2.Text = "Enter the Value of R1";
                label3.Text = "Enter the Value of T1";
                label4.Text = "Enter the Value of T2";

                //Ajuste nas Posições
                comboBoxMaterial.Location = new Point(930, 197);
                textBox2.Location = new Point(930, 243);
                textBox3.Location = new Point(930, 293);
                textBox4.Location = new Point(930, 338);

                label1.Location = new Point(790, 197);
                label2.Location = new Point(790, 243);
                label3.Location = new Point(790, 293);
                label4.Location = new Point(790, 338);

                //Ajuste nas Margens
                labelResultado2.Padding = new Padding(15, 0, 0, 0);
            }
        }

        private void CalcularR2(TextBox textBoxResultado)
        {
            double R1 = 0, T1 = 0, R2 = 0, T2 = 0, alpha = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox2.Text, out R1) ||
                !double.TryParse(textBox3.Text, out T1) ||
                !double.TryParse(textBox4.Text, out T2))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaCoeficiente == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCoeficiente == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado2.Visible = false;
                textBox6.Visible = false;
                return;
            }

            // Verifica se uma Opção foi Selecionada na ComboBox
            if (comboBoxMaterial.SelectedItem == null)
            {
                // Se nenhuma Opção Válida for Selecionada, Exibe uma Mensagem de Erro
                if (idiomaCoeficiente == "portugues")
                {
                    MessageBox.Show("Por favor, Selecione um Material na Lista");
                }
                else if (idiomaCoeficiente == "ingles")
                {
                    MessageBox.Show("Please Select a Material from the List");
                }

                labelResultado2.Visible = false;
                textBox6.Visible = false;
                return;
            }

            // Obtém a Opção Selecionada na ComboBox como uma String
            string escolha = comboBoxMaterial.SelectedItem.ToString();

            // Define o Valor de Alpha com Base na Opção Selecionada
            switch (escolha)
            {
                case "Cobre":
                case "Copper":
                    alpha = 0.0039;
                    break;

                case "Alumínio":
                case "Aluminum":
                    alpha = 0.0043;
                    break;

                case "Ferro":
                case "Iron":
                    alpha = 0.0050;
                    break;

                case "Níquel":
                case "Nickel":
                    alpha = 0.0060;
                    break;

                case "Vidro":
                case "Glass":
                    alpha = 0.0005;
                    break;

                case "Teflon (PTFE)":
                    alpha = 0.0002;
                    break;

                case "Prata":
                case "Silver":
                    alpha = 0.0038;
                    break;

                case "Ouro":
                case "Gold":
                    alpha = 0.0034;
                    break;

                case "Bronze":
                    alpha = 0.0017;
                    break;

                case "Aço inoxidável":
                case "Stainless steel":
                    alpha = 0.00094;
                    break;

                case "Poliestireno":
                case "Polystyrene":
                    alpha = 0.00007;
                    break;

                case "Polipropileno":
                case "Polypropylene":
                    alpha = 0.0001;
                    break;

                case "PVC (Policloreto de Vinila)":
                case "PVC (Polyvinyl Chloride)":
                    alpha = 0.00036;
                    break;

            }

            //Cálculo Seguindo a Respetiva Formúla
            R2 = R1 * (1 + alpha * (T2 - T1));

            //Imprime o Resultado
            textBoxResultado.Text = R2.ToString("0.####") + " Ω";
            labelResultado2.Visible = true;
            textBox6.Visible = true;

        }

        #endregion R2

        #endregion Cálculo

        #region Código Botões


        private int TipoCalculo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Limpa Tudo que o Usuário Inseriu
            btnLimpar_Click(sender, e);

            //Caso este botão seje Selecionado a Variável Tipo de Cálculo Fica a 0 ( Que Corresponde ao Cálculo do Alpha)
            int TipoCalculo = 0;

            //Envio o Valor da Variável TipoCalculo para a Variável TipoCalculo da Página
            this.TipoCalculo = TipoCalculo;

            //Executa a Função InserirAlpha()
            InserirAlpha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpa Tudo que o Usuário Inseriu
            btnLimpar_Click(sender, e);

            //Caso este botão seje Selecionado a Variável Tipo de Cálculo Fica a 1 ( Que Corresponde ao Cálculo do R2)
            int TipoCalculo = 1;

            //Envio o Valor da Variável TipoCalculo para a Variável TipoCalculo da Página
            this.TipoCalculo = TipoCalculo;

            //Executa a Função InserirR2()
            InserirR2();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Se a Variável TipoCalculo for 0 será Execuatada a Função CalcularAlpha(), se for 1 será Execuatada a Função CalcularR2() 
            if (TipoCalculo == 0)
            {
                //Executa a Função CalcularAlpha()
                CalcularAlpha(textBox6);
            }
            else if (TipoCalculo == 1)
            {
                //Executa a Função CalcularR2()
                CalcularR2(textBox6);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            //Esconde a Impressão de Resultado
            textBox6.Visible = false;
            labelResultado2.Visible = false;

            //Limpa a Opção Selecionada na ComboBoxMaterial
            comboBoxMaterial.SelectedIndex = -1;
        }

         private void btnLimparRes_Click(object sender, EventArgs e)
         {
                    //Limpa as TextBox
                    textBoxComprimento.Text = "";
                    textBoxArea.Text = "";
                    textBox5.Text = "";


                    //Esconde a Impressão de Resultado
                    textBox5.Visible = false;
                    labelResultado1.Visible = false;

                    //Limpa a Opção Selecionada na ComboBoxMaterial
                    comboBoxResistividade.SelectedIndex = -1;
         }
         private void button3_Click(object sender, EventArgs e)
         {
                    CalcularResistividade();
                    labelResultado1.Visible = true;
                    textBox5.Visible = true;
            textBox5.Visible = true;
        }

        #endregion Código Botões

        #endregion Coeficiente

        #region Resistividade
        private void CalcularResistividade()
        {
            double area = 0, comprimento = 0, resistividade = 1;
            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBoxArea.Text, out area) ||
                !double.TryParse(textBoxComprimento.Text, out comprimento))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaCoeficiente == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCoeficiente == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }
            }
                string escolha = comboBoxResistividade.SelectedItem.ToString();
                
                switch (escolha)
                {
                    case "Cobre":
                    case "Copper":
                        resistividade = 1.68e-8;
                        break;

                    case "Alumínio":
                    case "Aluminum":
                        resistividade = 2.82e-8;
                        break;

                    case "Ouro":
                    case "Gold":
                        resistividade = 2.44e-8;
                        break;

                    case "Prata":
                    case "Silver":
                        resistividade = 1.59e-8;
                        break;

                    case "Ferro":
                    case "Iron":
                        resistividade = 9.71e-8;
                        break;

                    case "Níquel":
                    case "Nickel":
                        resistividade = 6.99e-7;
                        break;

                    case "Carbono":
                    case "Carbon":
                        resistividade = 1.0e-4;
                        break;

                    case "Tungstênio":
                    case "Tungsten":
                        resistividade = 5.6e-8;
                        break;

                    case "Zinco":
                    case "Zinc":
                        resistividade = 5.9e-7;
                        break;

                    case "Platina":
                        resistividade = 1.06e-7;
                        break;

                    case "Constantan":
                        resistividade = 4.9e-7;
                        break;

                    case "Silício":
                    case "Silicon":
                        resistividade = 6.4e2;
                        break;

                    case "Vidro":
                    case "Glass":
                        resistividade = 1.0e11;
                        break;

                    default:
                        MessageBox.Show("Material não reconhecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                double calculoRes = resistividade * comprimento / area;
                textBox5.Text = ($"{calculoRes}"+ " Ω");       
        }
        #endregion Resistividade

    }
}