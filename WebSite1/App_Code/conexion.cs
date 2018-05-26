using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Descripción breve de conexion
/// </summary>
public class conexion
{

    private static SqlConnection objConexion;
    private static String error;

    public static SqlConnection getConexion()
    {
        if (objConexion != null)
            return objConexion;
        objConexion = new SqlConnection();
        objConexion.ConnectionString = "Data Source=DESKTOP-00QQ1J5;Initial Catalog=A_viaje;Integrated Security=True";
        try
        {
            objConexion.Open();
            return objConexion;

        }catch(Exception e)
        {
            error = e.Message;
            return null;
        }
    }
    public static void cerrarConexion()
    {
        if (objConexion != null)
            objConexion.Close();
    }
}