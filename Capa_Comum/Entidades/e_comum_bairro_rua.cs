﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Comum.Entidades
{
    public class e_comum_bairro_rua
    {
        public int id_bairro_rua { get; set; }
        public int id_municipio { get; set; }
        public string nome { get; set; }
        public DateTime data_registro { get; set; }
        public DateTime data_atualizacao { get; set; }
    }
}
