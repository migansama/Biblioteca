using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //libreria usada para la conexion a SQL

namespace APP_Biblioteca
{
   public class DBConex
    {
        public static SqlConnection Conexion() //estableciendo conexion con la DB 
        {
            SqlConnection Conex = new SqlConnection(@"Data source = MIGUELANTONIO\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security = True"); 
        Conex.Open();
        
        return Conex;
        }
    }
}
