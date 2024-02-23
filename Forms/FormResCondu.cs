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
    public partial class FormResCondu : Form
    {
        private PictureBox pictureBoxSelected;
        public FormResCondu()
        {
            InitializeComponent();
            pictureBoxRes.Visible = false;


        }
        private void LoadTheme()
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
        }
        // Codigo para retirar o realce do botao das resistencias
        private void ResetColors()
        {

            btn4stripes.BackColor = ThemeColor.PrimaryColor;
            btn5stripes.BackColor = ThemeColor.PrimaryColor;
        }
        private void btn4stripes_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = false;
            btn4stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void btn5stripes_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = true;
            btn5stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void FormResCondu_Load(object sender, EventArgs e)
        {
            LoadTheme();
            SetupColorComboBox(comboBox2);
            SetupColorComboBox(comboBox3);
            SetupColorComboBox(comboBox4);
            SetupColorComboBox(comboBox5);
        }
        private void DrawItemHandler(object sender, DrawItemEventArgs e)
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

        private Color GetItemColor(string itemText)
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
                    return comboBox2.ForeColor; // Retorna a cor padrão se não houver correspondência
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string corSelecionada = comboBox2.SelectedItem.ToString();

                pctBox1st.BackColor = GetItemColor(corSelecionada);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string corSelecionada = comboBox3.SelectedItem.ToString();

                pctBox2st.BackColor = GetItemColor(corSelecionada);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                string corSelecionada = comboBox4.SelectedItem.ToString();

                pctBox3st.BackColor = GetItemColor(corSelecionada);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {
                string corSelecionada = comboBox5.SelectedItem.ToString();

                pctBox4st.BackColor = GetItemColor(corSelecionada);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem != null)
            {
                string corSelecionada = comboBox6.SelectedItem.ToString();

                pctBox5st.BackColor = GetItemColor(corSelecionada);
                CalcularValorResistencia();
            }
        }
        private void CalcularValorResistencia()
        {
            // Obtém os valores dos dígitos a partir das cores escolhidas
            int primeiroDigito = ObterValorDigito(pctBox1st.BackColor);
            int segundoDigito = ObterValorDigito(pctBox2st.BackColor);
            int terceiroDigito = ObterValorDigito(pctBox3st.BackColor);

            // Obtém o multiplicador a partir da cor da faixa multiplicadora
            double multiplicador = ObterMultiplicador(pctBox4st.BackColor);

            // Calcula o valor da resistência
            double valorResistencia = (primeiroDigito * 100 + segundoDigito * 10 + terceiroDigito) * multiplicador;

            // Exibe o valor da resistência onde for apropriado (pode ser em uma label, console, etc.)
           textBox1.Text=($"{valorResistencia}") + " Ohms";
        }

        private int ObterValorDigito(Color cor)
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

        private double ObterMultiplicador(Color cor)
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

    }
}