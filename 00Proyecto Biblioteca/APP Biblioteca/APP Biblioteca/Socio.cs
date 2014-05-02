using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace APP_Biblioteca
{
    public class Socio //Estableciendo valores
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Telefono_Casa { get; set; }
        public String Telefono_Cell { get; set; }
        public String Direccion { get; set; }
        public String Correo { get; set; }
        
        public Socio() { }

        //Constructor
        public Socio(String xCedula, String xNombre, String xTelefono_Casa, String xTelefono_Cell, String xDireccion, String xCorreo)
        {
            this.Cedula = xCedula;
            this.Nombre = xNombre;
            this.Telefono_Casa = xTelefono_Casa;
            this.Telefono_Cell = xTelefono_Cell;
            this.Direccion = xDireccion;
            this.Correo = xCorreo;
        }
    }
}
