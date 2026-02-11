using StoreManagement.Common.DTOs;
using System.Threading.Tasks;

namespace StoreManagement.BAL.Interfaces
{
    public interface IAuthentication
    {
        Task<User> ValidateUser(string username, string password);
    }
}
