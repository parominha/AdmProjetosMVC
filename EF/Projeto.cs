using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmProjetosMVC.EF
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
