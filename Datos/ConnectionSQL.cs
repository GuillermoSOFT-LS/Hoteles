using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConnectionSQL
    {
        public static string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
    }
}
