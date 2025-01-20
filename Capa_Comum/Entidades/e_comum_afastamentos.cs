using System;

namespace Capa_Comum.Entidades
{
    public class e_comum_afastamentos
    {
        public int id_afastamento { get; set; }
        public int? id_investigador { get; set; }
        public int? id_usuario { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        public string descricao { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
        public string estado { get; set; }
    }
}
