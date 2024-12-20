using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;

namespace Capa_Dominio
{
    public class dominio_evidencias : Validacoes
    {
         dados_evidencias d_Evidencias = new dados_evidencias ();
        public DataTable selecionar_evidencias()
        {
            return d_Evidencias.selecionar_evidencias();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_evidencias evidencias)
        {
            Validadar_Nomes_Gerais(evidencias.descricao, "[ERRO] - O campo 'Descrição', deve conter somente letras e ter no mínimo 3 caracteres.");
        }
        public void inserir_evidencias (e_comum_evidencias evidencias)
        {
            validacacoes(evidencias);
            d_Evidencias.inserir_evidencias(evidencias);
        }
        public void atualizar_evidencias(e_comum_evidencias evidencias)
        {
            validacacoes(evidencias);
            d_Evidencias.atualizar_evidencias(evidencias);
        }
        public void eliminar_evidencias(e_comum_evidencias evidencias)
        {
            d_Evidencias.eliminar_evidencias(evidencias);
        }
    }
}
