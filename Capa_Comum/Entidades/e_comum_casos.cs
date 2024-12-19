using System;

namespace Capa_Comum.Entidades
{
    public class e_comum_casos
    {
        public int id_caso { get; set; }
        public int id_investigador { get; set; }
        public int id_departamento { get; set; }
        public int id_usuario { get; set; }
        public string titulo { get; set; }
        public DateTime data_abertura { get; set; }
        public DateTime data_fechamento { get; set; }
        public string estado { get; set; }
        public string descricao { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
