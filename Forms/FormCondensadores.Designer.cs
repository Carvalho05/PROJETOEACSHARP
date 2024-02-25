namespace EletroMath.Forms
{
    partial class FormCondensadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondensadores));
            this.labelAssoRes = new System.Windows.Forms.Label();
            this.btnSer = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.labelCapacitancia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxCapacitância = new System.Windows.Forms.ComboBox();
            this.labelResultado1 = new System.Windows.Forms.Label();
            this.labelResultado2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBoxUnidades = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBoxUnidades2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAssoRes
            // 
            this.labelAssoRes.AutoSize = true;
            this.labelAssoRes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssoRes.Location = new System.Drawing.Point(1245, 57);
            this.labelAssoRes.Name = "labelAssoRes";
            this.labelAssoRes.Size = new System.Drawing.Size(295, 28);
            this.labelAssoRes.TabIndex = 19;
            this.labelAssoRes.Text = "Associação de Condensadores";
            // 
            // btnSer
            // 
            this.btnSer.FlatAppearance.BorderSize = 0;
            this.btnSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer.Location = new System.Drawing.Point(1429, 605);
            this.btnSer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(179, 79);
            this.btnSer.TabIndex = 18;
            this.btnSer.Text = "Série";
            this.btnSer.UseVisualStyleBackColor = true;
            this.btnSer.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // btnPar
            // 
            this.btnPar.FlatAppearance.BorderSize = 0;
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPar.Location = new System.Drawing.Point(1163, 605);
            this.btnPar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(179, 79);
            this.btnPar.TabIndex = 17;
            this.btnPar.Text = "Paralelo";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnRem
            // 
            this.btnRem.Image = ((System.Drawing.Image)(resources.GetObject("btnRem.Image")));
            this.btnRem.Location = new System.Drawing.Point(1296, 142);
            this.btnRem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(39, 46);
            this.btnRem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRem.TabIndex = 16;
            this.btnRem.TabStop = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1385, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 46);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelCapacitancia
            // 
            this.labelCapacitancia.AutoSize = true;
            this.labelCapacitancia.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacitancia.Location = new System.Drawing.Point(285, 57);
            this.labelCapacitancia.Name = "labelCapacitancia";
            this.labelCapacitancia.Size = new System.Drawing.Size(234, 28);
            this.labelCapacitancia.TabIndex = 23;
            this.labelCapacitancia.Text = "Cálculo da Capacitância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(45, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Permitividade do Material Dialétrico entre as Placas (em Farads por Metro, F/m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(45, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Área de Sobreposição das Placas (em Metros Quadrados, m²)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(45, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Distância entre as Placas (em Metros, m)";
            // 
            // btnCal
            // 
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(102, 441);
            this.btnCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(179, 79);
            this.btnCal.TabIndex = 27;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(388, 441);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 79);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 314);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 30;
            // 
            // comboBoxCapacitância
            // 
            this.comboBoxCapacitância.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCapacitância.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCapacitância.FormattingEnabled = true;
            this.comboBoxCapacitância.Location = new System.Drawing.Point(697, 196);
            this.comboBoxCapacitância.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCapacitância.Name = "comboBoxCapacitância";
            this.comboBoxCapacitância.Size = new System.Drawing.Size(236, 24);
            this.comboBoxCapacitância.TabIndex = 31;
            // 
            // labelResultado1
            // 
            this.labelResultado1.AutoSize = true;
            this.labelResultado1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelResultado1.ForeColor = System.Drawing.Color.Red;
            this.labelResultado1.Location = new System.Drawing.Point(110, 568);
            this.labelResultado1.Name = "labelResultado1";
            this.labelResultado1.Size = new System.Drawing.Size(164, 29);
            this.labelResultado1.TabIndex = 32;
            this.labelResultado1.Text = "O Resultado é: ";
            // 
            // labelResultado2
            // 
            this.labelResultado2.AutoSize = true;
            this.labelResultado2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelResultado2.ForeColor = System.Drawing.Color.Red;
            this.labelResultado2.Location = new System.Drawing.Point(1175, 538);
            this.labelResultado2.Name = "labelResultado2";
            this.labelResultado2.Size = new System.Drawing.Size(164, 29);
            this.labelResultado2.TabIndex = 33;
            this.labelResultado2.Text = "O Resultado é: ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.textBox3.Location = new System.Drawing.Point(280, 568);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 29);
            this.textBox3.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.textBox5.Location = new System.Drawing.Point(1345, 538);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(301, 29);
            this.textBox5.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(0, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 14);
            this.label4.Size = new System.Drawing.Size(124, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Condensador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 18);
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Condensador 1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1163, 210);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 305);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.textBox7);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxUnidades);
            this.flowLayoutPanel2.Controls.Add(this.textBox8);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxUnidades2);
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1332, 210);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(233, 305);
            this.flowLayoutPanel2.TabIndex = 43;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 4);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(98, 27);
            this.textBox7.TabIndex = 15;
            // 
            // comboBoxUnidades
            // 
            this.comboBoxUnidades.FormattingEnabled = true;
            this.comboBoxUnidades.Location = new System.Drawing.Point(107, 3);
            this.comboBoxUnidades.Name = "comboBoxUnidades";
            this.comboBoxUnidades.Size = new System.Drawing.Size(121, 27);
            this.comboBoxUnidades.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(3, 39);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(98, 27);
            this.textBox8.TabIndex = 17;
            // 
            // comboBoxUnidades2
            // 
            this.comboBoxUnidades2.FormattingEnabled = true;
            this.comboBoxUnidades2.Location = new System.Drawing.Point(107, 38);
            this.comboBoxUnidades2.Name = "comboBoxUnidades2";
            this.comboBoxUnidades2.Size = new System.Drawing.Size(121, 27);
            this.comboBoxUnidades2.TabIndex = 18;
            // 
            // FormCondensadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 1004);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelResultado2);
            this.Controls.Add(this.labelResultado1);
            this.Controls.Add(this.comboBoxCapacitância);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCapacitancia);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelAssoRes);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCondensadores";
            this.Text = "Condensadores";
            this.Load += new System.EventHandler(this.FormCondensadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssoRes;
        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.PictureBox btnRem;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label labelCapacitancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxCapacitância;
        private System.Windows.Forms.Label labelResultado1;
        private System.Windows.Forms.Label labelResultado2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBoxUnidades;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBoxUnidades2;
    }
}