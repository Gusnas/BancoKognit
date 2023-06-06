using BancoKognit.Domain.Models;
using System.Data.Entity;

namespace BancoKognit.Infra.Context
{
    public class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
