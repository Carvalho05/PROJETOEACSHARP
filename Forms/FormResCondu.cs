﻿using System;
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
    public partial class FormResCondu : Form
    {
        int tipoResistencia;
        private PictureBox pictureBoxSelected;
        double resistenciaOhms;
        public FormResCondu()
        {
            InitializeComponent();
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

        private Color GetItemColor(string itemText) //Pintar as faixas da resistencia consoante o texto da ComboBox 
        {
            switch (itemText)
            {
                case "Preto":
                    return Color.Black;
                case "Castanho":
                    return Color.SaddleBrown;
                case "Vermelho":
                    return Color.Red;
                case "Laranja":
                    return Color.Orange;
                case "Amarelo":
                    return Color.Yellow;
                case "Verde":
                    return Color.Green;
                case "Azul":
                    return Color.Blue;
                case "Violeta":
                    return Color.Purple;
                case "Cinza":
                    return Color.Gray;
                case "Branco":
                    return Color.White;
                case "Dourado":
                    return Color.Goldenrod;
                case "Prateado":
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
            // Obtém os valores dos dígitos a partir das cores escolhidas
            int primeiroDigito = ObterValorDigito(pctBox1st.BackColor);
            int segundoDigito = ObterValorDigito(pctBox2st.BackColor);
            int terceiroDigito = ObterValorDigito(pctBox3st.BackColor);
            double valorResistencia = 0;

            // Obtém o multiplicador a partir da cor da faixa multiplicadora
            double multiplicador = ObterMultiplicador(pctBox4st.BackColor);

            // Calcula o valor da resistência
            if (tipoResistencia == 5)
            {
                valorResistencia = (primeiroDigito * 100 + segundoDigito * 10 + terceiroDigito) * multiplicador;
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
                {Color.Black, 1},//Ω
                {Color.Brown, 10},//Ω 
                {Color.Red, 100},//Ω 
                {Color.Orange, 1000}, //1kΩ 
                {Color.Yellow, 10000},//10kΩ 
                {Color.Green, 100000}, //100kΩ 
                {Color.Blue, 1000000},//1MΩ 
                {Color.Purple, 10000000},//10MΩ 
                {Color.Gray, 100000000},//100MΩ 
                {Color.White, 1000000000},//1GΩ 
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

       
    }
}