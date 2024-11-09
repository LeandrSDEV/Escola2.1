using RaioDeSol.Models.Enum;

namespace RaioDeSol.Models
{
    public class Valores
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorPago { get; set; }
        public StatusPagamento Status { get; set; }
        public Professor Professor { get; set; }
        public Aluno Aluno { get; set; }

        public Valores() { }

        public Valores(int id, double valorTotal, DateTime dataVencimento, double valorPago, StatusPagamento status, Professor professor, Aluno aluno)
        {
            Id = id;
            ValorTotal = valorTotal;
            DataVencimento = dataVencimento;
            ValorPago = valorPago;
            Status = status;
            Professor = professor;
            Aluno = aluno;
        }
    }
}
