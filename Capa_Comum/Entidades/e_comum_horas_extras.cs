using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_horas_extras
    {
        public int id_hora_extra { get; set; }
        public int id_investigador { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_trabalho { get; set; }
        public string horas_trabalhadas { get; set; }
        public string tipo_horas { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
