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

            //Associação da Variável Geral de Idioma dos Bobines com a do Programa
            this.idiomaBobines = idiomaAtual;

            //Função para trocar o Idioma das Caixas de Texto conforme o Idioma Selecionado
            AtualizarTextos();


            //Opções da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaHenrys (GH)");
            comboBoxUnidades.Items.Add("MegaHenrys (MH)");
            comboBoxUnidades.Items.Add("KiloHenrys (kH)");
            comboBoxUnidades.Items.Add("Henrys (H)");
            comboBoxUnidades.Items.Add("MiliHenrys (mH)");
            comboBoxUnidades.Items.Add("MicroHenrys (µH)");
            comboBoxUnidades.Items.Add("NanoHenrys (nH)");

            //Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opções da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaHenrys (GH)");
            comboBoxUnidades2.Items.Add("MegaHenrys (MH)");
            comboBoxUnidades2.Items.Add("KiloHenrys (kH)");
            comboBoxUnidades2.Items.Add("Henrys (H)");
            comboBoxUnidades2.Items.Add("MiliHenrys (mH)");
            comboBoxUnidades2.Items.Add("MicroHenrys (µH)");
            comboBoxUnidades2.Items.Add("NanoHenrys (nH)");

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opções da comboBoxIndutância
            if (idiomaBobines == "portugues")
            {
                comboBoxIndutancia.Items.Add("Ferro");
                comboBoxIndutancia.Items.Add("Aço");
                comboBoxIndutancia.Items.Add("Niquel");
                comboBoxIndutancia.Items.Add("Cobalto");
                comboBoxIndutancia.Items.Add("Cobre");
                comboBoxIndutancia.Items.Add("Ar");
            }
            else if (idiomaBobines == "ingles")
            {
                comboBoxIndutancia.Items.Add("Iron");
                comboBoxIndutancia.Items.Add("Steel");
                comboBoxIndutancia.Items.Add("Nickel");
                comboBoxIndutancia.Items.Add("Cobalt");
                comboBoxIndutancia.Items.Add("Copper");
                comboBoxIndutancia.Items.Add("Air");
            }

            //Indice da Opção Desejada como Seleção Inicial
            comboBoxIndutancia.SelectedIndex = -1;


            //Esconder Resultado no Cálculo de Associação de Bobines
            labelResultado2.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Indutância
            labelResultado1.Visible = false;
            textBox3.Visible = false;

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

            labelResultado1.ForeColor = ThemeColor.PrimaryColor;
            labelResultado2.ForeColor = ThemeColor.PrimaryColor;
        }

        //Função para Trocar os Textos conforme o Idioma
        private void AtualizarTextos()
        {
            if (idiomaBobines == "ingles")
            {
                //Tradução das Frases
                this.Text = "Coils";
                label2.Text = "Permeability of the Coil Core Material (in Henrys per Meter, H/m)";
                label3.Text = "Cross-sectional Area of the Coil Core (in Square Meters, m²)";
                label5.Text = "Length of the Coil Core (in Meters, m)";
                label6.Text = "Number of Turns of the Coil";
                labelResultado1.Text = "The result is:";
                labelResultado2.Text = "The result is:";
                labelindutancia.Text = "Calculation of Inductance";
                labelAssoRes.Text = "Capacitor Association";
                btnSer.Text = "Series";
                btnPar.Text = "Parallel";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                label1.Text = "Coil 1";
                label4.Text = "Coil 2";

                //Ajuste nas Posições
                textBox1.Location = new Point(410, 206);
                textBox2.Location = new Point(290, 255);
                textBox7.Location = new Point(225, 300);
                comboBoxIndutancia.Location = new Point(450, 160);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
                labelResultado2.Padding = new Padding(15, 0, 0, 0);
            }
            else if (idiomaBobines == "portugues")
            {
                this.Text = "Bobines";
                
                //Tradução das Frases
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

                //Ajuste nas Posições
                textBox1.Location = new Point(518, 206);
                textBox2.Location = new Point(365, 255);
                comboBoxIndutancia.Location = new Point(520, 160);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(0, 0, 0, 0);
                labelResultado2.Padding = new Padding(0, 0, 0, 0);
            }
        }

        //Aplicar Tema de Cor Principal
        private void FormBobines_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion Misc

        #region Adicionar/Remover Caixas Texto

        //Inicia Contador de Caixas de Texto no Valor 3
        private int textboxCount = 3;

        //Função para Adicionar Caixas de Texto
        private void AddBoxes()
        {
            // Verificação se o Número Máximo de TextBoxes foi Atingido
            if (textboxCount <= 8)
            {

                System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();
                System.Windows.Forms.ComboBox newComboBox = new System.Windows.Forms.ComboBox();

                //Propriedades das Novas ComboBoxs
                newComboBox.FlatStyle = FlatStyle.Flat;
                newComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                newComboBox.Cursor = Cursors.Hand;

                if (idiomaBobines == "portugues")
                {
                    // Propriedades dos Novos Controles
                    newLabel.Text = string.Format("Bobine {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a Fonte como Calibri, Tamanho 10.2 e Negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a Cor do Texto como Azul
                }
                else if (idiomaBobines == "ingles")
                {
                    newLabel.Text = string.Format("Coil {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a Fonte como Calibri, Tamanho 10.2 e Negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a Cor do Texto como Azul


                }

                // Adicionamento de Novos Controles aos FlowLayoutPanels
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel2.Controls.Add(newComboBox);

                //Opções da ComboBox
                newComboBox.Items.Add("GigaHenrys (GH)");
                newComboBox.Items.Add("MegaHenrys (MH)");
                newComboBox.Items.Add("KiloHenrys (kH)");
                newComboBox.Items.Add("Henrys (H)");
                newComboBox.Items.Add("MiliHenrys (mH)");
                newComboBox.Items.Add("MicroHenrys (µH)");
                newComboBox.Items.Add("NanoHenrys (nH)");

                // Indice da Opção Desejada como Seleção Inicial
                newComboBox.SelectedIndex = 3;

                // Incrementa o Contador
                textboxCount++;
            }
        }

        //Função para Remover Caixas de Texto
        private void RemoveBoxes()
        {
            //Remove as Caixas Inseridas até só Existir Menos que 3
            if (textboxCount > 3)
            {
                if (flowLayoutPanel1.Controls.Count > 1)
                {
                    //Remove os Últimos Controles Adicionados aos FlowLayoutPanels
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                    textboxCount--;
                }
            }
        }

        #endregion Adicionar/Remover Caixas Texto

        #region Calculo Bobines

        #region Codigo Calculo 

        //Função para Converter Unidades
        private double ConverterUnidade(double valor, string unidade)
        {
            switch (unidade)
            {
                case "GigaHenrys (GH)":
                    return valor * 1e9;

                case "MegaHenrys (MH)":
                    return valor * 1e6;

                case "KiloHenrys (kH)":
                    return valor * 1e3;

                case "Henrys (H)":
                    return valor;

                case "MiliHenrys (mH)":
                    return valor * 1e-3;

                case "MicroHenrys (µH)":
                    return valor * 1e-6;

                case "NanoHenrys (nH)":
                    return valor * 1e-9;

                default:
                    // Se a Unidade não for Reconhecida, Retorna o Valor Original
                    return valor;
            }
        }
        //Cálculo Série Bobines
        private void BobSerie(TextBox textBoxResultado)
        {
            double BobineTotal = 0;
            bool valoresValidos = true; // Flag para Verificar se todos os Valores são Válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para Processar TextBox e ComboBox Associada
            {
                Control controlBobine = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];
                double Bobine;
                string unidade = controlUnidade.Text;
                if (double.TryParse(controlBobine.Text, out Bobine))
                {
                    Bobine = ConverterUnidade(Bobine, unidade);
                    BobineTotal += Bobine;
                }
                else
                {
                    // Se um Valor não puder ser Convertido para Double, Definimos a Flag como False
                    valoresValidos = false;
                    break; // Sai do Loop, pois não há Necessidade de Continuar Verificando
                }
            }

            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro 
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
                // Exibimos o Calor Calculado na TextBox de Resultado
                textBoxResultado.Text = BobineTotal.ToString("0.####") + " Henrys";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Paralelo Bobines
        private void BobParalelo(TextBox textBoxResultado)
        {
            double BobineTotal = 0;
            bool valoresValidos = true; // Flag para Verificar se todos os Valores são Válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para processar TextBox e ComboBox associada
            {
                Control controlBobine = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];
                double Bobine;
                string unidade = controlUnidade.Text;
                if (double.TryParse(controlBobine.Text, out Bobine))
                {
                    Bobine = ConverterUnidade(Bobine, unidade);
                    BobineTotal += 1/Bobine;
                }
                else
                {
                    // Se um Valor não puder ser Convertido para Double, Definimos a Flag como False
                    valoresValidos = false;
                    break; // Sai do Loop, pois não há Necessidade de Continuar Verificando
                }
            }
            BobineTotal = 1 / BobineTotal;
            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro
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
                // Exibimos o Valor Calculado na TextBox de Resultado
                textBoxResultado.Text = BobineTotal.ToString("0.####") + " Henrys";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo da Indutância
        private void Indutancia(TextBox textBoxResultado)
        {
            double Pmagnetica = 0, area = 0, comprimento = 0, nEspiras = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out area) ||
                !double.TryParse(textBox7.Text, out nEspiras) ||
                !double.TryParse(textBox2.Text, out comprimento))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
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

            // Verifica se uma Opção foi Selecionada na ComboBox
            if (comboBoxIndutancia.SelectedItem == null)
            {
                // Se Nenhuma Opção for Selecionada, Exibe uma Mensagem de Erro
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

            // Obtém a Opção Selecionada na ComboBox como uma String
            string escolha = comboBoxIndutancia.SelectedItem.ToString();

            // Define o Valor da Permiabilidade Magnética com Base na Opção Selecionada
            switch (escolha)
            {
                case "Iron":
                case "Ferro":
                    Pmagnetica = 6000;
                    break;

                case "Steel":
                case "Aço":
                    Pmagnetica = 3000;
                    break;

                case "Nickel":
                case "Niquel":
                    Pmagnetica = 600;
                    break;

                case "Cobalt":
                case "Cobalto":
                    Pmagnetica = 2000;
                    break;

                case "Copper":
                case "Cobre":
                    Pmagnetica = 0.000001;
                    break;

                case "Air":
                case "Ar":
                    Pmagnetica = 1;
                    break;

            }

            // Realiza o Cálculo da Indutância da Bobine
            double indutancia = Pmagnetica * area * (nEspiras * nEspiras) / comprimento;

            //Imprime o Resultado
            textBoxResultado.Text = indutancia.ToString("0.####") + " Henrys";
            labelResultado1.Visible = true;
            textBox3.Visible = true;
       
        }
        
        #endregion Codigo Calculo 

        #region Codigo Botoes
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adiciona Caixa de Texto
            AddBoxes();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //Remove Caixa de Texto
            RemoveBoxes();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            //Executa Programa BobParalelo(textBox5)
            BobParalelo(textBox5);
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            //Executa Programa BobSerie(textBox5)
            BobSerie(textBox5);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Executa Programa Indutancia(textBox5)
            Indutancia(textBox3);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";

            //Esconde a Impressão de Resultado
            textBox3.Visible = false;
            labelResultado1.Visible = false;

            //Limpa a Opção Selecionada na ComboBoxMaterial
            comboBoxIndutancia.SelectedIndex = -1;
        }

        #endregion Codigo Botoes

        #endregion Calculo Bobines


    }
}
