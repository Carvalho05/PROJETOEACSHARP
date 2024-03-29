﻿using System;
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
            
            //Associação da Variável Geral de Idioma dos Condensadores com a do Programa
            this.idiomaCondensadores = idiomaAtual;
            
            AtualizarTextos();

            //Opções da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaFarads (GF)");
            comboBoxUnidades.Items.Add("MegaFarads (MF)");
            comboBoxUnidades.Items.Add("kiloFarads (kF)");
            comboBoxUnidades.Items.Add("Farads (F)");
            comboBoxUnidades.Items.Add("miliFarads (mF)");
            comboBoxUnidades.Items.Add("microFarads (µF)");
            comboBoxUnidades.Items.Add("nanoFarads (nF)");

            // Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades.SelectedIndex = 3;


            //Opções da comboBoxUnidades2
            comboBoxUnidades2.Items.Add("GigaFarads (GF)");
            comboBoxUnidades2.Items.Add("MegaFarads (MF)");
            comboBoxUnidades2.Items.Add("kiloFarads (kF)");
            comboBoxUnidades2.Items.Add("Farads (F)");
            comboBoxUnidades2.Items.Add("miliFarads (mF)");
            comboBoxUnidades2.Items.Add("microFarads (µF)");
            comboBoxUnidades2.Items.Add("nanoFarads (nF)");

            //Indice da Opção Desejada como Seleção Inicial
            comboBoxUnidades2.SelectedIndex = 3;


            //Opções da comboBoxCapacitância

            if (idiomaCondensadores == "portugues")
            {
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
            }
            else if (idiomaCondensadores == "ingles")
            {
                comboBoxCapacitância.Items.Add("Air");
                comboBoxCapacitância.Items.Add("Paper");
                comboBoxCapacitância.Items.Add("Glass");
                comboBoxCapacitância.Items.Add("PVC (Polyvinyl Chloride)");
                comboBoxCapacitância.Items.Add("Ceramic");
                comboBoxCapacitância.Items.Add("Water (20°C)");
                comboBoxCapacitância.Items.Add("Mica");
                comboBoxCapacitância.Items.Add("Teflon (PTFE)");
                comboBoxCapacitância.Items.Add("Polystyrene (PS)");
                comboBoxCapacitância.Items.Add("Polyethylene (PE)");
                comboBoxCapacitância.Items.Add("Polypropylene (PP)");
                comboBoxCapacitância.Items.Add("Polyurethane (PU)");
                comboBoxCapacitância.Items.Add("Silicone Rubber");
                comboBoxCapacitância.Items.Add("Ethylene Propylene Rubber");
            }
            //Indice da Opção Desejada como Seleção Inicial
            comboBoxCapacitância.SelectedIndex = -1;


            //Esconder Resultado no Cálculo de Associação de Condensadores
            labelResultado2.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Capacitância
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
            if (idiomaCondensadores == "ingles")
            {
                //Tradução das Frases
                this.Text = "Capacitors";
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

                //Ajuste nas Posições
                textBox1.Location = new Point(335, 205);
                textBox2.Location = new Point(300, 253);
                comboBoxCapacitância.Location = new Point(535, 158);

                //Ajuste nas Margens
                labelResultado1.Padding = new Padding(15, 0, 0, 0);
                labelResultado2.Padding = new Padding(15, 0, 0, 0);
            }
            else if (idiomaCondensadores == "portugues")
            {
                //Tradução das Frases
                this.Text = "Condensadores";
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

                //Ajuste nas Posições
                textBox1.Location = new Point(410, 205);
                textBox2.Location = new Point(288, 253);
                comboBoxCapacitância.Location = new Point(515, 158);
            }
        }

        //Aplicar Tema de Cores Principal
        private void FormCondensadores_Load(object sender, EventArgs e)
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
            // Verificação se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 8)
            {
                
                System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();
                System.Windows.Forms.ComboBox newComboBox = new System.Windows.Forms.ComboBox();

                //Propriedades das Novas ComboBoxs
                newComboBox.FlatStyle = FlatStyle.Flat;
                newComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                newComboBox.Cursor = Cursors.Hand;

                if (idiomaCondensadores == "portugues")
                {
                    // Propriedades dos novos controles
                    newLabel.Text = string.Format("Condensador {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a Fonte como Calibri, Tamanho 10.2 e Negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a Cor do Texto como Azul
                }
                else if (idiomaCondensadores == "ingles")
                {
                    newLabel.Text = string.Format("Capacitor {0}", textboxCount);
                    newLabel.Margin = new Padding(5, 0, 0, 6);
                    newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a Fonte como Calibri, Tamanho 10.2 e Negrito
                    newLabel.ForeColor = Color.Blue; // Definindo a Cor do Texto como Azul
                
                
                }

                // Adicionamento de Novos Controles ao FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newLabel);
                flowLayoutPanel2.Controls.Add(newTextBox);
                flowLayoutPanel2.Controls.Add(newComboBox);

                //Opções da ComboBox
                newComboBox.Items.Add("GigaFarads (GF)");
                newComboBox.Items.Add("MegaFarads (MF)");
                newComboBox.Items.Add("kiloFarads (kF)");
                newComboBox.Items.Add("Farads (F)");
                newComboBox.Items.Add("miliFarads (mF)");
                newComboBox.Items.Add("microFarads (µF)");
                newComboBox.Items.Add("nanoFarads (nF)");
                
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

        #region Calculo Condensadores

        #region Codigo Calculo 

        //Função para Converter Unidades
        private double ConverterUnidade(double valor, string unidade)
        {
            switch (unidade)
            {
                case "GigaFarads (GF)":
                    return valor * 1e9;

                case "MegaFarads (MF)":
                    return valor * 1e6;

                case "kiloFarads (kF)":
                    return valor * 1e3;

                case "Farads (F)":
                    return valor;

                case "miliFarads (mF)":
                    return valor * 1e-3;

                case "microFarads (µF)":
                    return valor * 1e-6;

                case "nanoFarads (nF)":
                    return valor * 1e-9;

                default:
                    // Se a Unidade não for Reconhecida, Retorna o Valor Original
                    return valor;
            }
        }
        //Cálculo Paralelo Condensadores
        private void ConParalelo(TextBox textBoxResultado)
        {
            double CondensadorTotal = 0;
            bool valoresValidos = true; // Flag para Verificar se todos os Valores são Válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para Processar TextBox e ComboBox Associada
            {
                Control controlCondensador = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];
                double Condensador;
                string unidade = controlUnidade.Text;
                if (double.TryParse(controlCondensador.Text, out Condensador))
                {
                    Condensador = ConverterUnidade(Condensador, unidade);
                    CondensadorTotal += Condensador;
                }
                else
                {
                    // Se um valor não puder ser Convertido para Double, Definimos a Flag como False
                    valoresValidos = false;
                    break; // Sai do Loop, pois não há Necessidade de Continuar Verificando
                }
            }

            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro
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
                // Exibimos o Valor Calculado na TextBox de Resultado
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo Série Condensadores
        private void ConSerie(TextBox textBoxResultado)
        {
            double CondensadorTotal = 0;
            bool valoresValidos = true; // Flag para Verificar se todos os Valores são Válidos

            // Loop através de todas as TextBoxes dentro do FlowLayoutPanel
            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i += 2) // Incremento de 2 para processar TextBox e ComboBox associada
            {
                Control controlCondensador = flowLayoutPanel2.Controls[i];
                Control controlUnidade = flowLayoutPanel2.Controls[i + 1];
                double Condensador;
                string unidade = controlUnidade.Text;
                if (double.TryParse(controlCondensador.Text, out Condensador))
                {
                    Condensador = ConverterUnidade(Condensador, unidade);
                    CondensadorTotal += 1/Condensador;
                }
                else
                {
                    // Se um valor não puder ser Convertido para Double, Definimos a Flag como False
                    valoresValidos = false;
                    break; // Sai do Loop, pois não há Necessidade de Continuar Verificando
                }
            }
            CondensadorTotal = 1 / CondensadorTotal;
            if (!valoresValidos)
            {
                // Se algum Valor não for Válido, Exibe uma Mensagem de Erro
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
                // Exibimos o Valor Calculado na TextBox de Resultado
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                labelResultado2.Visible = true;
                textBox5.Visible = true;
            }
        }

        //Cálculo da Capacitância
        private void Capacitancia(TextBox textBoxResultado)
        {
            double dialetrico = 0, area = 0, distancia = 0;

            // Verifica se a Conversão dos Valores das TextBoxes é Bem-Sucedida
            if (!double.TryParse(textBox1.Text, out area) ||
                !double.TryParse(textBox2.Text, out distancia))
            {
                // Se algum Valor não puder ser Convertido para Double, Exibe uma Mensagem de Erro
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

            // Verifica se uma Opção foi Selecionada na ComboBox
            if (comboBoxCapacitância.SelectedItem == null)
            {
                // Se a Opção Selecionada for Inválida, Exibe uma Mensagem de Erro
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

            // Obtém a Opção Selecionada na ComboBox como uma String
            string escolha = comboBoxCapacitância.SelectedItem.ToString();

            // Define o Valor do Diaelétrico com Base na Opção Selecionada
            switch (escolha)
            {
                case "Air":
                case "Ar":
                    dialetrico = 1;
                    break;

                case "Paper":
                case "Papel":
                    dialetrico = 4.75;
                    break;

                case "Glass":
                case "Vidro":
                    dialetrico = 7;
                    break;

                case "PVC (Polyvinyl Chloride)":
                case "PVC (Policloreto de Vinila)":
                    dialetrico = 5.6;
                    break;

                case "Ceramic":
                case "Cerâmica":
                    dialetrico = 6;
                    break;

                case "Water (20°C)":
                case "Água (20°C)":
                    dialetrico = 80;
                    break;

                case "Mica":
                    dialetrico = 6;
                    break;

                case "Teflon (PTFE)":
                    dialetrico = 2.05;
                    break;

                case "Polystyrene (PS)":
                case "Poliestireno (PS)":
                    dialetrico = 2.65;
                    break;

                case "Polyethylene (PE)":
                case "Polietileno (PE)":
                    dialetrico = 2.32;
                    break;

                case "Polypropylene (PP)":
                case "Polipropileno (PP)":
                    dialetrico = 2.25;
                    break;

                case "Polyurethane (PU)":
                case "Poliuretano (PU)":
                    dialetrico = 5.75;
                    break;

                case "Silicone Rubber":
                case "Borracha de Silicone":
                    dialetrico = 3.25;
                    break;

                case "Ethylene Propylene Rubber":
                case "Borracha Etileno Propileno":
                    dialetrico = 2.9;
                    break;
            }

            // Realiza o Cálculo da Capacitância do Condensador
            double capacitancia = (dialetrico * area) / distancia;

            // Exibe o Resultado na TextBox de Resultado
            textBoxResultado.Text = capacitancia.ToString("0.####") + " Farads";
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
            //Executa Programa ConParalelo(textBox5)
            ConParalelo(textBox5);
        }
        
        private void btnSer_Click(object sender, EventArgs e)
        {
            //Executa Programa ConSerie(textBox5)
            ConSerie(textBox5);
        }
        
        private void btnCal_Click(object sender, EventArgs e)
        {
            //Executa Programa Capacitancia(textBox5)
            Capacitancia(textBox3);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as TextBox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            //Esconde a Impressão de Resultado
            textBox3.Visible = false;
            labelResultado1.Visible = false;

            //Limpa a Opção Selecionada na ComboBoxCapacitância
            comboBoxCapacitância.SelectedItem = null;
        }

        #endregion Codigo Botoes

        #endregion Calculo Condensadores

    }
}
