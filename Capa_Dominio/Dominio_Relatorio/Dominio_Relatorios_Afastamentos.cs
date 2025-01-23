using System;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorios_Afastamentos
    {
        public int Codigo { get; set; }
        public string Funcionario { get; set; }
        public DateTime Data_inicial_feria { get; set; }
        public DateTime Data_final_feria { get; set; }
        public string Estado { get; set; }
        public DateTime Data_registro { get; set; }
    }
}
