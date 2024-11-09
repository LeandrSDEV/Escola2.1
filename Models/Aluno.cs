namespace RaioDeSol.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Escola Escola { get; set; }
        public ICollection<Valores> Valores { get; set; } = new List<Valores>();

        public Aluno() { }

        public Aluno(int id, string nome, string telefone, string email, DateTime dataNascimento, Escola escola)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            Escola = escola;
        }
    }
}
