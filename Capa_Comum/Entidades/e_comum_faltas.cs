using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_faltas
    {
        public int id_falta { get; set; }
        public int id_investigador { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_falta { get; set; }
        public string estado_falta { get; set; }
        public string descricao { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
