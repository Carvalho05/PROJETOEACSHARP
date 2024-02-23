using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroMath.Forms
{
    public partial class FormBobines : Form
    {
        #region Misc

        //Criação de Variável Geral de Idioma para o Código Bobines
        private string idiomaBobines;

        public FormBobines(string idiomaAtual)
        {
            InitializeComponent();

            //Associação da Variãvel Geral de Idioma dos Bobines com a do Programa
            this.idiomaBobines = idiomaAtual;

            //Função para trocar o Idioma das Caixas de Texto conforme o Idioma Selecionado
            AtualizarTextos();


            //Opçoes da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaHenrys (GH)");
            comboBoxUnidades.Items.Add("MegaHenrys (MH)");
            comboBoxUnidades.Items.Add("KiloHenrys (kH)");
            comboBoxUnidades.Items.Add("Henrys (H)");
            comboBoxUnidades.Items.Add("MiliHenrys (mH)");
            comboBoxUnidades.Items.Add("MicroHenrys (µH)");
            comboBoxUnidades.Items.Add("NanoHenrys (nH)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opçoes da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaHenrys (GH)");
            comboBoxUnidades2.Items.Add("MegaHenrys (MH)");
            comboBoxUnidades2.Items.Add("KiloHenrys (kH)");
            comboBoxUnidades2.Items.Add("Henrys (F)");
            comboBoxUnidades2.Items.Add("MiliHenrys (mH)");
            comboBoxUnidades2.Items.Add("MicroHenrys (µH)");
            comboBoxUnidades2.Items.Add("NanoHenrys (nH)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opçoes da comboBoxIndutância
            comboBoxIndutancia.Items.Add("Ferro");
            comboBoxIndutancia.Items.Add("Aço");
            comboBoxIndutancia.Items.Add("Niquel");
            comboBoxIndutancia.Items.Add("Cobalto");
            comboBoxIndutancia.Items.Add("Cobre");
            comboBoxIndutancia.Items.Add("Ar");


            // Indice da opção desejada como seleção inicial
            comboBoxIndutancia.SelectedIndex = -1;


            //Esconder Resultado no Cálculo de Associação de Bobines
            labelResultado2.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Capacitância
            labelResultado1.Visible = false;
            textBox3.Visible = false;

        }
        //Aplicar tema de cores aos botoes
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

            labelResultado1.ForeColor = ThemeColor.PrimaryColor;
            labelResultado2.ForeColor = ThemeColor.PrimaryColor;
        }

        //Função para Trocar os Textos conforme o Idioma
        private void AtualizarTextos()
        {
            if (idiomaBobines == "ingles")
            {
                label2.Text = "Permeability of the Coil Core Material (in Henrys per Meter, H/m)";
                label3.Text = "Cross-sectional Area of the Coil Core (in Square Meters, m²)";
                label5.Text = "Length of the Coil Core (in Meters, m)";
                label6.Text = "Number of Turns of the Coil";
                labelResultado1.Text = "The result is:";
                labelResultado2.Text = "The result is:";
                labelindutancia.Text = "Calculation of Indutance";
                labelAssoRes.Text = "Capacitor Association";
                btnSer.Text = "Series";
                btnPar.Text = "Parallel";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                label1.Text = "Coil 1";
                label4.Text = "Coil 2";
                textBox1.Location = new Point(410, 215);
                textBox2.Location = new Point(290, 263);
                textBox7.Location = new Point(225, 310);
                comboBoxIndutancia.Location = new Point(450, 168);
            }
            else if (idiomaBobines == "portugues")
            {
                label2.Text = "Permeabilidade Magnética do Núcleo da Bobina (em Henrys por Metro, H/m)";
                label3.Text = "Área da Seção Transversal do Núcleo da Bobina (em Metros Quadrados, m²)";
                label5.Text = "Comprimento do Núcleo da Bobina (em Metros, m)";
                label6.Text = "Número de Espiras da Bobina";
                labelResultado1.Text = "O Resultado é:";
                labelResultado2.Text = "O Resultado é:";
                labelindutancia.Text = "Cálculo da Indutância";
                labelAssoRes.Text = "Associação de Bobines";
                btnSer.Text = "Série";
                btnPar.Text = "Paralelo";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                label1.Text = "Bobine 1";
                label4.Text = "Bobine 2";
                textBox1.Location = new Point(518, 215);
                textBox2.Location = new Point(365, 263);
                comboBoxIndutancia.Location = new Point(520, 168);
            }
        }

        private void FormBobines_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion Misc

        #region Adicionar/Remover Caixas Texto
        private int textboxCount = 3;
        private void AddBoxes()
        {
            // Verificação se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 8)
            {

                System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();
                System.Windows.Forms.ComboBox newComboBox = new System.Windows.Forms.ComboBox();

                if (idiomaBobines == "portugues")
                {
                    // Propriedades dos novos controles
                    newLabel.Text = string.Format("Bobine {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a fonte como Calibri, tamanho 10.2 e negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a cor do texto como Azul
                }
                else if (idiomaBobines == "ingles")
                {
                    newLabel.Text = string.Format("Coil {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a fonte como Calibri, tamanho 10.2 e negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a cor do texto como Azul


                }

                // Adicionamento de novos controles ao FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel3.Controls.Add(newComboBox);

                //Opçoes da ComboBox
                newComboBox.Items.Add("GigaHenrys (GH)");
                newComboBox.Items.Add("MegaHenrys (MH)");
                newComboBox.Items.Add("KiloHenrys (kH)");
                newComboBox.Items.Add("Henrys (H)");
                newComboBox.Items.Add("MiliHenrys (mH)");
                newComboBox.Items.Add("MicroHenrys (µH)");
                newComboBox.Items.Add("NanoHenrys (nH)");

                // Indice da opção desejada como seleção inicial
                newComboBox.SelectedIndex = 3;

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
                    flowLayoutPanel3.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    textboxCount--;
                }
            }
        }

        #endregion Adicionar/Remover Caixas Texto

        #region Calculo Bobines

        #region Codigo Calculo 

        //Cálculo Paralelo Bobines
        private void BobSerie(TextBox textBoxResultado)
        {
            double BobineTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Bobine;
                if (double.TryParse(control.Text, out Bobine))
                {
                    BobineTotal += Bobine;
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
                if (idiomaBobines == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaBobines == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado2.Visible = false;
                textBox5.Visible = false;
                return;
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = BobineTotal.ToString("0.####") + " Henrys";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Série Bobines
        private void BobParalelo(TextBox textBoxResultado)
        {
            double BobineTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Bobine;
                if (double.TryParse(control.Text, out Bobine))
                {
                    BobineTotal += 1 / Bobine;
                }
                else
                {
                    // Se um valor não puder ser convertido para double, definimos a flag como false
                    valoresValidos = false;
                    break; // Sai do loop, pois não há necessidade de continuar verificando
                }
            }
            BobineTotal = 1 / BobineTotal;
            if (!valoresValidos)
            {
                // Se algum valor não for válido, exibimos uma mensagem de erro na TextBox de resultado
                if (idiomaBobines == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaBobines == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado2.Visible = false;
                textBox5.Visible = false;
                return;
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = BobineTotal.ToString("0.####") + " Henrys";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo da Indutância
        private void Indutancia(TextBox textBoxResultado)
        {
            double Pmagnetica = 0, area = 0, comprimento = 0, nEspiras = 0;

            // Verifica se a conversão dos valores das TextBoxes é bem-sucedida
            if (!double.TryParse(textBox1.Text, out area) ||
                !double.TryParse(textBox7.Text, out nEspiras) ||
                !double.TryParse(textBox2.Text, out comprimento))
            {
                // Se algum valor não puder ser convertido para double, exibe uma mensagem de erro
                if (idiomaBobines == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaBobines == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado1.Visible = false;
                textBox3.Visible = false;
                return;
            }

            // Verifica se uma opção foi selecionada na ComboBox
            if (comboBoxIndutancia.SelectedItem == null)
            {
                // Se nenhuma opção foi selecionada, exibe uma mensagem de erro
                if (idiomaBobines == "portugues")
                {
                    MessageBox.Show("Por favor, Selecione um Material na Lista");
                }
                else if (idiomaBobines == "ingles")
                {
                    MessageBox.Show("Please Select a Material from the List");
                }

                labelResultado1.Visible = false;
                textBox3.Visible = false;
                return;
            }

            // Obtém a opção selecionada na ComboBox como uma string
            string escolha = comboBoxIndutancia.SelectedItem.ToString();

            // Define o valor do diaelétrico com base na opção selecionada
            switch (escolha)
            {
                case "Ferro":
                    Pmagnetica = 6000;
                    break;

                case "Aço":
                    Pmagnetica = 3000;
                    break;

                case "Niquel":
                    Pmagnetica = 600;
                    break;

                case "Cobalto":
                    Pmagnetica = 2000;
                    break;

                case "Cobre":
                    Pmagnetica = 0.000001;
                    break;

                case "Ar":
                    Pmagnetica = 1;
                    break;

            }

            // Realiza o cálculo da capacitância do Bobine
            double indutancia = Pmagnetica * area * (nEspiras * nEspiras) / comprimento;

            //Imprime o Resultado
            textBoxResultado.Text = indutancia.ToString("0.####") + "Henrys";
            labelResultado1.Visible = true;
            textBox3.Visible = true;
       
        }
        
        #endregion Codigo Calculo 

        #region Codigo Botoes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBoxes();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            RemoveBoxes();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            BobParalelo(textBox5);
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            BobSerie(textBox5);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Indutancia(textBox3);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox3.Visible = false;
            labelResultado1.Visible = false;
            comboBoxIndutancia.SelectedItem = null;
        }

        #endregion Codigo Botoes

        #endregion Calculo Bobines


    }
}
