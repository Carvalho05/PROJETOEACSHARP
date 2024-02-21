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
    public partial class FormResistencias : Form
    {
        public FormResistencias()
        {
            InitializeComponent();
        }
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


        private int textboxCount = 3;
        private void AddBoxes()
        {
            // Verifique se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 6)
            {

                System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();

                // Configure propriedades dos novos controles
                newLabel.Text = string.Format("Resistência {0}", textboxCount);
                newLabel.Margin = new Padding(0, 0, 0, 7);

                // Adicione os novos controles ao FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);

                // Incrementa o contador
                textboxCount++;
            }
        }
        private void RemoveBoxes()
        {
            if (textboxCount > 3)
            {
                if (flowLayoutPanel1.Controls.Count > 1)
                {
                    // Remova os últimos controles adicionados do FlowLayoutPanel
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                    textboxCount--;
                }
            }
        }
        private void ResSerie(TextBox textBoxResultado)
        {
            double resistenciaTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                    double resistencia;
                    if (double.TryParse(control.Text, out resistencia))
                    {
                        resistenciaTotal += resistencia;
                    }
                    else
                    {
                        // Se um valor não puder ser convertido para double, definimos a flag como false
                        valoresValidos = false;
                        break; // Sai do loop, pois não há necessidade de continuar verificando
                    }
            }

            if (!valoresValidos)
            {
                // Se algum valor não for válido, exibimos uma mensagem de erro na TextBox de resultado
                textBoxResultado.Text = "Erro";
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = resistenciaTotal.ToString();
            }
        }
        private void ResPar(TextBox textBoxResultado)
        {
            double resistenciaTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double resistencia;
                if (double.TryParse(control.Text, out resistencia))
                {
                    resistenciaTotal += 1/resistencia;
                }
                else
                {
                    // Se um valor não puder ser convertido para double, definimos a flag como false
                    valoresValidos = false;
                    break; // Sai do loop, pois não há necessidade de continuar verificando
                }
            }
            resistenciaTotal = 1 / resistenciaTotal;
            if (!valoresValidos)
            {
                // Se algum valor não for válido, exibimos uma mensagem de erro na TextBox de resultado
                textBoxResultado.Text = "Erro";
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = resistenciaTotal.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBoxes();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            RemoveBoxes();
        }

        private void FormResistencias_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
                ResSerie(textBox2);
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            ResPar(textBox2);
        }
    }
}
