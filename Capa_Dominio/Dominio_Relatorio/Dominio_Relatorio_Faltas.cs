using System;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Faltas
    {
        public int Codigo { get; set; }
        public string Funcionario { get; set; }
        public string Desc_Falta { get; set; }
        public DateTime Data_Registro { get; set; }
    }
}
