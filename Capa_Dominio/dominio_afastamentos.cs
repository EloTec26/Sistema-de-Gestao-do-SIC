using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_afastamentos
    {
        dados_afastamentos d_Afastamentos = new dados_afastamentos();
        public DataTable selecionar_Afastamentos()
        {
            return d_Afastamentos.selecionar_afastamentos();
        }
        public void inserir_Afastamentos(e_comum_afastamentos afastamentos)
        {
            d_Afastamentos.registrar_afastamentos(afastamentos);
        }
        public void atualizar_Afastamentos(e_comum_afastamentos afastamentos)
        {
            d_Afastamentos.atualizar_afastamentos(afastamentos);
        }
        public void eliminar_Afastamentos(e_comum_afastamentos afastamentos)
        {
            d_Afastamentos.eliminar_afastamentos(afastamentos);
        }
    }
}
