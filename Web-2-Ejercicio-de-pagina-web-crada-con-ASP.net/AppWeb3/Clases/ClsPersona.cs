using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppWeb3.Clases
{
    public class ClsPersona : ClsConexion
    {
        private string cedula,
                       nombre,
                       primerApellido,
                       segundoApellido,
                       correoElectronico;
        private DataTable dataTable = new DataTable();

        public ClsPersona()
        {
            this.cedula = "";
            this.nombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.correoElectronico = "";
        }

        public string Cedula
        {
            get { return cedula; }
        }

        public string Nombre 
        {
            get { return nombre; }
        }

        public string PrimerApellido 
        {
            get { return primerApellido; }
        }

        public string SegundoApellido 
        {
            get { return segundoApellido; }
        }

        public string CorreoElectronico 
        {
            get { return correoElectronico; }
        }


        public ClsPersona (string pCedula, string pNombre, string pPrimerApellido, string pSegundoApellido, string pCorreoElectronico)
        {
            this.cedula            = pCedula;
            this.nombre            = pNombre;
            this.primerApellido    = pPrimerApellido;
            this.segundoApellido   = pSegundoApellido;
            this.correoElectronico = pCorreoElectronico;
        }

        public string AgregarPersona (ClsPersona pClsPersona, string pAccion)
        {
            try
            {
                SqlConnection conectado = new SqlConnection(this.conexion);
                conectado.Open();
                SqlCommand conexion = new SqlCommand();
                conexion.Connection = conectado;
                conexion.CommandType = CommandType.StoredProcedure;
                conexion.CommandText = "sp_AgregarPersona"; //Nombre de Nuestro Procedimiento Almacenado
                conexion.CommandTimeout = 10;
                conexion.Parameters.AddWithValue("@pCedula"             , pClsPersona.Cedula);
                conexion.Parameters.AddWithValue("@pNombre"             , pClsPersona.Nombre);
                conexion.Parameters.AddWithValue("@pPrimerApellido"     , pClsPersona.PrimerApellido);
                conexion.Parameters.AddWithValue("@pSegundoApellido"    , pClsPersona.SegundoApellido);
                conexion.Parameters.AddWithValue("@correo"              , pClsPersona.CorreoElectronico);
                conexion.Parameters.AddWithValue("@MantenimientoPersona", pClsPersona.CorreoElectronico);
                conexion.ExecuteNonQuery();
                conectado.Close();
                return "La persona ha sido agregada exitosamente.";
            } catch {
                return "La persona no se ha agregado.";
            }
        }

        public DataTable GetListaPersonas(ClsPersona pClsPersona, String pAccion)
        {
            try
            {​​
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.conexion);
                conectado.Open();
                SqlCommand conexion = new SqlCommand();
                conexion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.CommandType = CommandType.StoredProcedure;
                conexion.CommandText = "Stp_MantenimientoPersonas";
                conexion.Parameters.AddWithValue("@pCedula", pClsPersona.Cedula);
                conexion.Parameters.AddWithValue("@pNombre", pClsPersona.Nombre);
                conexion.Parameters.AddWithValue("@pPrimerApellido", pClsPersona.PrimerApellido);
                conexion.Parameters.AddWithValue("@pSegundoApellido", pClsPersona.SegundoApellido);
                conexion.Parameters.AddWithValue("@correo", pClsPersona.CorreoElectronico);
                conexion.Parameters.AddWithValue("@MantenimientoPersona", pAccion);
                adapter = new SqlDataAdapter(conexion);
                adapter.Fill(dataTable);
                conectado.Close();
            } catch (Exception Ex) {​​
                Console.WriteLine(Ex.Message);
            }​​
                return dataTable;
        }


    }
}