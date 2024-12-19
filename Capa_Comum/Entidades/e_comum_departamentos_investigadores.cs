using System;

namespace Capa_Comum.Entidades
{
    public class e_comum_departamentos_investigadores
    {
        public int id_departamento_investigador { get; set; }
        public int id_investigador { get; set; }
        public int id_departamento { get; set; }
        public int id_usuario { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
