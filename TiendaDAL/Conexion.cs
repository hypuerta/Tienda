using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace TiendaDAL
{
    public class Conexion
    {
        //#region "PatronSingleton"

        //private static Conexion conexion = null;
        //private Conexion() { }
        //public static Conexion getInstance()
        //{
        //    if(conexion == null)
        //    {
        //        conexion = new Conexion();
        //    }
        //    return conexion;
        //}

        //#endregion "PatronSingleton"


        public SqlConnection ConexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=HERLEY-PC\\SQLEXPRESS;Initial Catalog=Tienda_DB; Integrated Security = True";
            conexion.Open();
            return conexion;
        }

        public List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }


    }
}
