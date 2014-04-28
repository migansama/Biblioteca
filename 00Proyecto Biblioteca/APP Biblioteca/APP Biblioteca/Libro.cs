using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Biblioteca
{
    public class Libro //Estableciendo valores 
    {
        public Int64 ID { get; set; }
        public String Titulo { get; set; }
        public String Edicion { get; set; }
        public String Idioma { get; set; }
        public String Genero { get; set; }
        public String ISBN { get; set; }
        public String No_Pags { get; set; }
        public String Tomo { get; set; }
        public String Ubicacion { get; set; }
        public String Formato { get; set; }
        public String Costo { get; set; }
           
        public Libro() { }

        //Constructor
        public Libro(Int64 xID, String xTitulo, String xISBN, String xEdicion,
            String xGenero, String xIdioma, String xNo_Pags, String xTomo, String xUbicacion, String xFormato, String xCosto)
        {
            this.ID = xID;
            this.Titulo = xTitulo;
            this.Edicion = xEdicion;
            this.Idioma = xIdioma;
            this.Genero = xGenero;
            this.ISBN = xISBN;
            this.No_Pags = xNo_Pags;
            this.Tomo = xTomo;
            this.Ubicacion = xUbicacion;
            this.Formato = xFormato;
            this.Costo = xCosto;
   
        }
    }
}
