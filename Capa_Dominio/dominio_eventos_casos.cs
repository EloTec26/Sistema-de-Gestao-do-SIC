using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_eventos_casos
    {
        dados_eventos_casos e_Eventos_Casos = new dados_eventos_casos();
        public DataTable selecionar_Eventos_Casos()
        {
            return e_Eventos_Casos.selecionar_eventos_casos();
        }
        public void inserir_Enventos_Casos(e_comum_eventos_casos eventos_Casos)
        {
            e_Eventos_Casos.inserir_eventos_casos(eventos_Casos);
        }
        public void stualizar_Enventos_Casos(e_comum_eventos_casos eventos_Casos)
        {
            e_Eventos_Casos.atualizar_eventos_casos(eventos_Casos);
        }
        public void eliminar_Enventos_Casos(e_comum_eventos_casos eventos_Casos)
        {
            e_Eventos_Casos.eliminar_eventos_casos(eventos_Casos);
        }
    }
}
