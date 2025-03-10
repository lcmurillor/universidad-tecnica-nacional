using System;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsConexion
    {
        //String de coneccion para nuestro SQL SERVER....
        //public String coneccion = "Data Source = localhost;" +
        // "Initial Catalog=dbExpediente;" +
        // "User id=UserExpediente;" +
        // "Password=12345;";
        public String conexion = "Data Source=LAPTOP-0E3CP65E;Initial Catalog=DbExpediente;Integrated Security=True";
        //public String coneccion = "Server=localhost, Authentication=Windows Authentication, Database= DbExpediente";
        //public String coneccion = "Data Source=LEONY-PC;Initial Catalog=NORTHWND;Integrated Security=True";


        public Boolean Conectando()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(this.conexion);//Probamos que ahy coneccion.
                cnn.Close();//Cerramos la coneccion
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
