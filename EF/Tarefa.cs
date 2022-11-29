using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmProjetosMVC.EF
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstimativaHoras { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
