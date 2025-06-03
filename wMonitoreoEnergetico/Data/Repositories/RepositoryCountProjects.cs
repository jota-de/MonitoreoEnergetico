using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Data.Repositories;
using wMonitoreoEnergetico.Utils;
using System.Data.SqlClient;
using System.Data;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public class RepositoryCountProjects : IRepositoryCountProjects
    {
        private readonly SqlConnection _conexion;
        public RepositoryCountProjects()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }
        public int CountProjectsSolar()
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("sp_ContarProyectosSolar", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (_conexion.State != ConnectionState.Open)
                    _conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Suponiendo que el procedimiento retorna una columna con el conteo
                        count = dr.GetInt32(0);
                    }
                }
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }

            return count;
        }
        public int CountProjectsWind()
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("sp_ContarProyectosWind", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (_conexion.State != ConnectionState.Open)
                    _conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Suponiendo que el procedimiento retorna una columna con el conteo
                        count = dr.GetInt32(0);
                    }
                }
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }

            return count;
        }
        public int CountProjectsHydro()
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("sp_ContarProyectosHydro", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (_conexion.State != ConnectionState.Open)
                    _conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Suponiendo que el procedimiento retorna una columna con el conteo
                        count = dr.GetInt32(0);
                    }
                }
            }
            finally
            {
                if (_conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }

            return count;
        }
    }
}
