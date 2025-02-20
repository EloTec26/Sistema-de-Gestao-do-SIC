
-- Criar a base de dados
create database sic_menongue;
go
-- Usar a base de dados
use sic_menongue;
go

select * from continente_tbl;
delete from bairro_rua_tbl where id_bairro_rua = 1002
update bairro_rua_tbl set nome = 'Saúde' where id_bairro_rua=2
----------------------- Criar as tabelas do banco de dados----------------
------- tabela de continentes
create table continente_tbl (
	id_continente int identity (1,1) primary key,
	nome varchar (25) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
);

go
---
insert into continente_tbl (nome, data_registro, data_atualizacao) values ('África', '2024-07-07 19:15:25.000', '2024-07-07 19:15:25.000')
alter table continente_tbl add UNIQUE (nome);
select * from continente_tbl;
delete from continente_tbl where id_continente = 1010
------ tabela de países
create table pais_tbl(
	id_pais int identity (1,1) primary key,
	id_continente int not null,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	--- estabelecer relacionamento
	foreign key (id_continente) references continente_tbl (id_continente)
);
go
alter table pais_tbl add UNIQUE (nome);
-------------------Elimina dados duplicados, mantendo somente 1.
WITH CTE AS (
    SELECT
        id_provincia,
        nome,
        ROW_NUMBER() OVER (PARTITION BY nome ORDER BY id_provincia) AS row_num
    FROM provincia_tbl
)
DELETE FROM CTE
WHERE row_num > 1;

-------------------Fim de elimina dados duplicados, mantendo somente 1.
------ tabela de províncias
select * from municipio_tbl

insert into provincia_tbl values
       (1, 'AA', '2024-07-08 17:23:11.000', '2024-10-05 12:34:06.403')

alter table provincia_tbl add UNIQUE (nome);
create table provincia_tbl(
	id_provincia int identity (1,1) primary key,
	id_pais int not null,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	--- estabelecer relacionamento
	foreign key (id_pais) references pais_tbl (id_pais)
);
go
----- tabela de municípios
alter table municipio_tbl add UNIQUE (nome);
create table municipio_tbl(
	id_municipio int identity (1,1) primary key,
	id_provincia int not null,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	--- estabelecer relacionamento
	foreign key (id_provincia) references provincia_tbl (id_provincia)
);
go
alter table bairro_rua_tbl add UNIQUE (nome);
----- tabela de bairros/ruas
create table bairro_rua_tbl (
	id_bairro_rua int identity (1,1) primary key,
	id_municipio int not null,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	---- estabelecer relacionamento
	foreign key (id_municipio) references municipio_tbl (id_municipio)
);
go
----- tabela de cargos
alter table cargo_tbl add UNIQUE (nome);
create table cargo_tbl(
	id_cargo int identity (1,1) primary key,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
);
go
select * from cargo_tbl
--- alterar a tabele cargos e adicionar o id_usuario
alter table cargo_tbl add id_usuario int foreign key (id_usuario) references usuario_tbl (id_usuario);
-----  tabela de níveis acadêmicos
alter table nivel_academico_tbl add UNIQUE (nome);
create table nivel_academico_tbl(
	id_nivel_academico int identity (1,1) primary key,
	nome varchar (100) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
)
---- tabela de cursos
alter table curso_tbl add UNIQUE (nome);
create table curso_tbl (
	id_curso int identity (1,1) primary key,
	nome varchar (100) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
);
go
select * from especialidade_tbl;
---- tabele especialidade
alter table especialidade_tbl add UNIQUE (nome);
create table especialidade_tbl (
	id_especialidade int identity (1,1) primary key,
	nome varchar (100) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
);
--- adicionar a coluna do id_curso, para efectuar o relacionamento.
alter table especialidade_tbl add id_curso int
			foreign key (id_curso) references curso_tbl (id_curso);
go
select * from curso_tbl
----- tabela de tipos de usuários
create table tipo_usuario_tbl (
	id_tipo_usuario int identity (1,1) primary key,
	nome varchar (50) not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
);
go
alter table usuario_tbl add UNIQUE (bi);
alter table usuario_tbl add UNIQUE (telefone1);
alter table usuario_tbl add UNIQUE (telefone2);
alter table usuario_tbl add UNIQUE (palavra_passe);
alter table usuario_tbl add UNIQUE (e_mail);
-----  tabela de usuarios
create table usuario_tbl (
	id_usuario int identity (1,1) primary key,
	id_continente int not null,
	id_pais int not null,
	id_provincia int not null,
	id_municipio int not null,
	id_bairro_rua int not null,
	id_tipo_usuario int not null,

	primeiro_nome varchar (50) not null,
	nome_meio varchar (50) null,
	ultimo_nome varchar (50) not null,
	data_nascimento date not null,
	bi varchar (20) not null,
	sexo varchar (15) not null,
	telefone1 varchar (9) not null,
	telefone2 varchar (9) not null,
	e_mail varchar (100) null,
	palavra_passe varchar (100) not null

	--- estabelecer relacionamentos
	foreign key (id_continente) references continente_tbl (id_continente),
	foreign key (id_pais) references pais_tbl (id_pais),
	foreign key (id_provincia) references provincia_tbl (id_provincia),
	foreign key (id_municipio) references municipio_tbl (id_municipio),
	foreign key (id_bairro_rua) references bairro_rua_tbl (id_bairro_rua),
	foreign key (id_tipo_usuario) references tipo_usuario_tbl (id_tipo_usuario)
);
go
select * from usuario_tbl
ALTER TABLE usuario_tbl
ADD tentativas_login INT DEFAULT 0,
    ultima_tentativa_login DATETIME;
---------------Procedimento armazendo para o bloqueio de usuário por tentivas
CREATE PROCEDURE iniciar_Sessao
    @palavra_passe VARCHAR(100)
AS
BEGIN
    DECLARE @tentativas_login INT
    DECLARE @id_usuario INT

    -- Verificar se a senha existe
    SELECT @tentativas_login = tentativas_login,
           @id_usuario = id_usuario
    FROM usuario_tbl
    WHERE palavra_passe = @palavra_passe

    -- Verificar se encontrou o usuário
    IF @id_usuario IS NULL
    BEGIN
        -- Incrementar tentativas falhadas se a senha estiver errada
        UPDATE usuario_tbl
        SET tentativas_login = tentativas_login + 1
        WHERE palavra_passe = @palavra_passe

        RAISERROR ('Senha inválida', 16, 1)
        RETURN
    END

    -- Verificar tentativas falhadas
    IF @tentativas_login >= 3
    BEGIN
        RAISERROR ('Conta bloqueada devido a muitas tentativas de login falhadas', 16, 1)
        RETURN
    END

    -- Resetar tentativas falhadas após login bem-sucedido
    UPDATE usuario_tbl
    SET tentativas_login = 0
    WHERE id_usuario = @id_usuario

    -- Selecionar as informações do usuário
    SELECT id_usuario, id_continente, id_pais, id_provincia, id_municipio, id_bairro_rua, primeiro_nome,
           nome_meio, ultimo_nome, bi, sexo, telefone1, telefone2, e_mail, tipo_usuario, palavra_passe,tentativas_login
    FROM usuario_tbl
    WHERE id_usuario = @id_usuario
END
GO
---------==========================================------------
CREATE PROCEDURE iniciar_Sessao1
    @palavra_passe VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @tentativas INT;

    -- Verificar o número de tentativas falhadas
    SELECT @tentativas = tentativas_login
    FROM usuario_tbl
    WHERE palavra_passe = @palavra_passe;

    -- Se as tentativas forem maiores ou iguais a 3, bloquear a conta
    IF @tentativas >= 3
    BEGIN
        RAISERROR ('Conta bloqueada devido a muitas tentativas de login falhadas', 16, 1);
        RETURN;
    END

    -- Verificar se a senha está correta
    IF EXISTS (SELECT 1 FROM usuario_tbl WHERE palavra_passe = @palavra_passe)
    BEGIN
        -- Login bem-sucedido
        SELECT id_usuario, id_continente, id_pais, id_provincia, id_municipio, id_bairro_rua, primeiro_nome, nome_meio, ultimo_nome, bi, sexo, telefone1, telefone2, e_mail, tipo_usuario, palavra_passe, tentativas_login
        FROM usuario_tbl
        WHERE palavra_passe = @palavra_passe;

        -- Redefinir tentativas falhadas após login bem-sucedido
        UPDATE usuario_tbl
        SET tentativas_login = 0
        WHERE palavra_passe = @palavra_passe;
    END
    ELSE
    BEGIN
        -- Incrementar tentativas falhadas após login mal-sucedido
        UPDATE usuario_tbl
        SET tentativas_login = tentativas_login + 1
        WHERE palavra_passe = @palavra_passe;

        -- Lançar erro para senha inválida
        RAISERROR ('Senha inválida', 16, 1);
    END
END
GO
select
	u.id_usuario[Id],
	u.primeiro_nome + ' '+ u.nome_meio +' '+ u.ultimo_nome [Nome completo],
	c.nome +'; '+ p.nome +'; '+ pv.nome +'; '+ m.nome +'; '+ b.nome [Endereço]

	from usuario_tbl u
inner join continente_tbl c on c.id_continente =  u.id_continente
inner join pais_tbl p on p.id_pais = u.id_pais
inner join provincia_tbl pv on pv.id_provincia = u.id_provincia
inner join municipio_tbl m on m.id_municipio = u.id_municipio
inner join bairro_rua_tbl b on b.id_bairro_rua  = u.id_bairro_rua
----


------------========================================------------
-- Alterar a tabela patente_tbl e adicionar a restrição UNIQUE
alter table patente_tbl add UNIQUE (nome);
----- tabela de patentes
create table patente_tbl (
	id_patente int identity (1,1) primary key,
	id_usuario int not null,
	nome varchar (50) not null,
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	---- estabelecer relacionamento
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
-- Alterar a tabela de investigadores e adicionar a restrição UNIQUE
alter table investigador_tbl add UNIQUE (bi);
alter table investigador_tbl add UNIQUE (telefone1);
alter table investigador_tbl add UNIQUE (telefone2);
alter table investigador_tbl add UNIQUE (e_mail);


---- tabela de investigadores
create table investigador_tbl (
	id_investigador int identity (1,1) primary key,
	id_continente int not null,
	id_pais int not null,
	id_provincia int not null,
	id_municipio int not null,
	id_bairro_rua int not null,
	id_nivel_academico int not null,
	id_curso int null,
	id_especialidade int null,
	id_patente int not null,
	id_usuario int not null,
	primeiro_nome varchar (50) not null,
	nome_meio varchar (50) null,
	ultimo_nome varchar (50) not null,
	data_nascimento date not null,
	sexo varchar (15) not null,
	bi varchar (20) not null,
	telefone1 varchar (9) not null,
	telefone2 varchar (9) null,
	e_mail varchar (100) null,
	data_inicio_contrato date not null,
	data_fim_contrato date not null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabelecer relacionamentos
	foreign key (id_continente) references continente_tbl (id_continente),
	foreign key (id_pais) references pais_tbl (id_pais),
	foreign key (id_provincia) references provincia_tbl (id_provincia),
	foreign key (id_municipio) references municipio_tbl (id_municipio),
	foreign key (id_bairro_rua) references bairro_rua_tbl (id_bairro_rua),
	foreign key (id_nivel_academico) references nivel_academico_tbl(id_nivel_academico),
	foreign key (id_curso) references curso_tbl(id_curso),
	foreign key (id_especialidade) references especialidade_tbl (id_especialidade),
	foreign key (id_patente) references patente_tbl (id_patente),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
---- tabela departamento_investigadores (relacionamento m:m)
create table departamento_investigador_tbl(
	id_departamento_investigador int identity (1, 1) primary key,
	id_investigador int not null,
	id_departamento int not null,
	id_usuario int not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	foreign key (id_departamento) references departamento_tbl (id_departamento),
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
---- tabela cargos_investigadores (relacionamento m:m)
create table cargo_investigador_tbl(
	id_cargo_investigador int identity (1,1) primary key,
	id_cargo int not null,
	id_investigador int not null,
	id_usuario int not null,
	data_registro datetime not null,
	data_atualizacao datetime not null
	--- estabelecer relacionamentos
	foreign key (id_cargo) references cargo_tbl (id_cargo),
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
----- tabela de casos
create table caso_tbl(
	id_caso int identity (1,1) primary key,
	id_investigador int not null,
	id_departamento int not null,
	id_usuario int not null,
	titulo varchar (100) not null,
	data_abertura date not null,
	data_fechamento date not null,
	estado varchar (20) not null, -- aberto, em andamento, encerrado
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabecer relacionamentos
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_departamento) references departamento_tbl (id_departamento),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
select * from usuario_tbl;

-- Alterar a tablela de suspeitos e adicionar a rstrição UNIQUE
alter table suspeito_tbl add UNIQUE (telefone1);
alter table suspeito_tbl add UNIQUE (telefone2);
alter table suspeito_tbl add UNIQUE (e_mail);
----- tabela de suspeitos
create table suspeito_tbl (
	id_suspeito int identity (1,1) primary key,
	id_caso int not null,
	id_continente int not null,
	id_pais int not null,
	id_provincia int not null,
	id_municipio int not null,
	id_bairro_rua int not null,
	id_nivel_academico int not null,
	id_curso int not null,
	id_usuario int not null,
	primeiro_nome varchar (50) not null,
	nome_meio varchar (50) null,
	ultimo_nome varchar (50) not null,
	data_nascimento date not null,
	sexo varchar (15) not null,
	telefone1 varchar (9) not null,
	telefone2 varchar (9) null,
	e_mail varchar (100) null,
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabelecer relacionamentos
	foreign key (id_caso) references caso_tbl (id_caso),
	foreign key (id_continente) references continente_tbl (id_continente),
	foreign key (id_pais) references pais_tbl (id_pais),
	foreign key (id_provincia) references provincia_tbl (id_provincia),
	foreign key (id_municipio) references municipio_tbl (id_municipio),
	foreign key (id_bairro_rua) references bairro_rua_tbl (id_bairro_rua),
	foreign key (id_nivel_academico) references nivel_academico_tbl(id_nivel_academico),
	foreign key (id_curso) references curso_tbl(id_curso),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
alter table vitima_tbl add UNIQUE (telefone1);
alter table vitima_tbl add UNIQUE (telefone2);
alter table vitima_tbl add UNIQUE (e_mail);
select * from vitima_tbl;

update vitima_tbl set e_mail = 'adao@gmail.com' where id_vitima = 8;

--- Tabela de vítimas
create table vitima_tbl (
	id_vitima int identity (1,1) primary key,
	id_caso int not null,
	id_continente int not null,
	id_pais int not  null,
	id_provincia int not null,
	id_municipio int not null,
	id_bairro_rua int not null,
	id_nivel_academico int not null,
	id_curso int not null,
	id_usuario int not null,
	primeiro_nome varchar (50) not null,
	nome_meio varchar (50) null,
	ultimo_nome varchar (50) not null,
	data_nascimento date not null,
	sexo varchar (15) not null,
	telefone1 varchar (9) not null,
	telefone2 varchar (9) null,
	e_mail varchar (100) null,
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabelecer relacionamentos
	foreign key (id_caso) references caso_tbl (id_caso),
	foreign key (id_continente) references continente_tbl (id_continente),
	foreign key (id_pais) references pais_tbl (id_pais),
	foreign key (id_provincia) references provincia_tbl (id_provincia),
	foreign key (id_municipio) references municipio_tbl (id_municipio),
	foreign key (id_bairro_rua) references bairro_rua_tbl (id_bairro_rua),
	foreign key (id_nivel_academico) references nivel_academico_tbl(id_nivel_academico),
	foreign key (id_curso) references curso_tbl(id_curso),
	foreign key (id_usuario) references usuario_tbl (id_usuario)

);
go

---- Tabela de evidências
create table evidencia_tbl (
	id_evidencia int identity (1,1) primary key,
	id_investigador int not null,
	id_caso int not  null,
	id_usuario int not null,
	tipo varchar (100) not null,
	descricao text null,
	data_coleta date not null,
	local_armazenamento varchar (255) null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabelecer relacionamento
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_caso) references caso_tbl (id_caso),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
-- Alterar a tabela de testemunha e adicionar a restrição UNIQUE.
alter table testemunha_tbl add UNIQUE (telefone1);
alter table testemunha_tbl add UNIQUE (telefone2);
alter table testemunha_tbl add UNIQUE (e_mail);

----- tabela de testemunhas
create table testemunha_tbl (
	id_testemunha int identity (1,1) primary key,
	id_caso int not null,
	id_continente int not null,
	id_pais int not null,
	id_provincia int not null,
	id_municipio int not null,
	id_bairro_rua int not null,
	id_nivel_academico int not null,
	id_curso int not null,
	id_usuario int not null,
	primeiro_nome varchar (50) not null,
	nome_meio varchar (50) null,
	ultimo_nome varchar (50) not null,
	data_nascimento date not null,
	sexo varchar (15) not null,
	telefone1 varchar (9) not null,
	telefone2 varchar (9) null,
	e_mail varchar (100) null,
	declaracao text not null, -- o que a testemunha disse...
	data_registro datetime not null,
	data_atualizacao datetime not null

	--- estabelecer relacionamentos
	foreign key (id_caso) references caso_tbl (id_caso),
	foreign key (id_continente) references continente_tbl (id_continente),
	foreign key (id_pais) references pais_tbl (id_pais),
	foreign key (id_provincia) references provincia_tbl (id_provincia),
	foreign key (id_municipio) references municipio_tbl (id_municipio),
	foreign key (id_bairro_rua) references bairro_rua_tbl (id_bairro_rua),
	foreign key (id_nivel_academico) references nivel_academico_tbl(id_nivel_academico),
	foreign key (id_curso) references curso_tbl(id_curso),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go

----- tabela dos eventos dos casos (os dias em que ocorrem os julgamentos)
create table evento_caso_tbl (
	id_evento_caso int identity (1,1) primary key,
	id_caso int not null,
	id_investigador int not null,
	id_vitima int not null,
	id_testemunha int not null,
	id_usuario int not null,
	data_evento date not null,
	tipo_evento varchar (255) not null, -- interrogatório, coleta de evidencias...
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not  null

	--- estabelecer relacionamentos
	foreign key (id_caso) references caso_tbl (id_caso),
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_vitima) references vitima_tbl (id_vitima),
	foreign key (id_testemunha) references testemunha_tbl (id_testemunha),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
alter table evento_caso_tbl add id_suspeito int foreign key (id_suspeito) references suspeito_tbl (id_suspeito)

------- tabela de faltas
create table falta_tbl(
	id_falta int identity (1,1) primary key,
	id_investigador int not null,
	id_usuario int not null,
	data_falta date not null,
	descricao text, -- motivo da falta.
	data_registro datetime not null,
	data_atualizacao datetime not null

	---- estabelecer relacionamentos
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
------- tabela de férias
create table feria_tbl(
	id_feria int identity (1,1) primary key,
	id_investigador int not null,
	id_usuario int not null,
	data_inicio date not null,
	data_fim date not null,
	descricao text not null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	---- estabelecer relacionamentos
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
------- tabela afastamentos
create table afastamento_tbl (
	id_afastamento int identity (1,1) primary key,
	id_investigador int not null,
	id_usuario int not null,
	data_inicio date not null,
	data_fim date not null,
	descricao text null, -- motivo do afastamento (doenças, licença de parto[mulheres], etc...)
	data_registro datetime not null,
	data_atualizacao datetime not null

	---- estabelecer relacionamentos
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
------- tabela beneficios
create table beneficio_tbl (
	id_beneficio int identity (1, 1) primary key,
	id_usuario int not null,
	nome varchar (50) not null,
	descricao text null,
	data_registro datetime not null,
	data_atualizacao datetime not null

	---- estabelecer relacionamentos
	foreign key (id_usuario) references usuario_tbl (id_usuario)

);
go
------- tabela de beneficios_investigadores (m:m)

create table beneficio_investigador_tbl (
	id_beneficio_investigador int identity(1,1) primary key,
	id_beneficio int not null,
	id_investigador int not null,
	id_usuario int not null,
	data_inicio date not null,
	data_fim date not null,
	data_registro datetime not null,
	data_atualizacao datetime  not null

	---- estabelecer relacionamentos
	foreign key (id_beneficio) references beneficio_tbl (id_beneficio),
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go
------- tabela de horas extras
create table hora_extra (
	id_hora_extra int identity (1,1) primary key,
	id_investigador int not null,
	id_usuario int not null,
	dia int not null,
	mes varchar (15) not null,
	ano int not null,
	horas_trabalhadas decimal (5,2) not null,
	tipo_horas varchar (50) not null, -- matinal, vespertino, noturno......
	data_registro datetime not null,
	data_atualizacao datetime not null
	---- estabelecer relacionamentos
	foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
);
go



select * from municipio_tbl

-- Criar a tabela de treinamentos
create table treinamento_tbl(
    id_treinamento int identity(100, 1) primary key,
    id_departamento int not null,
    id_investigador int not null,
	id_usuario int not null,
    titulo varchar (100) not null,
    descricao text,
    data_inicio date not null,
    data_fim date not null,
    data_registro datetime not null default getdate(),
    data_atualizacao datetime not null default getdate(),
    foreign key (id_departamento) references departamento_tbl (id_departamento),
    foreign key (id_investigador) references investigador_tbl (id_investigador),
	foreign key (id_usuario) references usuario_tbl (id_usuario)
)
go

















/*
	Criar os procedimentos armazenados
	para [LISTAR, INSERIR, ATUALIZAR E DELETAR]
	no banco de dados [sic_menongue]
*/
--====================================================
/*

	Procedimentos armazendaos para a tabela de treinamento
*/
exec selecionar_treinamentos;
select * from treinamento_tbl;
create proc selecionar_treinamentos
as
select tr.id_treinamento [Id],
       tr.titulo [Título],
	   CONCAT(inv.primeiro_nome,' ',inv.nome_meio,' ',inv.ultimo_nome)[Investigador],
	   dep.nome [Departamento],
	   tr.data_inicio[Data inicial],
	   tr.data_fim[Data final],
	   tr.descricao[Descrição],
	   concat(us.primeiro_nome,' ', us.nome_meio,' ',us.ultimo_nome)[Registrado por],
	   tr.data_registro[Data de registro],
	   tr.data_atualizacao[Última atualização]
     from treinamento_tbl tr
inner join departamento_tbl dep on dep.id_departamento = tr.id_departamento
inner join investigador_tbl inv on inv.id_investigador = tr.id_investigador
inner join usuario_tbl us on us.id_usuario = tr.id_usuario
order by tr.id_treinamento
go
--- Pesquisar treinamentos
create proc pesquisar_treinamentos
	@chave varchar (10)
as
select tr.id_treinamento [Id],
       tr.titulo [Título],
	   concat(inv.primeiro_nome,' ',inv.nome_meio,' ',inv.ultimo_nome)[Investigador],
	   dep.nome [Departamento],
	   tr.data_inicio[Data inicial],
	   tr.data_fim[Data final],
	   tr.descricao[Descrição],
	   concat(us.primeiro_nome,' ', us.nome_meio,' ',us.ultimo_nome)[Registrado por],
	   tr.data_registro[Data de registro],
	   tr.data_atualizacao[Última atualização]
     from treinamento_tbl tr
inner join departamento_tbl dep on dep.id_departamento = tr.id_departamento
inner join investigador_tbl inv on inv.id_investigador = tr.id_investigador
inner join usuario_tbl us on us.id_usuario = tr.id_usuario
where
	  tr.id_treinamento like '%'+@chave+'%' or
	  tr.titulo like '%'+@chave+'%' or
	  concat(inv.primeiro_nome,' ',inv.nome_meio,' ',inv.ultimo_nome) like '%'+@chave+'%'
order by tr.id_treinamento
go
select * from treinamento_tbl;
--- Cadastrar treinamentos
create proc inserir_treinamentos
	@id_departamento int,
	@id_investigador int,
	@id_usuario int,
	@titulo varchar (100),
	@descricao text,
	@data_inicio date,
	@data_fim date,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into treinamento_tbl (id_departamento, id_investigador, id_usuario, titulo, descricao, data_inicio, data_fim, data_registro, data_atualizacao)
      values (@id_departamento, @id_investigador, @id_usuario, @titulo, @descricao, @data_inicio, @data_fim, @data_registro, @data_atualizacao)
go
select * from usuario_tbl
--- Atualizar treinamentos
drop proc atualizar_treinamentos;
create proc atualizar_treinamentos
	@id_treinamento int,
	@id_departamento int,
	@id_investigador int,
	@id_usuario int,
	@titulo varchar (100),
	@descricao text,
	@data_inicio date,
	@data_fim date,
	@data_atualizacao datetime
as
update treinamento_tbl set
	id_departamento=@id_departamento,
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	titulo=@titulo,
	descricao=@descricao,
	data_inicio=@data_inicio,
	data_fim=@data_fim,
	data_atualizacao=@data_atualizacao
where id_treinamento=@id_treinamento
go
--- Eliminar treinamentos
create proc eliminar_treinamentos
	@id_treinamento int
as
delete from treinamento_tbl where id_treinamento=@id_treinamento
go
/*
	procedimentos armazenados para a tabela
	de continentes
*/
------- selecionar
exec selecionar_continentes
create proc selecionar_continentes
as
	select cont.id_continente[Id],
		cont.nome[Nome],
		cont.data_registro[Registrado aos],
		cont.data_atualizacao[Atualizado aos]
	from continente_tbl cont
go
------ inserir
create proc inserir_continentes
 @nome varchar (25),
 @data_registro datetime,
 @data_atualizacao datetime
as
insert into continente_tbl values
						(@nome,
						 @data_registro,
						 @data_atualizacao
						 )
go
------ atualizar
create proc atualizar_continentes
 @id_continente int,
 @nome varchar (25),
 @data_atualizacao datetime
as
update continente_tbl set
				nome=@nome,
				data_atualizacao=@data_atualizacao
				where
				id_continente=@id_continente
go
------ eliminar
create proc eliminar_continentes
@id_continente int
as
delete from continente_tbl
			where
			id_continente=@id_continente
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de países
*/
drop proc selecionar_paises
----- selecionar
create proc selecionar_paises
as
	select
		p.id_pais[Id],
		c.nome[Continente],
		p.nome[País],
		p.data_registro[Data de registro],
		p.data_atualizacao[Data de atualização]
	from
  pais_tbl p
  inner join continente_tbl c on c.id_continente = p.id_continente
go
----- inserir
create proc inserir_paises
 @id_continente int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
insert into pais_tbl values
					(@id_continente,
					 @nome,
					 @data_registro,
					 @data_atualizacao
					 )
go
select * from pais_tbl
----- atualizar
create proc atualizar_paises
 @id_pais int,
 @id_continente int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
update pais_tbl set
	id_continente=@id_continente,
	nome=@nome,
	data_registro=@data_registro,
	data_atualizacao=@data_atualizacao
	where
	id_pais=@id_pais
go

----- eliminar
select * from pais_tbl
select * from provincia_tbl

create proc eliminar_paises
 @id_pais int
as
  delete from pais_tbl
			where
			id_pais=@id_pais
  go
----- pesquisar países
create proc pesquisar_paises
	@chave varchar (50)
as
select p.id_pais[Id],
	   c.nome[continente],
	   p.nome[País],
	   p.data_registro[Data de registro],
	   p.data_atualizacao[Data de atualização]
	from pais_tbl p
	inner join continente_tbl c on c.id_continente = p.id_continente
where
	p.id_pais like '%'+@chave+'%' or
	c.nome like '%'+@chave+'%' or
	p.nome like '%'+@chave+'%'
go
----- pesquisar continentes
create proc pesquisar_continentes
	@chave varchar (50)
as
select * from continente_tbl
			where id_continente like'%'+@chave+'%' or
			      nome like '%'+@chave+'%'
go
---- pesquisar as províncas

create proc pesquisar_provincias
	@chave varchar (50)
as
 select pv.id_provincia[Id],
		p.nome[País],
		pv.nome[Província],
		pv.data_registro[Data de registro],
	    pv.data_atualizacao[Data de atualização]
 from provincia_tbl pv
 inner join pais_tbl p on p.id_pais = pv.id_pais

  where pv.id_provincia like '%'+@chave+'%' or
		      p.id_pais like '%'+@chave+'%' or
			  pv.nome like '%'+@chave+'%'
go
---- Pesquisar municipios
create proc pesquisar_municipios
	@chave varchar (50)
as
select
		m.id_municipio[Id],
		p.nome[Províncias],
		m.nome[Municípios],
		m.data_registro[Data de registro],
		m.data_atualizacao[Data de atualização]
	from municipio_tbl m
inner join provincia_tbl p on p.id_provincia = m.id_provincia
	where
		m.id_municipio like '%'+@chave+'%' or
		p.nome like '%'+@chave+'%' or
		m.nome like '%'+@chave+'%'
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de próvíncias
*/
select * from provincia_tbl
---- selecionar
drop proc selecionar_provincias
create proc selecionar_provincias
as
	select pv.id_provincia[Id],
		   p.nome[País],
		   pv.nome[Província],
		   pv.data_registro[Data de registro],
		   pv.data_atualizacao[Data de atualização]
	from provincia_tbl pv
	inner join pais_tbl p on p.id_pais = pv.id_pais
go
---- inserir
create proc inserir_provincias
 @id_pais int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
insert into provincia_tbl
			values (
			@id_pais,
			@nome,
			@data_registro,
			@data_atualizacao
			)
go
---- atualizar
create proc atualizar_provincias
 @id_provincia int,
 @id_pais int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
update provincia_tbl
				set
				id_pais=@id_pais,
				nome=@nome,
				data_registro=@data_registro,
				data_atualizacao=@data_atualizacao
				where
				id_provincia=@id_provincia
go
---- eliminar
create proc eliminar_provincias
 @id_provincia int
as
	delete from provincia_tbl
				where
				id_provincia=@id_provincia
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de municípios
*/
---- selecionar
drop proc selecionar_municipios
create proc selecionar_municipios
as
	select
		m.id_municipio[Id],
		p.nome[Províncias],
		m.nome[Municípios],
		m.data_registro[Data de registro],
		m.data_atualizacao[Data de atualização]
	from municipio_tbl m
inner join provincia_tbl p on p.id_provincia = m.id_provincia
go
---- inserir
create proc inserir_municipios
 @id_provincia int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
insert into municipio_tbl
			values(
			@id_provincia,
			@nome,
			@data_registro,
			@data_atualizacao
			)
go
---- atualizar
create proc atualizar_municipios
 @id_municipio int,
 @id_provincia int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
update municipio_tbl
					set
					id_provincia=@id_provincia,
					nome=@nome,
					data_registro=@data_registro,
					data_atualizacao=@data_atualizacao
					where
					id_municipio=@id_municipio
go
---- eliminar
drop proc eliminar_municipios
create proc eliminar_municipios
 @id_municipio int
as
delete from municipio_tbl
			where
			id_municipio=@id_municipio
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de bairros_ruas
*/
----- selecionar
drop proc selecionar_bairros_ruas;
create proc selecionar_bairros_ruas
as
select
		b.id_bairro_rua[Id],
		m.nome[Municípios],
		b.nome[Bairros/ruas],
		b.data_registro[Registro aos],
		b.data_atualizacao[Atualizado aos]
		from bairro_rua_tbl b
inner join municipio_tbl m on m.id_municipio = b.id_municipio
go
----- inserir
create proc inserir_bairros_ruas
 @id_municipio int,
 @nome varchar (50),
 @data_registro datetime,
 @data_atualizacao datetime
as
insert into bairro_rua_tbl
					values (
							@id_municipio,
							@nome,
							@data_registro,
							@data_atualizacao
							)
go
drop procedure atualizar_bairros_ruas;
----- atualizar
create proc atualizar_bairros_ruas
 @id_bairro_rua int,
 @id_municipio int,
 @nome varchar (50),
 @data_atualizacao datetime
as
update bairro_rua_tbl set id_municipio=@id_municipio,
						  nome=@nome,
						  data_atualizacao=@data_atualizacao
					      where
						  id_bairro_rua=@id_bairro_rua
go
----- eliminar
create proc eliminar_bairros_ruas
 @id_bairro_rua int
as
delete from bairro_rua_tbl
       where
	   id_bairro_rua=@id_bairro_rua
go
select * from bairro_rua_tbl
---- pesquisar bairros/ruas
drop proc pesquisar_bairros_ruas
create proc pesquisar_bairros_ruas
	@chave varchar (50)
as
 select
		b.id_bairro_rua[Id],
		m.nome[Municípios],
		b.nome[Bairros/ruas],
		b.data_registro[Registrado aos],
		b.data_atualizacao[Atualizado aos]
		from bairro_rua_tbl b
inner join municipio_tbl m on m.id_municipio = b.id_municipio
where
		b.id_bairro_rua like '%'+@chave+'%' or
		m.nome like '%'+@chave+'%' or
		b.nome like '%'+@chave+'%'
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de usuarios
*/
---- selecionar
exec selecionar_usuarios
create proc selecionar_usuarios
as
select
        u.id_usuario[Id],
		u.primeiro_nome[Primeiro nome],
		u.nome_meio[Nome do meio],
		u.ultimo_nome[Último nome],
		u.bi[B.I],
		u.sexo[Sexo],
		u.telefone1[1º telefone],
		u.e_mail[E-mail],
		u.tipo_usuario[Tipo de usuário],
		u.palavra_passe[Palavra-passe]
from usuario_tbl u
go
-------------------Procedimento armazenado para pesquisar os usuários
drop proc pesquisar_usuarios;
create proc pesquisar_usuarios
	@chave varchar (50)
as
select
		u.id_usuario[Id],
		u.primeiro_nome[Primeiro nome],
		u.nome_meio[Nome do meio],
		u.ultimo_nome[Último nome],
		u.bi[B.I],
		u.sexo[Sexo],
		u.telefone1[1º telefone],
		u.e_mail[E-mail],
		u.tipo_usuario[Tipo de usuário],
		u.palavra_passe[Palavra-passe]
	from usuario_tbl u
	where
		u.id_usuario like ('%'+ @chave +'%') or
		u.primeiro_nome like ('%'+ @chave +'%') or
		u.nome_meio like ('%'+ @chave +'%') or
		u.ultimo_nome like ('%'+ @chave +'%') or
		u.bi like ('%'+ @chave +'%') or
		u.e_mail like ('%'+ @chave +'%') or
		u.telefone1 like ('%'+ @chave +'%')
go

---- Inserir
drop proc inserir_usuarios
create proc inserir_usuarios
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@bi varchar(20),
	@sexo varchar (15),
	@telefone1 varchar (9),
	@e_mail varchar (100),
	@tipo_usuario varchar(50),
	@palavra_passe varchar (100)
as
insert into usuario_tbl (primeiro_nome,nome_meio,ultimo_nome,bi,sexo,telefone1,e_mail,tipo_usuario,palavra_passe)
values (@primeiro_nome,@nome_meio,@ultimo_nome,@bi,@sexo,@telefone1,@e_mail,@tipo_usuario,@palavra_passe
)
go
select * from usuario_tbl
------------- Procedimento armazenado para iniciar sessão

CREATE PROCEDURE iniciar_Sessao
    @palavra_passe VARCHAR(100)
AS
BEGIN
    SELECT * FROM usuario_tbl WHERE palavra_passe = @palavra_passe;
END
GO

----------------------Fim do procedimento armazenado para iniciar sessão

---- Atualizar
drop proc atualizar_usuarios
create proc atualizar_usuarios
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@bi varchar(20),
	@sexo varchar (15),
	@telefone1 varchar (9),
	@e_mail varchar (100),
	@tipo_usuario varchar(50),
	@palavra_passe varchar (100)
as
update usuario_tbl set
	primeiro_nome=@primeiro_nome,
	nome_meio=@nome_meio,
	ultimo_nome=@ultimo_nome,
	bi=@bi,
	sexo=@sexo,
	telefone1=@telefone1,
	e_mail=@e_mail,
	tipo_usuario=@tipo_usuario,
	palavra_passe=@palavra_passe
where
	id_usuario=@id_usuario
go
select * from usuario_tbl
---- Deletar
create proc eliminar_usuarios
	@id_usuario int
as
delete from usuario_tbl where id_usuario=@id_usuario
go

alter table usuario_tbl drop column id_pais;

select * from usuario_tbl
--====================================================
/*
	procedimentos armazenados para a tabela
	de vitima_tbl
*/
exec selecionar_vitimas
---- Selecionar
drop proc selecionar_vitimas
create proc selecionar_vitimas
as
select va.id_vitima[Id],
	   va.primeiro_nome[Primeiro nome],
	   va.nome_meio[Nome do meio],
	   va.ultimo_nome[Último nome],
	   va.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, va.data_nascimento, GETDATE())[Idade],
	   va.sexo[Sexo],
	   va.telefone1[1º tlf.],
	   va.telefone2[2ºtlf.],
	   va.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   va.descricao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   va.data_registro[Registrado aos],
	   va.data_atualizacao[Atualizado aos]
	from vitima_tbl va
inner join caso_tbl co on co.id_caso = va.id_caso
inner join continente_tbl cte on cte.id_continente = va.id_continente
inner join pais_tbl ps on ps.id_pais = va.id_pais
inner join provincia_tbl pv on pv.id_provincia = va.id_provincia
inner join municipio_tbl mo on mo.id_municipio = va.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = va.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = va.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = va.id_curso
inner join usuario_tbl uo on uo.id_usuario = va.id_usuario
go

------- pesquisar
create proc pesquisar_vitimas
	@chave varchar(10)
as
select va.id_vitima[Id],
	   va.primeiro_nome[Primeiro nome],
	   va.nome_meio[Nome do meio],
	   va.ultimo_nome[Último nome],
	   va.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, va.data_nascimento, GETDATE())[Idade],
	   va.sexo[Sexo],
	   va.telefone1[1º tlf.],
	   va.telefone2[2ºtlf.],
	   va.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   va.descricao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   va.data_registro[Registrado aos],
	   va.data_atualizacao[Atualizado aos]
	from vitima_tbl va
inner join caso_tbl co on co.id_caso = va.id_caso
inner join continente_tbl cte on cte.id_continente = va.id_continente
inner join pais_tbl ps on ps.id_pais = va.id_pais
inner join provincia_tbl pv on pv.id_provincia = va.id_provincia
inner join municipio_tbl mo on mo.id_municipio = va.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = va.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = va.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = va.id_curso
inner join usuario_tbl uo on uo.id_usuario = va.id_usuario
where
	va.id_vitima like '%'+@chave+'%' or
	va.primeiro_nome like '%'+@chave+'%' or
	va.nome_meio like '%'+@chave+'%' or
    va.ultimo_nome like '%'+@chave+'%' or
	va.telefone1 like '%'+@chave+'%' or
    va.e_mail like '%'+@chave+'%'
go


---- Inserir
create proc inserir_vitimas
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	insert into vitima_tbl values (
	@id_caso, @id_continente, @id_pais, @id_provincia, @id_municipio, @id_bairro_rua,
	@id_nivel_academico, @id_curso, @id_usuario, @primeiro_nome, @nome_meio, @ultimo_nome,
	@data_nascimento, @sexo, @telefone1, @telefone2, @e_mail, @descricao, @data_registro,
	@data_atualizacao
)
go
---- Atualizar
create proc atualizar_vitimas
	@id_vitima int,
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	update vitima_tbl set
	id_caso=@id_caso, id_continente=@id_continente, id_pais=@id_pais,
	id_provincia=@id_provincia,id_municipio=@id_municipio,
	id_bairro_rua=@id_bairro_rua,id_nivel_academico=@id_nivel_academico,
	id_curso=@id_curso, id_usuario=@id_usuario, primeiro_nome=@primeiro_nome,
	nome_meio=@nome_meio, ultimo_nome=@ultimo_nome,data_nascimento=@data_nascimento,
	sexo=@sexo, telefone1=@telefone1, telefone2=@telefone2,e_mail=@e_mail,
	descricao=@descricao, data_registro=@data_registro, data_atualizacao=@data_atualizacao
	where
	id_vitima=@id_vitima
go
---- Eliminar
create proc eliminar_vitimas
	@id_vitima int
as
delete from vitima_tbl where id_vitima=@id_vitima
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de testemunhas
*/
------- Selecionar
drop proc selecionar_testemunha
create proc selecionar_testemunha
as
select tmh.id_testemunha[Id],
	   tmh.primeiro_nome[Primeiro nome],
	   tmh.nome_meio[Nome do meio],
	   tmh.ultimo_nome[Último nome],
	   tmh.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, tmh.data_nascimento, GETDATE())[Idade],
	   tmh.sexo[Sexo],
	   tmh.telefone1[1º tlf.],
	   tmh.telefone2[2ºtlf.],
	   tmh.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   tmh.declaracao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   tmh.data_registro[Registrado aos],
	   tmh.data_atualizacao[Atualizado aos]
	from testemunha_tbl tmh
inner join caso_tbl co on co.id_caso = tmh.id_caso
inner join continente_tbl cte on cte.id_continente = tmh.id_continente
inner join pais_tbl ps on ps.id_pais = tmh.id_pais
inner join provincia_tbl pv on pv.id_provincia = tmh.id_provincia
inner join municipio_tbl mo on mo.id_municipio = tmh.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = tmh.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = tmh.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = tmh.id_curso
inner join usuario_tbl uo on uo.id_usuario = tmh.id_usuario
go
------- Pesquisar

create proc pesquisar_testemunha
	@chave varchar(10)
as
select tmh.id_testemunha[Id],
	   tmh.primeiro_nome[Primeiro nome],
	   tmh.nome_meio[Nome do meio],
	   tmh.ultimo_nome[Último nome],
	   tmh.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, tmh.data_nascimento, GETDATE())[Idade],
	   tmh.sexo[Sexo],
	   tmh.telefone1[1º tlf.],
	   tmh.telefone2[2ºtlf.],
	   tmh.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   tmh.declaracao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   tmh.data_registro[Registrado aos],
	   tmh.data_atualizacao[Atualizado aos]
	from testemunha_tbl tmh
inner join caso_tbl co on co.id_caso = tmh.id_caso
inner join continente_tbl cte on cte.id_continente = tmh.id_continente
inner join pais_tbl ps on ps.id_pais = tmh.id_pais
inner join provincia_tbl pv on pv.id_provincia = tmh.id_provincia
inner join municipio_tbl mo on mo.id_municipio = tmh.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = tmh.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = tmh.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = tmh.id_curso
inner join usuario_tbl uo on uo.id_usuario = tmh.id_usuario
where tmh.id_testemunha like '%'+@chave+'%' or
	  tmh.primeiro_nome +' '+tmh.nome_meio +' '+tmh.ultimo_nome like '%'+@chave+'%'  or
	  tmh.telefone1 like '%'+@chave+'%'  or
	  tmh.e_mail like '%'+@chave+'%'
go
------- Inserir
create proc inserir_testemunha
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@declaracao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	insert into testemunha_tbl values (
	@id_caso, @id_continente, @id_pais, @id_provincia, @id_municipio, @id_bairro_rua,
	@id_nivel_academico, @id_curso, @id_usuario, @primeiro_nome, @nome_meio, @ultimo_nome,
	@data_nascimento, @sexo, @telefone1, @telefone2, @e_mail, @declaracao, @data_registro,
	@data_atualizacao
)
go
---- Atualizar
create proc atualizar_testemunhas
	@id_testemunha int,
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@declaracao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	update testemunha_tbl set
	id_caso=@id_caso, id_continente=@id_continente, id_pais=@id_pais,
	id_provincia=@id_provincia,id_municipio=@id_municipio,
	id_bairro_rua=@id_bairro_rua,id_nivel_academico=@id_nivel_academico,
	id_curso=@id_curso, id_usuario=@id_usuario, primeiro_nome=@primeiro_nome,
	nome_meio=@nome_meio, ultimo_nome=@ultimo_nome,data_nascimento=@data_nascimento,
	sexo=@sexo, telefone1=@telefone1, telefone2=@telefone2,e_mail=@e_mail,
	declaracao=@declaracao, data_registro=@data_registro, data_atualizacao=@data_atualizacao
	where
	id_testemunha=@id_testemunha
go
-----eliminar
create proc eliminar_testemunhas
	@id_testemunha int
as
delete from testemunha_tbl where id_testemunha=@id_testemunha
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de suspeitos
*/
drop proc selecionar_suspeitos
---- selecionar
create proc selecionar_suspeitos
as
select so.id_suspeito[Id],
	   so.primeiro_nome[Primeiro nome],
	   so.nome_meio[Nome do meio],
	   so.ultimo_nome[Último nome],
	   so.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, so.data_nascimento, GETDATE())[Idade],
	   so.sexo[Sexo],
	  so.telefone1[Nº de telefone],
	   so.telefone2[Nº altenativo],
	   so.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   so.descricao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   so.data_registro[Registrado aos],
	   so.data_atualizacao[Atualizado aos]
	from suspeito_tbl so
inner join caso_tbl co on co.id_caso = so.id_caso
inner join continente_tbl cte on cte.id_continente = so.id_continente
inner join pais_tbl ps on ps.id_pais = so.id_pais
inner join provincia_tbl pv on pv.id_provincia = so.id_provincia
inner join municipio_tbl mo on mo.id_municipio = so.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = so.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = so.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = so.id_curso
inner join usuario_tbl uo on uo.id_usuario = so.id_usuario
go
-------- Pesquisar
create proc pesquisar_suspeitos
	@chave varchar(10)
as
select so.id_suspeito[Id],
	   so.primeiro_nome[Primeiro nome],
	   so.nome_meio[Nome do meio],
	   so.ultimo_nome[Último nome],
	   so.data_nascimento[Data nasc.],
	   /*calcular a idade com base a data de nascimento*/
	   DATEDIFF(YEAR, so.data_nascimento, GETDATE())[Idade],
	   so.sexo[Sexo],
	   so.telefone1[Nº de telefone],
	   so.telefone2[Nº altenativo],
	   so.e_mail[E-mail],
	   cro.nome[Curso],
	   na.nome[N.acadêmico],
	   co.titulo[Caso],
	   so.descricao[Declaração],
	   cte.nome[Continente],
	   ps.nome[País],
	   pv.nome[Província],
	   mo.nome[Município],
	   ba.nome[Bairro],
	   uo.primeiro_nome +' '+uo.nome_meio +' '+uo.ultimo_nome[Registrado por],
	   so.data_registro[Registrado aos],
	   so.data_atualizacao[Atualizado aos]
	from suspeito_tbl so
inner join caso_tbl co on co.id_caso = so.id_caso
inner join continente_tbl cte on cte.id_continente = so.id_continente
inner join pais_tbl ps on ps.id_pais = so.id_pais
inner join provincia_tbl pv on pv.id_provincia = so.id_provincia
inner join municipio_tbl mo on mo.id_municipio = so.id_municipio
inner join bairro_rua_tbl ba on ba.id_bairro_rua = so.id_bairro_rua
inner join nivel_academico_tbl na on na.id_nivel_academico = so.id_nivel_academico
inner join curso_tbl cro on cro.id_curso = so.id_curso
inner join usuario_tbl uo on uo.id_usuario = so.id_usuario
where  so.id_suspeito like '%'+@chave+'%' or
	   so.primeiro_nome like '%'+@chave+'%' or
	   so.nome_meio like '%'+@chave+'%' or
	   so.ultimo_nome like '%'+@chave+'%' or
	   so.telefone1 like '%'+@chave+'%' or
	   so.telefone2 like '%'+@chave+'%' or
	   so.e_mail like '%'+@chave+'%'
go
------- Inserir
create proc inserir_suspeitos
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	insert into suspeito_tbl values (
	@id_caso, @id_continente, @id_pais, @id_provincia, @id_municipio, @id_bairro_rua,
	@id_nivel_academico, @id_curso, @id_usuario, @primeiro_nome, @nome_meio, @ultimo_nome,
	@data_nascimento, @sexo, @telefone1, @telefone2, @e_mail, @descricao, @data_registro,
	@data_atualizacao
)
go

---- Atualizar
create proc atualizar_suspeitos
	@id_suspeito int,
	@id_caso int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
	update suspeito_tbl set
	id_caso=@id_caso, id_continente=@id_continente, id_pais=@id_pais,
	id_provincia=@id_provincia,id_municipio=@id_municipio,
	id_bairro_rua=@id_bairro_rua,id_nivel_academico=@id_nivel_academico,
	id_curso=@id_curso, id_usuario=@id_usuario, primeiro_nome=@primeiro_nome,
	nome_meio=@nome_meio, ultimo_nome=@ultimo_nome,data_nascimento=@data_nascimento,
	sexo=@sexo, telefone1=@telefone1, telefone2=@telefone2,e_mail=@e_mail,
	descricao=@descricao, data_registro=@data_registro, data_atualizacao=@data_atualizacao
	where
	id_suspeito=@id_suspeito
go

---- eliminar
create proc eliminar_suspeitos
	@id_suspeito int
as
delete from suspeito_tbl where id_suspeito=@id_suspeito
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de patentes
*/
---- Selecionar

create proc selecionar_patentes
as
select
	p.id_patente[Id],
	p.nome[Petentes],
	p.descricao[Descrição],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
	p.data_registro[Data de registro],
	p.data_atualizacao[Data de atualização]
	from patente_tbl p
inner join usuario_tbl u on u.id_usuario = p.id_usuario
go
----pesquisar patentes
create proc pesquisar_patentes
	@chave varchar(50)
as
select
	p.id_patente[Id],
	p.nome[Petentes],
	p.descricao[Descrição],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
	p.data_registro[Data de registro],
	p.data_atualizacao[Data de atualização]
	from patente_tbl p
inner join usuario_tbl u on u.id_usuario = p.id_usuario
where p.id_patente like '%'+@chave+'%' or p.nome like '%'+@chave+'%'
go
---- Inserir
create proc inserir_patentes
	@id_usuario int,
	@nome varchar (50),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into patente_tbl values (@id_usuario, @nome, @descricao, @data_registro, @data_atualizacao)
go
---- Atualiazar
create proc atualizar_patentes
	@id_patente int,
	@id_usuario int,
	@nome varchar (50),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
update patente_tbl set id_usuario=@id_usuario, nome=@nome, descricao=@descricao,
						data_registro=@data_registro, data_atualizacao=@data_atualizacao
					where id_patente=@id_patente
go
---- Eliminar
create proc eliminar_patente
	@id_patente int
as
delete from patente_tbl where id_patente=@id_patente
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de nivel academicos
*/

--- selecionar
create proc selecionar_nivel_academicos
as
select * from nivel_academico_tbl
go
------Pesquisar niveis acadêmicos
create proc pesquisar_nivel_academicos
	@chave varchar (50)
as
select * from nivel_academico_tbl
where id_nivel_academico like '%'+@chave+'%' or nome like '%'+@chave+'%'
go
--- inserir
create proc inserir_nivel_academicos
	@nome varchar (100),
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into nivel_academico_tbl values (@nome, @data_registro, @data_atualizacao)
go

--- atualizar
create proc atualizar_nivel_academicos
	@id_nivel_academico int,
	@nome varchar (100),
	@data_registro datetime,
	@data_atualizacao datetime
as
update nivel_academico_tbl set nome=@nome, data_registro=@data_registro, data_atualizacao=@data_atualizacao
	where id_nivel_academico=@id_nivel_academico
	go
--- eliminar
create proc eliminar_nivel_academico
	@id_nivel_academico int
as
delete from nivel_academico_tbl where id_nivel_academico=@id_nivel_academico
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de investigadores
*/
------- Selecionar
drop proc selecionar_investigadores
create proc selecionar_investigadores
as
select
	i.id_investigador[Id],
	i.primeiro_nome[Primeiro nome],
	i.nome_meio[Nome do meio],
	i.ultimo_nome[Último nome],
	i.data_nascimento[Data de nascimento],
	/*calcular a idade com base a data de nascimento*/
	DATEDIFF(YEAR, i.data_nascimento, GETDATE())[Idade],
	i.sexo[Sexo],
	i.bi[Nº Bi],
	i.telefone1[1º telefone],
	i.telefone2[2º telefone],
	i.e_mail[E_mail],
	nc.nome[Escolaridade],
	co.nome[Curso],
	esp.nome[Especialidade],
	pt.nome[Patente],
	i.data_inicio_contrato[Início do contrado],
	i.data_fim_contrato[Fim do contrato],
	cnt.nome[Continente],
	p.nome[País],
	pv.nome[Província],
	m.nome[Município],
	b_r.nome[Bairro/rua],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
	i.data_registro[Data de registro],
	i.data_atualizacao[Data de atualização]
	from investigador_tbl i
inner join continente_tbl cnt on cnt.id_continente = i.id_continente
inner join pais_tbl p on p.id_pais = i.id_pais
inner join provincia_tbl pv on pv.id_provincia = i.id_provincia
inner join municipio_tbl m on m.id_municipio = i.id_municipio
inner join bairro_rua_tbl b_r on b_r.id_bairro_rua = i.id_bairro_rua
inner join nivel_academico_tbl nc on nc.id_nivel_academico = i.id_nivel_academico
inner join curso_tbl co on co.id_curso = i.id_curso
inner join especialidade_tbl esp on esp.id_especialidade = i.id_especialidade
inner join patente_tbl pt on pt.id_patente = i.id_patente
inner join usuario_tbl u on u.id_usuario = i.id_usuario

go

-----------Pesquisar investigadores
create proc pesquisar_Investigadores
	@chave varchar(10)
as
select
	i.id_investigador[Id],
	i.primeiro_nome[Primeiro nome],
	i.nome_meio[Nome do meio],
	i.ultimo_nome[Último nome],
	i.data_nascimento[Data de nascimento],
	/*calcular a idade com base a data de nascimento*/
	DATEDIFF(YEAR, i.data_nascimento, GETDATE())[Idade],
	i.sexo[Sexo],
	i.bi[Nº Bi],
	i.telefone1[1º telefone],
	i.telefone2[2º telefone],
	i.e_mail[E_mail],
	nc.nome[Escolaridade],
	co.nome[Curso],
	esp.nome[Especialidade],
	pt.nome[Patente],
	i.data_inicio_contrato[Início do contrado],
	i.data_fim_contrato[Fim do contrato],
	cnt.nome[Continente],
	p.nome[País],
	pv.nome[Província],
	m.nome[Município],
	b_r.nome[Bairro/rua],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
	i.data_registro[Data de registro],
	i.data_atualizacao[Data de atualização]
	from investigador_tbl i
inner join continente_tbl cnt on cnt.id_continente = i.id_continente
inner join pais_tbl p on p.id_pais = i.id_pais
inner join provincia_tbl pv on pv.id_provincia = i.id_provincia
inner join municipio_tbl m on m.id_municipio = i.id_municipio
inner join bairro_rua_tbl b_r on b_r.id_bairro_rua = i.id_bairro_rua
inner join nivel_academico_tbl nc on nc.id_nivel_academico = i.id_nivel_academico
inner join curso_tbl co on co.id_curso = i.id_curso
inner join especialidade_tbl esp on esp.id_especialidade = i.id_especialidade
inner join patente_tbl pt on pt.id_patente = i.id_patente
inner join usuario_tbl u on u.id_usuario = i.id_usuario
where
	i.id_investigador like '%'+@chave+'%' or
	i.primeiro_nome + i.nome_meio + i.ultimo_nome like '%'+@chave+'%' or
	i.e_mail like '%'+@chave+'%' or
	i.bi like '%'+@chave+'%'

go
------- Inserir
create proc inserir_investigadoes
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_especialidade int,
	@id_patente int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@bi varchar (20),
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@data_inicio_contrato date,
	@data_fim_contrato date,
	@data_registro datetime,
	@data_atualizacao datetime
as
	insert into investigador_tbl values (
	@id_continente,
	@id_pais,
	@id_provincia,
	@id_municipio,
	@id_bairro_rua,
	@id_nivel_academico,
	@id_curso,
	@id_especialidade,
	@id_patente,
	@id_usuario,
	@primeiro_nome,
	@nome_meio,
	@ultimo_nome,
	@data_nascimento,
	@sexo,
	@bi,
	@telefone1,
	@telefone2,
	@e_mail,
	@data_inicio_contrato,
	@data_fim_contrato,
	@data_registro,
	@data_atualizacao
)
go
---- Atualizar
create proc atualizar_investigadores
	@id_investigador int,
	@id_continente int,
	@id_pais int,
	@id_provincia int,
	@id_municipio int,
	@id_bairro_rua int,
	@id_nivel_academico int,
	@id_curso int,
	@id_especialidade int,
	@id_patente int,
	@id_usuario int,
	@primeiro_nome varchar(50),
	@nome_meio varchar (50),
	@ultimo_nome varchar (50),
	@data_nascimento date,
	@bi varchar (20),
	@sexo varchar (15),
	@telefone1 varchar (9),
	@telefone2 varchar (9),
	@e_mail varchar (100),
	@data_inicio_contrato date,
	@data_fim_contrato date,
	@data_registro datetime,
	@data_atualizacao datetime
as
update investigador_tbl set
	id_continente=@id_continente,
	id_pais=@id_pais,
	id_provincia=@id_provincia,
	id_municipio=@id_municipio,
	id_bairro_rua=@id_bairro_rua,
	id_nivel_academico=@id_nivel_academico,
	id_curso=@id_curso,
	id_especialidade=@id_especialidade,
	id_patente=@id_patente,
	id_usuario=@id_usuario,
	primeiro_nome=@primeiro_nome,
	nome_meio=@nome_meio,
	ultimo_nome=@ultimo_nome,
	data_nascimento=@data_nascimento,
	sexo=@sexo,
	bi=@bi,
	telefone1=@telefone1,
	telefone2=@telefone2,
	e_mail=@e_mail,
	data_inicio_contrato=@data_inicio_contrato,
	data_fim_contrato=@data_fim_contrato,
	data_registro=@data_registro,
	data_atualizacao=@data_atualizacao

	where
	id_investigador=@id_investigador
go
----- eliminar
create proc eliminar_investigadores
	@id_investigador int
as
delete from investigador_tbl where id_investigador=@id_investigador
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de horas extras
*/
select * from  hora_extra_tbl
----- selecionar
drop proc selecionar_horas_extras
create proc selecionar_horas_extras
as
select
	he.id_hora_extra[Id],
	i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome[Funcionário],
	he.data_trabalho[Data de trabalho],
	he.horas_trabalhadas[Horas trabalhadas],
	he.tipo_horas[Tipo de horas],
	u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
	he.data_registro[Registrado aos],
	he.data_atualizacao[Atualizado aos]
	from hora_extra_tbl he
inner join investigador_tbl i on i.id_investigador = he.id_investigador
inner join  usuario_tbl u on u.id_usuario = he.id_usuario
go
---------Pesquisar
drop proc pesquisar_horas_extras
create proc pesquisar_horas_extras
	@chave varchar(10)
as
select
	he.id_hora_extra[Id],
	i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome[Funcionário],
	he.data_trabalho[Data de trabalho],
	he.horas_trabalhadas[Horas trabalhadas],
	he.tipo_horas[Tipo de horas],
	u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
	he.data_registro[Registrado aos],
	he.data_atualizacao[Atualizado aos]
	from hora_extra_tbl he
inner join investigador_tbl i on i.id_investigador = he.id_investigador
inner join  usuario_tbl u on u.id_usuario = he.id_usuario
where he.id_hora_extra like '%'+@chave+'%' or
	  i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome like '%'+@chave+'%'
go


---- inserir
create proc inserir_horas_extras
	@id_investigador int,
	@id_usuario int,
	@data_trabalho date,
	@horas_trabalhadas varchar(5),
	@tipo_horas varchar (20),
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into hora_extra_tbl values (
	@id_investigador,
	@id_usuario,
	@data_trabalho,
	@horas_trabalhadas,
	@tipo_horas,
	@data_registro,
	@data_atualizacao
)
go
---- atualizar
drop proc atualizar_horas_extras;
create proc atualizar_horas_extras
	@id_hora_extra int,
	@id_investigador int,
	@id_usuario int,
	@data_trabalho date,
	@horas_trabalhadas varchar(5),
	@tipo_horas varchar (20),
	@data_atualizacao datetime
as
update hora_extra_tbl set
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_trabalho=@data_trabalho,
	horas_trabalhadas=@horas_trabalhadas,
	tipo_horas=@tipo_horas,
	data_atualizacao=@data_atualizacao
where
	id_hora_extra=@id_hora_extra
go
---- eliminar
create proc eliminar_horas_extras
	@id_hora_extra int
as
delete from hora_extra_tbl where id_hora_extra=@id_hora_extra
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de ferias
*/
select * from feria_tbl
drop proc selecionar_ferias
------ selecionar
create proc selecionar_ferias
as
select  f.id_feria[Id],
		i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome [Funcionários],
		f.data_inicio[Data inicial],
		f.data_fim[Data final],
		f.estado_feria[Estado],
		f.descricao[Descrição],
		u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
		f.data_registro[Registrado aos],
		f.data_atualizacao[Atualizado aos]

from feria_tbl f
inner join investigador_tbl i on i.id_investigador = f.id_investigador
inner join usuario_tbl u on u.id_usuario = f.id_usuario
go

---- Pesquisar
drop proc pesquisar_Ferias
create proc pesquisar_Ferias
	@chave varchar (10)
as
select  f.id_feria[Id],
		i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome [Funcionários],
		f.data_inicio[Data inicial],
		f.data_fim[Data final],
		f.estado_feria[Estado],
		f.descricao[Descrição],
		u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
		f.data_registro[Registrado aos],
		f.data_atualizacao[Atualizado aos]

from feria_tbl f
inner join investigador_tbl i on i.id_investigador = f.id_investigador
inner join usuario_tbl u on u.id_usuario = f.id_usuario
where f.id_feria like '%'+@chave+'%' or
	  i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome like '%'+@chave+'%'
go
drop proc inserir_ferias
------ inserir
create proc inserir_ferias
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@estado_feria varchar(50),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into feria_tbl values(
	@id_investigador,
	@id_usuario,
	@data_inicio,
	@data_fim,
	@estado_feria,
	@descricao,
	@data_registro,
	@data_atualizacao
)
go
------ atualizar
drop proc atualizar_ferias

create proc atualizar_ferias
    @id_feria int,
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@estado_feria varchar(50),
	@descricao text,
	@data_atualizacao datetime
as
update feria_tbl set
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_inicio=@data_inicio,
	data_fim=@data_fim,
	estado_feria=@estado_feria,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao
where
	id_feria=@id_feria
go
------ eliminar
create proc eliminar_ferias
	@id_feria int
as
delete from feria_tbl where id_feria=@id_feria
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de ferias
*/
---- selececionar

create proc selecionar_faltas
as
select
		f.id_falta[Id],
		i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome[Invest./Funcionários],
		f.data_falta[Data],
		f.estado_falta[Estado],
		f.descricao[Motivos],
		u.primeiro_nome +' '+u.nome_meio+' '+u.ultimo_nome[Registrado por],
		f.data_registro[Registrado aos],
		f.data_atualizacao[Atualizado aos]
from falta_tbl f
inner join investigador_tbl i on i.id_investigador = f.id_investigador
inner join usuario_tbl u on u.id_usuario = f.id_usuario
go
---- Pesquisar
drop proc pesquisar_faltas
create proc pesquisar_faltas
	@chave varchar (10)
as
select
		f.id_falta[Id],
		i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome[Funcionários],
		f.data_falta[Data],
		f.estado_falta[Estado],
		f.descricao[Motivos],
		u.primeiro_nome +' '+u.nome_meio+' '+u.ultimo_nome[Registrado por],
		f.data_registro[Registrado aos],
		f.data_atualizacao[Atualizado aos]
from falta_tbl f
inner join investigador_tbl i on i.id_investigador = f.id_investigador
inner join usuario_tbl u on u.id_usuario = f.id_usuario
where
	f.id_falta like '%'+@chave+'%' or
	i.primeiro_nome +' '+ i.nome_meio +' '+i.ultimo_nome like '%'+@chave+'%'
go
---- inserir
create proc inserir_faltas
	@id_investigador int,
	@id_usuario int,
	@data_falta date,
	@estado_falta varchar (20),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into falta_tbl values(
	@id_investigador,
	@id_usuario,
	@data_falta,
	@estado_falta,
	@descricao,
	@data_registro,
	@data_atualizacao
)
go
---- atualizar
create proc atualizar_faltas
	@id_falta int,
	@id_investigador int,
	@id_usuario int,
	@data_falta date,
	@estado_falta varchar (20),
	@descricao text,
	@data_atualizacao datetime
as
update falta_tbl set
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_falta=@data_falta,
	estado_falta=@estado_falta,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao
	where id_falta=@id_falta
go
---- eliminar
create proc eliminar_faltas
	@id_falta int
as
delete from falta_tbl where id_falta=@id_falta
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de evidencias
*/
----- selecionar
exec selecionar_evidencias;
create proc selecionar_evidencias
as
select ev.id_evidencia[Id],
       cs.titulo[Caso],
       ev.tipo[Tipo],
	   ev.data_coleta[Data de coleta],
	   ev.local_armazenamento[Local de armazenamento],
	   ev.descricao[Descrição],
	   invest.primeiro_nome +' '+invest.nome_meio +' '+invest.ultimo_nome[Funcionário],
	   us.primeiro_nome +' '+us.nome_meio +' '+us.ultimo_nome[Registrado por],
	   ev.data_registro[Registrado aos],
	   ev.data_atualizacao[Atualizado aos]
from evidencia_tbl ev
inner join investigador_tbl invest on invest.id_investigador = ev.id_investigador
inner join caso_tbl cs on cs.id_caso = ev.id_caso
inner join usuario_tbl us on us.id_usuario = ev.id_usuario
go
---- Pesquisar
drop proc pesquisar_evidencias;
create proc pesquisar_evidencias
	@chave varchar(10)
as
select ev.id_evidencia[Id],
       cs.titulo[Caso],
       ev.tipo[Tipo],
	   ev.data_coleta[Data de coleta],
	   ev.local_armazenamento[Local de armazenamento],
	   ev.descricao[Descrição],
	   invest.primeiro_nome +' '+invest.nome_meio +' '+invest.ultimo_nome[Funcionário],
	   us.primeiro_nome +' '+us.nome_meio +' '+us.ultimo_nome[Registrado por],
	   ev.data_registro[Registrado aos],
	   ev.data_atualizacao[Atualizado aos]
from evidencia_tbl ev
inner join investigador_tbl invest on invest.id_investigador = ev.id_investigador
inner join caso_tbl cs on cs.id_caso = ev.id_caso
inner join usuario_tbl us on us.id_usuario = ev.id_usuario
where ev.id_evidencia like '%'+@chave+'%' or ev.tipo like '%'+@chave+'%'
go
----- inserir
create proc inserir_evidencias
	@id_investigador int,
	@id_caso int,
	@id_usuario int,
	@tipo varchar (100),
	@descricao text,
	@data_coleta date,
	@local_armazenamento varchar(255),
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into evidencia_tbl values (
	@id_investigador,
	@id_caso,
	@id_usuario,
	@tipo,
	@descricao,
	@data_coleta,
	@local_armazenamento,
	@data_registro,
	@data_atualizacao
)
go
----- atualizar

create proc atualizar_evidencias
	@id_evidencia int,
	@id_investigador int,
	@id_caso int,
	@id_usuario int,
	@tipo varchar (100),
	@descricao text,
	@data_coleta date,
	@local_armazenamento varchar (255),
	@data_atualizacao datetime
as
update evidencia_tbl set
	id_investigador=@id_investigador,
	id_caso=@id_caso,
	id_usuario=@id_usuario,
	tipo=@tipo,
	descricao=@descricao,
	data_coleta=@data_coleta,
	local_armazenamento=@local_armazenamento,
	data_atualizacao=@data_atualizacao
	where id_evidencia=@id_evidencia
go
----- eliminar
create proc eliminar_evidencias
	@id_evidencia int
as
delete from evidencia_tbl where id_evidencia=@id_evidencia
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de eventos casos
*/
---- selecionar
create proc selecionar_evento_casos
as
select
		ec.id_evento_caso[Id],
		co.titulo[Casos],
		v.primeiro_nome +' '+  v.nome_meio +' '+ v.ultimo_nome[Vítimas],
		susp.primeiro_nome +' '+ susp.nome_meio +' '+ susp.ultimo_nome[Suspeitos],
		ta.primeiro_nome +' '+ ta.nome_meio +' '+ ta.ultimo_nome[Testemunhas],
		i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome[Funcionários],
		ec.data_evento[Data],
		ec.tipo_evento[Tipo de evento],
		ec.descricao[Descrição],
		u.primeiro_nome +' '+ u.nome_meio +' '+ u.ultimo_nome[Registrado por],
		ec.data_registro[Registrado aos],
		ec.data_atualizacao[Atualizado aos]
	from evento_caso_tbl ec
inner join caso_tbl co on co.id_caso =  ec.id_caso
inner join investigador_tbl i on i.id_investigador = ec.id_investigador
inner join vitima_tbl v on v.id_vitima = ec.id_vitima
inner join testemunha_tbl ta on ta.id_testemunha = ec.id_testemunha
inner join usuario_tbl u on u.id_usuario = ec.id_usuario
inner join suspeito_tbl susp on susp.id_suspeito = ec.id_suspeito
go
----- pesquisar

create proc pesquisar_evento_casos
	@chave varchar(10)
as
select
		ec.id_evento_caso[Id],
		co.titulo[Casos],
		v.primeiro_nome +' '+  v.nome_meio +' '+ v.ultimo_nome[Vítimas],
		susp.primeiro_nome +' '+ susp.nome_meio +' '+ susp.ultimo_nome[Suspeitos],
		ta.primeiro_nome +' '+ ta.nome_meio +' '+ ta.ultimo_nome[Testemunhas],
		i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome[Funcionários],
		ec.data_evento[Data],
		ec.tipo_evento[Tipo de evento],
		ec.descricao[Descrição],
		u.primeiro_nome +' '+ u.nome_meio +' '+ u.ultimo_nome[Registrado por],
		ec.data_registro[Registrado aos],
		ec.data_atualizacao[Atualizado aos]
	from evento_caso_tbl ec
inner join caso_tbl co on co.id_caso =  ec.id_caso
inner join investigador_tbl i on i.id_investigador = ec.id_investigador
inner join vitima_tbl v on v.id_vitima = ec.id_vitima
inner join testemunha_tbl ta on ta.id_testemunha = ec.id_testemunha
inner join usuario_tbl u on u.id_usuario = ec.id_usuario
inner join suspeito_tbl susp on susp.id_suspeito = ec.id_suspeito
where
        ec.id_evento_caso like '%'+@chave+'%' or
		co.titulo  like '%'+@chave+'%' or
		v.primeiro_nome +' '+  v.nome_meio +' '+ v.ultimo_nome  like '%'+@chave+'%' or
		susp.primeiro_nome +' '+ susp.nome_meio +' '+ susp.ultimo_nome  like '%'+@chave+'%' or
		ta.primeiro_nome +' '+ ta.nome_meio +' '+ ta.ultimo_nome  like '%'+@chave+'%' or
		i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome  like '%'+@chave+'%'
go
---- FIM
select id_vitima as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from vitima_tbl
select id_testemunha as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from testemunha_tbl
select id_suspeito as ID, (primeiro_nome +' '+nome_meio +' '+ultimo_nome) as Nomes from suspeito_tbl
----- inserir
drop proc inserir_enventos_casos
create proc inserir_enventos_casos
	@id_caso int,
	@id_investigador int,
	@id_vitima int,
	@id_testemunha int,
	@id_usuario int,
	@data_evento date,
	@tipo_evento varchar (255),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime,
	@id_suspeito int
as
insert into evento_caso_tbl values(
	@id_caso,
	@id_investigador,
	@id_vitima,
	@id_testemunha,
	@id_usuario,
	@data_evento,
	@tipo_evento,
	@descricao,
	@data_registro,
	@data_atualizacao,
	@id_suspeito
)
go

--- atualizar
drop proc atualizar_enventos_casos

create proc atualizar_enventos_casos
	@id_evento_caso int,
	@id_caso int,
	@id_investigador int,
	@id_vitima int,
	@id_testemunha int,
	@id_usuario int,
	@data_evento date,
	@tipo_evento varchar (255),
	@descricao text,
	@data_atualizacao datetime,
	@id_suspeito int
as
update evento_caso_tbl set
	id_caso=@id_caso,
	id_investigador=@id_investigador,
	id_vitima=@id_vitima,
	id_testemunha=@id_testemunha,
	id_usuario=@id_usuario,
	data_evento=@data_evento,
	tipo_evento=@tipo_evento,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao,
	id_suspeito=@id_suspeito
where id_evento_caso=@id_evento_caso

go

---- eliminar
create proc eliminar_evento_casos
	@id_evento_caso int
as
delete from evento_caso_tbl where id_evento_caso=@id_evento_caso
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de especialidades
*/
----- selecionar

create proc selecionar_especialidades
as
select
	es.id_especialidade[Id],
	cs.nome[Curso],
	es.nome[Especialidade],
	es.data_registro[Registrado aos],
	es.data_atualizacao[Atualizado aos]
	from especialidade_tbl es
inner join curso_tbl cs on cs.id_curso = es.id_curso
go
----- Pesquisar as especialidades

create proc pesquisar_especialidades
	@chave varchar(50)
as
select
	es.id_especialidade[Id],
	cs.nome[Curso],
	es.nome[Especialidade],
	es.data_registro[Registrado aos],
	es.data_atualizacao[Atualizado aos]
	 from especialidade_tbl es
inner join curso_tbl cs on cs.id_curso = es.id_curso
where es.id_especialidade like '%'+@chave+'%' or
	  cs.nome like '%'+@chave+'%' or
	  es.nome like '%'+@chave+'%'
go

----- inserir

create proc inserir_especialidades
	@id_curso int,
	@nome varchar (100),
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into especialidade_tbl values(
	@nome, @data_registro, @data_atualizacao,@id_curso
)go
----- atualizar
drop proc atualizar_especialidades
create proc atualizar_especialidades
	@id_especialidade int,
	@id_curso int,
	@nome varchar (100),
	@data_atualizacao datetime
as
update especialidade_tbl set
	nome=@nome,
	data_atualizacao=@data_atualizacao,id_curso=@id_curso
where id_especialidade=@id_especialidade
go
----- eliminar
create proc eliminar_especialidade
	@id_especialidade int
as
delete from especialidade_tbl where id_especialidade=@id_especialidade
go



--====================================================
/*
	procedimentos armazenados para a tabela
	de departamento
*/
----- selecionar

create proc selecionar_departamentos
as
select
	d.id_departamento[Id],
	d.nome[Departamentos],
	d.descricao[Descrição],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Resgistrado por],
	d.data_registro[Registro aos],
	d.data_atualizacao[Atualizado aos]
	from departamento_tbl d
inner join usuario_tbl u on u.id_usuario = d.id_usuario
go
---- Pesquisar departamentos

create proc pesquisar_departamentos
	@chave varchar(50)
as
select
	d.id_departamento[Id],
	d.nome[Departamentos],
	d.descricao[Descrição],
	u.primeiro_nome + u.nome_meio + u.ultimo_nome[Resgistrado por],
	d.data_registro[Registrado aos],
	d.data_atualizacao[Atualizado aos]
	from departamento_tbl d
inner join usuario_tbl u on u.id_usuario = d.id_usuario
where
	d.id_departamento like '%'+@chave+'%' or
	d.nome like '%'+@chave+'%' or
	u.primeiro_nome + u.nome_meio + u.ultimo_nome like '%'+@chave+'%'
go
----- inserir
create proc inserir_departamentos
	@id_usuario int,
	@nome varchar (100),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into departamento_tbl values(
	@id_usuario,
	@nome,
	@descricao,
	@data_registro,
	@data_atualizacao
)
go
----- atualizar

create proc atualizar_departamentos
	@id_departamento int,
	@id_usuario int,
	@nome varchar (100),
	@descricao text,
	@data_atualizacao datetime
as
update departamento_tbl set
	id_usuario=@id_usuario,
	nome=@nome,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao
where id_departamento=@id_departamento
go
----- eliminar
create proc eliminar_departamentos
	@id_departamento int
as
delete from departamento_tbl where id_departamento=@id_departamento
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de departamento-investigadores
*/
---- selecionar
create proc selecionar_departamento_investigadores
as
select
	di.id_departamento_investigador[Id],
	i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome[Funcionários],
	dp.nome[Departamentos],
	u.primeiro_nome +' '+ u.nome_meio +' '+ u.ultimo_nome[Registrado por],
	di.data_registro[Registrado aos],
	di.data_atualizacao[Atualizado aos]
from departamento_investigador_tbl di
	inner join investigador_tbl i on i.id_investigador = di.id_investigador
	inner join departamento_tbl dp on dp.id_departamento = di.id_departamento
	inner join usuario_tbl u on u.id_usuario = di.id_usuario
go
----pesquisar
create proc pesquisar_departamento_investigadores
	@chave varchar (20)
as
select
	di.id_departamento_investigador[Id],
	i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome[Funcionários],
	dp.nome[Departamentos],
	u.primeiro_nome +' '+ u.nome_meio +' '+ u.ultimo_nome[Registrado por],
	di.data_registro[Registrado aos],
	di.data_atualizacao[Atualizado aos]
from departamento_investigador_tbl di
	inner join investigador_tbl i on i.id_investigador = di.id_investigador
	inner join departamento_tbl dp on dp.id_departamento = di.id_departamento
	inner join usuario_tbl u on u.id_usuario = di.id_usuario
where
	di.id_departamento_investigador like '%'+@chave+'%' or
	i.primeiro_nome +' '+ i.nome_meio +' '+ i.ultimo_nome like '%'+@chave+'%' or
	dp.nome like '%'+@chave+'%'

go
---- inserir
create proc inserir_departamento_investigadores
	@id_investigador int,
	@id_departamento int,
	@id_usuario int,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into departamento_investigador_tbl values (
	@id_investigador,
	@id_departamento,
	@id_usuario,
	@data_registro,
	@data_atualizacao
)
go

---- atualiazar
create proc atualizar_departamento_investigadores
	@id_departamento_investigador int,
	@id_investigador int,
	@id_departamento int,
	@id_usuario int,
	@data_atualizacao datetime
as
update departamento_investigador_tbl set
	id_investigador=@id_investigador,
	id_departamento=@id_departamento,
	id_usuario=@id_usuario,
	data_atualizacao=@data_atualizacao
where id_departamento_investigador=@id_departamento_investigador
go
---- eliminar
create proc eliminar_departamento_investigadores
	@id_departamento_investigador int
as
delete from departamento_investigador_tbl where id_departamento_investigador=@id_departamento_investigador
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de cursos
*/
--- selecionar
exec selecionar_cursos
create proc selecionar_cursos
as
select curso_tbl.id_curso[Id],
	    curso_tbl.nome[Curso],
		curso_tbl.data_registro[Registrado aos],
		curso_tbl.data_atualizacao[Atualizado aos]
 from curso_tbl
go
---------Pesquisar cursos
drop proc pesquisar_cursos
create proc pesquisar_cursos
	@chave varchar (50)
as
select curso_tbl.id_curso[Id],
	    curso_tbl.nome[Curso],
		curso_tbl.data_registro[Registrado aos],
		curso_tbl.data_atualizacao[Atualizado aos]
 from curso_tbl
where id_curso like '%'+@chave+'%' or nome like '%'+@chave+'%'
go
--- inserir
create proc inserir_cursos
	@nome varchar (100),
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into curso_tbl values (
	@nome,
	@data_registro,
	@data_atualizacao
)
go
--- atualizar
drop proc atualizar_cursos
create proc atualizar_cursos
	@id_curso int,
	@nome varchar (100),
	@data_atualizacao datetime
as
update curso_tbl set
	nome=@nome,
	data_atualizacao=@data_atualizacao
where id_curso=@id_curso
go
--- eliminar
create proc eliminar_cursos
	@id_curso int
as
delete from curso_tbl where id_curso=@id_curso
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de casos
*/

---- selecionar
drop proc selecionar_casos
create proc selecionar_casos
as
select
	c.id_caso[Id],
	c.titulo[Título],
	i.primeiro_nome +' '+i.nome_meio+' '+i.ultimo_nome[Funcionário],
	d.nome[Departamento],
	c.data_abertura[Data de abertura],
	c.data_fechamento[Data fechamento],
	c.estado[Estado],
	c.descricao[Descrição],
	u.primeiro_nome +' '+ u.nome_meio+' '+ u.ultimo_nome[Registrado por],
	c.data_registro[Registrado aos],
	c.data_atualizacao[Atualizado aos]
	from caso_tbl c
inner join investigador_tbl i on i.id_investigador = c.id_investigador
inner join departamento_tbl d on d.id_departamento = c.id_departamento
inner join usuario_tbl u on u.id_usuario = c.id_usuario
go
---- Pesquisar

create proc pesquisar_casos
	@chave varchar(10)
as
select
	c.id_caso[Id],
	c.titulo[Título],
	i.primeiro_nome +' '+i.nome_meio+' '+i.ultimo_nome[Funcionário],
	d.nome[Departamento],
	c.data_abertura[Data de abertura],
	c.data_fechamento[Data fechamento],
	c.estado[Estado],
	c.descricao[Descrição],
	u.primeiro_nome +' '+ u.nome_meio+' '+ u.ultimo_nome[Registrado por],
	c.data_registro[Registrado aos],
	c.data_atualizacao[Atualizado aos]
	from caso_tbl c
inner join investigador_tbl i on i.id_investigador = c.id_investigador
inner join departamento_tbl d on d.id_departamento = c.id_departamento
inner join usuario_tbl u on u.id_usuario = c.id_usuario
where c.id_caso like '%'+@chave+'%' or
	  d.nome like '%'+@chave+'%' or
	  c.titulo like '%'+@chave+'%'
go
---- registrar
create proc inserir_casos
	@id_investigador int,
	@id_departamento int,
	@id_usuario int,
	@titulo varchar (100),
	@data_abertura date,
	@data_fechamento date,
	@estado varchar (20),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into caso_tbl values(
	@id_investigador,
	@id_departamento,
	@id_usuario,
	@titulo,
	@data_abertura,
	@data_fechamento,
	@estado,
	@descricao,
	@data_registro,
	@data_atualizacao
);
go
---- atualizar
drop proc atualizar_casos
create proc atualizar_casos
	@id_caso int,
	@id_investigador int,
	@id_departamento int,
	@id_usuario int,
	@titulo varchar (100),
	@data_abertura date,
	@data_fechamento date,
	@estado varchar (20),
	@descricao text,
	@data_atualizacao datetime
as
update caso_tbl set
	id_investigador=@id_investigador,
	id_departamento=@id_departamento,
	id_usuario=@id_usuario,
	titulo=@titulo,
	data_abertura=@data_abertura,
	data_fechamento=@data_fechamento,
	estado=@estado,
	descricao=@descricao,
	data_atualizacao =@data_atualizacao
where
	id_caso=@id_caso
go
---- eliminar
create proc eliminar_casos
	@id_caso int
as
delete from caso_tbl where id_caso=@id_caso
go

--====================================================
/*
	procedimentos armazenados para a tabela
	de cargos
*/
----- selecionar
drop proc selecionar_cargos;
create proc selecionar_cargos
as
select
	  c.id_cargo[Id],
	  c.nome[Cargos],
	  u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
	  c.data_registro[Registrado aos],
	  c.data_atualizacao[Atualizado aos]
from cargo_tbl c
inner join usuario_tbl u on u.id_usuario = c.id_usuario
go
select * from cargo_tbl
----- Pesquisar

create proc pesquisar_cargos
	@chave varchar (10)
as
select
	  c.id_cargo[Id],
	  c.nome[Cargos],
	  u.primeiro_nome +' '+ u.nome_meio +' '+u.ultimo_nome[Registrado por],
	  c.data_registro[Registrado aos],
	  c.data_atualizacao[Atualizado aos]
from cargo_tbl c
inner join usuario_tbl u on u.id_usuario = c.id_usuario
where c.id_cargo like '%'+@chave+'%' or
	  c.nome like '%'+@chave+'%'
go
----- inserir
drop proc inserir_cargos
create proc inserir_cargos
	@nome varchar (50),
	@data_registro datetime,
	@data_atualizacao datetime,
	@id_usuario int
as
insert into cargo_tbl values(@nome, @data_registro,@data_atualizacao, @id_usuario)
go
----- atualizar
drop proc atualizar_cargos
create proc atualizar_cargos
	@id_cargo int,
	@nome varchar (50),
	@data_atualizacao datetime,
	@id_usuario int
as
update cargo_tbl set
	nome=@nome,
	data_atualizacao=@data_atualizacao,
	id_usuario=@id_usuario
where id_cargo=@id_cargo
go
----- eliminar
create proc eliminar_cargos
	@id_cargo int
as
delete from cargo_tbl where id_cargo=@id_cargo
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de cargo investigador
*/
----- selecionar
drop proc selecionar_cargos_investigadores
create proc selecionar_cargos_investigadores
as
select
	  ci.id_cargo_investigador[Id],
	  c.nome[Cargos],
	  i.primeiro_nome +' '+i.nome_meio +' '+i.ultimo_nome[Funcionário],
	  u.primeiro_nome +' '+u.nome_meio +' '+u.ultimo_nome[Registrado por],
	  ci.data_registro[Registrado aos],
	  ci.data_atualizacao[Atualizado aos]
from cargo_investigador_tbl  ci
inner join cargo_tbl c on c.id_cargo = ci.id_cargo
inner join investigador_tbl i on i.id_investigador = ci.id_investigador
inner join usuario_tbl u on u.id_usuario = ci.id_usuario
go
--- pesquisar
drop proc pesquisar_cargos_investigadores;
create proc pesquisar_cargos_investigadores
	@chave varchar(10)
as
select
	  ci.id_cargo_investigador[Id],
	  c.nome[Cargos],
	  i.primeiro_nome +' '+i.nome_meio +' '+i.ultimo_nome[Funcionário],
	  u.primeiro_nome +' '+u.nome_meio +' '+u.ultimo_nome[Registrado por],
	  ci.data_registro[Registrado aos],
	  ci.data_atualizacao[Atualizado aos]
from cargo_investigador_tbl  ci
inner join cargo_tbl c on c.id_cargo = ci.id_cargo
inner join investigador_tbl i on i.id_investigador = ci.id_investigador
inner join usuario_tbl u on u.id_usuario = ci.id_usuario
where   ci.id_cargo_investigador like '%'+@chave+'%' or
		c.nome like '%'+@chave+'%' or
		i.primeiro_nome +' '+i.nome_meio +' '+i.ultimo_nome like '%'+@chave+'%'
go

CREATE PROC pesquisar_cargos_investigadores_Contagem
    @chave VARCHAR(10)
AS
BEGIN
    -- Obter o total de registros filtrados
    DECLARE @total INT;

    SELECT
        @total = COUNT(*)
    FROM
        cargo_investigador_tbl ci
    INNER JOIN
        cargo_tbl c ON c.id_cargo = ci.id_cargo
    INNER JOIN
        investigador_tbl i ON i.id_investigador = ci.id_investigador
    WHERE
        ci.id_cargo_investigador LIKE '%' + @chave + '%' OR
        c.nome LIKE '%' + @chave + '%' OR
        i.primeiro_nome + ' ' + i.nome_meio + ' ' + i.ultimo_nome LIKE '%' + @chave + '%';

    -- Selecionar os dados e adicionar a coluna TotalFiltrados
    SELECT
        ci.id_cargo_investigador [Id],
        c.nome [Cargos],
        i.primeiro_nome + ' ' + i.nome_meio + ' ' + i.ultimo_nome [Funcionários],
        u.primeiro_nome + ' ' + u.nome_meio + ' ' + u.ultimo_nome [Registrado por],
        ci.data_registro [Registrado aos],
        ci.data_atualizacao [Atualizado aos],
        @total AS TotalFiltrados -- Adiciona a contagem total filtrada
    FROM
        cargo_investigador_tbl ci
    INNER JOIN
        cargo_tbl c ON c.id_cargo = ci.id_cargo
    INNER JOIN
        investigador_tbl i ON i.id_investigador = ci.id_investigador
    INNER JOIN
        usuario_tbl u ON u.id_usuario = ci.id_usuario
    WHERE
        ci.id_cargo_investigador LIKE '%' + @chave + '%' OR
        c.nome LIKE '%' + @chave + '%' OR
        i.primeiro_nome + ' ' + i.nome_meio + ' ' + i.ultimo_nome LIKE '%' + @chave + '%';
END;











----- inserir
create proc inserir_cargos_investigadores
	@id_cargo int,
	@id_investigador int,
	@id_usuario int,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into cargo_investigador_tbl values (
	@id_cargo,
	@id_investigador,
	@id_usuario,
	@data_registro,
	@data_atualizacao
);
go
----- atualizar
drop proc atualizar_cargos_investigadores
create proc atualizar_cargos_investigadores
	@id_cargo_investigador int,
	@id_cargo int,
	@id_investigador int,
	@id_usuario int,
	@data_atualizacao datetime
as
update cargo_investigador_tbl set
	id_cargo=@id_cargo,
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_atualizacao=@data_atualizacao
where id_cargo_investigador=@id_cargo_investigador
go
----- eliminar
create proc eliminar_cargo_investigador
	@id_cargo_investigador int
as
delete from cargo_investigador_tbl where id_cargo_investigador=@id_cargo_investigador
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de beneficios
*/
----- selecionar
drop proc selecionar_beneficios
create proc selecionar_beneficios
as
select  b.id_beneficio[Id],
		b.nome[Benefício],
		b.descricao[Descrição],
		u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
		b.data_registro[Registrado aos],
		b.data_atualizacao[Atualizado aos]
	from beneficio_tbl b
inner join usuario_tbl u on u.id_usuario = b.id_usuario
go

-----------Pesquisar
drop proc pesquisar_Beneficios
create proc pesquisar_Beneficios
	@chave varchar(10)
as
select b.id_beneficio[Id],
		b.nome[Benefício],
		b.descricao[Descrição],
		u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
		b.data_registro[Registro aos],
		b.data_atualizacao[Atualizado aos]
	from beneficio_tbl b
inner join usuario_tbl u on u.id_usuario = b.id_usuario
where b.id_beneficio like '%'+@chave+'%' or b.nome like '%'+@chave+'%'
go
-----
----- inserir
create proc inserir_beneficios
	@id_usuario int,
	@nome varchar(50),
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into beneficio_tbl values (
	@id_usuario,
	@nome,
	@descricao,
	@data_registro,
	@data_atualizacao
)
go

----- atualizar
create proc atualizar_beneficios
	@id_beneficio int,
	@id_usuario int,
	@nome varchar(50),
	@descricao text,
	@data_atualizacao datetime
as
update beneficio_tbl set
	id_usuario=@id_usuario,
	nome=@nome,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao
where id_beneficio=@id_beneficio
go
---- eliminar
create proc eliminar_beneficios
	@id_beneficio int
as
delete from beneficio_tbl where id_beneficio=@id_beneficio
go
--====================================================
/*
	procedimentos armazenados para a tabela
	de beneficios investigadores
*/
-------- selecionar
drop proc selecionar_beneficios_investigadores

create proc selecionar_beneficios_investigadores
as
select bi.id_beneficio_investigador[Id],
		b.nome[Benefícios],
		iv.primeiro_nome + iv.nome_meio + iv.ultimo_nome[Beneficiadores],
		bi.data_inicio[Inicio do benefício],
		bi.data_fim[Fim do benefício],
		u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
		bi.data_registro[Registro aos],
		bi.data_atualizacao[Atualizado aos]
	from beneficio_investigador_tbl bi
inner join beneficio_tbl b on b.id_beneficio = bi.id_beneficio
inner join investigador_tbl iv on iv.id_investigador = bi.id_investigador
inner join usuario_tbl u on u.id_usuario = bi.id_usuario
go
-------------pesquisar beneficios
drop proc pesquisar_Ieneficios_Investigadores
create proc pesquisar_Ieneficios_Investigadores
	@chave varchar (10)
as
select bi.id_beneficio_investigador[Id],
		b.nome[Benefícios],
		iv.primeiro_nome + iv.nome_meio + iv.ultimo_nome[Beneficiadores],
		bi.data_inicio[Inicio do benefício],
		bi.data_fim[Fim do benefício],
		u.primeiro_nome + u.nome_meio + u.ultimo_nome[Registrado por],
		bi.data_registro[Registro aos],
		bi.data_atualizacao[Atualizado aos]
	from beneficio_investigador_tbl bi
inner join beneficio_tbl b on b.id_beneficio = bi.id_beneficio
inner join investigador_tbl iv on iv.id_investigador = bi.id_investigador
inner join usuario_tbl u on u.id_usuario = bi.id_usuario
where b.nome like '%'+@chave+'%' or
  iv.primeiro_nome + iv.nome_meio + iv.ultimo_nome like '%'+@chave+'%'
go
-------- inserir
create proc inserir_beneficios_investigadores
	@id_beneficio int,
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@data_registro datetime,
	@data_atualizacao datetime
as
insert into beneficio_investigador_tbl values(
	@id_beneficio,
	@id_investigador,
	@id_usuario,
	@data_inicio,
	@data_fim,
	@data_registro,
	@data_atualizacao
)
go
-------- atualizar
drop proc atualizar_beneficios_investigadores
create proc atualizar_beneficios_investigadores
	@id_beneficio_investigador int,
	@id_beneficio int,
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@data_atualizacao datetime
as
update beneficio_investigador_tbl set
	id_beneficio=@id_beneficio,
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_inicio=@data_inicio,
	data_fim=@data_fim,
	data_atualizacao=@data_atualizacao
 where id_beneficio_investigador = @id_beneficio_investigador
go
-----------------consulta para carregar o nome completo no comboBox-------------
select  id_investigador as ID, (primeiro_nome +' '+nome_meio +' '+ ultimo_nome) as Nomes
	from investigador_tbl
	-----------------Fim da consulta-------------
-------- eliminar
drop proc eliminar_beneficios_investigadores
create proc eliminar_beneficios_investigadores
	@id_beneficio_investigador int
as
delete from beneficio_investigador_tbl where
   id_beneficio_investigador =@id_beneficio_investigador
go


--====================================================
/*
	procedimentos armazenados para a tabela
	de afastamentos
*/
----- selecionar
drop proc selecionar_afastamentos
create proc selecionar_afastamentos
as
 select
		af.id_afastamento[Id],
		inv.primeiro_nome +' '+ inv.nome_meio +' '+ inv.ultimo_nome[Funcionário],
		af.data_inicio[Data inicial],
		af.data_fim[Data final],
		af.descricao[Descrição],
		af.estado[Estado],
		us.primeiro_nome + us.nome_meio + us.ultimo_nome[Registrado por],
		af.data_registro[Registrado aos],
		af.data_atualizacao[Atualizado aos]

 from afastamento_tbl af
inner join investigador_tbl inv on inv.id_investigador = af.id_investigador
inner join usuario_tbl us on us.id_usuario = af.id_usuario

go
--- pesquisar afastamentos
drop proc pesquisar_afastamentos
create proc pesquisar_afastamentos
	@chave varchar (50)
as
 select
		af.id_afastamento[Id],
		inv.primeiro_nome +' '+ inv.nome_meio +' '+ inv.ultimo_nome[Funionário],
		af.data_inicio[Data inicial],
		af.data_fim[Data final],
		af.descricao[Descrição],
		af.estado[Estado],
		us.primeiro_nome +' '+ us.nome_meio +' '+ us.ultimo_nome[Registrado por],
		af.data_registro[Registrado aos],
		af.data_atualizacao[Atualizado aos]

 from afastamento_tbl af
inner join investigador_tbl inv on inv.id_investigador = af.id_investigador
inner join usuario_tbl us on us.id_usuario = af.id_usuario
where
	af.id_afastamento like '%'+@chave+'%' or
	us.primeiro_nome +' '+ us.nome_meio + ' '+ us.ultimo_nome like '%'+@chave+'%' or
	af.estado like '%'+@chave+'%'
go

----- inserir

create proc inserir_afastamentos
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@descricao text,
	@data_registro datetime,
	@data_atualizacao datetime,
	@estado varchar(20)
as
insert into afastamento_tbl values(
	@id_investigador,
	@id_usuario,
	@data_inicio,
	@data_fim,
	@descricao,
	@data_registro,
	@data_atualizacao,
	@estado
)
go

----- Atualizar
create proc atualizar_afastamentos
	@id_afastamento int,
	@id_investigador int,
	@id_usuario int,
	@data_inicio date,
	@data_fim date,
	@descricao text,
	@data_atualizacao datetime,
	@estado varchar(20)
as
update afastamento_tbl set
	id_investigador=@id_investigador,
	id_usuario=@id_usuario,
	data_inicio=@data_inicio,
	data_fim=@data_fim,
	descricao=@descricao,
	data_atualizacao=@data_atualizacao,
	estado=@estado
where id_afastamento=@id_afastamento
go

----- eliminar
create proc eliminar_afastamentos
	@id_afastamento int
as
delete from afastamento_tbl where id_afastamento=@id_afastamento
go




/*==========================CONSULTAS DASHBOARD==========================*/
--- consulta contar
select count(id_afastamento)[Afastamentos] from afastamento_tbl;
select count(id_bairro_rua)[Bairros/ruas] from bairro_rua_tbl;
select count(id_beneficio_investigador)[Bfs. Func.] from beneficio_investigador_tbl;
select count(id_beneficio)[Benefícios] from beneficio_tbl;
select count(id_cargo)[Cargos] from cargo_tbl;
select count(id_caso)[Casos] from caso_tbl;
select count(id_continente)[Continentes] from continente_tbl;
select count(id_curso)[Cursos] from curso_tbl;
select count(id_departamento)[Departamentos] from departamento_tbl;
select count(id_departamento_investigador)[Deprt. Func.] from departamento_investigador_tbl;
select count(id_especialidade)[Espec.] from especialidade_tbl;
select count(id_evidencia)[Evidências] from evidencia_tbl;
select count(id_falta)[Faltas] from falta_tbl;
select count(id_feria)[Férias] from feria_tbl;
select count(id_hora_extra)[H.Extras] from hora_extra_tbl;
select count(id_investigador)[Funcionários] from investigador_tbl;
select count(id_municipio)[Municípios] from municipio_tbl;
select count(id_nivel_academico)[N.acad.] from nivel_academico_tbl;
select count(id_pais)[Países] from pais_tbl;
select count(id_patente)[Patentes] from patente_tbl;
select count(id_provincia)[Províncias] from provincia_tbl;
select count(id_suspeito)[Suspeitos] from suspeito_tbl;
select count(id_testemunha)[Testemunhas] from testemunha_tbl;
select count(id_usuario)[Usuários] from usuario_tbl;
select count(id_vitima)[Vítimas] from vitima_tbl;
select count(id_treinamento)[Treinamento] from treinamento_tbl;
select * from caso_tbl;


-- Consulta para a impressão de relatórios de evento-casos
-- declarando variáveis
declare @data_inicial datetime = '2024-09-17 01:18:34'
declare @data_final datetime = '2024-10-05 10:10:04'
drop proc relatorio_eventos_casos

create proc relatorio_eventos_casos
     @data_inicial datetime,
     @data_final datetime
as
select
     count(evn_cs.id_evento_caso) over () as total_eventos,
     sum(CASE WHEN vma.sexo = 'M' THEN 1 ELSE 0 END) over () as total_masculino,
     sum(CASE WHEN vma.sexo = 'F' THEN 1 ELSE 0 END) over () as total_feminino,
     evn_cs.id_evento_caso as codigo,
     concat('Nome completo: ',vma.primeiro_nome,' ',vma.nome_meio,' ',vma.ultimo_nome,
     '; ','Nasc.: ',vma.data_nascimento,'; ','Sexo: ', vma.sexo,'; ','Tel: ', vma.telefone1) as descricao_vitima,
     concat(cso.titulo,'; ',cso.estado,'; ',evn_cs.tipo_evento,'; ', cast(evn_cs.descricao as varchar(max))) as inf_caso,
     concat(inv.primeiro_nome,' ',inv.nome_meio,' ',inv.ultimo_nome) as responsavel,
     concat(test.primeiro_nome,' ',test.nome_meio,' ',test.ultimo_nome) as testemunha,
     concat(cont.nome,'; ',pais.nome,'; ',prov.nome,'; ',mun.nome,'; ',br.nome) as endereco,
     evn_cs.data_registro as data_do_evento
from evento_caso_tbl evn_cs
inner join vitima_tbl vma on vma.id_vitima = evn_cs.id_vitima
inner join investigador_tbl inv on inv.id_investigador = evn_cs.id_investigador
inner join caso_tbl cso on cso.id_caso = evn_cs.id_caso
inner join testemunha_tbl test on test.id_testemunha = evn_cs.id_testemunha
inner join continente_tbl cont on cont.id_continente = vma.id_continente
inner join pais_tbl pais on pais.id_pais = vma.id_pais
inner join provincia_tbl prov on prov.id_provincia = vma.id_provincia
inner join municipio_tbl mun on mun.id_municipio = vma.id_municipio
inner join bairro_rua_tbl br on br.id_bairro_rua = vma.id_bairro_rua
where evn_cs.data_registro between @data_inicial and  @data_final
group by
     evn_cs.id_evento_caso,
     vma.primeiro_nome, vma.nome_meio, vma.ultimo_nome, vma.data_nascimento, vma.sexo, vma.telefone1,
     cso.titulo, cso.estado, evn_cs.tipo_evento, cast(evn_cs.descricao as varchar(max)),
     inv.primeiro_nome, inv.nome_meio, inv.ultimo_nome,
     test.primeiro_nome, test.nome_meio, test.ultimo_nome,
     cont.nome, pais.nome, prov.nome, mun.nome, br.nome,
     evn_cs.data_registro
order by
    evn_cs.id_evento_caso
go
ALTER TABLE feria_tbl
ALTER COLUMN descricao VARCHAR(MAX);


-- Consulta para a impressão de relatórios de piquete
create proc relatorio_piquete
     @data_inicial datetime,
     @data_final datetime
as
select he.id_hora_extra [Código],
       concat('Nome completo: ',inv.primeiro_nome,' ',inv.nome_meio, ' ', inv.ultimo_nome, '; ','Contatos: ', inv.telefone1,'/',
	   inv.telefone2,'; ',inv.e_mail,'; ','B.I: ',inv.bi) [Detalhes do funcionários],
	   concat('Data: ', he.data_trabalho,'; ','Horas: ',he.horas_trabalhadas,'; ','Período: ',he.tipo_horas) [Detalhes do piquete],
	   he.data_registro [Data de registro]
	from hora_extra_tbl he
inner join investigador_tbl inv on inv.id_investigador = he.id_investigador
where he.data_registro between @data_inicial and  @data_final
group by
     he.id_hora_extra, inv.primeiro_nome, inv.nome_meio, inv.ultimo_nome, inv.telefone1,
	 inv.telefone2, inv.e_mail, inv.bi, he.data_trabalho, he.horas_trabalhadas, he.tipo_horas,
	 he.data_registro
order by
    he.id_hora_extra
go


-- Consulta para a impressão de relatórios de férias
create proc relatorio_ferias
     @data_inicial datetime,
     @data_final datetime
as
select
    f.id_feria [Código],
    concat('Nome completo: ', inv.primeiro_nome, ' ', inv.nome_meio, ' ', inv.ultimo_nome, '; ', 'Contatos: ', inv.telefone1, '/', inv.telefone2, '; ', inv.e_mail, '; ', 'B.I: ', inv.bi) [Detalhes do funcionários],
    concat('Data inicial: ', f.data_inicio, '; ', 'Data final: ', f.data_fim, '; ', 'Estado: ', f.estado_feria, '; ', 'Descrição: ', CAST(f.descricao AS VARCHAR(MAX))) [Detalhes da féria],
    concat(cont.nome, '; ', pais.nome, '; ', prov.nome, '; ', mun.nome, '; ', br.nome) [Endereço],
    f.data_registro [Data_Registro]
from
    feria_tbl f
inner join
    investigador_tbl inv on inv.id_investigador = f.id_investigador
inner join
    continente_tbl cont on cont.id_continente = inv.id_continente
inner join
    pais_tbl pais on pais.id_pais = inv.id_pais
inner join
    provincia_tbl prov on prov.id_provincia = inv.id_provincia
inner join
    municipio_tbl mun on mun.id_municipio = inv.id_municipio
inner join
    bairro_rua_tbl br on br.id_bairro_rua = inv.id_bairro_rua
where
    f.data_registro between @data_inicial and @data_final
group by
    f.id_feria,
    inv.primeiro_nome, inv.nome_meio, inv.ultimo_nome, inv.telefone1, inv.telefone2, inv.e_mail, inv.bi,
    f.data_inicio, f.data_fim, f.estado_feria, CAST(f.descricao AS VARCHAR(MAX)),
    cont.nome, pais.nome, prov.nome, mun.nome, br.nome, f.data_registro
order by
    f.id_feria
go
--- Consulta para a impressão do relatório de faltas.
alter table falta_tbl
alter column descricao varchar(max);
create proc relatorio_faltas
	@data_inicial datetime,
	@data_final datetime
as
select fl.id_falta as Codigo,
	   concat(inv.primeiro_nome, ' ', inv.nome_meio,' ',inv.ultimo_nome) as Funcionario,
	   concat(fl.data_falta,'; ',fl.estado_falta,'; ',fl.descricao) as Desc_Falta,
	   fl.data_registro as Data_Registro
	from falta_tbl fl
inner join investigador_tbl inv on inv.id_investigador = fl.id_investigador
where
	fl.data_registro between @data_inicial and @data_final
group by
 fl.id_falta,
 inv.primeiro_nome, inv.nome_meio,inv.ultimo_nome,
 fl.data_falta,fl.estado_falta,fl.descricao,
 fl.data_registro
order by fl.id_falta
go
--- Consulta para o relatório de afastamentos
create proc relatorio_afastamentos
	@data_inicial datetime,
	@data_final datetime
as
select
	 af.id_afastamento as Codigo,
	 concat(inv.primeiro_nome, ' ', inv.nome_meio,' ',inv.ultimo_nome) as Funcionario,
	 af.data_inicio as Data_inicial_feria,
	 af.data_fim as Data_final_feria,
	 af.estado as Estado,
	 af.data_registro as Data_registro
from afastamento_tbl af
     inner join investigador_tbl inv on inv.id_investigador = af.id_investigador
where af.data_registro between @data_inicial and @data_final
group by
     af.id_afastamento,
	 inv.primeiro_nome, inv.nome_meio,inv.ultimo_nome,
	 af.data_inicio,
	 af.data_fim,
	 af.estado,
	 af.data_registro
order by
af.id_afastamento
go


-- Consulta para o relatório de beneficios e beneficios_funcionarios
create proc relatorio_beneficio_investigador
	@data_inicial datetime,
	@data_final datetime
as
select bi.id_beneficio_investigador as Codigo,
	  concat(inv.primeiro_nome, ' ', inv.nome_meio,' ',inv.ultimo_nome) as Funcionario,
      concat('Nome: ', b.nome,'; ','Descrição: ', b.descricao, '; ', 'Data inicial: (',bi.data_inicio,'),','Data final: (',bi.data_fim,')') as Descricao,
	  bi.data_registro as Data_registro
	 from beneficio_investigador_tbl bi
inner join investigador_tbl inv on inv.id_investigador = bi.id_investigador
inner join beneficio_tbl b on b.id_beneficio = bi.id_beneficio
where bi.data_registro between @data_inicial and @data_final
group by
      bi.id_beneficio_investigador,
	  inv.primeiro_nome,inv.nome_meio,inv.ultimo_nome,
      b.nome,b.descricao,bi.data_inicio,bi.data_fim,
	  bi.data_registro
order by bi.id_beneficio_investigador
go
-- Consulta para o relatório de testemunhas

create proc relatorio_testemunhas
	@data_inicial DATETIME,
	@data_final DATETIME
AS
SELECT
    ts.id_testemunha AS Codigo_Testemunha,
    CONCAT(
        'Dados pessoais: ',
        'Nome completo: (', ISNULL(ts.primeiro_nome, 'N/A'), ' ', ISNULL(ts.nome_meio, ''), ' ', ISNULL(ts.ultimo_nome, 'N/A'), '); ',
        'Data nasc.: (', ISNULL(CONVERT(VARCHAR, ts.data_nascimento, 103), 'N/A'), '); ',
        'Sexo: (', ISNULL(ts.sexo, 'N/A'), ')'
    ) AS Testemunha,
    CONCAT(
        'Endereço: (', ISNULL(cont.nome, 'N/A'), '; ', ISNULL(pais.nome, 'N/A'), '; ', ISNULL(prov.nome, 'N/A'), '; ', ISNULL(mun.nome, 'N/A'), '; ', ISNULL(br.nome, 'N/A'), '); ',
        'Contatos: (', ISNULL(ts.telefone1, 'N/A'), '; ', ISNULL(ts.telefone2, 'N/A'), ', ', ISNULL(ts.e_mail, 'N/A'), '); ',
        'Escolaridade: (', ISNULL(na.nome, 'N/A'), '; ', ISNULL(cr.nome, 'N/A'), '); ',
        'Caso: (', ISNULL(cs.titulo, 'N/A'), '); ',
        'Departamento: (', ISNULL(dp.nome, 'N/A'), '); ',
        'Responsável: (', ISNULL(us.primeiro_nome, ''), ' ', ISNULL(us.nome_meio, ''), ' ', ISNULL(us.ultimo_nome, ''), ')'
    ) AS Informacoes_gerais,
    ts.data_registro as Data_Registro
FROM
    testemunha_tbl ts
inner join
    usuario_tbl us on us.id_usuario = ts.id_usuario
inner join
    continente_tbl cont on cont.id_continente = ts.id_continente
inner join
    pais_tbl pais on pais.id_pais = ts.id_pais
inner join
    provincia_tbl prov on prov.id_provincia = ts.id_provincia
inner join
    municipio_tbl mun on mun.id_municipio = ts.id_municipio
inner join
    bairro_rua_tbl br on br.id_bairro_rua = ts.id_bairro_rua
inner join
    caso_tbl cs on cs.id_caso = ts.id_caso
inner join
    departamento_tbl dp on dp.id_departamento = cs.id_departamento
inner join
    nivel_academico_tbl na on na.id_nivel_academico = ts.id_nivel_academico
inner join
    curso_tbl cr on cr.id_curso = ts.id_curso
where ts.data_registro between @data_inicial and @data_final
group by
    ts.id_testemunha,
    ts.primeiro_nome,ts.nome_meio,ts.ultimo_nome,
    ts.data_nascimento,ts.sexo,
    cont.nome, pais.nome,prov.nome,mun.nome,br.nome, cr.nome,
    ts.telefone1,ts.telefone2,ts.e_mail,na.nome,
    cs.titulo, dp.nome,us.primeiro_nome,us.nome_meio,us.ultimo_nome,
    ts.data_registro
order by ts.data_registro asc
go
-- Consulta para o relatório de vitimas
select *

 from vitima_tbl vt
 inner join
    usuario_tbl us on us.id_usuario = vt.id_usuario
inner join
    continente_tbl cont on cont.id_continente = vt.id_continente
inner join
    pais_tbl pais on pais.id_pais = vt.id_pais
inner join
    provincia_tbl prov on prov.id_provincia = vt.id_provincia
inner join
    municipio_tbl mun on mun.id_municipio = vt.id_municipio
inner join
    bairro_rua_tbl br on br.id_bairro_rua = vt.id_bairro_rua
inner join
    caso_tbl cs on cs.id_caso = vt.id_caso
inner join
    nivel_academico_tbl na on na.id_nivel_academico = ts.id_nivel_academico
inner join
    curso_tbl cr on cr.id_curso = ts.id_curso
-- Consulta para o relatório de evidências
Evidência.

SELECT * FROM aluno_tbl;


BACKUP DATABASE [sic_menongue]
	TO DISK = N'C:\Backups\sic_menongue.bak'
WITH
	NAME = N'sic_menongue'




