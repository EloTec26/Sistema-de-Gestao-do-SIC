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
    public class dominio_cursos
    {
        dados_cursos d_Cursos = new dados_cursos();
        public DataTable selecionar_Cursos_Combo_Box()
        {
            return d_Cursos.selecionar_cursos_combo_box();
        }
        public DataTable selecionar_Cursos()
        {
            return d_Cursos.selecionar_cursos();
        }
        public void inserir_Cursos(e_comum_cursos cursos)
        {
            try
            {
                d_Cursos.inserir_cursos(cursos);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do curso já está registrado. Por favor, insira um curso diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void atualizar_Cursos(e_comum_cursos cursos)
        {
            try
            {
                d_Cursos.atualizar_cursos(cursos);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE")) // Verifica se a exceção está relacionada à restrição UNIQUE
                {
                    throw new Exception("O nome do curso já está registrado. Por favor, insira um curso diferente.");
                }
                else
                {
                    throw; // Se for outro tipo de exceção, relançá-la
                }
            }
        }
        public void eliminar_Cursos(e_comum_cursos cursos)
        {
            d_Cursos.eliminar_cursos(cursos);
        }
    }
}
