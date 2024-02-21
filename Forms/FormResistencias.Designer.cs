namespace EletroMath.Forms
{
    partial class FormResistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResistencias));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnRem = new System.Windows.Forms.PictureBox();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnSer = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAssoRes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resistência 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resistência 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 181);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 230);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 28);
            this.textBox2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(277, 109);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 46);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRem
            // 
            this.btnRem.Image = ((System.Drawing.Image)(resources.GetObject("btnRem.Image")));
            this.btnRem.Location = new System.Drawing.Point(204, 109);
            this.btnRem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(39, 46);
            this.btnRem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRem.TabIndex = 5;
            this.btnRem.TabStop = false;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnPar
            // 
            this.btnPar.FlatAppearance.BorderSize = 0;
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPar.Location = new System.Drawing.Point(49, 503);
            this.btnPar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(179, 79);
            this.btnPar.TabIndex = 6;
            this.btnPar.Text = "Paralelo";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // btnSer
            // 
            this.btnSer.FlatAppearance.BorderSize = 0;
            this.btnSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer.Location = new System.Drawing.Point(270, 503);
            this.btnSer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(179, 79);
            this.btnSer.TabIndex = 7;
            this.btnSer.Text = "Série";
            this.btnSer.UseVisualStyleBackColor = true;
            this.btnSer.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(659, 177);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 28);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resistência 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelAssoRes
            // 
            this.labelAssoRes.AutoSize = true;
            this.labelAssoRes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssoRes.Location = new System.Drawing.Point(161, 29);
            this.labelAssoRes.Name = "labelAssoRes";
            this.labelAssoRes.Size = new System.Drawing.Size(174, 21);
            this.labelAssoRes.TabIndex = 10;
            this.labelAssoRes.Text = "Associação Resistências";
            this.labelAssoRes.Click += new System.EventHandler(this.labelAssoRes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(633, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Condutância";
            // 
            // FormResistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAssoRes);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormResistencias";
            this.Text = "Resistências";
            this.Load += new System.EventHandler(this.FormResistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnRem;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAssoRes;
        private System.Windows.Forms.Label label5;
    }
}