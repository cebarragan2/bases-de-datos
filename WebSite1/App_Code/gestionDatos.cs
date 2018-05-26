using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Descripción breve de gestionDatos
/// </summary>
public class gestionDatos
{
    public SqlConnection conexio;
    public SqlTransaction transaccion;
    public String error;
    public gestionDatos()
    {
        this.conexio = conexion.getConexion();
    }

    public bool agregarPersona( persona unaPersona)
    {
        bool agrega = false;
        SqlCommand comando = new SqlCommand();
        comando.Connection = conexio;
        comando.CommandText = "insert into cliente values(@id_cliente, @nombre_Clente ,@apellido_Clente,@direc_Clente, @email_Clente)";
        comando.Parameters.AddWithValue("@id_cliente", unaPersona.Identificacion);
        comando.Parameters.AddWithValue("@nombre_Clente", unaPersona.Nombre);
        comando.Parameters.AddWithValue("@apellido_Clente", unaPersona.Apellido);
        comando.Parameters.AddWithValue("@direc_Clente", unaPersona.Direccion);
        comando.Parameters.AddWithValue("@email_Clente", unaPersona.Correo);
        try
        {
            comando.ExecuteNonQuery();
            agrega = true;
        }catch(SqlException ex)
        {
            this.error = ex.Message;
        }
        return agrega;
    }

    /*public persona consularPersonaIdentifica (String identificacion)
    {
        SqlCommand comando = new SqlCommand();
        comando.Connection = conexio;
        comando.CommandText = "select * from cliente where id_cliente=@identificacion";
        SqlDataReader registro = comando.ExecuteReader();
        if (registro.Read())
        {
            persona unapersona = new persona();
            unapersona.IdCliente = registro.GetInt32(0);
            
        }
    }*/
}