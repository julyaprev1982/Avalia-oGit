using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Profissionaise
    {
        public int IdProfissional { get; set; }
        public string Profissional { get; set; }
        public string Cpf { get; set; }
        public Cidadee Cidade { get; set; }
        public Especialidadee Especialidade { get; set; }
    }
}
