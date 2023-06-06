using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BancoKognit.Application.ViewModels
{
    public class WalletViewModel
    {
        [Key] public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [DisplayName("Current Value")]
        public float CurrentValue { get; set; }

        [Required]
        [DisplayName("Bank")]
        public string Bank { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Last Update")]
        public DateTime LastUpdate { get; set; }
    }
}
