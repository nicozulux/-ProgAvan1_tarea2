
namespace AlquilerV
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmicrobuses = new System.Windows.Forms.Button();
            this.btnfurgonetas = new System.Windows.Forms.Button();
            this.btncoche = new System.Windows.Forms.Button();
            this.btncamiones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Resultado = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnvolver = new System.Windows.Forms.Button();
            this.lplaca = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.matricula1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquiler de Vehiculos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlquilerV.Properties.Resources._170667a;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnmicrobuses
            // 
            this.btnmicrobuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmicrobuses.Location = new System.Drawing.Point(223, 263);
            this.btnmicrobuses.Name = "btnmicrobuses";
            this.btnmicrobuses.Size = new System.Drawing.Size(129, 65);
            this.btnmicrobuses.TabIndex = 2;
            this.btnmicrobuses.Text = "Microbuses";
            this.btnmicrobuses.UseVisualStyleBackColor = true;
            this.btnmicrobuses.Click += new System.EventHandler(this.btnmicrobuses_Click);
            // 
            // btnfurgonetas
            // 
            this.btnfurgonetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfurgonetas.Location = new System.Drawing.Point(616, 263);
            this.btnfurgonetas.Name = "btnfurgonetas";
            this.btnfurgonetas.Size = new System.Drawing.Size(129, 62);
            this.btnfurgonetas.TabIndex = 3;
            this.btnfurgonetas.Text = "Furgonetas";
            this.btnfurgonetas.UseVisualStyleBackColor = true;
            this.btnfurgonetas.Click += new System.EventHandler(this.btnfurgonetas_Click);
            // 
            // btncoche
            // 
            this.btncoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncoche.Location = new System.Drawing.Point(66, 263);
            this.btncoche.Name = "btncoche";
            this.btncoche.Size = new System.Drawing.Size(129, 65);
            this.btncoche.TabIndex = 4;
            this.btncoche.Text = "Coche";
            this.btncoche.UseVisualStyleBackColor = true;
            this.btncoche.Click += new System.EventHandler(this.btncoche_Click);
            // 
            // btncamiones
            // 
            this.btncamiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncamiones.Location = new System.Drawing.Point(454, 263);
            this.btncamiones.Name = "btncamiones";
            this.btncamiones.Size = new System.Drawing.Size(129, 62);
            this.btncamiones.TabIndex = 5;
            this.btncamiones.Text = "Camiones";
            this.btncamiones.UseVisualStyleBackColor = true;
            this.btncamiones.Click += new System.EventHandler(this.btncamiones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dias a Cotizar";
            // 
            // Dias
            // 
            this.Dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dias.Location = new System.Drawing.Point(504, 154);
            this.Dias.Name = "Dias";
            this.Dias.Size = new System.Drawing.Size(100, 29);
            this.Dias.TabIndex = 7;
            this.Dias.TextChanged += new System.EventHandler(this.Dias_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vehiculos Particulares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehiculos de carga";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 382);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(76, 25);
            this.Resultado.TabIndex = 10;
            this.Resultado.Text = "label5";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(670, 426);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(116, 23);
            this.btnvolver.TabIndex = 16;
            this.btnvolver.Text = "Volver a Cotizar";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lplaca
            // 
            this.lplaca.AutoSize = true;
            this.lplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplaca.Location = new System.Drawing.Point(329, 110);
            this.lplaca.Name = "lplaca";
            this.lplaca.Size = new System.Drawing.Size(169, 25);
            this.lplaca.TabIndex = 17;
            this.lplaca.Text = "Placa Vehiculo";
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(504, 110);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(100, 20);
            this.matricula.TabIndex = 18;
            this.matricula.TextChanged += new System.EventHandler(this.matricula_TextChanged);
            // 
            // matricula1
            // 
            this.matricula1.AutoSize = true;
            this.matricula1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matricula1.Location = new System.Drawing.Point(17, 426);
            this.matricula1.Name = "matricula1";
            this.matricula1.Size = new System.Drawing.Size(51, 16);
            this.matricula1.TabIndex = 19;
            this.matricula1.Text = "label5";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.matricula1);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.lplaca);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncamiones);
            this.Controls.Add(this.btncoche);
            this.Controls.Add(this.btnfurgonetas);
            this.Controls.Add(this.btnmicrobuses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alquiler de Vehiculos";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmicrobuses;
        private System.Windows.Forms.Button btnfurgonetas;
        private System.Windows.Forms.Button btncoche;
        private System.Windows.Forms.Button btncamiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label matricula1;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label lplaca;
    }
}

