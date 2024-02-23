using System;
using System.Drawing;
using System.Windows.Forms;

namespace EletroMath.Forms
{
    public partial class FormResistencias : Form
    {
        #region Misc

        //Criação de Variável Geral de Idioma para o Código Condensadores
        private string idiomaResistencias;
        public FormResistencias(string idiomaAtual)
        {
            InitializeComponent();

            //Associação da Variãvel Geral de Idioma das Resistências com a do Programa
            this.idiomaResistencias = idiomaAtual;

            AtualizarTextos();


            //Opções da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidades.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidades.Items.Add("KiloOhms (kΩ)");
            comboBoxUnidades.Items.Add("Ohms (Ω)");
            comboBoxUnidades.Items.Add("MiliOhms (mΩ)");
            comboBoxUnidades.Items.Add("MicroOhms (µΩ)");
            comboBoxUnidades.Items.Add("NanoOhms (nΩ)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opçoes da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidades2.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidades2.Items.Add("KiloOhms (kΩ)");
            comboBoxUnidades2.Items.Add("Ohms (Ω)");
            comboBoxUnidades2.Items.Add("MiliOhms (mΩ)");
            comboBoxUnidades2.Items.Add("MicroOhms (µΩ)");
            comboBoxUnidades2.Items.Add("NanoOhms (nΩ)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opções da comboBoxCondutancia
            comboBoxUnidadesCondutancia.Items.Add("GigaOhms (GΩ)");
            comboBoxUnidadesCondutancia.Items.Add("MegaOhms (MΩ)");
            comboBoxUnidadesCondutancia.Items.Add("KiloOhms (kΩ)");
            comboBoxUnidadesCondutancia.Items.Add("Ohms (Ω)");
            comboBoxUnidadesCondutancia.Items.Add("MiliOhms (mΩ)");
            comboBoxUnidadesCondutancia.Items.Add("MicroOhms (µΩ)");
            comboBoxUnidadesCondutancia.Items.Add("NanoOhms (nΩ)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidadesCondutancia.SelectedIndex = 3;


            //Esconder Resultado no Cálculo de Associação de Resistências
            labelResultado2.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Capacitância
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
        private int textboxCount = 3;

        private void AddBoxes()
        {
            // Verificação se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 8)
            {

                Label newLabel = new Label();
                TextBox newTextBox = new TextBox();
                ComboBox newComboBox = new ComboBox();

                // Propriedades dos novos controles

                if (idiomaResistencias == "portugues")
                {
                    newLabel.Text = string.Format(" Resistência {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Aplicar Formatação de texto 
                    newLabel.ForeColor = Color.Blue; // Aplicar cor azul
                }
                else if (idiomaResistencias == "ingles")
                {
                    newLabel.Text = string.Format(" Resistor {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Aplicar Formatação de texto 
                    newLabel.ForeColor = Color.Blue; // Aplicar cor azul
                }

                // Adição de caixas
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel3.Controls.Add(newComboBox);

                //Opções da ComboBox
                newComboBox.Items.Add("GigaOhms (GΩ)");
                newComboBox.Items.Add("MegaOhms (MΩ)");
                newComboBox.Items.Add("kiloOhms (KΩ)");
                newComboBox.Items.Add("Ohms (Ω)");
                newComboBox.Items.Add("miliOhms (mΩ)");
                newComboBox.Items.Add("microOhms (µΩ)");
                newComboBox.Items.Add("nanoOhms (nΩ)");

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

        #region Calculo Resistencias

        #region Codigo Calculo 

        //Cálculo Série Resistências
        private void ResSerie(TextBox textBoxResultado)
        {
            double ResistenciaTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Resistencia;
                if (double.TryParse(control.Text, out Resistencia))
                {
                    ResistenciaTotal += Resistencia;
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
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = ResistenciaTotal.ToString("0.####") + " Ω";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Paralelo Resistências
        private void ResParalelo(TextBox textBoxResultado)
        {
            double ResistenciaTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Resistencia;
                if (double.TryParse(control.Text, out Resistencia))
                {
                    ResistenciaTotal += 1 / Resistencia;
                }
                else
                {
                    // Se um valor não puder ser convertido para double, definimos a flag como false
                    valoresValidos = false;
                    break; // Sai do loop, pois não há necessidade de continuar verificando
                }
            }
            ResistenciaTotal = 1 / ResistenciaTotal;
            if (!valoresValidos)
            {
                // Se algum valor não for válido, exibimos uma mensagem de erro na TextBox de resultado
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
                // Exibimos o valor calculado na TextBox de resultado
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
                // Se algum valor não puder ser convertido para double, exibe uma mensagem de erro
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

            // Verifica se uma opção foi selecionada na ComboBox
            if (comboBoxUnidadesCondutancia.SelectedItem == null)
            {
                // Se nenhuma opção foi selecionada, exibe uma mensagem de erro
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

            // Obtém a opção selecionada na ComboBox como uma string
            string escolha = comboBoxUnidadesCondutancia.SelectedItem.ToString();

            // Define o valor do diaelétrico com base na opção selecionada
            switch (escolha)
            {
                case "GigaOhms (GΩ)":
                    resistencia *= 1e9;
                    break;

                case "MegaOhms (MΩ)":
                    resistencia *= 1e6;
                    break;

                case "kiloOhms (KΩ)":
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

            // Realiza o cálculo da condutância do condensador
            condutancia = 1 / resistencia;

            // Exibe o resultado na TextBox de resultado
            textBoxResultado.Text = condutancia.ToString("0.####") + " Siemens";
            labelResultado1.Visible = true;
            textBox2.Visible = true;
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
            ResParalelo(textBox5);
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            ResSerie(textBox5);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Condutancia(textBox2);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Visible = false;
            labelResultado1.Visible = false;
            comboBoxUnidadesCondutancia.SelectedIndex = 3;
        }

        #endregion Codigo Botoes

        #endregion Calculo Resistencias

    }
}
