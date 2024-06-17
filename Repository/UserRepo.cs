using AutoMapper;
using Core.Dtos;
using LOH_UserManagement.Context;
using LOH_UserManagement.Entities;
using Microsoft.EntityFrameworkCore;
using LOH_UserManagement.Repository.IRepository;

namespace LOH_UserManagement.Repository
{
    public class UserRepo: IUserRepo
    {
        private readonly AppDbContext _context;
        public IMapper _mapper;
        public UserRepo(AppDbContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<LOHUser> CreateUser(RegisterDto registerDto)
        {
           var register = _mapper.Map<LOHUser>(registerDto);
           var result = await _context.Users.AddAsync(register);
           return result.Entity;

        }

        public async Task<LOHUser> GetAUser(string userId)
        {
            var result = await _context.Users.FindAsync(userId);
            return result;
        }

        public async Task<List<LOHUser>> GetAllUsers()
        {
            var result = await _context.Users.ToListAsync();
            return result;
        }

        public async Task<LOHUser> GetUserByEmail(string email)
        {
            var result = await _context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
            return result;
        }
    }
}
