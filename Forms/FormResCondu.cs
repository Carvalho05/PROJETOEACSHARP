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
            LoadTheme();    
            pnlfrstcol.Visible = false; 
            SetupEventHandlers();
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
        private void SetupEventHandlers()
        {
            // Associe o manipulador de eventos ao evento Click de cada PictureBox
            pctBox1st.Click += pctBox1st_Click;
            // Adicione outros manipuladores de eventos para PictureBoxes aqui, se necessário

            // Associe o manipulador de eventos ao evento CheckedChanged de cada botão de rádio
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
            radioButton9.CheckedChanged += RadioButton_CheckedChanged;
            radioButton10.CheckedChanged += RadioButton_CheckedChanged;

        }

        private void pctBox1st_Click(object sender, EventArgs e)
        {
            // Salva a PictureBox clicada para referência futura
            pictureBoxSelected = sender as PictureBox;
            pnlfrstcol.Visible = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (pictureBoxSelected != null && radioButton != null && radioButton.Checked)
            {
                // Aplica a cor do RadioButton à PictureBox selecionada
                pictureBoxSelected.BackColor = radioButton.ForeColor;
            }
        }
    }
}



        /*private void pctBox1st_Click(object sender, EventArgs e)
        {
            // Torna o painel de cores visível
            pnlfrstcol.Visible = true;

            // Itera sobre os RadioButtons no painel de cores
            foreach (Control control in pnlfrstcol.Controls)
            {
                RadioButton radioButton = control as RadioButton;
                if (radioButton != null && radioButton.Checked)
                {
                    // Atualiza a cor da PictureBox com a cor selecionada no RadioButton
                    pctBox1st.BackColor = radioButton.ForeColor;

                    // Não é necessário continuar procurando após encontrar o RadioButton selecionado
                    break;
                }
            }
        }*/

  