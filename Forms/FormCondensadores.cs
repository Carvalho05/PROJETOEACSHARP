using System;
using System.Drawing;
using System.Windows.Forms;



namespace EletroMath.Forms
{
    public partial class FormCondensadores : Form
    {
        #region Misc

        //Criação de Variável Geral de Idioma para o Código Condensadores
        private string idiomaCondensadores;
        public FormCondensadores(string idiomaAtual)
        {
            InitializeComponent();
            
            //Associação da Variãvel Geral de Idioma dos Condensadores com a do Programa
            this.idiomaCondensadores = idiomaAtual;
            
            AtualizarTextos();


            //Opçoes da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaFarads (GF)");
            comboBoxUnidades.Items.Add("MegaFarads (MF)");
            comboBoxUnidades.Items.Add("KiloFarads (KF)");
            comboBoxUnidades.Items.Add("Farads (F)");
            comboBoxUnidades.Items.Add("MiliFarads (mF)");
            comboBoxUnidades.Items.Add("MicroFarads (µF)");
            comboBoxUnidades.Items.Add("NanoFarads (nF)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opçoes da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaFarads (GF)");
            comboBoxUnidades2.Items.Add("MegaFarads (MF)");
            comboBoxUnidades2.Items.Add("KiloFarads (KF)");
            comboBoxUnidades2.Items.Add("Farads (F)");
            comboBoxUnidades2.Items.Add("MiliFarads (mF)");
            comboBoxUnidades2.Items.Add("MicroFarads (µF)");
            comboBoxUnidades2.Items.Add("NanoFarads (nF)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opçoes da comboBoxCapacitância
            comboBoxCapacitância.Items.Add("Ar");
            comboBoxCapacitância.Items.Add("Papel");
            comboBoxCapacitância.Items.Add("Vidro");
            comboBoxCapacitância.Items.Add("PVC (Policloreto de Vinila)");
            comboBoxCapacitância.Items.Add("Cerâmica");
            comboBoxCapacitância.Items.Add("Água (20°C)");
            comboBoxCapacitância.Items.Add("Mica");
            comboBoxCapacitância.Items.Add("Teflon (PTFE)");
            comboBoxCapacitância.Items.Add("Poliestireno (PS)");
            comboBoxCapacitância.Items.Add("Polietileno (PE)");
            comboBoxCapacitância.Items.Add("Polipropileno (PP)");
            comboBoxCapacitância.Items.Add("Poliuretano (PU)");
            comboBoxCapacitância.Items.Add("Borracha de Silicone");
            comboBoxCapacitância.Items.Add("Borracha Etileno Propileno");
            
            // Indice da opção desejada como seleção inicial
            comboBoxCapacitância.SelectedIndex = -1;


            //Esconder Resultado no Cálculo de Associação de Condensadores
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
            if (idiomaCondensadores == "ingles")
            {
                label2.Text = "Permittivity of the Dielectric Material between the Plates (in Farads per Meter, F/m)";
                label3.Text = "Overlap Area of the Plates (in Square Meters, m²)";
                label5.Text = "Distance between the Plates (in Meters, m)";
                labelResultado1.Text = "The result is:";
                labelResultado2.Text = "The result is:";
                labelCapacitancia.Text = "Calculation of Capacitance";
                labelAssoRes.Text = "Capacitor Association";
                btnSer.Text = "Series";
                btnPar.Text = "Parallel";
                btnCal.Text = "Calculate";
                btnLimpar.Text = "Clear";
                label1.Text = "Capacitor 1";
                label4.Text = "Capacitor 2";
                textBox1.Location = new Point(335, 205);
                textBox2.Location = new Point(300, 253);
                comboBoxCapacitância.Location = new Point(535, 158);
            }
            else if (idiomaCondensadores == "portugues")
            {
                label2.Text = "Permitividade do Material Dialétrico entre as Placas (em Farads por Metro, F/m)";
                label3.Text = "Área de Sobreposição das Placas (em Metros Quadrados, m²)";
                label5.Text = "Distância entre as Placas (em Metros, m)";
                labelResultado1.Text = "O Resultado é:";
                labelResultado2.Text = "O Resultado é:";
                labelCapacitancia.Text = "Cálculo da Capacitância";
                labelAssoRes.Text = "Associação de Condensadores";
                btnSer.Text = "Série";
                btnPar.Text = "Paralelo";
                btnCal.Text = "Calcular";
                btnLimpar.Text = "Limpar";
                label1.Text = "Condensador 1";
                label4.Text = "Condensador 2";
                textBox1.Location = new Point(410, 205);
                textBox2.Location = new Point(288, 253);
                comboBoxCapacitância.Location = new Point(515, 158);
            }
        }

        private void FormCondensadores_Load(object sender, EventArgs e)
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

                if (idiomaCondensadores == "portugues")
                {
                    // Propriedades dos novos controles
                    newLabel.Text = string.Format("Condensador {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a fonte como Calibri, tamanho 10.2 e negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a cor do texto como Azul
                }
                else if (idiomaCondensadores == "ingles")
                {
                    newLabel.Text = string.Format("Capacitor {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a fonte como Calibri, tamanho 10.2 e negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a cor do texto como Azul
                
                
                }

                // Adicionamento de novos controles ao FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel3.Controls.Add(newComboBox);

                //Opçoes da ComboBox
                newComboBox.Items.Add("GigaFarads (GF)");
                newComboBox.Items.Add("MegaFarads (MF)");
                newComboBox.Items.Add("kiloFarads (KF)");
                newComboBox.Items.Add("Farads (F)");
                newComboBox.Items.Add("miliFarads (mF)");
                newComboBox.Items.Add("microFarads (µF)");
                newComboBox.Items.Add("nanoFarads (nF)");
                
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

        #region Calculo Condensadores

        #region Codigo Calculo 

        //Cálculo Paralelo Condensadores
        private void ConParalelo(TextBox textBoxResultado)
        {
            double CondensadorTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Condensador;
                if (double.TryParse(control.Text, out Condensador))
                {
                    CondensadorTotal += Condensador;
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
                if (idiomaCondensadores == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCondensadores == "ingles")
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
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Série Condensadores
        private void ConSerie(TextBox textBoxResultado)
        {
            double CondensadorTotal = 0;
            bool valoresValidos = true; // Flag para verificar se todos os valores são válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                double Condensador;
                if (double.TryParse(control.Text, out Condensador))
                {
                    CondensadorTotal += 1 / Condensador;
                }
                else
                {
                    // Se um valor não puder ser convertido para double, definimos a flag como false
                    valoresValidos = false;
                    break; // Sai do loop, pois não há necessidade de continuar verificando
                }
            }
            CondensadorTotal = 1 / CondensadorTotal;
            if (!valoresValidos)
            {
                // Se algum valor não for válido, exibimos uma mensagem de erro na TextBox de resultado
                if (idiomaCondensadores == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCondensadores == "ingles")
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
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo da Capacitância
        private void Capacitancia(TextBox textBoxResultado)
        {
            double dialetrico = 0, area = 0, distancia = 0;

            // Verifica se a conversão dos valores das TextBoxes é bem-sucedida
            if (!double.TryParse(textBox1.Text, out area) ||
                !double.TryParse(textBox2.Text, out distancia))
            {
                // Se algum valor não puder ser convertido para double, exibe uma mensagem de erro
                if (idiomaCondensadores == "portugues")
                {
                    MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                }
                else if (idiomaCondensadores == "ingles")
                {
                    MessageBox.Show("Please Enter Valid Values ​​in All Text Boxes");
                }

                labelResultado1.Visible = false;
                textBox3.Visible = false;
                return;
            }

            // Verifica se uma opção foi selecionada na ComboBox
            if (comboBoxCapacitância.SelectedItem == null)
            {
                // Se nenhuma opção foi selecionada, exibe uma mensagem de erro
                if (idiomaCondensadores == "portugues")
                {
                    MessageBox.Show("Por favor, Selecione um Material na Lista");
                }
                else if (idiomaCondensadores == "ingles")
                {
                    MessageBox.Show("Please Select a Material from the List");
                }

                labelResultado1.Visible = false;
                textBox3.Visible = false;
                return;
            }

            // Obtém a opção selecionada na ComboBox como uma string
            string escolha = comboBoxCapacitância.SelectedItem.ToString();

            // Define o valor do diaelétrico com base na opção selecionada
            switch (escolha)
            {
                case "Ar":
                    dialetrico = 1;
                    break;

                case "Papel":
                    dialetrico = 4.75;
                    break;

                case "Vidro":
                    dialetrico = 7;
                    break;

                case "PVC (Policloreto de Vinila)":
                    dialetrico = 5.6;
                    break;

                case "Cerâmica":
                    dialetrico = 6;
                    break;

                case "Água (20°C)":
                    dialetrico = 80;
                    break;

                case "Mica":
                    dialetrico = 6;
                    break;

                case "Teflon (PTFE)":
                    dialetrico = 2.05;
                    break;

                case "Poliestireno (PS)":
                    dialetrico = 2.65;
                    break;

                case "Polietileno (PE)":
                    dialetrico = 2.32;
                    break;

                case "Polipropileno (PP)":
                    dialetrico = 2.25;
                    break;

                case "Poliuretano (PU)":
                    dialetrico = 5.75;
                    break;

                case "Borracha de Silicone":
                    dialetrico = 3.25;
                    break;

                case "Borracha Etileno Propileno":
                    dialetrico = 2.9;
                    break;
            }

            // Realiza o cálculo da capacitância do condensador
            double capacitancia = (dialetrico * area) / distancia;

            // Exibe o resultado na TextBox de resultado
            textBoxResultado.Text = capacitancia.ToString("0.####") + " Farads";
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
            ConParalelo(textBox5);
        }
        
        private void btnSer_Click(object sender, EventArgs e)
        {
            ConSerie(textBox5);
        }
        
        private void btnCal_Click(object sender, EventArgs e)
        {
            Capacitancia(textBox3);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox3.Visible = false;
            labelResultado1.Visible = false;
            comboBoxCapacitância.SelectedItem = null;
        }

        #endregion Codigo Botoes

        #endregion Calculo Condensadores

    }
}
