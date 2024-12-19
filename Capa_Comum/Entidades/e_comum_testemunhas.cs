using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_testemunhas
    {
        public int id_testemunha { get; set; }
        public int id_caso { get; set; }
        public int id_continente { get; set; }
        public int id_pais { get; set; }
        public int id_provincia { get; set; }
        public int id_municipio { get; set; }
        public int id_bairro_rua { get; set; }
        public int id_nivel_academico { get; set; }
        public int id_curso { get; set; }
        public int id_usuario { get; set; }
        public string primeiro_nome { get; set; }
        public string nome_meio { get; set; }
        public string ultimo_nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string e_mail { get; set; }
        public string declaracao { get; set; }
        public string palavra_passe { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
