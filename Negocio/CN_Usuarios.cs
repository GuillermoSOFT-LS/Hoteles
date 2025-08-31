using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using Datos;

namespace Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios ObjCD = new CD_Usuarios();

        public List<Usuario> GetLista()
        {
            return ObjCD.GetAllusuarios();
        }
    }
}
