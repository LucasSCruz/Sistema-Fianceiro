using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SF.Domain.Entity
{
    public class Movimentacao : Entity
    {
        public string Descricao { get; set; }
        public int TipoMovimentacao { get; set; }
        public double Valor { get; set; }
        public DateTime DataMovimentcao { get; set; }
        public DateTime DataCriacao { get; set; }
        public Instituicao InstituicaoID { get; set; }
    }
}
