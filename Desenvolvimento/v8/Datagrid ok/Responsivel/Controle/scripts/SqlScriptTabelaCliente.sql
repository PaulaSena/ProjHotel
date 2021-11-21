--CREAR TABLA 
CREATE TABLE Clientes (
  idCli int IDENTITY(1,1) primary key,
  Nome varchar(20) NOT NULL,
  Sobrenome varchar(30) NOT NULL,
  Direcao varchar(100) NOT NULL,
  Cidade varchar(100) NOT NULL,
  Email varchar(100) NOT NULL,
  Telefone varchar(25) NOT NULL,
  Ocupacao varchar(100) NOT NULL
);
go
--INSERCION DE 10 MIL REGISTROS
insert into Clientes values(N'Nehuén',N'Trejo',N'4948 Hickman Street',N'Chicago',N'NehuenTrejoGamboa@cuvox.de',N'630-523-1794',N'Local transit bus driver');
insert into Clientes values(N'Olimpo',N'Garibay',N'1473 Mahlon Street',N'Southfield',N'OlimpoGaribayLimon@rhyta.com',N'734-227-9161',N'Roustabout');
insert into Clientes values(N'Normando',N'Segovia',N'505 Reppert Coal Road',N'Southfield',N'NormandoSegoviaLozano@teleworm.us',N'586-819-7304',N'Agronomist');
insert into Clientes values(N'Cuasimodo',N'Acevedo',N'3129 Eagle Drive',N'Southfield',N'CuasimodoAcevedoPaz@cuvox.de',N'734-758-1113',N'Management accountant');
insert into Clientes values(N'Tilo',N'Quintero',N'1026 Park Avenue',N'Sacramento',N'TiloQuinteroRoybal@superrito.com',N'916-479-8297',N'Grader operator');
insert into Clientes values(N'Efraim',N'Fajardo',N'4402 Oakway Lane',N'Los Angeles',N'EfraimFajardoCuellar@fleckens.hu',N'818-329-2608',N'Metal pourer');
insert into Clientes values(N'Viviano',N'Maestas',N'118 Water Street',N'Walnut Creek',N'VivianoMaestasColunga@rhyta.com',N'925-287-1169',N'School and college counselor');
insert into Clientes values(N'Denisse',N'Alva',N'2916 Glendale Avenue',N'Northridge',N'DenisseAlvaRoque@teleworm.us',N'818-727-3647',N'Sports book runner');
insert into Clientes values(N'Mamerto',N'Briseño',N'875 Mahlon Street',N'Red Bank',N'MamertoBrisenoLopez@rhyta.com',N'732-964-2074',N'Dance captain');
insert into Clientes values(N'Heliena',N'Montez',N'3759 Clifford Street',N'Oakland',N'HelienaMontezGamboa@rhyta.com',N'510-663-2656',N'Computer hardware engineer');
insert into Clientes values(N'Luano',N'Carvajal',N'4504 Little Acres Lane',N'Dieterich',N'LuanoCarvajalVerdugo@armyspy.com',N'217-925-9141',N'Oral surgeon');
insert into Clientes values(N'Urban',N'Delgado',N'3431 Raoul Wallenberg Place',N'Milford',N'UrbanDelgadoMayonga@superrito.com',N'203-882-0180',N'Combined food preparation and serving worker');
insert into Clientes values(N'Saustin',N'Gracia',N'356 Marcus Street',N'Gadsden',N'SaustinGraciaPerea@einrot.com',N'256-549-8973',N'Education and training manager');
insert into Clientes values(N'Malva',N'Correa',N'271 Brown Street',N'Oakland',N'MalvaCorreaResendez@gustr.com',N'925-984-4729',N'Tool and die maker');
insert into Clientes values(N'Sein',N'Vallejo',N'2172 Moore Avenue',N'Fort Worth',N'SeinVallejoYanez@einrot.com',N'817-782-5307',N'Word processor');
insert into Clientes values(N'Olimpo',N'Gallardo',N'4747 Briarwood Road',N'Joplin',N'OlimpoGallardoBriseno@armyspy.com',N'417-825-8900',N'Geologist');
insert into Clientes values(N'Lalita',N'Villalpando',N'2272 Reeves Street',N'Brussels',N'LalitaVillalpandoEchevarria@einrot.com',N'920-825-8672',N'Management analyst');
insert into Clientes values(N'Angie',N'Ordóñez',N'4795 Calvin Street',N'Baltimore',N'AngieOrdonezAlcala@teleworm.us',N'443-408-2164',N'Hanger');

Select *from Clientes 

--Busqueda de datos exactos
select *from Clientes where Nome='Olimpo'

--Busqueda de datos por Aproximacion 
select *from Clientes where Nome like 'Ma%'

--PROCEDIMIENTO
CREATE PROC VerRegistros
@Condicao varchar(30)
as
select *from Clientes where idCli like @Condicion+'%' or Nome like @Condicion+'%' 
go
exec VerRegistros 'Ang'