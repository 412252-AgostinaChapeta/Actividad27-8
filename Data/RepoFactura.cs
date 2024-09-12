using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data
{
    public class RepoFactura : IRepoFactura
    {
        public bool Save(Factura oFactura)
        {
            bool result = true;
            SqlTransaction? t = null;
            SqlConnection? cnn = null;

            try
            {
                cnn = DataHelper.GetInstance().GetConnection();
                cnn.Open();
                t = cnn.BeginTransaction();

                var cmd = new SqlCommand("SP_REGISTRAR_FACTURA", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha", oFactura.Fecha);
                cmd.Parameters.AddWithValue("@id_pago", oFactura.FormaPago.Id);
                cmd.Parameters.AddWithValue("@cliente", oFactura.Cliente);

                SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                int FacturaId = (int)param.Value;

                int nroDetail = 1;

                foreach (var detail in oFactura.GetDetails())
                {
                    var cmdDetail = new SqlCommand("SP_REGISTRAR_DETALLE", cnn, t);
                    cmdDetail.CommandType = CommandType.StoredProcedure;
                    cmdDetail.Parameters.AddWithValue("@id_factura", FacturaId);
                    cmdDetail.Parameters.AddWithValue("@producto", detail.Articulo.Id);
                    cmdDetail.Parameters.AddWithValue("@cantidad", detail.Cantidad);
                    cmdDetail.ExecuteNonQuery();
                    nroDetail++;
                }

                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                result = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return result;
        }
    }
}

