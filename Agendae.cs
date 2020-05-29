using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
  public  class Agendae
    {
        public int IdAgencia { get; set; }
        public Pacientee NomePaciente { get; set; }
        public Profissionaise NomeProfissional { get; set; }
        public string Valor { get; set; }
        public string Horario { get; set; }
        public string  Data { get; set; }

    }
}
