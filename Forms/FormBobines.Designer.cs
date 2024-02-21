namespace EletroMath.Forms
{
    partial class FormBobines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBobines));
            this.labelAssoRes = new System.Windows.Forms.Label();
            this.btnSer = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAssoRes
            // 
            this.labelAssoRes.AutoSize = true;
            this.labelAssoRes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssoRes.Location = new System.Drawing.Point(311, 11);
            this.labelAssoRes.Name = "labelAssoRes";
            this.labelAssoRes.Size = new System.Drawing.Size(145, 21);
            this.labelAssoRes.TabIndex = 19;
            this.labelAssoRes.Text = "Associação Bobines";
            // 
            // btnSer
            // 
            this.btnSer.FlatAppearance.BorderSize = 0;
            this.btnSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSer.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSer.Location = new System.Drawing.Point(420, 485);
            this.btnSer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(179, 79);
            this.btnSer.TabIndex = 18;
            this.btnSer.Text = "Série";
            this.btnSer.UseVisualStyleBackColor = true;
            // 
            // btnPar
            // 
            this.btnPar.FlatAppearance.BorderSize = 0;
            this.btnPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPar.Location = new System.Drawing.Point(199, 485);
            this.btnPar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(179, 79);
            this.btnPar.TabIndex = 17;
            this.btnPar.Text = "Paralelo";
            this.btnPar.UseVisualStyleBackColor = true;
            // 
            // btnRem
            // 
            this.btnRem.Image = ((System.Drawing.Image)(resources.GetObject("btnRem.Image")));
            this.btnRem.Location = new System.Drawing.Point(354, 91);
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
            this.btnAdd.Location = new System.Drawing.Point(427, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 46);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 212);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 163);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resistência 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resistência 1";
            // 
            // FormBobines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 623);
            this.Controls.Add(this.labelAssoRes);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBobines";
            this.Text = "Bobines";
            this.Load += new System.EventHandler(this.FormBobines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssoRes;
        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.PictureBox btnRem;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}