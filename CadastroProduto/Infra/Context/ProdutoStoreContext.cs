using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Infra.Context
{
    public  class ProdutoStoreContext
    {
        private readonly IConfiguration _configuration;
        public SqlConnection Connection { get; set; }

        public ProdutoStoreContext(IConfiguration configuration)
        {
            _configuration = configuration;

            Connection = new SqlConnection(_configuration.GetConnectionString("CnnStr"));
            Connection.Open();
        }
        
    }
}
