use Salba

DROP TABLE nota_nivelUno
DROP TABLE nota_nivelDos
DROP TABLE nota_nivelTres
DROP TABLE nota_nivelcuatro
DROP TABLE nota_nivelCinco
DROP TABLE nota_nivelSeis


CREATE TABLE aprendiz(
codAp int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(90) not null,
nDocumento int not null,
correo varchar(70)not null,
contraseña varchar(40)not null)

CREATE TABLE nota_nivelUno(
codN1 int IDENTITY(1,1) PRIMARY KEY,
notaUno varchar(50) null,
puntuacion int,
fecha varchar(50) null,
codAp int foreign key(codAp)
references aprendiz(codAp))

CREATE TABLE nota_nivelDos(
codN2 int IDENTITY(1,1) PRIMARY KEY,
notaDos varchar(50) null,
puntuacion int,
fecha varchar(60),
codAp int foreign key(codAp)
references aprendiz(codAp))

CREATE TABLE nota_nivelTres(
codN3 int IDENTITY(1,1) PRIMARY KEY,
notaTres varchar(50) null,
puntuacion int,
fecha varchar(60),
codAp int foreign key(codAp)
references aprendiz(codAp))

CREATE TABLE nota_nivelCuatro(
codN4 int IDENTITY(1,1) PRIMARY KEY,
notaCuatro varchar(60) null,
puntuacion int,
fecha varchar(60) null,
codAp int foreign key(codAp)
references aprendiz(codAp))

CREATE TABLE nota_nivelCinco(
codN5 int IDENTITY(1,1) PRIMARY KEY,
notaCinco varchar(60) null,
puntuacion int,
fecha varchar(60) null,
codAp int foreign key(codAp)
references aprendiz(codAp))

CREATE TABLE nota_nivelSeis(
codN6 int IDENTITY(1,1) PRIMARY KEY,
notaSeis varchar(60) null,
puntuacion int,
fecha varchar(60)null,
codAp int foreign key(codAp)
references aprendiz(codAp))

select * from nota_nivelCinco



create procedure pa_RegisUsuario
(
@nomApre varchar(70),
@numDoc varchar(30),
@corrApre varchar(90),
@pass varchar(70)
)
as
begin
insert into aprendiz values(@nomApre,@numDoc,@corrApre,@pass)
end 
go




create procedure pa_ValidApre
as
begin
select * from aprendiz;
end 
go




CREATE TABLE Nivel
(
id int primary key identity(1,1),
numeroNivel int,
codAp int foreign key(codAp) references aprendiz(codAp)
)


create procedure idAprendiz
(
@codigoAprendiz int 
)
as
begin 
select  codAp from aprendiz where nDocumento = @codigoAprendiz;
end 
go



create procedure pa_Defecto
(
@documento int 
)
as
begin
select numeroNivel  from  Nivel as n inner join aprendiz as a on n.codAp = @documento;
end
go

create procedure p_ModificarNivel
(
@numero int,
@codAp int

)
as
begin
UPDATE Nivel
SET  numeroNivel= @numero
WHERE codAp =  @codAp;
end
go





CREATE PROCEDURE  pa_ValidApreRegistro
(
@numDoc int
)
as
begin

select * from aprendiz where nDocumento = @numDoc;
end
go


create procedure pa_ValidApre
(
@numDoc int ,
@contraseña varchar(70)
)
as
begin
select * from aprendiz  where nDocumento = @numDoc and contraseña =@contraseña;
end 


create procedure pa_RegisUsuario
(
@nomApre varchar(70),
@numDoc varchar(30),
@corrApre varchar(90),
@pass varchar(70)
)
as
begin
insert into aprendiz values(@nomApre,@numDoc,@corrApre,@pass)
end 


create procedure p_InsertarNivel0
(

@codAp int

)
as
begin
insert into Nivel values(0,@codAp);
end



create procedure idAprendiz07
(

@codAp int

)
as
begin
select * from  Nivel where codAp = @codAp;
end




