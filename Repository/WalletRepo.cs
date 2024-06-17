using AutoMapper;
using Core.Dtos;
using LOH_UserManagement.Context;
using LOH_UserManagement.Entities;
using Microsoft.EntityFrameworkCore;
using LOH_UserManagement.Repository.IRepository;

namespace LOH_UserManagement.Repository
{
    public class WalletRepo: IWalletRepo
    {
        private readonly AppDbContext _context;
        public IMapper _mapper;
        public WalletRepo(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Wallet> CreateWallet(Wallet wallet)
        {
            
            var result = await _context.Wallets.AddAsync(wallet);
            return result.Entity;

        }

        public async Task<Wallet> GetAWalletById(string Id)
        {
            var result = await _context.Wallets.FindAsync(Id);
            return result;
        }

        public async Task<List<Wallet>> GetAllWallets()
        {
            var result = await _context.Wallets.ToListAsync();
            return result;
        }

        public async Task<Wallet> GetWalletByUserId(string userId)
        {
            var result = await _context.Wallets.Where(w => w.UserId == userId).FirstOrDefaultAsync();
            return result;
        }
        public async Task<Wallet> CreditWalletBalance(string Id, decimal amount)
        {
            var wallet = await _context.Wallets.Where(w => w.Id == Id).FirstOrDefaultAsync();
            wallet.Balance += amount;
            await _context.SaveChangesAsync();
            return wallet;
        }
        public async Task<Wallet> DebitWalletBalance(string Id, decimal amount)
        {
            var wallet = await _context.Wallets.Where(w => w.Id == Id).FirstOrDefaultAsync();
            wallet.Balance -= amount;
            await _context.SaveChangesAsync();
            return wallet;
        }
    }
}
