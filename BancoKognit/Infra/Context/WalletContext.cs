using BancoKognit.Domain.Models;
using System.Data.Entity;

namespace BancoKognit.Infra.Context
{
    public class WalletContext:DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }
    }
}
