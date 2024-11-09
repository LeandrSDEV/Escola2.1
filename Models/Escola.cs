namespace RaioDeSol.Models
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public ICollection<Professor> Professor { get; set; } = new List<Professor>();
        public ICollection<Aluno> Aluno { get; set; } = new List<Aluno>();

        public Escola() { }

        public Escola(int id, string nome, string endereço, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Endereço = endereço;
            Telefone = telefone;
            Email = email;
        }
    }
}
