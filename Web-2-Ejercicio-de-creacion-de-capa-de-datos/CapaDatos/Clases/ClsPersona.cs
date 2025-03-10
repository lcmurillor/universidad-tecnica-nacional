using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Clases
{
    public class ClsPersona : ClsConexion
    {
        public String Cedula;
        public String Nombre;
        public String Ape1;
        public String Ape2;
        public String Email;
        ///Atributos
        ///
        public ClsPersona()
        {
            this.Cedula = "";
            this.Nombre = "";
            this.Ape1 = "";
            this.Ape2 = "";
            this.Email = "";
        }

        public ClsPersona(string pCedula, String pNombre, String pAp1, String pAp2, String pEamil)
        {
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Ape1 = pAp1;
            this.Ape2 = pAp2;
            this.Email = pEamil;
        }

        public String MantenimientoPersona(ClsPersona pClspersona, String pAccion)
        {
            String vResultado = "";
            if (this.Conectando())//Probamos si ahy coneccion...
            {
                try
                {

                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.conexion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "Stp_MantenimientoPersonas"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@pCedula", pClspersona.Cedula);
                    coneccion.Parameters.AddWithValue("@pNombre", pClspersona.Nombre);
                    coneccion.Parameters.AddWithValue("@pAp1", pClspersona.Ape1);
                    coneccion.Parameters.AddWithValue("@pAp2", pClspersona.Ape2);
                    coneccion.Parameters.AddWithValue("@pEmail", pClspersona.Email);
                    coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    vResultado = "Ejecutado con exito";


                }
                catch (Exception Ex)
                {
                    //MessageBox.Show(Ex.Message);
                    vResultado = Ex.Message;

                }
            }
            return vResultado;

        }

        private DataTable dataTable = new DataTable();
        public DataTable GetListaPersonas(ClsPersona pClspersona, String pAccion)
        {
            try
            {
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.conexion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "Stp_MantenimientoPersonas";
                coneccion.Parameters.AddWithValue("@pCedula", pClspersona.Cedula);
                coneccion.Parameters.AddWithValue("@pNombre", pClspersona.Nombre);
                coneccion.Parameters.AddWithValue("@pAp1", pClspersona.Ape1);
                coneccion.Parameters.AddWithValue("@pAp2", pClspersona.Ape2);
                coneccion.Parameters.AddWithValue("@pEmail", pClspersona.Email);
                coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(dataTable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                Console.WriteLine(Ex.Message);
            }
            return dataTable;


        }


    }
}
