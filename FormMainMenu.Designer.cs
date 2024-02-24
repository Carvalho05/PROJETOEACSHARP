namespace EletroMath
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnBob = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.panelSubMenuTeo = new System.Windows.Forms.Panel();
            this.btnSMteo3 = new System.Windows.Forms.Button();
            this.btnSMteo2 = new System.Windows.Forms.Button();
            this.btnSMteo1 = new System.Windows.Forms.Button();
            this.btnTeo = new System.Windows.Forms.Button();
            this.panelSubMenuRes = new System.Windows.Forms.Panel();
            this.btnCondRes = new System.Windows.Forms.Button();
            this.btnTempRes = new System.Windows.Forms.Button();
            this.btnAssoRes = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.botaoMinimizar = new System.Windows.Forms.Button();
            this.botaoMaximizar = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubMenuTeo.SuspendLayout();
            this.panelSubMenuRes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSin);
            this.panelMenu.Controls.Add(this.btnBob);
            this.panelMenu.Controls.Add(this.btnCon);
            this.panelMenu.Controls.Add(this.panelSubMenuTeo);
            this.panelMenu.Controls.Add(this.btnTeo);
            this.panelMenu.Controls.Add(this.panelSubMenuRes);
            this.panelMenu.Controls.Add(this.btnRes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 709);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSin
            // 
            this.btnSin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSin.Image = ((System.Drawing.Image)(resources.GetObject("btnSin.Image")));
            this.btnSin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSin.Location = new System.Drawing.Point(0, 564);
            this.btnSin.Name = "btnSin";
            this.btnSin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSin.Size = new System.Drawing.Size(220, 60);
            this.btnSin.TabIndex = 14;
            this.btnSin.Text = "Sinais Elétricos";
            this.btnSin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnBob
            // 
            this.btnBob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBob.FlatAppearance.BorderSize = 0;
            this.btnBob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBob.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBob.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBob.Image = ((System.Drawing.Image)(resources.GetObject("btnBob.Image")));
            this.btnBob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBob.Location = new System.Drawing.Point(0, 504);
            this.btnBob.Name = "btnBob";
            this.btnBob.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBob.Size = new System.Drawing.Size(220, 60);
            this.btnBob.TabIndex = 13;
            this.btnBob.Text = "Bobines";
            this.btnBob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBob.UseVisualStyleBackColor = true;
            this.btnBob.Click += new System.EventHandler(this.btnBob_Click);
            // 
            // btnCon
            // 
            this.btnCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCon.FlatAppearance.BorderSize = 0;
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCon.Image = ((System.Drawing.Image)(resources.GetObject("btnCon.Image")));
            this.btnCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon.Location = new System.Drawing.Point(0, 444);
            this.btnCon.Name = "btnCon";
            this.btnCon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCon.Size = new System.Drawing.Size(220, 60);
            this.btnCon.TabIndex = 12;
            this.btnCon.Text = "Condensadores";
            this.btnCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // panelSubMenuTeo
            // 
            this.panelSubMenuTeo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.panelSubMenuTeo.Controls.Add(this.btnSMteo3);
            this.panelSubMenuTeo.Controls.Add(this.btnSMteo2);
            this.panelSubMenuTeo.Controls.Add(this.btnSMteo1);
            this.panelSubMenuTeo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuTeo.Location = new System.Drawing.Point(0, 322);
            this.panelSubMenuTeo.Name = "panelSubMenuTeo";
            this.panelSubMenuTeo.Size = new System.Drawing.Size(220, 122);
            this.panelSubMenuTeo.TabIndex = 11;
            // 
            // btnSMteo3
            // 
            this.btnSMteo3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMteo3.FlatAppearance.BorderSize = 0;
            this.btnSMteo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMteo3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMteo3.Location = new System.Drawing.Point(0, 80);
            this.btnSMteo3.Name = "btnSMteo3";
            this.btnSMteo3.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSMteo3.Size = new System.Drawing.Size(220, 42);
            this.btnSMteo3.TabIndex = 2;
            this.btnSMteo3.Text = "paginazteo";
            this.btnSMteo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMteo3.UseVisualStyleBackColor = true;
            this.btnSMteo3.Click += new System.EventHandler(this.btnSMteo3_Click);
            // 
            // btnSMteo2
            // 
            this.btnSMteo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMteo2.FlatAppearance.BorderSize = 0;
            this.btnSMteo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMteo2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMteo2.Location = new System.Drawing.Point(0, 40);
            this.btnSMteo2.Name = "btnSMteo2";
            this.btnSMteo2.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSMteo2.Size = new System.Drawing.Size(220, 40);
            this.btnSMteo2.TabIndex = 1;
            this.btnSMteo2.Text = "paginayteo";
            this.btnSMteo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMteo2.UseVisualStyleBackColor = true;
            this.btnSMteo2.Click += new System.EventHandler(this.btnSMteo2_Click);
            // 
            // btnSMteo1
            // 
            this.btnSMteo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMteo1.FlatAppearance.BorderSize = 0;
            this.btnSMteo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMteo1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMteo1.Location = new System.Drawing.Point(0, 0);
            this.btnSMteo1.Name = "btnSMteo1";
            this.btnSMteo1.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSMteo1.Size = new System.Drawing.Size(220, 40);
            this.btnSMteo1.TabIndex = 0;
            this.btnSMteo1.Text = "paginaxteo";
            this.btnSMteo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMteo1.UseVisualStyleBackColor = true;
            this.btnSMteo1.Click += new System.EventHandler(this.btnSMteo1_Click);
            // 
            // btnTeo
            // 
            this.btnTeo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeo.FlatAppearance.BorderSize = 0;
            this.btnTeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeo.Image = ((System.Drawing.Image)(resources.GetObject("btnTeo.Image")));
            this.btnTeo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeo.Location = new System.Drawing.Point(0, 262);
            this.btnTeo.Name = "btnTeo";
            this.btnTeo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTeo.Size = new System.Drawing.Size(220, 60);
            this.btnTeo.TabIndex = 7;
            this.btnTeo.Text = " Teoremas";
            this.btnTeo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeo.UseVisualStyleBackColor = true;
            this.btnTeo.Click += new System.EventHandler(this.btnTeo_Click);
            // 
            // panelSubMenuRes
            // 
            this.panelSubMenuRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.panelSubMenuRes.Controls.Add(this.btnCondRes);
            this.panelSubMenuRes.Controls.Add(this.btnTempRes);
            this.panelSubMenuRes.Controls.Add(this.btnAssoRes);
            this.panelSubMenuRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuRes.Location = new System.Drawing.Point(0, 140);
            this.panelSubMenuRes.Name = "panelSubMenuRes";
            this.panelSubMenuRes.Size = new System.Drawing.Size(220, 122);
            this.panelSubMenuRes.TabIndex = 6;
            // 
            // btnCondRes
            // 
            this.btnCondRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCondRes.FlatAppearance.BorderSize = 0;
            this.btnCondRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCondRes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondRes.Location = new System.Drawing.Point(0, 80);
            this.btnCondRes.Name = "btnCondRes";
            this.btnCondRes.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnCondRes.Size = new System.Drawing.Size(220, 27);
            this.btnCondRes.TabIndex = 2;
            this.btnCondRes.Text = "Código de Cores";
            this.btnCondRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondRes.UseVisualStyleBackColor = true;
            this.btnCondRes.Click += new System.EventHandler(this.btnCondRes_Click);
            // 
            // btnTempRes
            // 
            this.btnTempRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTempRes.FlatAppearance.BorderSize = 0;
            this.btnTempRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempRes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempRes.Location = new System.Drawing.Point(0, 40);
            this.btnTempRes.Name = "btnTempRes";
            this.btnTempRes.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnTempRes.Size = new System.Drawing.Size(220, 40);
            this.btnTempRes.TabIndex = 1;
            this.btnTempRes.Text = "Coeficiente de Temperatura";
            this.btnTempRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempRes.UseVisualStyleBackColor = true;
            this.btnTempRes.Click += new System.EventHandler(this.btnTempRes_Click);
            // 
            // btnAssoRes
            // 
            this.btnAssoRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssoRes.FlatAppearance.BorderSize = 0;
            this.btnAssoRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssoRes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssoRes.Location = new System.Drawing.Point(0, 0);
            this.btnAssoRes.Name = "btnAssoRes";
            this.btnAssoRes.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAssoRes.Size = new System.Drawing.Size(220, 40);
            this.btnAssoRes.TabIndex = 0;
            this.btnAssoRes.Text = "Associação Resistências";
            this.btnAssoRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssoRes.UseVisualStyleBackColor = true;
            this.btnAssoRes.Click += new System.EventHandler(this.btnAssoRes_Click);
            // 
            // btnRes
            // 
            this.btnRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRes.FlatAppearance.BorderSize = 0;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRes.Location = new System.Drawing.Point(0, 80);
            this.btnRes.Name = "btnRes";
            this.btnRes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRes.Size = new System.Drawing.Size(220, 60);
            this.btnRes.TabIndex = 1;
            this.btnRes.Text = "     Resistências";
            this.btnRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "EletroMath";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.botaoMinimizar);
            this.panelTitleBar.Controls.Add(this.botaoMaximizar);
            this.panelTitleBar.Controls.Add(this.botaoFechar);
            this.panelTitleBar.Controls.Add(this.btnLang);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1059, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // botaoMinimizar
            // 
            this.botaoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoMinimizar.FlatAppearance.BorderSize = 0;
            this.botaoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMinimizar.ForeColor = System.Drawing.Color.White;
            this.botaoMinimizar.Location = new System.Drawing.Point(953, 0);
            this.botaoMinimizar.Name = "botaoMinimizar";
            this.botaoMinimizar.Size = new System.Drawing.Size(34, 30);
            this.botaoMinimizar.TabIndex = 4;
            this.botaoMinimizar.Text = "_";
            this.botaoMinimizar.UseVisualStyleBackColor = true;
            this.botaoMinimizar.Click += new System.EventHandler(this.botaoMinimizar_Click);
            // 
            // botaoMaximizar
            // 
            this.botaoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoMaximizar.FlatAppearance.BorderSize = 0;
            this.botaoMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMaximizar.ForeColor = System.Drawing.Color.White;
            this.botaoMaximizar.Location = new System.Drawing.Point(993, 0);
            this.botaoMaximizar.Name = "botaoMaximizar";
            this.botaoMaximizar.Size = new System.Drawing.Size(30, 30);
            this.botaoMaximizar.TabIndex = 3;
            this.botaoMaximizar.Text = "O";
            this.botaoMaximizar.UseVisualStyleBackColor = true;
            this.botaoMaximizar.Click += new System.EventHandler(this.botaoMaximizar_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoFechar.FlatAppearance.BorderSize = 0;
            this.botaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFechar.ForeColor = System.Drawing.Color.White;
            this.botaoFechar.Location = new System.Drawing.Point(1029, 0);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(30, 30);
            this.botaoFechar.TabIndex = 1;
            this.botaoFechar.Text = "X";
            this.botaoFechar.UseVisualStyleBackColor = true;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // btnLang
            // 
            this.btnLang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLang.ForeColor = System.Drawing.Color.White;
            this.btnLang.Location = new System.Drawing.Point(953, 37);
            this.btnLang.Margin = new System.Windows.Forms.Padding(2);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(106, 43);
            this.btnLang.TabIndex = 2;
            this.btnLang.Text = "Lang";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(501, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.MinimumSize = new System.Drawing.Size(900, 366);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1059, 629);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 709);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenuTeo.ResumeLayout(false);
            this.panelSubMenuRes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Panel panelSubMenuRes;
        private System.Windows.Forms.Button btnCondRes;
        private System.Windows.Forms.Button btnTempRes;
        private System.Windows.Forms.Button btnAssoRes;
        private System.Windows.Forms.Button btnTeo;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnBob;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Panel panelSubMenuTeo;
        private System.Windows.Forms.Button btnSMteo3;
        private System.Windows.Forms.Button btnSMteo2;
        private System.Windows.Forms.Button btnSMteo1;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button botaoMinimizar;
        private System.Windows.Forms.Button botaoMaximizar;
    }
}

