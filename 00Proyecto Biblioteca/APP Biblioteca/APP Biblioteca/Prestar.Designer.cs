namespace APP_Biblioteca
{
    partial class Prestar
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
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listSocios = new System.Windows.Forms.ListBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LawnGreen;
            this.label15.Location = new System.Drawing.Point(221, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 42);
            this.label15.TabIndex = 38;
            this.label15.Text = "Prestar libro?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Libro:";
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(122, 222);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(192, 31);
            this.txtInicio.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(344, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fin:";
            // 
            // txtFin
            // 
            this.txtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFin.Location = new System.Drawing.Point(417, 222);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(192, 31);
            this.txtFin.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 40);
            this.button1.TabIndex = 45;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSocios
            // 
            this.listSocios.FormattingEnabled = true;
            this.listSocios.Location = new System.Drawing.Point(122, 162);
            this.listSocios.Name = "listSocios";
            this.listSocios.Size = new System.Drawing.Size(487, 43);
            this.listSocios.TabIndex = 46;
            // 
            // cmbLibro
            // 
            this.cmbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(122, 115);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(487, 33);
            this.cmbLibro.TabIndex = 47;
            this.cmbLibro.Text = "Busque sus Libros para prestar";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Location = new System.Drawing.Point(439, 424);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 57);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Location = new System.Drawing.Point(82, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 57);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Prestar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Prestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(685, 554);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.listSocios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "Prestar";
            this.Text = "Prestar";
            this.Load += new System.EventHandler(this.Prestar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listSocios;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
    }
}