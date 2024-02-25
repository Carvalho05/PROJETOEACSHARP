using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            panelSubMenuRes.Visible = false;
            panelSubMenuTeo.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Codigo para esconder o submenu das resistencias
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

        //Codigo para a cor random
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

        //Código para realçar botão ao ser pressionado, aplicar tema de cores, esconder/mostrar botoes
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

        //Codigo para tirar realce do botão previamente pressionado
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
            foreach (Control previousBtn in panelSubMenuRes.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(73, 73, 100);
                    previousBtn.ForeColor = Color.Gainsboro;
                    new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnLang.Visible = true;
                }
            }
            foreach (Control previousBtn in panelSubMenuTeo.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(73, 73, 100);
                    previousBtn.ForeColor = Color.Gainsboro;
                    new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnLang.Visible = true;
                }
            }
        }
        //Código para definicoes ao abrir forms
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
        #region AcoesClique
        private void btnRes_Click(object sender, EventArgs e)
        {
            panelSubMenuTeo.Visible = false;
            showSubMenu(panelSubMenuRes);
        }

        private void btnTeo_Click(object sender, EventArgs e)
        {
            panelSubMenuRes.Visible = false;
            showSubMenu(panelSubMenuTeo);
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            panelSubMenuTeo.Visible = false;
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormCondensadores(idiomaAtual), sender);
        }

        private void btnBob_Click(object sender, EventArgs e)
        {
            panelSubMenuTeo.Visible = false;
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormBobines(idiomaAtual), sender);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            panelSubMenuTeo.Visible = false;
            panelSubMenuRes.Visible = false;
            OpenChildForm(new Forms.FormSinais(idiomaAtual), sender);
        }
        private void btnAssoRes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResistencias(idiomaAtual), sender);
        }

        private void btnTempRes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResTemp(idiomaAtual), sender);
        }

        private void btnCondRes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormResCondu(idiomaAtual), sender);
        }
        private void btnSMteo1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTeo1(idiomaAtual), sender);
        }

        private void btnSMteo2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTeo2(), sender);
        }

        private void btnSMteo3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTeo3(), sender);
        }

        //Close button
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }
        //Reset as definicoes para o MainMenu
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        //Codigo para alterar a variavel do idioma
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
                UpdateLanguageButtonText();
                AtualizarTextos();
            }
        }
        #endregion AcoesClique
        //Codgo para alterar o texto apresetado no botao de idioma
        private void UpdateLanguageButtonText()
        {
            btnLang.Text = idiomaAtual == "portugues" ? "EN" : "PT";
        }

        //Definicoes de texto a apresentar consoante variavel de idioma
        private void AtualizarTextos()
        {
            if (idiomaAtual == "ingles")
            {
                btnRes.Text = "Resistors";
                btnTeo.Text = "Theorems";
                btnCon.Text = "Capacitors";
                btnBob.Text = "Coils";
                btnSin.Text = "Digital Signals";
                btnAssoRes.Text = "Resistor Calculation and Conductance";
                btnCondRes.Text = "Resistor Color Code";
                btnTempRes.Text = "Temperature Coefficient";
                btnSMteo1.Text = "Ohm's Law and Dividers";
            }
            else if (idiomaAtual == "portugues")
            {
                btnRes.Text = "Resistências";
                btnTeo.Text = "Teoremas";
                btnCon.Text = "Condensadores";
                btnBob.Text = "Bobines";
                btnSin.Text = "Sinais Digitais";
                btnAssoRes.Text = "Cálculo de Resistências e Condutância";
                btnCondRes.Text = "Código de Cores";
                btnTempRes.Text = "Coeficiente de Temperatura";
                btnSMteo1.Text = "Lei de Ohm e Divisores";
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState= FormWindowState.Normal;
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botaoFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMaximizar_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void botaoMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
