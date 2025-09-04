using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;

namespace Datos
{
    public class CD_Habitacion
    {
        public List<CE_Habitacion> habitaciones()
        {
            List<CE_Habitacion> lista = new List<CE_Habitacion>();

            try
            {
                using(SqlConnection sqlcon = new SqlConnection(ConnectionDB.Conn))
                {
                    using(SqlCommand cmd = new SqlCommand("uspListarTipoHabitacion", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        sqlcon.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            lista.Add(new CE_Habitacion
                            {
                                Id = Convert.ToInt32(sdr["IIDTIPOHABILITACION"]),
                                Tipo = sdr["NOMBRE"].ToString(),
                                Descripcion = sdr["DESCRIPCION"].ToString(),
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

        public List<CE_Habitacion> FILTRARhabitaciones(string nombre)
        {
            List<CE_Habitacion> lista = new List<CE_Habitacion>();

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionDB.Conn))
                {
                    using (SqlCommand cmd = new SqlCommand("uspFiltarTipoHabitacion", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombrehabitacion", nombre);
                        sqlcon.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            lista.Add(new CE_Habitacion
                            {
                                Id = Convert.ToInt32(sdr["IIDTIPOHABILITACION"]),
                                Tipo = sdr["NOMBRE"].ToString(),
                                Descripcion = sdr["DESCRIPCION"].ToString(),
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
