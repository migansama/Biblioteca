using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Biblioteca
{
    public class Prestamo //Estableciendo valores
    {
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public Prestamo() { }

        //Constructor
        public Prestamo(DateTime xFecha_Inicio, DateTime xFecha_Fin)
        {
            this.Fecha_Inicio= xFecha_Inicio;
            this.Fecha_Fin = xFecha_Fin;
        }
    }
}
