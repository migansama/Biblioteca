using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Biblioteca
{
    public class Editora //Estableciendo valores
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Pais { get; set; }

        public Editora() { }

        //Constructor
        public Editora(int xID, String xNombre, String xPais)
        {
            this.ID = xID;
            this.Nombre = xNombre;
            this.Pais = xPais;
        }
    }
}
