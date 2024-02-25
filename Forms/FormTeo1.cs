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

            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;

            //Esconder TextBox
            textBox1.Visible = false;
            textBox2.Visible = false;

            textBox3.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            //Esconder Botões
            btnCal.Visible = false;
            btnLimpar.Visible = false;

            btnCal2.Visible = false;
            btnLimpar2.Visible = false;

            //Esconder Resultado
            labelResultado1.Visible = false;
            textBox5.Visible = false;

            labelResultado2.Visible = false;
            textBox4.Visible = false;

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
                this.Text = "Lei de Ohm e Divisores";
                labelCoeficiente.Text = "Lei de Ohm";
                labelDivTensaoCorrente.Text = "Divisor de Tensão e Corrente";
                labelResultado1.Text = "O Resultado é:";
                labelResultado2.Text = "O Resultado é:";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                btnCal2.Text = "Calcular";
                btnLimpar2.Text = "Limpar";
                button1.Text = "Calcular Tensão";
                button2.Text = "Calcular Corrente";
                button3.Text = "Calcular Resistência";
                button5.Text = "Divisor de Tensão";
                button6.Text = "Divisor de Corrente";
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                this.Text = "Ohm's Law and Dividers";
                labelCoeficiente.Text = "Ohm's Law";
                labelDivTensaoCorrente.Text = "Voltage and Current Divider";
                labelResultado1.Text = "The result is:";
                labelResultado2.Text = "The result is:";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                btnCal2.Text = "Calculate";
                btnLimpar2.Text = "Clear";
                button1.Text = "Calculate Voltage";
                button2.Text = "Calculate Current";
                button3.Text = "Calculate Resistence";
                button5.Text = "Voltage Divider";
                button6.Text = "Current Divider";
            }
        }
        private void FormTeo1_Load(object sender, EventArgs e)
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

            //Esconde as TextBoxs
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox5.Visible = false;

            //Esconde os Labels
            labelResultado1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            //Esconde os Botões
            btnCal.Visible = false;
            btnLimpar.Visible = false;
        }





        #endregion Código Botões

        #endregion Coeficiente

        #region Calculo Divisores

        #region Divisor de Tensão
        private void InserirDivTensao()
        {
            //Retirar Invisibilidade
            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = true;

            textBox3.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;

            btnCal2.Visible = true;
            btnLimpar2.Visible = true;

            //Inserir Frase nas Labels
            if (idiomaTeoremas1 == "portugues")
            {
                label3.Text = "Digite o Valor da Resistência, Rn (Ω)";
                label4.Text = "Digite o Valor da Resistência Equivalente, Req (Ω)";
                label5.Text = "Digite o Valor da Fonte de Tensão, E (V)";

                //Ajuste nas Posições
                textBox3.Location = new Point(1130, 250);
                textBox6.Location = new Point(1130, 290);
                textBox7.Location = new Point(1130, 330);

                label3.Location = new Point(820, 250);
                label4.Location = new Point(820, 290);
                label5.Location = new Point(820, 330);
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                label3.Text = "Enter the Value of Resistance, Rn (Ω)";
                label4.Text = "Enter the Value of the Equivalent Resistance, Req (Ω)";
                label5.Text = "Enter the Value of the Voltage Source, E (V)";

                //Ajuste nas Posições
                textBox3.Location = new Point(1130, 250);
                textBox6.Location = new Point(1130, 290);
                textBox7.Location = new Point(1130, 330);

                label3.Location = new Point(800, 250);
                label4.Location = new Point(800, 290);
                label5.Location = new Point(800, 330);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
            }

        }

        private void CalcularDivTensao(TextBox textBoxResultado)
        {
            double Rn = 0, Req = 0, E = 0, U = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox3.Text, out Rn) ||
                !double.TryParse(textBox6.Text, out Req) ||
                !double.TryParse(textBox7.Text, out E))
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

                labelResultado2.Visible = false;
                textBox4.Visible = false;
                return;
            }

            //Cálculo Seguindo a Respetiva Formúla
            U = (Rn / Req) * E;

            //Imprime o Resultado
            textBoxResultado.Text = U.ToString("0.####") + " V";
            labelResultado2.Visible = true;
            textBox4.Visible = true;

        }
        #endregion Divisor de Tensão

        #region Divisor de Corrente
        private void InserirDivCorrente()
        {
            //Retirar Invisibilidade
            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = true;


            textBox3.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;


            btnCal2.Visible = true;
            btnLimpar2.Visible = true;

            //Inserir Frase nas Labels
            if (idiomaTeoremas1 == "portugues")
            {
                label3.Text = "Digite o Valor da Resistência, Rn (Ω)";
                label4.Text = "Digite o Valor da Resistência Equivalente, Req (Ω)";
                label5.Text = "Digite o Valor da Corrente Total (A)";

                //Ajuste nas Posições
                textBox3.Location = new Point(1130, 250);
                textBox6.Location = new Point(1130, 290);
                textBox7.Location = new Point(1130, 330);

                label3.Location = new Point(820, 250);
                label4.Location = new Point(820, 290);
                label5.Location = new Point(820, 330);
            }
            else if (idiomaTeoremas1 == "ingles")
            {
                label3.Text = "Enter the Value of Resistance, Rn (Ω)";
                label4.Text = "Enter the Value of the Equivalent Resistance, Req (Ω)";
                label5.Text = "Enter the Value of Total Current (A)";

                //Ajuste nas Posições
                textBox3.Location = new Point(1130, 250);
                textBox6.Location = new Point(1130, 290);
                textBox7.Location = new Point(1130, 330);

                label3.Location = new Point(800, 250);
                label4.Location = new Point(800, 290);
                label5.Location = new Point(800, 330);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
            }

        }

        private void CalcularDivCorrente(TextBox textBoxResultado)
        {
            double Rn = 0, Req = 0, It = 0, I = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox3.Text, out Rn) ||
                !double.TryParse(textBox6.Text, out Req) ||
                !double.TryParse(textBox7.Text, out It))
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

                labelResultado2.Visible = false;
                textBox4.Visible = false;
                return;
            }

            //Cálculo Seguindo a Respetiva Formúla
            I = (Req / Rn) * It;

            //Imprime o Resultado
            textBoxResultado.Text = I.ToString("0.####") + " A";
            labelResultado2.Visible = true;
            textBox4.Visible = true;

        }

        #endregion Divisor de Corrente

        #region Código Botões


        private int TipoCalculo2 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            //Limpa Tudo que o Usuário Inseriu
            btnLimpar_Click(sender, e);

            //Caso este botão seje Selecionado a Variável Tipo de Cálculo Fica a 0 ( Que Corresponde ao Cálculo do Alpha)
            int TipoCalculo2 = 0;

            //Envio o Valor da Variável TipoCalculo para a Variável TipoCalculo da Página
            this.TipoCalculo2 = TipoCalculo2;

            //Executa a Função InserirAlpha()
            InserirDivTensao();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Limpa Tudo que o Usuário Inseriu
            btnLimpar_Click(sender, e);

            //Caso este botão seje Selecionado a Variável Tipo de Cálculo Fica a 1 ( Que Corresponde ao Cálculo do R2)
            int TipoCalculo2 = 1;

            //Envio o Valor da Variável TipoCalculo para a Variável TipoCalculo da Página
            this.TipoCalculo2 = TipoCalculo2;

            //Executa a Função InserirR2()
            InserirDivCorrente();
        }



        private void btnCal2_Click(object sender, EventArgs e)
        {
            //Se a Variável TipoCalculo for 0 será Execuatada a Função CalcularAlpha(), se for 1 será Execuatada a Função CalcularR2() 
            if (TipoCalculo2 == 0)
            {
                //Executa a Função CalcularAlpha()
                CalcularDivTensao(textBox4);
            }
            else if (TipoCalculo2 == 1)
            {
                //Executa a Função CalcularR2()
                CalcularDivCorrente(textBox4);
            }
        }


        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
            //Esconde as TextBoxs
            textBox4.Visible = false;

            //Esconde os Labels
            labelResultado2.Visible = false;
        }

        #endregion Código Botões

        #endregion Calculo Divisores


    }
}
