using System;

/// <summary>
/// Descripción breve de persona
/// </summary>
public class persona
{
    private int idCliente;
    private int identificacion;
    private String nombre;
    private String apellido;
    private String direccion;
    private String correo;

    public persona()
    {
        
    }
    public persona(int identificacion, String nombre, String apellido, String direccion, String corre)
    {
        this.Identificacion = identificacion;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
        this.Correo = corre; 
    }

    public int IdCliente { get => idCliente; set => idCliente = value; }
   
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public string Direccion { get => direccion; set => direccion = value; }
  
    public int Identificacion { get => identificacion; set => identificacion = value; }
    public string Correo { get => correo; set => correo = value; }
}