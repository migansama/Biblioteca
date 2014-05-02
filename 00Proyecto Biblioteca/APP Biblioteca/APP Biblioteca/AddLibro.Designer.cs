namespace APP_Biblioteca
{
    partial class AddLibro
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtPags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTomo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.cmbEdicion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(104, 107);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(444, 30);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Género:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(791, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edición:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(298, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Idioma:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(104, 150);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(213, 30);
            this.txtISBN.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Location = new System.Drawing.Point(190, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(197, 98);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Location = new System.Drawing.Point(644, 401);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(197, 96);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtPags
            // 
            this.txtPags.Location = new System.Drawing.Point(127, 285);
            this.txtPags.Name = "txtPags";
            this.txtPags.Size = new System.Drawing.Size(151, 30);
            this.txtPags.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "No. Págs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(554, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(625, 107);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(394, 30);
            this.txtAutor.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(488, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nacionalidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Casa Editora:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(156, 194);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(392, 30);
            this.txtEditora.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(554, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "País:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(554, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ubicación:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(664, 239);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(121, 30);
            this.txtUbicacion.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(284, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Formato:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(645, 285);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 30);
            this.txtCosto.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(557, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "Costo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(323, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Tomo:";
            // 
            // txtTomo
            // 
            this.txtTomo.Location = new System.Drawing.Point(398, 150);
            this.txtTomo.Name = "txtTomo";
            this.txtTomo.Size = new System.Drawing.Size(84, 30);
            this.txtTomo.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LawnGreen;
            this.label15.Location = new System.Drawing.Point(375, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 42);
            this.label15.TabIndex = 36;
            this.label15.Text = "Agregar Libro";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(625, 197);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(394, 33);
            this.cmbPais.TabIndex = 37;
            this.cmbPais.Text = "Pais de la Casa Editora";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(791, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 39;
            this.label16.Text = "Moneda:";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(888, 285);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(131, 33);
            this.cmbMoneda.TabIndex = 40;
            this.cmbMoneda.Text = "Moneda";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(625, 147);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(394, 33);
            this.cmbNacionalidad.TabIndex = 41;
            this.cmbNacionalidad.Text = "Nacionalidad del Autor";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Contabilidad",
            "Informática",
            "Matemáticas",
            "Pedagogía",
            "Economía"});
            this.cmbGenero.Location = new System.Drawing.Point(118, 239);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 33);
            this.cmbGenero.TabIndex = 42;
            this.cmbGenero.Text = "Tema";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Francés"});
            this.cmbIdioma.Location = new System.Drawing.Point(382, 239);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(166, 33);
            this.cmbIdioma.TabIndex = 43;
            this.cmbIdioma.Text = "Idioma";
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "Físico",
            "Digital",
            "CD",
            "Revista"});
            this.cmbFormato.Location = new System.Drawing.Point(382, 282);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(166, 33);
            this.cmbFormato.TabIndex = 44;
            this.cmbFormato.Text = "Formato";
            // 
            // cmbEdicion
            // 
            this.cmbEdicion.FormattingEnabled = true;
            this.cmbEdicion.Items.AddRange(new object[] {
            "1ra",
            "2da",
            "3ra",
            "4ta",
            "5ta",
            "6ta",
            "7ma",
            "8va",
            "9na",
            "10ma",
            "11va",
            "12va",
            "13va",
            "14va",
            "15va"});
            this.cmbEdicion.Location = new System.Drawing.Point(888, 239);
            this.cmbEdicion.Name = "cmbEdicion";
            this.cmbEdicion.Size = new System.Drawing.Size(131, 33);
            this.cmbEdicion.TabIndex = 45;
            this.cmbEdicion.Text = "# de Edición";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1025, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1076, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEdicion);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTomo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPags);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddLibro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Libro";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.AddLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtPags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTomo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.ComboBox cmbEdicion;
        private System.Windows.Forms.Button button1;
    }
}

