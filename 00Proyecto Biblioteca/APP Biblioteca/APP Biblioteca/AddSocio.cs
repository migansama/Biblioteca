using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace APP_Biblioteca
{
    public partial class AddSocio : Form
    {
        public AddSocio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestar pPrestar = new Prestar();
            pPrestar.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Socio xSocio = new Socio();
            xSocio.Nombre = txtNombre.Text;
            xSocio.Cedula = txtCedula.Text;
            xSocio.Telefono_Casa = txtCasa.Text;
            xSocio.Telefono_Cell = txtCell.Text;
            xSocio.Correo = txtCorreo.Text;
            xSocio.Direccion = richDireccion.Text;

            int respuesta = DataBaseRegister.AgregarSocio(xSocio);

            if (respuesta > 0)
            {
                MessageBox.Show("Socio Guardado Exitosamente", "Guardando ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Hubo problemas, Verifique nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AddSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
