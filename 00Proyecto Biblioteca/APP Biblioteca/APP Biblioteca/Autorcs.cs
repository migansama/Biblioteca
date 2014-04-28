using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Biblioteca
{
    public class Autor //Estableciendo valores
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Nacionalidad { get; set; }
        
        public Autor() { }

        //Constructor
        public Autor(int xID, String xNombre, String xNacionalidad)
        {
            this.ID = xID;
            this.Nombre = xNombre;
            this.Nacionalidad = xNacionalidad;
        }
    }
}
