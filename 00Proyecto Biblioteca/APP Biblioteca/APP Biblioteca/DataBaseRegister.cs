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
    public class DataBaseRegister
    {
        //Funciones para guardar los datos del libro como un string
        //Agregando datos de libro
        public static int Agregarlibro(Libro xLibro)
        {
            int retorno = 0;
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Libro (Titulo, Edicion, Idioma, Genero, ISBN, No_Pags, Volumen, Ubicacion , Formato, Costo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                xLibro.Titulo, xLibro.Edicion, xLibro.Idioma, xLibro.Genero, xLibro.ISBN, xLibro.No_Pags, xLibro.Tomo, xLibro.Ubicacion, xLibro.Formato, xLibro.Costo), Conex);
                retorno = Comando.ExecuteNonQuery();   
            }
            return retorno;
        }
        //Agregando datos de Autor
        public static int AgregarAutor(Autor xAutor)
        {
            int retorno = 0;
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Autor (Nombre , Nacionalidad) values ('{0}','{1}')",
                xAutor.Nombre, xAutor.Nacionalidad), Conex);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        //Agregando datos de Editora
        public static int AgregarEditora(Editora xEditora)
        {
            int retorno = 0;
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Casa_Editora (Nombre , Pais) values ('{0}','{1}')",
                xEditora.Nombre, xEditora.Pais), Conex);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        //Agregando datos de Socio
        public static int AgregarSocio(Socio xSocio)
        {
            int retorno = 0;
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Socio (Cedula, Nombre, TelefonoCasa, TelefonoCell, Direccion, Correo) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
               xSocio.Cedula, xSocio.Nombre, xSocio.Telefono_Casa, xSocio.Telefono_Cell, xSocio.Direccion, xSocio.Correo), Conex);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        //Agregando prestamo
        public static int Prestarlibro(Libro xLibro, Socio xSocio, Prestamo xPrestamo)
        {
            int retorno = 0;
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Prestamo (FechaInicio, FechaFin, IDSocio, IDlibro) values ('{0}','{1}','{2}','{3}')",
                xPrestamo.Fecha_Inicio, xPrestamo.Fecha_Fin, xSocio.Cedula, xLibro.ID), Conex);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
        //Lista para consultar los libros
        public static List<Libro> Consultar(String pTitulo)
        {
            List<Libro> Lista = new List<Libro>(); //Creando Lista
            //Proceso de Conexion con la DataB
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format(
                "Select ID, Titulo, Edicion, Idioma, Genero, ISBN, No_Pags, Volumen, Ubicacion, Formato, Costo, Estado from Libro where Titulo like '%{0}%'",pTitulo), Conex);
                SqlDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    Libro pLibro = new Libro(); //Crea nueva instancia

                    pLibro.ID = lector.GetInt64(0);
                    pLibro.Titulo = lector.GetString(1);
                    pLibro.Edicion = lector.GetString(2);
                    pLibro.Idioma = lector.GetString(3);
                    pLibro.Genero = lector.GetString(4);
                    pLibro.ISBN = lector.GetString(5);
                    //Convirtiendo de int a String
                    int p = lector.GetInt32(6);
                    string paginas = Convert.ToString(p);
                    pLibro.No_Pags = paginas;
                    int v = lector.GetInt32(7);
                    string volumen = Convert.ToString(v);
                    pLibro.Tomo = volumen;
                    pLibro.Ubicacion = lector.GetString(8);
                    pLibro.Formato = lector.GetString(9);
                    int pv = lector.GetInt32(10);
                    string valor = Convert.ToString(pv);
                    pLibro.Costo = valor;
                    Lista.Add(pLibro); //Agregando valores a la lista
                }
                Conex.Close(); //Cerrando la conexion
                return Lista;
            }
        }
        //Poblando Boxes
        public static List<Pais> ObtenerPaises()
        {
            List<Pais> Lista = new List<Pais>(); //Creando Lista
            //Proceso de Conexion con la DataB
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand("select ID, Name from Pais", Conex);
                SqlDataReader lector = Comando.ExecuteReader();

                while (lector.Read()) //Mientras se lea algo, ejecutar
                {
                    Pais pPais = new Pais(); //Crea nueva instancia
                    pPais.ID = lector.GetInt32(0);
                    pPais.Name = lector.GetString(1);
                    Lista.Add(pPais); //Agregando Pais a el combobox
                }
                Conex.Close();
                return Lista;
            }
        }
    }
}
