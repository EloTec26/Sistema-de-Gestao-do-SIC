using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_provincias
    {
        public int id_provincia { get; set; }
        public int id_pais { get; set; }
        public string nome { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }

    }
}
