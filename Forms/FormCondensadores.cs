using System;
using System.Drawing;
using System.Windows.Forms;



namespace EletroMath.Forms
{
    public partial class FormCondensadores : Form
    {
        #region Misc
        public FormCondensadores()
        {
            InitializeComponent();

            //Opçoes da comboBoxUnidades
            comboBoxUnidades.Items.Add("GigaFarads (GF)");
            comboBoxUnidades.Items.Add("MegaFarads (MF)");
            comboBoxUnidades.Items.Add("kiloFarads (KF)");
            comboBoxUnidades.Items.Add("Farads (F)");
            comboBoxUnidades.Items.Add("miliFarads (mF)");
            comboBoxUnidades.Items.Add("microFarads (µF)");
            comboBoxUnidades.Items.Add("nanoFarads (nF)");

            // Indice da opção desejada como seleção inicial
            comboBoxUnidades.SelectedIndex = 3;

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
            label7.Visible = false;
            textBox5.Visible = false;

            //Esconder Resultado no Cálculo da Capacitância
            label6.Visible = false;
            textBox3.Visible = false;

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
        }
        private void FormCondensadores_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        #endregion Misc

        #region Adicionar/Remover Caixas Texto
        private int textboxCount = 2;
        private void AddBoxes()
        {
            // Verificação se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 8)
            {
                
                System.Windows.Forms.Label newLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();
                System.Windows.Forms.ComboBox newComboBox = new System.Windows.Forms.ComboBox();

                // Propriedades dos novos controles
                newLabel.Text = string.Format("Condensador {0}", textboxCount);
                newLabel.Margin = new Padding(0, 0, 0, 7);
                newLabel.Font = new Font("Calibri", 10.2f, FontStyle.Bold); // Definindo a fonte como Calibri, tamanho 10.2 e negrito
                newLabel.ForeColor = Color.Blue; // Definindo a cor do texto como Azul


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
            if (textboxCount > 2)
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
                MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                label7.Visible = false;
                textBox5.Visible = false;
                return;
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                label7.Visible = true;
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
                MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                label7.Visible = false;
                textBox5.Visible = false;
                return;
            }
            else
            {
                // Exibimos o valor calculado na TextBox de resultado
                textBoxResultado.Text = CondensadorTotal.ToString("0.####") + " Farads";
                label7.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void Capacitancia(TextBox textBoxResultado)
        {
            double dialetrico = 0, area = 0, distancia = 0;

            // Verifica se a conversão dos valores das TextBoxes é bem-sucedida
            if (!double.TryParse(textBox1.Text, out area) ||
                !double.TryParse(textBox2.Text, out distancia))
            {
                // Se algum valor não puder ser convertido para double, exibe uma mensagem de erro
                MessageBox.Show("Por favor, Insira Valores Válidos em todas as Caixas de Texto");
                label6.Visible = false;
                textBox3.Visible = false;
                return;
            }

            // Verifica se uma opção foi selecionada na ComboBox
            if (comboBoxCapacitância.SelectedItem == null)
            {
                // Se nenhuma opção foi selecionada, exibe uma mensagem de erro
                MessageBox.Show("Por favor, Selecione um Material na Lista");
                label6.Visible = false;
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
            label6.Visible = true;
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
            label6.Visible = false;
            comboBoxCapacitância.SelectedItem = null;
        }

        #endregion Codigo Botoes

        #endregion Calculo Condensadores

    }
}
