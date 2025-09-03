using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Habitacion
    {

        CD_Habitacion obj = new CD_Habitacion();

        public List<CE_Habitacion> GetListHabitacion()
        {
            return obj.habitaciones();
        }

        public List<CE_Habitacion> Filtrarhabitaciones(string nombre)
        {
            return obj.FILTRARhabitaciones(nombre);
        }
    }
}
