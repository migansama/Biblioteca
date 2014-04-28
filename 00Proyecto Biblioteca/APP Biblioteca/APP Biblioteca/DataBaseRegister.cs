using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APP_Biblioteca
{
    public class DataBaseRegister
    {
        //Funciones para guardar los datos del libro como un string

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

        public static List<Libro> Consultar(String pTitulo)
        {
            List<Libro> Lista = new List<Libro>();
            using (SqlConnection Conex = DBConex.Conexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format(
                "Select ID, Titulo, Edicion, Idioma, Genero, ISBN, No_Pags, Volumen, Ubicacion , Formato, Costo from Libro where Titulo like '%{0}%'", pTitulo), Conex);

                SqlDataReader lector = Comando.ExecuteReader();

                while (lector.Read())
                {
                    Libro pLibro = new Libro();
                    pLibro.ID = lector.GetInt64(0);
                    pLibro.Titulo = lector.GetString(1);
                    pLibro.Edicion = lector.GetString(2);
                    pLibro.Idioma = lector.GetString(3);
                    pLibro.Genero = lector.GetString(4);
                    pLibro.ISBN = lector.GetString(5);
                    //string Paginas = pLibro.No_Pags.ToString();
                    //Paginas = lector.GetString(6);
                    //string Volumen = pLibro.Tomo.ToString();
                    //Volumen = lector.GetString(7);
                    pLibro.Ubicacion = lector.GetString(8);
                    pLibro.Formato = lector.GetString(9);
                    //string Valor = pLibro.Costo.ToString();
                    //Valor = lector.GetString(10);
         
                    Lista.Add(pLibro);

                }
                Conex.Close();
                return Lista;
            }
        }
    }
}
