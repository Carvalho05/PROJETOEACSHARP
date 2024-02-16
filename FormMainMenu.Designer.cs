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
            this.btnTeo = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSin);
            this.panelMenu.Controls.Add(this.btnBob);
            this.panelMenu.Controls.Add(this.btnCon);
            this.panelMenu.Controls.Add(this.btnTeo);
            this.panelMenu.Controls.Add(this.btnRes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
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
            this.btnSin.Location = new System.Drawing.Point(0, 320);
            this.btnSin.Name = "btnSin";
            this.btnSin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSin.Size = new System.Drawing.Size(220, 60);
            this.btnSin.TabIndex = 5;
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
            this.btnBob.Location = new System.Drawing.Point(0, 260);
            this.btnBob.Name = "btnBob";
            this.btnBob.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBob.Size = new System.Drawing.Size(220, 60);
            this.btnBob.TabIndex = 4;
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
            this.btnCon.Location = new System.Drawing.Point(0, 200);
            this.btnCon.Name = "btnCon";
            this.btnCon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCon.Size = new System.Drawing.Size(220, 60);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "Condensadores";
            this.btnCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
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
            this.btnTeo.Location = new System.Drawing.Point(0, 140);
            this.btnTeo.Name = "btnTeo";
            this.btnTeo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTeo.Size = new System.Drawing.Size(220, 60);
            this.btnTeo.TabIndex = 2;
            this.btnTeo.Text = " Teoremas";
            this.btnTeo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeo.UseVisualStyleBackColor = true;
            this.btnTeo.Click += new System.EventHandler(this.btnTeo_Click);
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
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(650, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(299, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(650, 501);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 581);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnTeo;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnBob;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

