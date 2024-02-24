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

            //Associação da Variável Geral de Idioma do Form Coeficiente com a do Programa
            this.idiomaCoeficiente = idiomaAtual;

            //Função para trocar o Idioma das Caixas de Texto conforme o Idioma Selecionado
            AtualizarTextos();

            //Esconder Label
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Esconder TextBox
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            //Esconder Botões
            btnCal.Visible = false;
            btnLimpar.Visible = false;

            //Esconder ComboBoxMaterial
            comboBoxMaterial.Visible = false;

            //Esconder Resultado
            labelResultado1.Visible = false;
            textBox5.Visible = false;

            //Desativa TextBox1
            textBox1.Enabled = false;

            //Opções da comboBoxMaterial
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
            }

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxMaterial.SelectedIndex = -1;

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
        }

        private void AtualizarTextos()
        {
            if(idiomaCoeficiente == "portugues")
            {
                this.Text = "Coeficiente de Temperatura";
                labelCoeficiente.Text = "Coeficiente de Temperatura";
                labelResultado1.Text = "O Resultado é:";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                button1.Text = "Calcular α";
                button2.Text = "Calcular R2";
            }
            else if (idiomaCoeficiente == "ingles")
            {
                this.Text = "Temperature Coefficient";
                labelCoeficiente.Text = "Temperature Coefficient";
                labelResultado1.Text = "The result is:";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                button1.Text = "Calculate α";
                button2.Text = "Calculate R2";
            }
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
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
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

                labelResultado1.Visible = false;
                textBox5.Visible = false;
                return;
            }

            //Cálculo Seguindo a Respetiva Formúla
            alpha = (R2 - R1) / R1 * (T2 - T1);

            //Imprime o Resultado
            textBoxResultado.Text = alpha.ToString("0.####") + " Ω/ºC";
            labelResultado1.Visible = true;
            textBox5.Visible = true;

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
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
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

                labelResultado1.Visible = false;
                textBox5.Visible = false;
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

                labelResultado1.Visible = false;
                textBox5.Visible = false;
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
            R2 = R1 * (1 + alpha * (T2-T1));

            //Imprime o Resultado
            textBoxResultado.Text = R2.ToString("0.####") + " Ω";
            labelResultado1.Visible = true;
            textBox5.Visible = true;

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
                CalcularAlpha(textBox5);
            }
            else if (TipoCalculo == 1)
            {
                //Executa a Função CalcularR2()
                CalcularR2(textBox5);
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
            textBox5.Visible = false;
            labelResultado1.Visible = false;

            //Limpa a Opção Selecionada na ComboBoxMaterial
            comboBoxMaterial.SelectedIndex = -1;
        }




        #endregion Código Botões

        #endregion Coeficiente

        private void FormResTemp_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
