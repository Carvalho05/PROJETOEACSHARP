using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroMath.Forms
{
    public partial class FormResistencias : Form
    {
        #region Misc

        //Criação de Variável Geral de Idioma para o Código Resistências
        private string idiomaResistencias;
        public FormResistencias(string idiomaAtual)
        {
            InitializeComponent();

            //Associação da Variável Geral de Idioma das Resistências com a do Programa
            this.idiomaResistencias = idiomaAtual;

            AtualizarTextos();


            //Opções da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidades.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidades.Items.Add("kiloOhms (kΩ)");
            comboBoxUnidades.Items.Add("Ohms (Ω)");
            comboBoxUnidades.Items.Add("miliOhms (mΩ)");
            comboBoxUnidades.Items.Add("microOhms (µΩ)");
            comboBoxUnidades.Items.Add("nanoOhms (nΩ)");

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opções da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidades2.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidades2.Items.Add("kiloOhms (kΩ)");
            comboBoxUnidades2.Items.Add("Ohms (Ω)");
            comboBoxUnidades2.Items.Add("miliOhms (mΩ)");
            comboBoxUnidades2.Items.Add("microOhms (µΩ)");
            comboBoxUnidades2.Items.Add("nanoOhms (nΩ)");

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opções da comboBoxCondutancia
            comboBoxUnidadesCondutancia.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidadesCondutancia.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidadesCondutancia.Items.Add("kiloOhms (kΩ)");
            comboBoxUnidadesCondutancia.Items.Add("Ohms (Ω)");
            comboBoxUnidadesCondutancia.Items.Add("MiliOhms (mΩ)");
            comboBoxUnidadesCondutancia.Items.Add("MicroOhms (µΩ)");
            comboBoxUnidadesCondutancia.Items.Add("NanoOhms (nΩ)");

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidadesCondutancia.SelectedIndex = 3;


            //Esconder Resultado no Cálculo de Associação de Resistências
            labelResultado2.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Condutância
            labelResultado1.Visible = false;
            textBox2.Visible = false;
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
            labelResultado1.ForeColor = ThemeColor.PrimaryColor;
            labelResultado2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormResistencias_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void AtualizarTextos()
        {
            if (idiomaResistencias == "ingles")
            {
                //Tradução das Frases
                this.Text = "Conductance and Resistor Calculation";
                label1.Text = "Enter the Resistance Value";
                label2.Text = "Resistor 1";
                label3.Text = "Resistor 2";
                labelResultado1.Text = "The result is:";
                labelResultado2.Text = "The result is:";
                labelCondutancia.Text = "Calculation of Conductance";
                labelAssoRes.Text = "Resistors Association";
                btnSer.Text = "Series";
                btnPar.Text = "Parallel";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";

                //Ajuste nas Posições
                textBox1.Location = new Point(223, 187);
                comboBoxUnidadesCondutancia.Location = new Point(343, 187);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(35, 0, 0, 0);
                labelResultado2.Padding = new Padding(35, 0, 0, 0);
            }
            else if (idiomaResistencias == "portugues")
            {
                //Tradução das Frases
                this.Text = "Condutância e Cálculo de Resistências";
                label1.Text = "Insira o Valor da Resistência";
                label2.Text = "Resistência 1";
                label3.Text = "Resistência 2";
                labelResultado1.Text = "O Resultado é:";
                labelResultado2.Text = "O Resultado é:";
                labelCondutancia.Text = "Cálculo da Condutância";
                labelAssoRes.Text = "Associação de Resistências";
                btnSer.Text = "Série";
                btnPar.Text = "Paralelo";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";

                //Ajuste nas Posições
                textBox1.Location = new Point(227, 187);
                comboBoxUnidadesCondutancia.Location = new Point(347, 187);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(25, 0, 0, 0);
                labelResultado2.Padding = new Padding(25, 0, 0, 0);
            }
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

                Label newLabel = new Label();
                TextBox newTextBox = new TextBox();
                ComboBox newComboBox = new ComboBox();

                // Propriedades dos Novos Controles

                if (idiomaResistencias == "portugues")
                {
                    newLabel.Text = string.Format(" Resistência {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Aplicar Formatação de Texto 
                    newLabel.ForeColor = Color.Blue; // Aplicar Cor Azul
                }
                else if (idiomaResistencias == "ingles")
                {
                    newLabel.Text = string.Format(" Resistor {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Aplicar Formatação de Texto 
                    newLabel.ForeColor = Color.Blue; // Aplicar Cor Azul
                }

                // Adição de caixas
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel2.Controls.Add(newComboBox);

                //Opções da ComboBox
                newComboBox.Items.Add("GigaOhms (GΩ)");
                newComboBox.Items.Add("MegaOhms (MΩ)");
                newComboBox.Items.Add("kiloOhms (kΩ)");
                newComboBox.Items.Add("Ohms (Ω)");
                newComboBox.Items.Add("miliOhms (mΩ)");
                newComboBox.Items.Add("microOhms (µΩ)");
                newComboBox.Items.Add("nanoOhms (nΩ)");

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
                    // Remova os Últimos Controles Adicionados dos FlowLayoutPanels
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                    flowLayoutPanel2.Controls.RemoveAt(flowLayoutPanel2.Controls.Count - 1);
                    textboxCount--;
                }
            }
        }

        #endregion Adicionar/Remover Caixas Texto

        #region Calculo Resistencias

        #region Codigo Calculo 
        private double ConverterUnidade(double valor, string unidade)
        {
            switch (unidade)
            {
                case "GigaOhms (GΩ)":
                    return valor * 1e9;

                case "MegaOhms (MΩ)":
                    return valor * 1e6;

                case "kiloOhms (kΩ)":
                    return valor * 1e3;

                case "Ohms (Ω)":
                    return valor;

                case "miliOhms (mΩ)":
                    return valor * 1e-3;

                case "microOhms (µΩ)":
                    return valor * 1e-6;

                case "nanoOhms (nΩ)":
                    return valor * 1e-9;

                default:
                    // Se a unidade não for reconhecida, retorna o valor original
                    return valor;
            }
        }
        //Cálculo Série Resistências
        private void ResSerie(TextBox textBoxResultado)
        {
            double ResistenciaTotal = 0;
            bool valoresValidos = true;

            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para processar TextBox e ComboBox associada
            {
                Control controlResistencia = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];

                double Resistencia;
                string unidade = controlUnidade.Text;

                if (double.TryParse(controlResistencia.Text, out Resistencia))
                {
                    // Aplica a conversão de unidades à resistência individual
                    Resistencia = ConverterUnidade(Resistencia, unidade);

                    ResistenciaTotal += Resistencia;
                }
                else
                {
                    valoresValidos = false;
                    break;
                }
            }

            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro
                if (idiomaResistencias == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaResistencias == "ingles")
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
                textBoxResultado.Text = ResistenciaTotal.ToString("0.####") + " Ω";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Paralelo Resistências
        private void ResParalelo(TextBox textBoxResultado)
        {
            double ResistenciaTotal = 0;
            bool valoresValidos = true; // Flag para Verificar se todos os Valores são Válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para processar TextBox e ComboBox associada
            {
                Control controlResistencia = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];

                double Resistencia;
                string unidade = controlUnidade.Text;

                if (double.TryParse(controlResistencia.Text, out Resistencia))
                {
                    // Aplica a conversão de unidades à resistência individual
                    Resistencia = ConverterUnidade(Resistencia, unidade);

                    ResistenciaTotal += 1/Resistencia;
                }
                else
                {
                    valoresValidos = false;
                    break;
                }
            }
            ResistenciaTotal = 1 / ResistenciaTotal;
            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro 
                if (idiomaResistencias == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaResistencias == "ingles")
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
                textBoxResultado.Text = ResistenciaTotal.ToString("0.####") + " Ω";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Condutância
        private void Condutancia(TextBox textBoxResultado)
        {
            double resistencia = 0, condutancia = 0;

            if (!double.TryParse(textBox1.Text, out resistencia))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
                if (idiomaResistencias == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaResistencias == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }
                labelResultado1.Visible = false;
                textBox2.Visible = false;
                return;
            }

            // Verifica se uma Opção foi Selecionada na ComboBox
            if (comboBoxUnidadesCondutancia.SelectedItem == null)
            {
                // Se nenhuma Ppção foi Selecionada, Exibe uma Mensagem de Erro
                if (idiomaResistencias == "portugues")
                {
                    MessageBox.Show("Por favor, Selecione uma Unidade da Lista");
                }
                else if (idiomaResistencias == "ingles")
                {
                    MessageBox.Show("Please Select a Unit from the List");
                }
                labelResultado1.Visible = false;
                textBox2.Visible = false;
                return;
            }

            // Obtém a Opção Selecionada na ComboBox como uma String
            string escolha = comboBoxUnidadesCondutancia.SelectedItem.ToString();

            // Define o Valor da Resistência com Base na Opção Selecionada
            switch (escolha)
            {
                case "GigaOhms (GΩ)":
                    resistencia *= 1e9;
                    break;

                case "MegaOhms (MΩ)":
                    resistencia *= 1e6;
                    break;

                case "kiloOhms (kΩ)":
                    resistencia *= 1e3;
                    break;

                case "Ohms (Ω)":
                    break;

                case "miliOhms (mΩ)":
                    resistencia *= 1e-3;
                    break;

                case "microOhms (µΩ)":
                    resistencia *= 1e-6;
                    break;

                case "nanoOhms (nΩ)":
                    resistencia *= 1e-9;
                    break;

            }

            // Realiza o Cálculo da Condutância da Resistência
            condutancia = 1 / resistencia;

            // Exibe o Resultado na TextBox de Resultado
            textBoxResultado.Text = condutancia.ToString("0.####") + " Siemens";
            labelResultado1.Visible = true;
            textBox2.Visible = true;
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
            //Executa Programa ResParalelo(textBox5)
            ResParalelo(textBox5);
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            //Executa Programa ResSerie(textBox5)
            ResSerie(textBox5);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Executa Programa Condutancia(textBox5)
            Condutancia(textBox2);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox1.Text = "";
            textBox2.Text = "";

            //Esconde a Impressão de Resultado
            textBox2.Visible = false;
            labelResultado1.Visible = false;

            //Limpa a Opção Selecionada na ComboBoxCondutância
            comboBoxUnidadesCondutancia.SelectedIndex = 3;
        }

        #endregion Codigo Botoes

        #endregion Calculo Resistencias


    }
}