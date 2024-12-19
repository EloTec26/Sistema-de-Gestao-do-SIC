using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_beneficios_investigadores
    {
        public int id_beneficio_investigador { get; set; }
        public int id_beneficio { get; set; }
        public int id_investigador { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
