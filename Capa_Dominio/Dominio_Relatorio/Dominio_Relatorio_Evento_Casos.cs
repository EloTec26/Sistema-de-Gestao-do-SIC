﻿using System;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Evento_Casos
    {
        public string codigo { get; set; }
        public string descricao_vitima { get; set; }
        public string inf_caso { get; set; }
        public string responsavel { get; set; }
        public string testemunha { get; set; }
        public string endereco { get; set; }
        public DateTime data_do_evento { get; set; }
        public string total_eventos { get; set; }
        public string total_masculino { get; set; }
        public string total_feminino { get; set; }
    }
}
