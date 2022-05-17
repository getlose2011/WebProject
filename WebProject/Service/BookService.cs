using Dapper;
using System.Data.SqlClient;
using WebProject.Models;

namespace WebProject.Service
{
    public class BookService
    {
        private readonly string _connectionString;
        public BookService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public async Task<IEnumerable<Book>> Get()
        {
            var sqlQuery = @"SELECT  [DFP_ID] as Id
                              ,[DFP_CODE] as Description
                          FROM[EBCNEWS].[dbo].[NEWSDFP]";

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Book>(sqlQuery);
            }
        }

    }
}
