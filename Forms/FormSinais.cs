using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EletroMath.Forms
{
    public partial class FormSinais : Form
    {
        private const double M_PI = Math.PI;
        public FormSinais()
        {
            InitializeComponent();
        }
        private void FormSinais_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
            private void button1_Click(object sender, EventArgs e)
        {
            double amplitude = ParseDouble(txtBoxVolt.Text);
            double frequencia = ParseDouble(txtBoxFreq.Text);
            GerarGrafico("Onda Sinusoidal", (tempo) => amplitude * Math.Sin(2 * M_PI * frequencia * tempo));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amplitude = ParseDouble(txtBoxVolt.Text);
            double frequencia = ParseDouble(txtBoxFreq.Text);
            GerarGrafico("Onda Quadrada", (tempo) =>
            {
                double periodo = 1.0 / frequencia;
                double fase = tempo % periodo;
                return (fase < periodo / 2.0) ? amplitude : -amplitude;
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double amplitude = ParseDouble(txtBoxVolt.Text);
            double frequencia = ParseDouble(txtBoxFreq.Text);
            GerarGrafico("Onda Triangular", (tempo) =>
            {
                return (tempo < 0.5) ? 4.0 * amplitude / 1.0 * tempo : 4.0 * amplitude / 1.0 * (1.0 - tempo);
            });
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
            chart1.ChartAreas[0].AxisY.Minimum = -1.5 * ParseDouble(txtBoxVolt.Text);
            chart1.ChartAreas[0].AxisY.Maximum = 1.5 * ParseDouble(txtBoxVolt.Text);

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
