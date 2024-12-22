using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Comum.Entidade_Relatorio;
using Capa_Dados.Dados_Relatorios;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Evento_Casos
    {
        public string codigo { get; set; }
        public string descricao_vitima { get; set; }
        public string endereco { get; set; }
        public string inf_caso { get; set; }
        public string responsavel { get; set; }
        public string testemunha { get; set; }
        public string suspeito { get; set; }
        public DateTime data_registro { get; set; }
    }
}
