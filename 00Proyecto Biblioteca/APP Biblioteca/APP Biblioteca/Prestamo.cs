using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Biblioteca
{
    public class Prestamo //Estableciendo valores
    {
        public String Fecha_Inicio { get; set; }
        public String Fecha_Fin { get; set; }
        public Prestamo() { }

        //Constructor
        public Prestamo(String xFecha_Inicio, String xFecha_Fin)
        {
            this.Fecha_Inicio= xFecha_Inicio;
            this.Fecha_Fin = xFecha_Fin;
        }
    }
}
