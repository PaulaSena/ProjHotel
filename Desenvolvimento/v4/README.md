# ProjHotel  TESTES

Desenvolvimento de sistema de Hotelaria em Desktop com C#, Web com Aspnet e Java para Mobile.

# Protótipo
## Desktop

#### Teste tela de Login Desktop
<img src="https://raw.githubusercontent.com/PaulaSena/ProjHotel/main/ImagensTelas/Desktop/TesteTela/frmlogin.PNG" title="Tela de Login Desktop" width=800 height=600 align="center">
<img src="https://raw.githubusercontent.com/PaulaSena/ProjHotel/main/ImagensTelas/Desktop/TesteTela/frmcadastrouser.PNG" title="Tela de Cadastro Usuario Desktop" width=800 height=600 align="center">
<img src="https://raw.githubusercontent.com/PaulaSena/ProjHotel/main/ImagensTelas/Desktop/TesteTela/frmhome.PNG" title="Tela Home Desktop" width=800 height=600 align="center">

Realizada simples validações com if e else e link em alguns botões telas iniciais.

-Tela de login
-Tela home 
-Tela de cadastro.

Login:admin
Senha:admin


Realizada a estrutura MVC inclusão da classe Usuario e Banco de dados.

-Model
-View 
-Controller 

SQL Server Criando Banco 

BANCO DE DADOS – Scrips para geração do banco de dados.
-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.

--Criação da base de Dados do Hotel---

CREATE DATABASE HOTEL

CREATE TABLE Pessoa (
idPessoa INTEGER PRIMARY KEY,
telPessoal VARCHAR(13),
nome VARCHAR(40),
dataNasci DATETIME,
emailPessoal VARCHAR(50),
dataDeAceP DATETIME
)
CREATE TABLE endereco (
endereco_PK INTEGER PRIMARY KEY,
endereco VARCHAR(10),
idHosp_FK INTEGER,
idFunc_FK INTEGER
)
CREATE TABLE Usuario_Funcionario (
idFunc INTEGER PRIMARY KEY,
cargo VARCHAR(30),
dataAcessoFunc DATETIME,
situacaoFunc VARCHAR(10),
cpf VARCHAR(14),
rg VARCHAR(12)
)
CREATE TABLE email (
email_PK INTEGER PRIMARY KEY,
email VARCHAR(10),
idFunc_FK INTEGER,
idHosp_FK INTEGER
)
CREATE TABLE Usuario_Hospede (
idHosp INTEGER PRIMARY KEY,
situacaoHosp VARCHAR(10),
dataAcessoHop VARCHAR(10),
cpf VARCHAR(14),
rg VARCHAR(12)
)
CREATE TABLE telefone (
telefone_PK INTEGER PRIMARY KEY,
telefone VARCHAR(10),
idFunc_FK INTEGER,
idHosp_FK INTEGER
)
CREATE TABLE Usuario (
idUser INTEGER PRIMARY KEY,
tipoUser VARCHAR(10),
senha VARCHAR(10),
estadLogin VARCHAR(10),
loginUser VARCHAR(15),
dataDeAceUser DATETIME,
fotoPerfil VARCHAR(500),
idPessoa INTEGER,
idAceite INTEGER,
idFunc_FK INTEGER,
idHosp_FK INTEGER,
FOREIGN KEY(idPessoa) REFERENCES Pessoa (idPessoa),
FOREIGN KEY(idFunc_FK) REFERENCES Usuario_Funcionario (idFunc),
FOREIGN KEY(idHosp_FK) REFERENCES Usuario_Hospede (idHosp)
)
CREATE TABLE Operacao (
idOperacao INTEGER,
dataOperacao DATETIME,
idAceite INTEGER,
idUser INTEGER,
idHosp INTEGER,
idFunc INTEGER,
idPessoa INTEGER,
PRIMARY KEY(idOperacao,idAceite, idUser,idHosp,idFunc,idPessoa)
)
CREATE TABLE Aceite (
idAceite INTEGER PRIMARY KEY,
estadoAceite VARCHAR(10),
description VARCHAR(1000),
dataAceite DATETIME,
tipo VARCHAR(10),
politica VARCHAR(1000),
lgpd VARCHAR(1000),
emailMark VARCHAR(25),
lembrarSenha VARCHAR(10)
)
ALTER TABLE endereco ADD FOREIGN KEY(idHosp_FK) REFERENCES Usuario_Hospede (idHosp)
ALTER TABLE endereco ADD FOREIGN KEY(idFunc_FK) REFERENCES endereco (endereco_PK)
ALTER TABLE email ADD FOREIGN KEY(idFunc_FK) REFERENCES email (email_PK)
ALTER TABLE email ADD FOREIGN KEY(idHosp_FK) REFERENCES email (email_PK)
ALTER TABLE telefone ADD FOREIGN KEY(idFunc_FK) REFERENCES telefone (telefone_PK)
ALTER TABLE telefone ADD FOREIGN KEY(idHosp_FK) REFERENCES telefone (telefone_PK)
ALTER TABLE Usuario ADD FOREIGN KEY(idAceite) REFERENCES Aceite (idAceite)

-----

--inserindo usuario

CREATE TABLE Usuario (
idUser INTEGER PRIMARY KEY,
tipoUser VARCHAR(13),
senha VARCHAR(13),
estadLogin VARCHAR(10),
loginUser VARCHAR(15),
dataDeAceUser DATETIME,
fotoPerfil VARCHAR(500),
idPessoa INTEGER,
idAceite INTEGER,
idFunc_FK INTEGER,
idHosp_FK INTEGER,
FOREIGN KEY(idPessoa) REFERENCES Pessoa (idPessoa),
FOREIGN KEY(idFunc_FK) REFERENCES Usuario_Funcionario (idFunc),
FOREIGN KEY(idHosp_FK) REFERENCES Usuario_Hospede (idHosp)
)

--inserindo usuario

INSERT INTO Usuario (idUser,tipoUser,senha,estadLogin,loginUser,dataDeAceUser,fotoPerfil)Values
(1,'Funcionário','admF001','Ativo','F001',2021-10-05,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(2,'Funcionário','admF002','Ativo','F002',2021-10-05,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(3,'Funcionário','admF003','Ativo','F003',2021-10-05,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(4,'Funcionário','admF004','Ativo','F004',2021-11-06,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(5,'Funcionário','admF005','Ativo','F005',2021-11-07,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(6,'Funcionário','admF006','Ativo','F006',2021-13-08,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ'),
(7,'Hóspede','H001','Ativo','H001',2021-14-09,'https://media-exp1.licdn.com/dms/image/C4D03AQEhuCQzva4jsA/profile-displayphoto-shrink_200_200/0/1630419953789?e=1639008000&v=beta&t=JFQaEuJ4atM5gNfsX7fya4-uzTUoMs3kzDl8FSojvlQ')
GO




***07/10/2021 13:27********* Testando outro modelo no MVC e banco para realizar login 06 a 07/10/2021 13:27


create database MyCompany
go
use MyCompany
go
create table Users(
UserID int identity(1,1) primary key,
LoginName nvarchar (100) unique not null,
Password nvarchar (100) not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Position nvarchar (100) not null,
Email nvarchar(150)not null
) 

insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz')
insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com')                                                         
insert into Users values ('Kathy','abc123456','Kathrine','Smith','Accounting','KathySmith@MyCompany.com')

select *from Users 

--SELECT * FROM Users WHERE LoginName=@user and PassWord= @pass

SELECT * FROM Users WHERE LoginName='admin' and PassWord= 'admin'

declare @user nvarchar (100) = 'admin'
declare @pass nvarchar (100) = 'admin'
SELECT * FROM Users WHERE LoginName=@user and PassWord= @pass 


****07/10/2021 13:27********** Criado form Home logado com sucesso!





