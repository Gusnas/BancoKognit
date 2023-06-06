using BancoKognit.Domain.Models;
using System.Data.Entity;

namespace BancoKognit.Infra.Context
{
    public class BankContext : DbContext
    {
        public BankContext() : base("BankContext")
        {
        }

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<User> Users { get; set; } 
    }
}
