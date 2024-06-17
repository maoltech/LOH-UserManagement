using Core.Dtos;
using LOH_UserManagement.Entities;

namespace LOH_UserManagement.Repository.IRepository
{
    public interface IUserRepo
    {
        Task<LOHUser> CreateUser(RegisterDto registerDto);
        Task<LOHUser> GetAUser(string userId);
        Task<List<LOHUser>> GetAllUsers();
    }
}
