using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppWeb3.Clases
{
    public class ClsConexion {
        //String de coneccion para nuestro SQL SERVER....
        //public String coneccion = "Data Source = localhost;" +
        // "Initial Catalog=dbExpediente;" +
        /// "User id=tiexpediente;" +
        // "Password=123456;"; //public String coneccion = "Server=LEONY-PC, Authentication=Windows Authentication, Database= NORTHWND";
        public String conexion = "Data Source=LEONY-PC;Initial Catalog=NORTHWND;Integrated Security=True"; 

        public bool Conectado ()
        {
            try {
                SqlConnection cxn = new SqlConnection(this.conexion);
                cxn.Close();
                return true;
            } catch {
                return false;
            }
        }
    }
}