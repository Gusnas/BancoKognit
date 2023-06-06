using System.ComponentModel.DataAnnotations.Schema;

namespace BancoKognit.Domain.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public float CurrentValue { get; set; }
        public string Bank { get; set; }
        public DateTime LastUpdate{ get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
