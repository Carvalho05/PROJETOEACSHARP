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
            pnlfrstcol.Visible = false;
            pictureBoxRes.Visible = false;
            SetupEventHandlers();
        }
        //Aplicar o tema de cores aos botoes
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
        private void SetupEventHandlers()
        {
            pctBox1st.Click += pctBox1st_Click;
            pctBox2st.Click += pctBox2st_Click;
            pctBox3st.Click += pctBox3st_Click;


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
            radioButton11.CheckedChanged += RadioButton_CheckedChanged;
            radioButton12.CheckedChanged += RadioButton_CheckedChanged;

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
        private void pctBox1st_Click(object sender, EventArgs e)
        {
            pictureBoxSelected = sender as PictureBox;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            pnlfrstcol.Visible = true;
        }


        private void pctBox2st_Click(object sender, EventArgs e)
        {
            pictureBoxSelected = sender as PictureBox;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            pnlfrstcol.Visible = true;
        }

        private void pctBox3st_Click(object sender, EventArgs e)
        {
            pictureBoxSelected = sender as PictureBox;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            pnlfrstcol.Visible = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pctBox4st_Click(object sender, EventArgs e)
        {
            pictureBoxSelected = sender as PictureBox;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            pnlfrstcol.Visible = true;
        }

        private void btn4stripes_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = false;
            btn4stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void btn5strips_Click(object sender, EventArgs e)
        {
            ResetColors();
            pictureBoxRes.Visible = true;
            pctBox3st.Visible = true;
            btn5stripes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.3);
        }

        private void FormResCondu_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
  