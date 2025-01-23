using System;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Vitimas
    {
        public int Codigo_Vitima { get; set; }
        public string Vitima { get; set; }
        public string Informacoes_gerais { get; set; }
        public DateTime Data_Registro { get; set; }
    }
}
