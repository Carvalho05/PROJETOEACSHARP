using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroMath.Forms
{
    public partial class FormTeo1 : Form
    {
        #region Misc

        private string idiomaTeoremas1;
        public FormTeo1 (string idiomaAtual)
        {
            InitializeComponent();
            LoadTheme();

            //Associação da Variável Geral de Idioma do Form Coeficiente com a do Programa
            this.idiomaTeoremas1 = idiomaAtual;

            //Função para trocar o Idioma das Caixas de Texto conforme o Idioma Selecionado
            AtualizarTextos();

            //Esconder Label
            label1.Visible = false;
            label2.Visible = false;

            //Esconder TextBox
            textBox1.Visible = false;
            textBox2.Visible = false;

            //Esconder Botões
            btnCal.Visible = false;
            btnLimpar.Visible = false;

            //Esconder Resultado
            labelResultado1.Visible = false;
            textBox5.Visible = false;
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
            if (idiomaTeoremas1 == "portugues")
            {
                this.Text = "Teoremas";
                labelCoeficiente.Text = "Lei de Ohm";
                labelResultado1.Text = "O Resultado é:";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                button1.Text = "Calcular Tensão";
                button2.Text = "Calcular Corrente";
                button3.Text = "Calcular Resistência";
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                this.Text = "Theorems";
                labelCoeficiente.Text = "Ohm's Law";
                labelResultado1.Text = "The result is:";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                button1.Text = "Calculate Voltage";
                button2.Text = "Calculate Current";
                button3.Text = "Calculate Resistence";
            }
        }

        private void FormResTemp_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        #endregion Misc

        #region Coeficiente

        #region Cálculo

        #region Cálcular Tensão
        private void InserirTensao()
        {
            //Retirar Invisibilidade
            label1.Visible = true;
            label2.Visible = true;
            
            
            textBox1.Visible = true;
            textBox2.Visible = true;
            
            
            btnCal.Visible = true;
            btnLimpar.Visible = true;

            //Inserir Frase nas Labels
            if (idiomaTeoremas1 == "portugues")
            {
                label1.Text = "Digite o Valor da Resistência (Ω)";
                label2.Text = "Digite o Valor da Corrente (A)";

                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                label1.Text = "Enter the Value of Resistance (Ω)";
                label2.Text = "Enter the Value of Current (A)";

                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
            }

        }

        private void CalcularTensao(TextBox textBoxResultado)
        {
            double R = 0, I = 0, U = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out R) ||
                !double.TryParse(textBox2.Text, out I))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaTeoremas1 == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaTeoremas1 == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado1.Visible = false;
                textBox5.Visible = false;
                return;
            }

            //Cálculo Seguindo a Respetiva Formúla
            U = R * I;

            //Imprime o Resultado
            textBoxResultado.Text = U.ToString("0.####") + " V";
            labelResultado1.Visible = true;
            textBox5.Visible = true;

        }
        #endregion Cálcular Tensão

        #region Calcular Corrente
        private void InserirCorrente()
        {
            //Retirar Invisibilidade 
            label1.Visible = true;
            label2.Visible = true;
            
            
            textBox1.Visible = true;
            textBox2.Visible = true;
            
            
            btnCal.Visible = true;
            btnLimpar.Visible = true;
         

            //Inserir Frase nas Labels
            if (idiomaTeoremas1 == "portugues")
            {
                label1.Text = "Digite o Valor da Tensão (V)";
                label2.Text = "Digite o Valor da Resistência (Ω)";



                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                label1.Text = "Enter the Value of Voltage (V)";
                label2.Text = "Enter the Value of Resistance (Ω)";

                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
            }
        }

        private void CalcularCorrente(TextBox textBoxResultado)
        {
            double U = 0, I = 0, R = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out U) ||
                !double.TryParse(textBox2.Text, out R))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaTeoremas1 == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaTeoremas1 == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado1.Visible = false;
                textBox5.Visible = false;
                return;
            }


            //Cálculo Seguindo a Respetiva Formúla
            I = U / R;

            //Imprime o Resultado
            textBoxResultado.Text = I.ToString("0.####") + " A";
            labelResultado1.Visible = true;
            textBox5.Visible = true;

        }

        #endregion Calcular Corrente

        #region Calcular Resistencia
        private void InserirResistencia()
        {
            //Retirar Invisibilidade 
            label1.Visible = true;
            label2.Visible = true;


            textBox1.Visible = true;
            textBox2.Visible = true;


            btnCal.Visible = true;
            btnLimpar.Visible = true;

            //Inserir Frase nas Labels
            if (idiomaTeoremas1 == "portugues")
            {
                label1.Text = "Digite o Valor da Tensão (V)";
                label2.Text = "Digite o Valor da Corrente (A)";



                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                label1.Text = "Enter the Value of Voltage (V)";
                label2.Text = "Enter the Value of Current (A)";

                //Ajuste nas Posições
                textBox1.Location = new Point(290, 267);
                textBox2.Location = new Point(290, 323);

                label1.Location = new Point(90, 267);
                label2.Location = new Point(90, 323);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
            }
        }

        private void CalcularResistencia(TextBox textBoxResultado)
        {
            double U = 0, I = 0, R = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out U) ||
                !double.TryParse(textBox2.Text, out I))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaTeoremas1 == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaTeoremas1 == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado1.Visible = false;
                textBox5.Visible = false;
                return;
            }


            //Cálculo Seguindo a Respetiva Formúla
            R = U / I;

            //Imprime o Resultado
            textBoxResultado.Text = R.ToString("0.####") + " Ω";
            labelResultado1.Visible = true;
            textBox5.Visible = true;

        }

        #endregion Calcular Resistencia

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
            InserirTensao();
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
            InserirCorrente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Limpa Tudo que o Usuário Inseriu
            btnLimpar_Click(sender, e);

            //Caso este botão seje Selecionado a Variável Tipo de Cálculo Fica a 1 ( Que Corresponde ao Cálculo do R2)
            int TipoCalculo = 2;

            //Envio o Valor da Variável TipoCalculo para a Variável TipoCalculo da Página
            this.TipoCalculo = TipoCalculo;

            //Executa a Função InserirR2()
            InserirResistencia();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Se a Variável TipoCalculo for 0 será Execuatada a Função CalcularAlpha(), se for 1 será Execuatada a Função CalcularR2() 
            if (TipoCalculo == 0)
            {
                //Executa a Função CalcularAlpha()
                CalcularTensao(textBox5);
            }
            else if (TipoCalculo == 1)
            {
                //Executa a Função CalcularR2()
                CalcularCorrente(textBox5);
            }
            else if (TipoCalculo == 2)
            {
                //Executa a Função CalcularR2()
                CalcularResistencia(textBox5);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox1.Text = "";
            textBox2.Text = "";

            //Esconde a Impressão de Resultado
            textBox5.Visible = false;
            labelResultado1.Visible = false;
        }





        #endregion Código Botões

        #endregion Coeficiente

    }
}
