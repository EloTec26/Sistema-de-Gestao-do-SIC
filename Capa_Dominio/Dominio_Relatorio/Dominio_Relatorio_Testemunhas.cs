using System;

namespace Capa_Dominio.Dominio_Relatorio
{
    public class Dominio_Relatorio_Testemunhas
    {
        public int Codigo_Testemunha { get; set; }
        public string Testemunha { get; set; }
        public string Informacoes_gerais { get; set; }
        public DateTime Data_Registro { get; set; }
    }
}
