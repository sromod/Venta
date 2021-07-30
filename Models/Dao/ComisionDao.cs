using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Ventas.Models.Dto;
using Ventas.Models.Context;

namespace Ventas.Models.Dao
{
    class ComisionDao:DbContext
    {

        SqlDataReader leerFilas;
        SqlCommand comando = new SqlCommand();

        public List<Comision> ListarComisionesVendedor(string anio, string mes)
        {
            comando.Connection = Connection;
            comando.CommandText = "SP_Comision";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Anio", anio);
            comando.Parameters.AddWithValue("@Mes", mes);
            Connection.Open();

            leerFilas = comando.ExecuteReader();

            List<Comision> ListaComisiones = new List<Comision>();
            while (leerFilas.Read())
            {
                ListaComisiones.Add(new Comision
                {
                    NombreVendedor = leerFilas.GetString(0),
                    ValorComision = String.Format("{0:n0}", leerFilas.GetDecimal(1))
                });
            }
            leerFilas.Close();
            Connection.Close();
            return ListaComisiones;
        }
    }
}
