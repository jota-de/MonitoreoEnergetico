using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Utils;



namespace wMonitoreoEnergetico.Data.Repositories
{
    public class UserRepository : IuserRepository
    {
        private readonly SqlConnection _conexion;

        public UserRepository()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> users = new List<Usuario>();         
            SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarios", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                users.Add(new Usuario
                {
                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                    NombreUsuario = dr["Usuario"].ToString(),
                    Rol = dr.GetSchemaTable().Rows.Cast<DataRow>().Any(r => r["ColumnName"].ToString() == "RolId")
                        ? dr["RolId"].ToString()
                        : "" // Si no existe la columna, asigna vacío
                });

            }
            _conexion.Close();
            return users;

        }
        /*public void Insertar(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@RolId", usuario.Rol);
            cmd.Parameters.AddWithValue("@Clave", usuario.Contrasena);

        } */
        public void Eliminar(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }

}
