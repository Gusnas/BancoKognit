using System.ComponentModel.DataAnnotations.Schema;

namespace BancoKognit.Domain.Models
{
    public class Wallet
    {
        public Wallet() { }

        public Wallet(Guid guid, Guid userId, float currentValue, string bank, DateTime lastUpdate)
        {
            Id = guid;
            UserId = userId;
            CurrentValue = currentValue;
            Bank = bank;
            LastUpdate = lastUpdate;
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public float CurrentValue { get; set; }
        public string Bank { get; set; }
        public DateTime LastUpdate{ get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
