

namespace SF.Domain.Entity
{
    public class Instituicao : Entity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public Conta contaId { get; set; }
    }
}
