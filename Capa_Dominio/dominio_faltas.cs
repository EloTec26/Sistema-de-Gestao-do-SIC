using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;

namespace Capa_Dominio
{
    public class dominio_faltas
    {
        dados_faltas d_Faltas = new dados_faltas();
        public DataTable selecionar_Faltas()
        {
            return d_Faltas.selecionar_faltas();
        }
        public void inserir_Faltas(e_comum_faltas faltas)
        {
            d_Faltas.inserir_faltas(faltas);
        }
        public void atualizar_Faltas(e_comum_faltas faltas)
        {
            d_Faltas.atualizar_faltas(faltas);
        }
        public void eliminar_Faltas(e_comum_faltas faltas)
        {
            d_Faltas.eliminar_faltas(faltas);
        }
    }
}
