using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models.Context;
using System.Data;
using System.Data.SqlClient;
using Ventas.Models.Dto;

namespace Ventas.Models.Dao
{
    class VentaDao:DbContext
    {
        SqlDataReader leerFilas;
        SqlCommand comando = new SqlCommand();

        public List<Venta> ListarVentasAcumuladas(string fechaInicial, string fechaFinal)
        {
            comando.Connection = Connection;
            comando.CommandText = "SP_VentasPeriodo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaInicial", fechaInicial);
            comando.Parameters.AddWithValue("@FechaFinal", fechaFinal);
            Connection.Open();

            leerFilas = comando.ExecuteReader();

            List<Venta> ListaVentasAcumuladas = new List<Venta>();
            while (leerFilas.Read())
            {
                ListaVentasAcumuladas.Add(new Venta
                {
                    NombreDepartamento = leerFilas.GetString(0),
                    VentasAcumuladas = String.Format("{0:n0}", leerFilas.GetDecimal(1))
                });
            }
            leerFilas.Close();
            Connection.Close();
            return ListaVentasAcumuladas;
        }
    }
}
