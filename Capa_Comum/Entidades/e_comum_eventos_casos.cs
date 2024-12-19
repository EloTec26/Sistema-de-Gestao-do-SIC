using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_eventos_casos
    {
        public int id_evento_caso { get; set; }
        public int id_caso { get; set; }
        public int id_investigador { get; set; }
        public int id_vitima { get; set; }
        public int id_testemunha { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_evento { get; set; }
        public string tipo_evento { get; set; }
        public string descricao { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
        public int id_suspeito { get; set; }
    }
}
