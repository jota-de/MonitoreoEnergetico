using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Utils;
using System.Data.SqlClient;
using System.Data;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public class ConstructorRepository : IConstructorRepository
    {
        private readonly SqlConnection _conexion;

        public ConstructorRepository()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }
        public List<Constructor> ObtenerTodos()
        {
            List<Constructor> lista = new List<Constructor>();
            SqlCommand cmd = new SqlCommand("sp_ObtenerConstructores",_conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Constructor 
                {
                    idConstructor = Convert.ToInt16(dr["idEmpresa"]),
                    nombreConstructor = dr["nombreEmpresa"].ToString(),
                    codigoConstructor = dr["codigoEmpresa"].ToString(),
                    tipoConstructor = dr["especializacion"].ToString(),
                    paisOrigenConstructor = dr["PaisOrigenEmpresa"].ToString(),
                    emailConstructor = dr["emailEmpresa"].ToString(),
                    telefonoConstructor = Convert.ToInt32(dr["telefonoEmpresa"])

                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Constructor constructor)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarConstructor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreEmpresa", constructor.nombreConstructor);
            cmd.Parameters.AddWithValue("@paisOrigenEmpresa", constructor.paisOrigenConstructor);
            cmd.Parameters.AddWithValue("@especializacion", constructor.tipoConstructor);
            cmd.Parameters.AddWithValue("@emailEmpresa", constructor.emailConstructor);
            cmd.Parameters.AddWithValue("@telefonoEmpresa", constructor.telefonoConstructor);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
        public void Actualizar(Constructor constructor)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarConstructor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEmpresa", constructor.idConstructor);
            cmd.Parameters.AddWithValue("@nombreEmpresa", constructor.nombreConstructor);
            cmd.Parameters.AddWithValue("@paisOrigenEmpresa", constructor.paisOrigenConstructor);
            cmd.Parameters.AddWithValue("@especializacion", constructor.tipoConstructor);
            cmd.Parameters.AddWithValue("@emailEmpresa", constructor.emailConstructor);
            cmd.Parameters.AddWithValue("@telefonoEmpresa", constructor.telefonoConstructor);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();

        }
        public void Eliminar(short idEmpresa)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarConstructor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEmpresa",idEmpresa);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        

    }
}
