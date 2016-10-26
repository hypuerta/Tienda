using System;
using TiendaBL;

namespace TiendaWeb
{
    public partial class Vehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VehiculoBL vehiculo = new VehiculoBL();
            TiendaDTO.Vehiculo ve = vehiculo.ObtenerVehiculo(1);
            lblIdentificador.Text = ve.Identificador.ToString();
            lblPlaca.Text = ve.Placa;
            lblColor.Text = ve.Color;

            grvVehiculos.DataSource = vehiculo.ObtenerVehiculos();
            grvVehiculos.DataBind();
        }
    }
}