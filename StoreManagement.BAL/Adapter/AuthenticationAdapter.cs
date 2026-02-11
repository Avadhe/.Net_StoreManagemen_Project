using Dapper;
using StoreManagement.BAL.Interfaces;
using StoreManagement.Common.DapperContext;
using StoreManagement.Common.DTOs;


namespace StoreManagement.BAL.Adapter
{
    public class AuthenticationAdapter : IAuthentication
    {
        private readonly DbContext _context;

        public AuthenticationAdapter(DbContext context)
        {
            _context = context;
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT * FROM [users] WHERE [username] = @username AND [password_hash] = @password";
                return await connection.QueryFirstOrDefaultAsync<User>(query, new { username, password });
            }
        }
    }
}
