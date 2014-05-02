using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Biblioteca
{
    public partial class Prestar : Form
    {
        public Prestar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSocio sSocio = new AddSocio();
            sSocio.Show();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master mlibro = new Master();
            mlibro.Show();
        }

        private void Prestar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            Socio socio = new Socio();
            Prestamo prestamo = new Prestamo();

            libro.Titulo = cmbLibro.SelectedText;
            //socio.Nombre = listSocios.
            prestamo.Fecha_Inicio = txtInicio.Text;
            prestamo.Fecha_Fin = txtFin.Text;           


            int respuesta = DataBaseRegister.Prestarlibro(libro,socio,prestamo);

            if (respuesta > 0)
            {
                MessageBox.Show("Socio Guardado Exitosamente", "Guardando ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo problemas, Verifique nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
