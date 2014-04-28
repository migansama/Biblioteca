﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlServerCe;
using System.Data.SqlClient; //libreria usada para la conexion a SQL

namespace APP_Biblioteca
{
    public partial class AddLibro : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = ");

        public AddLibro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Titulo = txtTitulo.Text;
            libro.Edicion = txtEdicion.Text;
            libro.Idioma = txtIdioma.Text;
            libro.Genero = txtGenero.Text;
            libro.ISBN = txtISBN.Text;
            libro.No_Pags = txtPags.Text;
            libro.Tomo = txtTomo.Text;
            libro.Ubicacion = txtUbicacion.Text;
            libro.Formato = txtFormato.Text;
            libro.Costo = txtCosto.Text;

            Autor Autor = new Autor();
            Autor.Nombre = txtAutor.Text;
            Autor.Nacionalidad = txtNacionalidad.Text;

            Editora Editora = new Editora();
            Editora.Nombre = txtEditora.Text;
            Editora.Pais = txtPais.Text;

            int respuesta = DataBaseRegister.Agregarlibro(libro);
            int respuesta1 = DataBaseRegister.AgregarAutor(Autor);
            int respuesta2 = DataBaseRegister.AgregarEditora(Editora);
          

            if (respuesta > 0 && respuesta1 > 0 && respuesta2 > 0)
            {
                MessageBox.Show("Libro Guardado Exitosamente", "Guardando ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Hubo problemas, Verifique nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master mlibro = new Master();
            mlibro.Show();
        }

        private void AddLibro_Load(object sender, EventArgs e)
        {


        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
