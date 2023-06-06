namespace BancoKognit.Domain.Models
{
    public class User
    {
        private Guid guid;

        public User(Guid guid, string name, DateTime birthDate, string cpf)
        {
            this.guid = guid;
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
