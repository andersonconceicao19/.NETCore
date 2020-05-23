using ApiVendas.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Repositoty
{
    public abstract class RepositotyBase<TEntity>
    {

       public static List<TEntity> QuerySql(string sql, object[] parameter)
        {
            List<TEntity> orderDetails;
            using (var connection = new SqlConnection("Server=LAPTOP-N2DJEVQI;Database=Usuario;trusted_connection=true;"))
            {
                orderDetails = connection.Query<TEntity>(sql, parameter).ToList();

            }

            return orderDetails;
        }



        public Task<List<TEntity>> GetAll()
        {
            return null;
        }
        public Task<TEntity> GetbyId(Guid id)
        {
            return null;
        }
        public Task<TEntity> Add(TEntity produtos)
        {
            return null;
        }
        public Task<Produtos> Update(TEntity produtos)
        {
            return null;
        }
        public Task<Produtos> Delete(Guid id)
        {
            return null;
        }

    }
}
