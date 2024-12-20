
using Capa_Comum.Entidades;
using Capa_Dados;
using System.Data;
using Capa_Dominio.Dominio_Validacoes;


namespace Capa_Dominio
{
    public class dominio_usuarios : Validacoes
    {
        dados_usuarios d_usuarios = new dados_usuarios();
        public DataTable selecionar_usuarios()
        {
            return d_usuarios.selecionar_usuarios();
        }
        //Validade a quantidade de letras no campo
        private void validacacoes(e_comum_usuarios usuarios)
        {
            Validadar_Nomes_Gerais(usuarios.primeiro_nome, "[ERRO] - O campo 'Primeiro nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(usuarios.nome_meio, "[ERRO] - O campo 'Nome do meio', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Nomes_Gerais(usuarios.ultimo_nome, "[ERRO] - O campo 'Último nome', deve conter somente letras e ter no mínimo 3 caracteres.");
            Validadar_Telefone(usuarios.telefone1);
            Validadar_Telefone(usuarios.telefone2);
            Validar_Bilhete_Identidade(usuarios.bi);
            Validar_Palavra_Passe(usuarios.palavra_passe);
        }
        public void inserir_usuarios(e_comum_usuarios usuarios)
        {
            validacacoes(usuarios);
            d_usuarios.registrar_usuarios(usuarios);
        }
        public void atualizar_usuarios(e_comum_usuarios usuarios)
        {
            validacacoes(usuarios);
            d_usuarios.atualizar_usuarios(usuarios);
        }
        public void eliminar_usuarios(e_comum_usuarios usuarios)
        {
            d_usuarios.eliminar_usuarios(usuarios);
        }
    }
}
