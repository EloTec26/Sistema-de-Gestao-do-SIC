using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Piquete
    {
        public int Codigo { get; set; }
        public string Funcionario { get; set; }
        public string Detalhes { get; set; }
        public DateTime Data_registro { get; set; }
    }
}
