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
        private PictureBox pictureBoxSelected;
        double resistenciaOhms;
        public FormResCondu(string idiomaAtual)
        {
            InitializeComponent();
            AtualizarTextos(idiomaAtual);
            comboBoxUnidades.SelectedIndex = 3;
            pictureBoxRes.Visible = false;
            flowLayoutPanelCombo.Visible = false;
            labelResultado.Visible = false;
            comboBoxUnidades.Visible = false;
            textBoxResultado.Visible = false;
        }
        #region Tema
        private void LoadTheme() // Aplicar tema de cors aos Botoes
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
            labelResultado.ForeColor = ThemeColor.PrimaryColor;
        }
        private void ResetColors()  // Codigo para retirar o realce do botao das resistencias
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
            labelFaixa3.Visible=false;
            btn4stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
            comboBoxUnidades.Visible = true;
            textBoxResultado.Visible = true;
            labelResultado.Visible = true;
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
        }
        #endregion TipoResistencia  
        #region ComboBox
        private void DrawItemHandler(object sender, DrawItemEventArgs e) //Pinta as linhas da combobox de acordo com a cor do texto
        {
            if (e.Index >= 0)
            {
                ComboBox comboBox = sender as ComboBox;

                // Verifica se o objeto sender é uma ComboBox válida
                if (comboBox != null)
                {
                    // Obtém o texto do item
                    string itemText = comboBox.Items[e.Index].ToString();

                    // Obtém a cor para o item atual
                    Color color = GetItemColor(itemText);

                    // Desenha o fundo com a cor correspondente
                    e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);

                    // Desenha o texto do item
                    using (SolidBrush brush = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds.X, e.Bounds.Y);
                    }

                    // Indica que o desenho do item está completo
                    e.DrawFocusRectangle();
                }
            }
        }

        private void SetupColorComboBox(ComboBox comboBox)
        {
            // Manipula o evento DrawItem para personalizar a aparência dos itens
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;

            // Conecta o evento DrawItem ao manipulador DrawItemHandler
            comboBox.DrawItem += new DrawItemEventHandler(DrawItemHandler);
        }
        #endregion ComboBox
        private Color GetItemColor(string itemText) //Pintar as faixas da resistencia consoante o texto da ComboBox 
        {
            switch (itemText)
            {
                case "Preto":
                case "Black":
                    return Color.Black;
                case "Castanho":
                case "Brown":
                    return Color.SaddleBrown;
                case "Vermelho":
                case "Red":
                    return Color.Red;
                case "Laranja":
                case "Orange":
                    return Color.Orange;
                case "Amarelo":
                case "Yellow":
                    return Color.Yellow;
                case "Verde":
                case "Green":
                    return Color.Green;
                case "Azul":
                case "Blue":
                    return Color.Blue;
                case "Violeta":
                case "Violet":
                    return Color.Purple;
                case "Cinza":
                case "Grey":
                    return Color.Gray;
                case "Branco":
                case "White":
                    return Color.White;
                case "Dourado":
                case "Gold":
                    return Color.Goldenrod;
                case "Prateado":
                case "Silver":
                    return Color.Silver;
                default:
                    return comboBoxFaixa1.ForeColor; // Retorna a cor padrão se não houver correspondência
            }
        }

        #region DefinicoesComboBox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa1.SelectedItem != null)
            {
                string corSelecionada = comboBoxFaixa1.SelectedItem.ToString();

                pctBox1st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa2.SelectedItem != null)
            {
                string corSelecionada = comboBoxFaixa2.SelectedItem.ToString();

                pctBox2st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFaixa3.SelectedItem != null)
            {
                string corSelecionada = comboBoxFaixa3.SelectedItem.ToString();
                CalcularValorResistencia();

                pctBox3st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMult.SelectedItem != null)
            {
                string corSelecionada = comboBoxMult.SelectedItem.ToString();

                pctBox4st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTole.SelectedItem != null)
            {
                string corSelecionada = comboBoxTole.SelectedItem.ToString();

                pctBox5st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }
        private void comboBoxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConverterUnidades(textBoxResultado);
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
           textBoxResultado.Text=($"{valorResistencia}");
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
                {Color.Orange, 1}, //k
                {Color.Yellow, 10},//k
                {Color.Green, 100}, //k
                {Color.Blue, 1},//M
                {Color.Purple, 10},//M
                {Color.Gray, 100},//M
                {Color.White, 1},//G
                {Color.Gold, 0.1},
                {Color.Silver, 0.01},


            };

            // Retorna o valor do multiplicador correspondente à cor
            return coresMultiplicadores.ContainsKey(cor) ? coresMultiplicadores[cor] : 1;
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
                    resistencia= resistenciaOhms;
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

            return coresDigitos.ContainsKey[valor] ? coresDigitos(valor) : Color.Black;
            /*foreach (var corValor in coresDigitos)
            {
                // Itera sobre cada par chave-valor no dicionário 'coresDigitos'

                if (corValor.Value == valor)
                {
                    // Verifica se o valor associado à chave atual é igual ao valor fornecido como parâmetro

                    return corValor.Key;
                    // Se for verdadeiro, retorna a chave (cor) correspondente ao valor fornecido
                }
            }
            return Color.Black;*/

        }

        private Color ObterCorMultiplicador(int valor)// Obter o valor do multiplicador associado à cor
        {
            // Associa a cor ao valor do multiplicador
            Dictionary<Color, double> coresMultiplicadores = new Dictionary<Color, double>
            {
                {Color.Black, 1},
                {Color.Brown, 10},
                {Color.Red, 100},
                {Color.Orange, 1}, //k
                {Color.Yellow, 10},//k
                {Color.Green, 100}, //k
                {Color.Blue, 1},//M
                {Color.Purple, 10},//M
                {Color.Gray, 100},//M
                {Color.White, 1},//G
                {Color.Gold, 0.1},
                {Color.Silver, 0.01},


            };

            foreach (var corMultiplicador in coresMultiplicadores)
            {
                // Itera sobre cada par chave-valor no dicionário 'coresDigitos'

                if (corMultiplicador.Value == valor)
                {
                    // Verifica se o valor associado à chave atual é igual ao valor fornecido como parâmetro

                    return corMultiplicador.Key;
                    // Se for verdadeiro, retorna a chave (cor) correspondente ao valor fornecido
                }
            }
            return Color.Black;
        }
        private void ObterCores()
        {
            int primeiroDigito=0, segundoDigito=0, terceiroDigito=0, multiplicador = 0; 
            string valorRes = textBoxValor.Text;
            int tamanhodaRes = valorRes.Length;

            if (tamanhodaRes >= 1)
            {
                primeiroDigito = valorRes[0];
            }
            else if (tamanhodaRes >= 2)
            {
                segundoDigito = valorRes[1];
            }
            else if (tipoResistencia == 5)
            {
                terceiroDigito = valorRes[2];
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
            pctBox4st.BackColor = ObterCorDigito(multiplicador);
            // Mapear os dígitos para cores
            // string corPrimeiroDigito = MapearDigitoParaCor(primeiroDigito);
            // string corSegundoDigito = MapearDigitoParaCor(segundoDigito);
            //string corMultiplicador = MapearMultiplicadorParaCor(multiplicador);


            // Construir o código de cores

         }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            ObterCores();
        }
    }
    

}
