using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EletroMath.Forms
{
    public partial class FormSinais : Form
    {
        private const double M_PI = Math.PI;
        string idioma;
        public FormSinais(string idiomaAtual)
        {
            idioma=idiomaAtual;
            InitializeComponent();
            AtualizarTextos(idiomaAtual);
            chart1.Visible = false; //esconde o grafico
        }
        private void FormSinais_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void AtualizarTextos(string idiomaAtual)
        {
            if (idiomaAtual == "ingles")
            {
                this.Text = "Digital Signals";
                button1.Text = "Sinusoidal Wave";
                button2.Text = "Quadratic Wave";
                button3.Text = "Triangular Wave";
                label3.Text = "Frequency (in Hz)";
                label2.Text = "Voltage(in V)";
            }
            else if (idiomaAtual == "portugues")
            {
                this.Text = "Sinais Digitais";
                button1.Text = "Onda Sinusoidal";
                button2.Text = "Onda Quadratica";
                button3.Text = "Onda Triangular";
                label3.Text = "Frequência (em Hz)";
                label2.Text = "Tensão (em V)";
            }
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn= (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor =ThemeColor.SecundaryColor;
                }
            }
        }
        private void ResetColors()
        {
            // Restaura a cor original de todos os botões
            button1.BackColor = ThemeColor.PrimaryColor;
            button2.BackColor = ThemeColor.PrimaryColor;
            button3.BackColor = ThemeColor.PrimaryColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetColors();
            double amplitude;
            double frequencia;
            if (!double.TryParse(txtBoxVolt.Text, out amplitude) ||
            (!double.TryParse(txtBoxFreq.Text, out frequencia)))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idioma == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idioma == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }
                return;
            }
            GerarGrafico("", (tempo) => amplitude * Math.Sin(2 * M_PI * frequencia * tempo));

            chart1.Visible = true;
            button1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetColors();
            double amplitude;
            double frequencia;
            if (!double.TryParse(txtBoxVolt.Text, out amplitude)||
            (!double.TryParse(txtBoxFreq.Text, out frequencia)))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if ( idioma == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idioma == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }
                return;
            }

            GerarGrafico("", (tempo) =>
            {

                double periodo = 1.0 / frequencia;
                double fase = tempo % periodo;
                return (fase < periodo / 2.0) ? amplitude : -amplitude;
            });
            chart1.Visible = true;
            button2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetColors();
            double amplitude;
            
            double frequencia;
            if (!double.TryParse(txtBoxVolt.Text, out amplitude) ||
            (!double.TryParse(txtBoxFreq.Text, out frequencia)))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idioma == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idioma == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }
                return;
            }
            double amplitudePico = amplitude / 2;
            GerarGrafico("", (tempo) =>
            {
                double periodo = 1.0 / frequencia;
                double duracaoInclinacao = periodo / 2.0;

                // Utilize a função módulo para obter um comportamento periódico
                tempo = tempo % periodo;

                double valor = 0.0;

                if (tempo < duracaoInclinacao)
                {
                    // Parte crescente da onda triangular
                    valor = (2.0 * amplitudePico / duracaoInclinacao) * tempo;
                }
                else
                {
                    // Parte decrescente da onda triangular
                    valor = 2.0 * amplitudePico - (2.0 * amplitudePico / duracaoInclinacao) * (tempo - duracaoInclinacao);
                }

                return valor;
            });
            chart1.Visible = true;
            button3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }
        private void GerarGrafico(string title, Func<double, double> gerarFuncao)
        {
            // Limpar pontos anteriores do gráfico
            chart1.Series.Clear();

            // Adicionar nova série ao gráfico
            var series = chart1.Series.Add(title);
            series.ChartType = SeriesChartType.Line;  // Definir o tipo de gráfico como linhas

            // Adicionar pontos à série
            for (double tempo = 0.0; tempo <= 1.0; tempo += 0.01)
            {
                double valor = gerarFuncao(tempo);

                // Criar um ponto de dados e definir a cor personalizada
                var ponto = new DataPoint(tempo, valor);
                ponto.Color = ThemeColor.PrimaryColor;  // Substitua por sua lógica de obtenção de cor

                // Adicionar ponto de dados à série
                series.Points.Add(ponto);

            }

            // Configurar propriedades do gráfico
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;
            chart1.ChartAreas[0].AxisX.Maximum = 1.0;
            chart1.ChartAreas[0].AxisY.Minimum = -3 * ParseDouble(txtBoxVolt.Text);
            chart1.ChartAreas[0].AxisY.Maximum = 3 * ParseDouble(txtBoxVolt.Text);

            series.Color = ThemeColor.PrimaryColor;
        }

        private double ParseDouble(string text)
        {
            double result;
            if (double.TryParse(text, out result))
            {
                return result;
            }
            return 0.0; // Valor padrão se não puder ser convertido
        }
    
    }
}
