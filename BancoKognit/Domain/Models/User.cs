﻿namespace BancoKognit.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
    }
}
