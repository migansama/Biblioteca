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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TablaDatos.DataSource = DataBaseRegister.Consultar(txtTitulo.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master mlibro = new Master();
            mlibro.Show();
        }
    }
}
