using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EletroMath
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string idiomaAtual = "portugues";



        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            UpdateLanguageButtonText();
            AtualizarTextos();
            this.Text=string.Empty;
            panelSubMenuRes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                panelSubMenuRes.Visible = false;
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecundaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    btnLang.Visible = false;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnLang.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRes);
        }

        private void btnTeo_Click(object sender, EventArgs e)
        {
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormTeoremas(), sender);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormCondensadores(), sender);
        }

        private void btnBob_Click(object sender, EventArgs e)
        {
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormBobines(), sender);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormSinais(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            {
                if (idiomaAtual == "portugues")
                {
                    idiomaAtual = "ingles";
                }
                else
                {
                    idiomaAtual = "portugues";
                }
                // Atualiza o texto do botão de alteração de idioma com base no idioma atual
                UpdateLanguageButtonText();
                AtualizarTextos();
            }
        }
        private void UpdateLanguageButtonText()
        {
            // Define o texto do botão de alteração de idioma com base no idioma atual
            btnLang.Text = idiomaAtual == "portugues" ? "EN" : "PT";
        }
        private void AtualizarTextos()
        {
            // Verifica o idioma atual e define os textos correspondentes para cada Label
            if (idiomaAtual == "ingles")
            {
                btnRes.Text = "Resistors";
                btnTeo.Text = "Theorems";
                btnCon.Text = "Capacitors";
                btnBob.Text = "Coils";
                btnSin.Text = "Digital Signals";
            }
            else if (idiomaAtual == "portugues")
            {
                btnRes.Text = "Resistências";
                btnTeo.Text = "Teoremas";
                btnCon.Text = "Condensadores";
                btnBob.Text = "Bobines";
                btnSin.Text = "Sinais Digitais";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResistencias(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResTemp(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResCondu(), sender);
        }
    }
}
