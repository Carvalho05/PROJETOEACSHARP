using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace EletroMath.Forms
{
    public partial class FormResCondu : Form
    {
        int tipoResistencia;
        double resistenciaOhms;
        public FormResCondu(string idiomaAtual)
        {
            InitializeComponent();
            AtualizarTextos(idiomaAtual);

            //Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades.SelectedIndex = 3;

            //Esconder Labels
            labelResultado.Visible = false;
            labelValor.Visible = false;

            //Esconder ComboBoxs
            comboBoxUnidades.Visible = false;
            comboBoxUnidades2.Visible = false;
            
            //Esconder TextBoxs
            textBoxResultado.Visible = false;
            textBoxValor.Visible = false;

            //Esconder Outros
            pictureBoxRes.Visible = false;
            flowLayoutPanelCombo.Visible = false;
        }
        #region Tema
        private void LoadTheme() // Aplicar Tema de Cor aos Botões
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }

            //Coloca as Seguintes Labels com a Cor do Tema Principal
            labelResultado.ForeColor = ThemeColor.PrimaryColor;
            labelValor.ForeColor = ThemeColor.PrimaryColor;
        }
        private void ResetColors()  // Codigo para Retirar o Realce do Botão das Resistências
        {

            btn4stripes.BackColor = ThemeColor.PrimaryColor;
            btn5stripes.BackColor = ThemeColor.PrimaryColor;
        }
        private void FormResCondu_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupColorComboBox(comboBoxFaixa1);
            SetupColorComboBox(comboBoxFaixa2);
            SetupColorComboBox(comboBoxFaixa3);
            SetupColorComboBox(comboBoxMult);
            SetupColorComboBox(comboBoxTole);
        }
        #endregion Tema 

        #region Idioma
        private void AtualizarTextos(string idiomaAtual)
        {
            if (idiomaAtual == "ingles")
            {
                this.Text = "Color Code";
                btn4stripes.Text = "4 Bands";
                btn5stripes.Text = "5 Bands";
                labelResultado.Text = "Resistor Value";
                labelFaixa1.Text = "1st Band";
                labelFaixa2.Text = "2nd Band";
                labelFaixa3.Text = "3rd Band";
                labelMultip.Text = "Multiplier";
                labelTole.Text = "Tolerance";
                labelValor.Text = "Resistor Value (in Ω)";

                comboBoxFaixa1.Items.Add("Brown");
                comboBoxFaixa1.Items.Add("Red");
                comboBoxFaixa1.Items.Add("Orange");
                comboBoxFaixa1.Items.Add("Yellow");
                comboBoxFaixa1.Items.Add("Green");
                comboBoxFaixa1.Items.Add("Blue");
                comboBoxFaixa1.Items.Add("Violet");
                comboBoxFaixa1.Items.Add("Grey");
                comboBoxFaixa1.Items.Add("White");

                comboBoxFaixa2.Items.Add("Black");
                comboBoxFaixa2.Items.Add("Brown");
                comboBoxFaixa2.Items.Add("Red");
                comboBoxFaixa2.Items.Add("Orange");
                comboBoxFaixa2.Items.Add("Yellow");
                comboBoxFaixa2.Items.Add("Green");
                comboBoxFaixa2.Items.Add("Blue");
                comboBoxFaixa2.Items.Add("Violet");
                comboBoxFaixa2.Items.Add("Grey");
                comboBoxFaixa2.Items.Add("White");


                comboBoxFaixa3.Items.Add("Black");
                comboBoxFaixa3.Items.Add("Brown");
                comboBoxFaixa3.Items.Add("Red");
                comboBoxFaixa3.Items.Add("Orange");
                comboBoxFaixa3.Items.Add("Yellow");
                comboBoxFaixa3.Items.Add("Green");
                comboBoxFaixa3.Items.Add("Blue");
                comboBoxFaixa3.Items.Add("Violet");
                comboBoxFaixa3.Items.Add("Grey");
                comboBoxFaixa3.Items.Add("White");


                comboBoxMult.Items.Add("Black");
                comboBoxMult.Items.Add("Brown");
                comboBoxMult.Items.Add("Red");
                comboBoxMult.Items.Add("Orange");
                comboBoxMult.Items.Add("Yellow");
                comboBoxMult.Items.Add("Green");
                comboBoxMult.Items.Add("Blue");
                comboBoxMult.Items.Add("Violet");
                comboBoxMult.Items.Add("Grey");
                comboBoxMult.Items.Add("White");
                comboBoxMult.Items.Add("Gold");
                comboBoxMult.Items.Add("Silver");

                comboBoxTole.Items.Add("Brown");
                comboBoxTole.Items.Add("Red");
                comboBoxTole.Items.Add("Orange");
                comboBoxTole.Items.Add("Yellow");
                comboBoxTole.Items.Add("Green");
                comboBoxTole.Items.Add("Blue");
                comboBoxTole.Items.Add("Violet");
                comboBoxTole.Items.Add("Grey");
                comboBoxTole.Items.Add("Gold");
                comboBoxTole.Items.Add("Silver");

                textBoxValor.Location = new Point(970, 452);
                comboBoxUnidades2.Location = new Point(1080, 451);
            }
            else if (idiomaAtual == "portugues")
            {
                this.Text = "Código de Cores";
                btn4stripes.Text = "4 Faixas";
                btn5stripes.Text = "5 Faixas";
                labelResultado.Text = "Valor da Resistência";
                labelFaixa1.Text = "Faixa 1";
                labelFaixa2.Text = "Faixa 2";
                labelFaixa3.Text = "Faixa 3";
                labelMultip.Text = "Multiplicador";
                labelTole.Text = "Tolerância";
                labelValor.Text = "Valor da Resistência (em Ω)";

                comboBoxFaixa1.Items.Add("Castanho");
                comboBoxFaixa1.Items.Add("Vermelho");
                comboBoxFaixa1.Items.Add("Laranja");
                comboBoxFaixa1.Items.Add("Amarelo");
                comboBoxFaixa1.Items.Add("Verde");
                comboBoxFaixa1.Items.Add("Azul");
                comboBoxFaixa1.Items.Add("Violeta");
                comboBoxFaixa1.Items.Add("Cinza");
                comboBoxFaixa1.Items.Add("Branco");

                comboBoxFaixa2.Items.Add("Pretp");
                comboBoxFaixa2.Items.Add("Castanho");
                comboBoxFaixa2.Items.Add("Vermelho");
                comboBoxFaixa2.Items.Add("Laranja");
                comboBoxFaixa2.Items.Add("Amarelo");
                comboBoxFaixa2.Items.Add("Verde");
                comboBoxFaixa2.Items.Add("Azul");
                comboBoxFaixa2.Items.Add("Violeta");
                comboBoxFaixa2.Items.Add("Cinza");
                comboBoxFaixa2.Items.Add("Branco");


                comboBoxFaixa3.Items.Add("Preto");
                comboBoxFaixa3.Items.Add("Castanho");
                comboBoxFaixa3.Items.Add("Vermelho");
                comboBoxFaixa3.Items.Add("Laranja");
                comboBoxFaixa3.Items.Add("Amarelo");
                comboBoxFaixa3.Items.Add("Verde");
                comboBoxFaixa3.Items.Add("Azul");
                comboBoxFaixa3.Items.Add("Violeta");
                comboBoxFaixa3.Items.Add("Cinza");
                comboBoxFaixa3.Items.Add("Branco");


                comboBoxMult.Items.Add("Preto");
                comboBoxMult.Items.Add("Castanho");
                comboBoxMult.Items.Add("Vermelho");
                comboBoxMult.Items.Add("Laranja");
                comboBoxMult.Items.Add("Amarelo");
                comboBoxMult.Items.Add("Verde");
                comboBoxMult.Items.Add("Azul");
                comboBoxMult.Items.Add("Violeta");
                comboBoxMult.Items.Add("Cinza");
                comboBoxMult.Items.Add("Branco");
                comboBoxMult.Items.Add("Dourado");
                comboBoxMult.Items.Add("Prateado");

                comboBoxTole.Items.Add("Castanho");
                comboBoxTole.Items.Add("Vermelho");
                comboBoxTole.Items.Add("Laranja");
                comboBoxTole.Items.Add("Amarelo");
                comboBoxTole.Items.Add("Verde");
                comboBoxTole.Items.Add("Azul");
                comboBoxTole.Items.Add("Violeta");
                comboBoxTole.Items.Add("Cinza");
                comboBoxTole.Items.Add("Dourado");
                comboBoxTole.Items.Add("Prateado");
            }
        }


        #endregion Idioma
        #region TipoResistencia
        private void btn4stripes_Click(object sender, EventArgs e)
        {
            tipoResistencia = 4;
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = false;
            flowLayoutPanelCombo.Visible = true;
            comboBoxFaixa3.Visible = false;
            labelFaixa3.Visible = false;
            btn4stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
            comboBoxUnidades.Visible = true;
            textBoxResultado.Visible = true;
            labelResultado.Visible = true;
            labelValor.Visible = true;
            textBoxValor.Visible = true;
            comboBoxUnidades2.Visible = true;
        }

        private void btn5stripes_Click(object sender, EventArgs e)
        {
            tipoResistencia = 5;
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = true;
            comboBoxFaixa3.Visible = true;
            labelFaixa3.Visible = true;
            flowLayoutPanelCombo.Visible = true;
            btn5stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
            comboBoxUnidades.Visible = true;
            textBoxResultado.Visible = true;
            labelResultado.Visible = true;
            labelValor.Visible = true;
            textBoxValor.Visible = true;
            comboBoxUnidades2.Visible=true;
        }
        #endregion TipoResistencia  
        #region ComboBox
        private void DrawItemHandler(object sender, DrawItemEventArgs e) //Pinta as linhas da combobox de acordo com a cor do texto
        {
            if (e.Index >= 0)
            {
                ComboBox comboBox = sender as ComboBox;

                
                if (comboBox != null)
                {
                    // Obtém o texto do item
                    string itemText = comboBox.Items[e.Index].ToString();

                    // Obtém a cor 
                    Color color = GetItemColor(itemText);

                    // Desenha o fundo com a cor correspondente
                    e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);

                    
                    using (SolidBrush brush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds.X, e.Bounds.Y);
                    }

                    
                    e.DrawFocusRectangle();
                }
            }
        }

        private void SetupColorComboBox(ComboBox comboBox)
        {
            // Manipula o evento DrawItem para personalizar a aparência
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;

            // Conecta o evento DrawItem ao manipulador DrawItemHandler
            comboBox.DrawItem += new DrawItemEventHandler(DrawItemHandler);
        }
        #endregion ComboBox
        private Color GetItemColor(string itemText) //Pintar as Faixas da Resistência Consoante o Texto da ComboBox 
        {
            switch (itemText)
            {
                case "Preto":
                case "Black":
                    return Color.Black;
                case "Castanho":
                case "Brown":
                case "±1%":
                    return Color.SaddleBrown;
                case "Vermelho":
                case "Red":
                case "±2%":
                    return Color.Red;
                case "Laranja":
                case "Orange":
                case "±0.05%":
                    return Color.Orange;
                case "Amarelo":
                case "Yellow":
                case "±0.02%":
                    return Color.Yellow;
                case "Verde":
                case "Green":
                case "±0.5%":
                    return Color.Green;
                case "Azul":
                case "Blue":
                case "±0.25%":
                    return Color.Blue;
                case "Violeta":
                case "Violet":
                case "±0.1%":
                    return Color.Purple;
                case "Cinza":
                case "Grey":
                case "±0.01%":
                    return Color.Gray;
                case "Branco":
                case "White":
                    return Color.White;
                case "Dourado":
                case "Gold":
                case "±5%":
                    return Color.Goldenrod;
                case "Prateado":
                case "Silver":
                case "±10%":
                    return Color.Silver;
                case "±20%":
                    return Color.Transparent;
                default:
                    return comboBoxFaixa1.ForeColor; // Retorna a cor padrão se não houver correspondência
            }
        }

        #region DefinicoesComboBox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa1.SelectedItem != null)
            {
                textBoxResultado.Visible = true;
                textBoxTolerancia.Visible = true;
                labelResultado.Visible = true;
                comboBoxUnidades.Visible = true;
                string corSelecionada = comboBoxFaixa1.SelectedItem.ToString();
                pctBox1st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa2.SelectedItem != null)
            {
                textBoxResultado.Visible = true;
                textBoxTolerancia.Visible = true;
                labelResultado.Visible = true;
                comboBoxUnidades.Visible = true;
                string corSelecionada = comboBoxFaixa2.SelectedItem.ToString();
                pctBox2st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa3.SelectedItem != null)
            {
                textBoxResultado.Visible = true;
                textBoxTolerancia.Visible = true;
                labelResultado.Visible = true;
                comboBoxUnidades.Visible = true;
                string corSelecionada = comboBoxFaixa3.SelectedItem.ToString();
                pctBox3st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMult.SelectedItem != null)
            {
                textBoxResultado.Visible = true;
                textBoxTolerancia.Visible = true;
                labelResultado.Visible = true;
                comboBoxUnidades.Visible = true;
                string corSelecionada = comboBoxMult.SelectedItem.ToString();
                pctBox4st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTole.SelectedItem != null)
            {
                textBoxResultado.Visible = true;
                textBoxTolerancia.Visible = true;
                labelResultado.Visible = true;
                comboBoxUnidades.Visible = true;
                string corSelecionada = comboBoxTole.SelectedItem.ToString();
                pctBox5st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }
        private void comboBoxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConverterUnidades(textBoxResultado);
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            ResetColors();
            pctBox3st.Visible = true;
            comboBoxFaixa1.SelectedIndex = -1;
            comboBoxFaixa2.SelectedIndex = -1;
            comboBoxFaixa3.SelectedIndex = -1;
            comboBoxMult.SelectedIndex = -1;
            comboBoxTole.SelectedIndex = -1;
            textBoxResultado.Visible = false;
            textBoxTolerancia.Visible = false;
            labelResultado.Visible = false;
            comboBoxUnidades.Visible = false;
            ObterCores();
        }

        async private void comboBoxUnidades2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUnidades2 != null)
            {
                string corSelecionada = comboBoxUnidades2.SelectedItem.ToString();
                pctBox5st.BackColor = GetItemColor(corSelecionada);
            }
        }
        #endregion DefinicoesComboBox


        #region CalculoResistencias
        private void CalcularValorResistencia()
        {
            double valorResistencia = 0;
            int primeiroDigito = ObterValorDigito(pctBox1st.BackColor);
            int segundoDigito = ObterValorDigito(pctBox2st.BackColor);

            // Obtém o multiplicador a partir da cor da faixa multiplicadora
            double multiplicador = ObterMultiplicador(pctBox4st.BackColor);
            string tolerancia =ObterValorTolerancia(pctBox5st.BackColor);
            // Calcula o valor da resistência
            if (tipoResistencia == 5)
            {
                int terceiroDigito = ObterValorDigito(pctBox3st.BackColor); valorResistencia = (primeiroDigito * 100 + segundoDigito * 10 + terceiroDigito) * multiplicador;
            }
            else
            {
                valorResistencia = (primeiroDigito * 100 + segundoDigito * 10) * multiplicador;
            }

            resistenciaOhms = valorResistencia;
            // Exibe o valor da resistência na textbox
            textBoxResultado.Text = ($"{valorResistencia}");
            textBoxTolerancia.Text = ($"± {tolerancia}");
        }

        private int ObterValorDigito(Color cor)// Obter o valor da resistencia associado à cor
        {
            Dictionary<Color, int> coresDigitos = new Dictionary<Color, int>
        {
            {Color.Black, 0},
            {Color.SaddleBrown, 1},
            {Color.Red, 2},
            {Color.Orange, 3},
            {Color.Yellow, 4},
            {Color.Green, 5},
            {Color.Blue, 6},
            {Color.Purple, 7},
            {Color.Gray, 8},
            {Color.White, 9}
            };

            // Retorna o valor do dígito correspondente à cor
            return coresDigitos.ContainsKey(cor) ? coresDigitos[cor] : 0;
        }

        private double ObterMultiplicador(Color cor)// Obter o valor do multiplicador associado à cor
        {
            // Associa a cor ao valor do multiplicador
            Dictionary<Color, double> coresMultiplicadores = new Dictionary<Color, double>
            {
                {Color.Black, 1},
                {Color.Brown, 10},
                {Color.Red, 100},
                {Color.Orange, 1000}, //k
                {Color.Yellow, 10000},//k
                {Color.Green, 100000}, //k
                {Color.Blue, 1000000},//M
                {Color.Purple, 10000000},//M
                {Color.Gray, 100000000},//M
                {Color.White, 1000000000},//G
                {Color.Gold, 0.1},
                {Color.Silver, 0.01},


            };

            // Retorna o valor do multiplicador correspondente à cor
            return coresMultiplicadores.ContainsKey(cor) ? coresMultiplicadores[cor] : 1;
        }
        private string ObterValorTolerancia(Color cor)// Obter o valor da resistencia associado à cor
        {
            Dictionary<Color, string> coresDigitos = new Dictionary<Color, string>
        {
            {Color.SaddleBrown, "1%"},
            {Color.Red, "2%"},
            {Color.Orange, "0.05%"},
            {Color.Yellow, "0.02%"},
            {Color.Green, "0.5%"},
            {Color.Blue, "0.25%"},
            {Color.Purple, "0.1%"},
            {Color.Gray, "0.01%"},
            {Color.Gold, "5%"},
            {Color.Silver, "10%"}
        };

            // Retorna o valor do dígito correspondente à cor
            return coresDigitos.ContainsKey(cor) ? coresDigitos[cor] : "20%";
        }
        #endregion CalculoResistencias

        #region ConverterUnidades
        private void ConverterUnidades(TextBox textBoxResultado)
        {
            double resistencia = 0;

            // Obtém a opção selecionada na ComboBox como uma string
            string escolha = comboBoxUnidades.SelectedItem.ToString();

            switch (escolha)
            {
                case "GigaOhms (GΩ)":
                    resistencia = resistenciaOhms * 1e-9;
                    break;

                case "MegaOhms (MΩ)":
                    resistencia = resistenciaOhms * 1e-6;
                    break;

                case "kiloOhms (KΩ)":
                    resistencia = resistenciaOhms * 1e-3;
                    break;

                case "Ohms (Ω)":
                    resistencia = resistenciaOhms;
                    break;

                case "miliOhms (mΩ)":
                    resistencia = resistenciaOhms * 1e3;
                    break;

                case "microOhms (µΩ)":
                    resistencia = resistenciaOhms * 1e6;
                    break;

                case "nanoOhms (nΩ)":
                    resistencia = resistenciaOhms * 1e9;
                    break;

            }



            // Exibe o resultado na TextBox de resultado
            textBoxResultado.Text = resistencia.ToString("0.####");

        }





        #endregion ConverterUnidades

        private Color ObterCorDigito(int valor)// Obter o valor da resistencia associado à cor
        {
            Dictionary<Color, int> coresDigitos = new Dictionary<Color, int>
        {
            {Color.Black, 0},
            {Color.SaddleBrown, 1},
            {Color.Red, 2},
            {Color.Orange, 3},
            {Color.Yellow, 4},
            {Color.Green, 5},
            {Color.Blue, 6},
            {Color.Purple, 7},
            {Color.Gray, 8},
            {Color.White, 9}
            };

            foreach (var corValor in coresDigitos)
            {
              

                if (corValor.Value == valor)
                {
                    // Verifica se o valor associado é igual ao valor fornecido como parâmetro

                    return corValor.Key;
                    // Se for verdadeiro, retorna a chave (cor) correspondente ao valor fornecido
                }
            }
            return Color.Cyan;

        }

        private Color ObterCorMultiplicador(int valor)// Obter o valor do multiplicador associado à cor
        {
            // Associa a cor ao valor do multiplicador
            Dictionary<Color, double> coresMultiplicadores = new Dictionary<Color, double>
            {
                {Color.Black, 1},
                {Color.Brown, 10},
                {Color.Red, 100},
                {Color.Orange, 1000}, //k
                {Color.Yellow, 10000},//k
                {Color.Green, 100000}, //k
                {Color.Blue, 1000000},//M
                {Color.Purple, 10000000},//M
                {Color.Gray, 100000000},//M
                {Color.White, 1000000000},//G
                {Color.Gold, 0.1},
                {Color.Silver, 0.01},


            };

            foreach (var corMultiplicador in coresMultiplicadores)
            {
            
                if (corMultiplicador.Value == valor)
                {
                    // Verifica se o valor associado é igual ao valor fornecido como parâmetro

                    return corMultiplicador.Key;
                    // Se for verdadeiro, retorna a chave (cor) correspondente ao valor fornecido
                }
            }
            return Color.Black;
        }

        private void ObterCores()
        {
            int primeiroDigito = 0, segundoDigito = 0, terceiroDigito = 0, multiplicador = 0;
            string valorRes = textBoxValor.Text;
            int tamanhodaRes = valorRes.Length;

            if (tamanhodaRes >= 1)
            {
                int.TryParse(valorRes[0].ToString(), out primeiroDigito);
            }

            if (tamanhodaRes >= 2)
            {
                int.TryParse(valorRes[1].ToString(), out segundoDigito);
            }
            if (tipoResistencia == 5 && tamanhodaRes>=3)
            {
                int.TryParse(valorRes[2].ToString(), out terceiroDigito);
             }
            

            switch (tamanhodaRes)
            {
                case 4:
                    multiplicador = 10;
                    break;
                case 5:
                    multiplicador = 100;
                    break;
                case 6:
                    multiplicador = 1000;
                    break;
                case 7:
                    multiplicador = 10000;
                    break;
                case 8:
                    multiplicador = 100000;
                    break;
                case 9:
                    multiplicador = 1000000;
                    break;
                case 10:
                    multiplicador = 10000000;
                    break;
                case 11:
                    multiplicador = 100000000;
                    break;
                case 12:
                    multiplicador = 1000000000;
                    break;
                default:
                    multiplicador = 1;
                    break;
            }


            pctBox1st.BackColor = ObterCorDigito(primeiroDigito);
            pctBox2st.BackColor = ObterCorDigito(segundoDigito);
            pctBox3st.BackColor = ObterCorDigito(terceiroDigito);
            pctBox4st.BackColor = ObterCorMultiplicador(multiplicador);
      }


    }
}
