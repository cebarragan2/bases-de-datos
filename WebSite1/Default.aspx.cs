using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    gestionDatos objGestinDatos = new gestionDatos();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        persona unaPersona = new persona();
        unaPersona.Identificacion = Convert.ToInt32( txtIdentificacion.Text);
        unaPersona.Nombre = txtNombre.Text;
        unaPersona.Apellido = txtApellido.Text;
        unaPersona.Direccion = txtDireccion.Text;
        unaPersona.Correo = txtCorreo.Text;
        bool agregado = objGestinDatos.agregarPersona(unaPersona);
        if(agregado)
        {
            lblMensaje.Text = "una persona se ha agregado a la base de datos";
        }
        else
        {
            lblMensaje.Text = objGestinDatos.error;
        }
    }
}