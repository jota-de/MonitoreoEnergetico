using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Utils;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public class InvestorRepository : IInvestorRepository
    {
        private readonly SqlConnection _conexion;

        public InvestorRepository()
        {
            _conexion = DbConnectionSingleton.Instancia;
        }

        public List<Investor> ObtenerTodos()
        {
            List<Investor> inversores = new List<Investor>();
            SqlCommand cmd = new SqlCommand("sp_ObtenerInvestor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                inversores.Add(new Investor
                {
                    idInversor = Convert.ToInt16(dr["idInversor"]),
                    nombreInversor = dr["nombreInversor"].ToString(),
                    codigoInversor = dr["codigoInversor"].ToString(),
                    tipoInversor = dr["tipoInversor"].ToString(),
                    paisOrigenInversor = dr["paisOrigenInversor"].ToString(),
                    emailInversor = dr["emailInversor"].ToString(),
                    telefonoInversor = Convert.ToInt32(dr["telefonoInversor"])
                });
            }
            _conexion.Close();
            return inversores;
        }
        public void Insertar(Investor inversor)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarInversor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreInversor", inversor.nombreInversor);
            cmd.Parameters.AddWithValue("@codigoInversor", inversor.codigoInversor);
            cmd.Parameters.AddWithValue("@tipoInversor", inversor.tipoInversor);
            cmd.Parameters.AddWithValue("@paisOrigenInversor", inversor.paisOrigenInversor);
            cmd.Parameters.AddWithValue("@emailInversor", inversor.emailInversor);
            cmd.Parameters.AddWithValue("@telefonoInversor", inversor.telefonoInversor);
            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
        public void Actualizar(Investor inversor)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarInversor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idInversor", inversor.idInversor);
            cmd.Parameters.AddWithValue("@nombreInversor", inversor.nombreInversor);
            cmd.Parameters.AddWithValue("@codigoInversor", inversor.codigoInversor);
            cmd.Parameters.AddWithValue("@tipoInversor", inversor.tipoInversor);
            cmd.Parameters.AddWithValue("@paisOrigenInversor", inversor.paisOrigenInversor);
            cmd.Parameters.AddWithValue("@emailInversor", inversor.emailInversor);
            cmd.Parameters.AddWithValue("@telefonoInversor", inversor.telefonoInversor);
            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
        public void Eliminar(short idInversor)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarInversor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idInversor", idInversor);
            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }
}
