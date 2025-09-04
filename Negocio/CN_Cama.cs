using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CN_Cama
    {
        public List<CE_Cama> GetCamas()
        {
            return new CD_Cama().GetAllCamas();
        }

        public List<CE_Cama> GetCamaSearch(string nombre)
        {
            return new CD_Cama().GetCama(nombre);
        }
    }
}
