using System.Collections.Generic;
using TiendaDAL;
using TiendaDTO;

namespace TiendaBL
{
    public class VehiculoBL
    {
        public Vehiculo ObtenerVehiculo(int identificador)
        {
            return new VehiculoDAL().ObtenerVehiculo(identificador);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return new VehiculoDAL().ObtenerVehiculos();
        }
    }
}
