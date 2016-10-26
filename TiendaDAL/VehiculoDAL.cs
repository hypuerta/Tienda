using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TiendaDTO;

namespace TiendaDAL
{
    public class VehiculoDAL: Conexion
    {

        public Vehiculo ObtenerVehiculo(int identificador)
        {
            SqlConnection con = null;
            Vehiculo vehiculo = new Vehiculo();
            try
            {
                con = ConexionBD();
                SqlCommand cmd = new SqlCommand("spObtenerVehiculo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@identificador", SqlDbType.Int).Value = identificador;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehiculo.Identificador = Convert.ToInt32(dr["Identificador"]);
                    vehiculo.Placa = Convert.ToString(dr["Placa"]);
                    vehiculo.Color = Convert.ToString(dr["Color"]);
                }

            }
            catch (Exception ex)
            {
                vehiculo = null;
                throw ex;
            }

            finally { con.Close(); }
            return vehiculo;
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            SqlConnection con = null;
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                con = new Conexion().ConexionBD();
                SqlCommand cmd = new SqlCommand("spObtenerVehiculos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //vehiculos = DataReaderMapToList<Vehiculo>(dr);
                    while (dr.Read())
                    {
                        ExObject user = new ExObject();
                        user.Identificador = (Decimal)dr["Identificador"];
                        user.Descripcion = (String)dr["Descripcion"];
                        vehiculos.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                vehiculos = null;
                throw ex;
            }
            finally { con.Close(); }
            return vehiculos;
        }
    }
}
