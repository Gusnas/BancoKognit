using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BancoKognit.Application.ViewModels
{
    public class UserViewModel
    {
        [Key] public Guid Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [DisplayName("CPF")]
        public string CPF { get; set; }
    }
}
