﻿using System;
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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLibro bAddlibro = new AddLibro();
            bAddlibro.Show();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta bConsulta = new Consulta();
            bConsulta.Show();
        }

        private void Prestar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestar bPrestar = new Prestar();
            bPrestar.Show();
        }
    }
}
