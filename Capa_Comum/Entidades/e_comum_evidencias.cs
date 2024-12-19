using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_evidencias
    {
        public int id_evidencia { get; set; }
        public int id_investigador { get; set; }
        public int id_caso { get; set; }
        public int id_usuario { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public DateTime data_coleta { get; set; }
        public string local_armazenamento { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
