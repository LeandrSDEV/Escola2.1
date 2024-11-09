namespace RaioDeSol.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataContratacao { get; set; }
        public Escola Escola { get; set; }
        public ICollection<Valores> Valores { get; set; } = new List<Valores>();

        public Professor() { }

        public Professor(int id, string nome, string email,string telefone, DateTime datacontratacao, Escola escola) 
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DataContratacao = datacontratacao;
            Escola = escola;
        }
    }
}
