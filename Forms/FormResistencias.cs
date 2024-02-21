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
    public partial class FormResistencias : Form
    {
        public FormResistencias()
        {
            InitializeComponent();
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


        private int textboxCount = 3;
        private void AddBoxes()
        {
            // Verifique se o número máximo de TextBoxes foi atingido
            if (textboxCount <= 6)
            {


                // Crie novos controles
                System.Windows.Forms.Label novaLabel = new System.Windows.Forms.Label();
                System.Windows.Forms.TextBox novaTextBox = new System.Windows.Forms.TextBox();

              

                // Configure propriedades dos novos controles
                novaLabel.Text = "Label";
                novaLabel.Text = string.Format("Resistência {0}", textboxCount);
                novaTextBox.Width = 88;
                novaTextBox.Height = 22;
                novaLabel.Width = 80;
                novaLabel.Height = 16;
                // Posicione os novos controles no formulário
                int top = 85 + textboxCount * 28; // Ajuste a posição conforme necessário
                novaLabel.Location = new Point(85, top);
                novaTextBox.Location = new Point(165, top);

                // Adicione os novos controles ao formulário
                Controls.Add(novaLabel);
                Controls.Add(novaTextBox);

                // Incrementa o contador
                textboxCount++;
            }
        }
        private void RemoveBoxes()
        {
            if (textboxCount > 3)
            {
                if (Controls.Count > 2)
                {
                    // Remova os últimos controles adicionados
                    Controls.RemoveAt(Controls.Count - 1);
                    Controls.RemoveAt(Controls.Count - 1);
                    textboxCount--;
                }
            }
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBoxes();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            RemoveBoxes();

        }

        private void FormResistencias_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

       
        private void labelAssoRes_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPar_Click(object sender, EventArgs e)
        {

        }

        private void btnSer_Click(object sender, EventArgs e)
        {

        }
    }
   
}
