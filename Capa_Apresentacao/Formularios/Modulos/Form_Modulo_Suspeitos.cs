﻿using Capa_Apresentacao.Formularios.Lista_Formularios;
using Capa_Apresentacao.Formularios.Modulos.Validacao_Campos_Formularios;
using Capa_Comum.Comum_Permissoes.Cache;
using Capa_Comum.Entidades;
using Capa_Dominio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Apresentacao.Formularios.Modulos
{
    public partial class Form_Modulo_Suspeitos : Form
    {
        #region Instanciar as classes e os métodos
        dominio_suspeitos d_Suspeito = new dominio_suspeitos();
        e_comum_suspeitos c_Suspeito = new e_comum_suspeitos();
        dominio_continentes d_Continentes = new dominio_continentes();
        dominio_paises d_Paises = new dominio_paises();
        dominio_provincias d_Provincias = new dominio_provincias();
        dominio_municipios d_Municipios = new dominio_municipios();
        dominio_bairro_rua d_Bairro_Ruas = new dominio_bairro_rua();
        dominio_niveis_academicos d_Nivel_Academino = new dominio_niveis_academicos();
        dominio_cursos d_Curso = new dominio_cursos();
        dominio_casos d_Caso = new dominio_casos();
        #endregion
        Form_Lista_Suspeitos suspeitos;
        public Form_Modulo_Suspeitos(Form_Lista_Suspeitos suspeitos)
        {
            InitializeComponent();
            filtrar();
            this.suspeitos = suspeitos;
        }
        #region Método para selecionar os dados e trazê-los nos seus respectivos comboBox´s
        private void filtrar()
        {
            // buscarS continentes
            text_continente.DataSource = d_Continentes.selecionar_continentes_combobox();
            text_continente.DisplayMember = "nome";
            text_continente.ValueMember = "id_continente";
            // buscar paises
            text_pais.DataSource = d_Paises.selecionar_paises_comboBox();
            text_pais.DisplayMember = "nome";
            text_pais.ValueMember = "id_pais";
            // buscar provincias
            text_provincias.DataSource = d_Provincias.selecionar_provincias_ComboBox();
            text_provincias.DisplayMember = "nome";
            text_provincias.ValueMember = "id_provincia";
            // buscar municipios
            text_municipio.DataSource = d_Municipios.selecionar_municipios_comboBox();
            text_municipio.DisplayMember = "nome";
            text_municipio.ValueMember = "id_municipio";
            // buscar bairros/ruas
            text_bairro_rua.DataSource = d_Bairro_Ruas.selecionar_bairros_ruas_combobox();
            text_bairro_rua.DisplayMember = "nome";
            text_bairro_rua.ValueMember = "id_bairro_rua";
            // buscar nivel casos
            text_caso.DataSource = d_Caso.selecionar_Casos_Combo_Box();
            text_caso.DisplayMember = "titulo";
            text_caso.ValueMember = "id_caso";
            // buscar nivel academico
            text_nivel_academico.DataSource = d_Nivel_Academino.selecionar_niveis_academicos_combo_box();
            text_nivel_academico.DisplayMember = "nome";
            text_nivel_academico.ValueMember = "id_nivel_academico";
            // buscar curso
            text_curso.DataSource = d_Curso.selecionar_Cursos_Combo_Box();
            text_curso.DisplayMember = "nome";
            text_curso.ValueMember = "id_curso";
        }
        #endregion
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CapturarDadosDigitadosFormulario()
        {
            // Capturar os dados do formulário
            int id_Caso = Convert.ToInt32(text_caso.SelectedValue);
            int id_Continente = Convert.ToInt32(text_continente.SelectedValue);
            int id_Pais = Convert.ToInt32(text_pais.SelectedValue);
            int id_Provincia = Convert.ToInt32(text_provincias.SelectedValue);
            int id_Municipio = Convert.ToInt32(text_municipio.SelectedValue);
            int id_Bairro_Rua = Convert.ToInt32(text_bairro_rua.SelectedValue);
            int id_Nivel_Academico = Convert.ToInt32(text_nivel_academico.SelectedValue);
            int id_Curso = Convert.ToInt32(text_curso.SelectedValue);
            int id_Usuario = comum_cache_permissoes_usuarios.cache_inicio_sessao.id_usuario;
            string primeiro_Nome = text_primeiro_nome.Text;
            string nome_Meio = text_nome_meio.Text;
            string ultimo_nome = text_ultimo_nome.Text;
            DateTime data_Nascimento = text_data_nascimento.Value;
            string sexo = text_sexo.Text;
            string primeiro_Numero_Telefone = text_primerio_numero_telefone.Text;
            string segundo_Numero_Telefone = text_segundo_numero_telefone.Text;
            string E_Mail = text_e_mail.Text;
            string declaracao = text_declaracao.Text;
            // Salvar os dados capturados
            c_Suspeito.id_caso = id_Caso;
            c_Suspeito.id_continente = id_Continente;
            c_Suspeito.id_pais = id_Pais;
            c_Suspeito.id_provincia = id_Provincia;
            c_Suspeito.id_municipio = id_Municipio;
            c_Suspeito.id_bairro_rua = id_Bairro_Rua;
            c_Suspeito.id_nivel_academico = id_Nivel_Academico;
            c_Suspeito.id_curso = id_Curso;
            c_Suspeito.id_usuario = id_Usuario;
            c_Suspeito.primeiro_nome = primeiro_Nome;
            c_Suspeito.nome_meio = nome_Meio;
            c_Suspeito.ultimo_nome = ultimo_nome;
            c_Suspeito.data_nascimento = data_Nascimento;
            c_Suspeito.sexo = sexo;
            c_Suspeito.telefone1 = primeiro_Numero_Telefone;
            c_Suspeito.telefone2 = segundo_Numero_Telefone;
            c_Suspeito.e_mail = E_Mail;
            c_Suspeito.descricao = declaracao;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data_Registro = DateTime.Now;
                DateTime data_Atualizacao = DateTime.Now;
                c_Suspeito.data_registro = data_Registro;
                c_Suspeito.data_atualizacao = data_Atualizacao;
                CapturarDadosDigitadosFormulario();
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de registrar este suspeito?", "Mensagem de registro") == DialogResult.Yes)
                {
                    d_Suspeito.inserir_suspeitos(c_Suspeito);
                    guna2MessageDialog_Inform.Show($"O suspeito {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi registrado com sucesso",
                        "Registro bem sucedido");
                    suspeitos.selecionar_Suspeitos();
                    limpar_Campos();
                }
            }
            //catch (SqlException ex)
            //{
            //    MessageDialog_Error.Show(ex.Message);
            //}

            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não foi possível salvar este suspeito!", Ex.Message);
            }
        }
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_Suspeito = Convert.ToInt32(label_id.Text);
                DateTime data_Atualizacao = DateTime.Now;
                c_Suspeito.data_atualizacao = data_Atualizacao;
                CapturarDadosDigitadosFormulario();
                c_Suspeito.id_suspeito = id_Suspeito;
                if (guna2MessageDialog_Confirm.Show("Tens a certeza de atualizar esta vítima?", "Mensagem de atualização") == DialogResult.Yes)
                {
                    d_Suspeito.atualizar_suspeitos(c_Suspeito);
                    guna2MessageDialog_Inform.Show($"O suspeito {text_primeiro_nome.Text + " " + text_ultimo_nome.Text} foi atualizado com sucesso!",
                        "Atualização bem sucedida");
                    limpar_Campos();
                    suspeitos.selecionar_Suspeitos();
                    this.Dispose();
                }
            }
            //catch (SqlException ex)
            //{
            //    MessageDialog_Error.Show(ex.Message);

            //}
            catch (Exception Ex)
            {
                MessageDialog_Error.Show("Não foi possível atualizar este suspeito!", Ex.Message);
            }
    }
    private void limpar_Campos()
    {
        text_caso.Text = String.Empty;
        text_continente.Text = String.Empty;
        text_pais.Text = String.Empty;
        text_provincias.Text = String.Empty;
        text_municipio.Text = String.Empty;
        text_bairro_rua.Text = String.Empty;
        text_nivel_academico.Text = String.Empty;
        text_curso.Text = String.Empty;
        text_primeiro_nome.Text = String.Empty;
        text_nome_meio.Text = String.Empty;
        text_ultimo_nome.Text = String.Empty;
        text_data_nascimento.Value = DateTime.Now;
        text_sexo.Text = String.Empty;
        text_primerio_numero_telefone.Text = String.Empty;
        text_segundo_numero_telefone.Text = String.Empty;
        text_e_mail.Text = String.Empty;
        text_declaracao.Text = String.Empty;
    }
    private void btn_Limpar_Click(object sender, EventArgs e)
    {
        limpar_Campos();
    }
    private void text_primeiro_nome_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_primeiro_nome, label_msg_primeiro_nome, "Apenas letras são permitidas!");
    }
    private void text_nome_meio_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_nome_meio, label_msg_nome_meio, "Apenas letras são permitidas!");
    }
    private void text_ultimo_nome_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarTexto(e, text_ultimo_nome, label_msg_ultimo_nome, "Apenas letras são permitidas!");
    }
    private void text_primerio_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_primerio_numero_telefone, label_msg_primeiro_telefone, "Apenas números são permitidas!");
    }
    private void text_segundo_numero_telefone_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarNumero(e, text_segundo_numero_telefone, label_msg_segundo_telefone, "Apenas números são permitidas!");
    }
    private void text_e_mail_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidadorCampos.ValidarEmail(text_e_mail, label_msg_email, "Email inválido!");
    }
    private void text_declaracao_KeyPress(object sender, KeyPressEventArgs e)
    {
        validacao_campos_formularios.ValidarTextoDescricao(e, text_declaracao, label_msg_descricao, "Apenas letras e alguns caracteres são permitidos!");
    }
}
}
