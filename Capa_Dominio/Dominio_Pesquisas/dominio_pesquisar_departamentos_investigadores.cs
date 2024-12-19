using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Dados.Dados_Pesquisas;

namespace Capa_Dominio.Dominio_Pesquisas
{
    public class dominio_pesquisar_departamentos_investigadores
    {
        dados_pesquisar_departamentos_investigadores d_Departamentos_Investigadores = new dados_pesquisar_departamentos_investigadores();
        public DataTable pesquisar_Departamento_Investigador(string chave)
        {
            return d_Departamentos_Investigadores.pesquisar_Depertamentos_Investigadores(chave);
        }
    }
}
