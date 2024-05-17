using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; //drinver SQL
using System.Data; //buffer de memorias
using System.Configuration;
using capaEntidad; //extraer cadena de conexion de presenCapa


namespace capaNegocio
{
    public class clienteBL : Interface.ICliente
    {
        //cadena de conexion extraida
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "Select *from TCliente";
                //la consulta se lleva a la base de datos y traer los registros de la tabla
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }

        }
        public bool Actualizar(cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(cliente cliente)
        {
            throw new NotImplementedException();
        }

        public DataTable Buscar(string codCliente)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string cliente)
        {
            throw new NotImplementedException();
        }

    }
}


















