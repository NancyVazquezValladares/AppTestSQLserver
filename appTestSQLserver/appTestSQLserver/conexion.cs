using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTestSQLServer
{
    internal class conexion
    {
        string server = "localhost\\SQLEXPRESS01";
        string user = "sa";
        string password = "fime23";
        string database = "NORTWND";
        string port = "1433";

        public static void Conectar()
        {
            string cadena = "Server="+server+";Database="+database+";User Id="+user+";Password="+password+";";
            SqlConnection cnx = new SqlConnection(cadena);
            cnx.Open();


        }

        public static void Desconectar()
        {
            cnx.Close();
             
        }


        public static DataTable Selecciona(string consulta)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(ds,"datos");
            Desconectar();
            return ds.Tables["datos"];
        }

        public static int EjecutaConsulta(string consulta)
        {
            Conectar();
            SqlCommand c = new SqlCommand(consulta, cnx);
            int filasAfectadas = c.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }
    }
}
