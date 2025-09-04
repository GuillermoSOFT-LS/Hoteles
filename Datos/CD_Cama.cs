using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Cama
    {
        public List<CE_Cama> GetAllCamas()
        {
			List<CE_Cama> lista = new List<CE_Cama>();

            try
			{
                using(SqlConnection sqlcon = new SqlConnection(ConnectionDB.Conn))
                {
                    using(SqlCommand cmd = new SqlCommand("uspListarCama", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        sqlcon.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            lista.Add(new CE_Cama
                            {
                                Id = Convert.ToInt32(sdr["IIDCAMA"]),
                                Nombre = sdr["NOMBRE"].ToString(),
                                Descripcion = sdr.IsDBNull(sdr.GetOrdinal("DESCRIPCION")) ? "No hay descripcion" : sdr["DESCRIPCION"].ToString()  
                            });
                        }
                    }
                }
			}
			catch (Exception)
			{

				throw;
			}

            return lista;
        }

        public List<CE_Cama> GetCama(string nombre)
        {
            List<CE_Cama> lista = new List<CE_Cama>();

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionDB.Conn))
                {
                    using (SqlCommand cmd = new SqlCommand("uspFiltarCama", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombrecama",(object)nombre ?? "");
                        sqlcon.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            lista.Add(new CE_Cama
                            {
                                Id = Convert.ToInt32(sdr["IIDCAMA"]),
                                Nombre = sdr["NOMBRE"].ToString(),
                                Descripcion = sdr.IsDBNull(sdr.GetOrdinal("DESCRIPCION")) ? "No hay descripcion" : sdr["DESCRIPCION"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
