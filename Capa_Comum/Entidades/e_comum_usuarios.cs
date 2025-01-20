using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_usuarios
    {
        public int id_usuario { get; set; }
        public string primeiro_nome { get; set; }
        public string nome_meio { get; set; }
        public string ultimo_nome { get; set; }
        public string bi { get; set; }
        public string sexo { get; set; }
        public string telefone1 { get; set; }
        public string e_mail { get; set; }
        public string tipo_usuario { get; set; }
        public string palavra_passe { get; set; }	 
	}
}
