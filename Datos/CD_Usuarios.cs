using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Entidad;

namespace Datos
{
    public class CD_Usuarios
    {
        public List<Usuario> GetAllusuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            try
			{
                using (SqlConnection sqlcon = new SqlConnection(ConnectionSQL.SQLConnection))
                {
                    using(SqlCommand cmd = new SqlCommand("SELECT_USERS", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        sqlcon.Open();

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {

                            while (sdr.Read())
                            {
                                lista.Add(

                                    new Usuario
                                    {
                                        IdUsuario = Convert.ToInt32(sdr["IdUsuario"]),
                                        Nombres = sdr["Nombres"].ToString(),
                                        Apellidos = sdr["Apellidos"].ToString(),
                                        Correo = sdr["Correo"].ToString(),
                                        Clave = sdr["Clave"].ToString(),
                                        Reestablecer = Convert.ToBoolean(sdr["Reestablecer"]),
                                        Activo = Convert.ToBoolean(sdr["Activo"])
                                    }
                                    );
                            }

                        }

                    }
                }
            }
			catch
			{
                lista = new List<Usuario>();
			}

            return lista;
        }
    }
}
