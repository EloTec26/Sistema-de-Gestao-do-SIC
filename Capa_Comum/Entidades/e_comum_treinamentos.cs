using System;

namespace Capa_Comum.Entidades
{
    public class e_comum_treinamentos
    {
        public int id_treinamento { get; set; }
        public int id_departamento { get; set; }
        public int id_investigador { get; set; }
        public int id_usuario { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
