namespace BancoKognit.Domain.Models
{
    public class User
    {
        public User() { }
        public User(Guid guid, string name, DateTime birthDate, string cpf)
        {
            Id = guid;
            Name = name;
            BirthDate = birthDate;
            Cpf = cpf;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
    }
}
