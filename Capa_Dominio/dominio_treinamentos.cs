using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Comum.Entidades;
using Capa_Dados;

namespace Capa_Dominio
{
    public class dominio_treinamentos
    {
        dados_treinamentos d_treinamentos = new dados_treinamentos();
        public void cadastrar_treinamentos(e_comum_treinamentos treinamentos)
        {
            d_treinamentos.Cadastrar_Treinamentos(treinamentos);
        }
        public System.Data.DataTable selecionar_treinamentos()
        {
            return d_treinamentos.Selecionar_Treinamentos();
        }
        public void atualizar_treinamentos(e_comum_treinamentos treinamentos)
        {
            d_treinamentos.Atualizar_Treinamentos(treinamentos);
        }
        public void eliminar_treinamentos(e_comum_treinamentos treinamentos)
        {
            d_treinamentos.Eliminar_Treinamentos(treinamentos);
        }
    }
}
