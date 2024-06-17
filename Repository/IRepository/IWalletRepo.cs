using LOH_UserManagement.Entities;

namespace LOH_UserManagement.Repository.IRepository
{
    public interface IWalletRepo
    {
        Task<Wallet> CreateWallet(Wallet wallet);
        Task<Wallet> GetAWalletById(string Id);
        Task<List<Wallet>> GetAllWallets();
        Task<Wallet> GetWalletByUserId(string userId);
        Task<Wallet> CreditWalletBalance(string Id, decimal amount);
        Task<Wallet> DebitWalletBalance(string Id, decimal amount);
    }
}
