using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Utils;
using System.Data;


namespace wMonitoreoEnergetico.Data.Repositories
{
    public class ProjectRespository : IProjectRepository
    {
        private readonly SqlConnection _conexion;
        public ProjectRespository()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }
        public List<Project> ObtenerTodos()
        {
            List<Project> lista = new List<Project>();
            SqlCommand cmd = new SqlCommand("sp_ObtenerProyecto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Project
                {
                    idProyecto = Convert.ToInt16(dr["idProyecto"]),
                    nombreProyecto = dr["nombreProyecto"].ToString(),
                    codigoProyecto = dr["codigoProyecto"].ToString(),
                    tipoGeneracion = dr["tipoGeneracion"].ToString(),
                    numeroUnidades = Convert.ToInt16(dr["numeroUnidades"]),
                    departamento = dr["departamento"].ToString(),
                    municipio = dr["municipio"].ToString(),
                    capacidadInstalada = Convert.ToInt32(dr["capacidadInstalada"]),
                    idInversor = Convert.ToInt16(dr["idInversor"]),
                    idEmpresa = Convert.ToInt16(dr["idEmpresa"])
                });    
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Project proyecto)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarProyecto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreProyecto",proyecto.nombreProyecto);
            cmd.Parameters.AddWithValue("@tipoGeneracion", proyecto.tipoGeneracion);
            cmd.Parameters.AddWithValue("@numeroUnidades", proyecto.numeroUnidades);
            cmd.Parameters.AddWithValue("@departamento", proyecto.departamento);
            cmd.Parameters.AddWithValue("@municipio", proyecto.municipio);
            cmd.Parameters.AddWithValue("@capacidadInstalada", proyecto.capacidadInstalada);
            cmd.Parameters.AddWithValue("@idInversor", proyecto.idInversor);
            cmd.Parameters.AddWithValue("@idEmpresa", proyecto.idEmpresa);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Project proyecto)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarProyecto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProyecto", proyecto.idProyecto);
            cmd.Parameters.AddWithValue("@nombreProyecto", proyecto.nombreProyecto);
            cmd.Parameters.AddWithValue("@tipoGeneracion", proyecto.tipoGeneracion);
            cmd.Parameters.AddWithValue("@numeroUnidades", proyecto.numeroUnidades);
            cmd.Parameters.AddWithValue("@departamento", proyecto.departamento);
            cmd.Parameters.AddWithValue("@municipio", proyecto.municipio);
            cmd.Parameters.AddWithValue("@capacidadInstalada", proyecto.capacidadInstalada);
            cmd.Parameters.AddWithValue("@idInversor", proyecto.idInversor);
            cmd.Parameters.AddWithValue("@idEmpresa", proyecto.idEmpresa);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(short idProject)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarProyecto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProyecto", idProject);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

    }
}
