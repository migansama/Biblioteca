use Biblioteca

-- Creacion de tablas --
--Creando tabla libro--
create table Libro
(
ID bigint identity(1,1) not null,
Titulo varchar(20) not null,
Edicion char(5) not null,
Idioma nchar(20) not null,
Genero varchar(20) not null,
ISBN varchar(13) DEFAULT ' ',
No_Pags int not null,
Volumen int  DEFAULT ' ',
Ubicacion char(5) not null,
Formato varchar(8) not null,
Costo int not null,
Estado int, -- solo tendrá valores 0/1 para saber si está o no en la biblioteca--
IDEditora int,
IDAutor int,
IDPais int,
IDMoneda int
)
--Creando tabla Autor--
create table Autor
(
ID int identity(1,1) not null,
Nombre varchar(40) not null,
Nacionalidad varchar(20)
)
--Creando tabla Casa Editora--
create table Casa_Editora
(
ID int identity(1,1) not null,
Nombre varchar(50) not null,
Pais varchar(30) not null
)
--Creando tabla Socio--
create Table Socio
(
Cedula varchar(13) not null,
Nombre varchar(40) not null,
TelefonoCasa varchar(10) not null,
TelefonoCell varchar(10),
Direccion text not null,
Correo varchar(40)
)
--Creando tabla Préstamo--
create table Prestamo
(
FechaInicio date not null,
FechaFin date not null,
IDSocio varchar(13),
IDlibro bigint
)
--Creando tabla Pais--
create table Pais
(
ID int not null,
Symbol char(2) not null,
Name varchar(50) not null
)
--Creando tabla Moneda--
create table Moneda
(
ID int identity(1,1) not null,
Symbol char(3) not null,
Name varchar(50) not null
)

-- Eliminar Tablas --

drop table Autor
drop table Casa_Editora
drop table Libro
drop table Prestamo
drop table Socio

--Establecer llaves primarias--

ALTER TABLE libro ADD CONSTRAINT pk_libro_ID PRIMARY KEY (ID)

ALTER TABLE Autor ADD CONSTRAINT pk_Autor_ID PRIMARY KEY (ID)

ALTER TABLE Casa_Editora ADD CONSTRAINT pk_Casa_Editora_ID PRIMARY KEY (ID)

ALTER TABLE Socio ADD CONSTRAINT pk_Socio_Cedula PRIMARY KEY (Cedula)

ALTER TABLE Moneda ADD CONSTRAINT pk_Moneda_ID PRIMARY KEY (ID)

ALTER TABLE Pais ADD CONSTRAINT pk_Pais_ID PRIMARY KEY (ID)

--Agregando las columnas a ser llaves foraneas--

alter table Prestamo
add IDlibro bigint

alter table Prestamo
add IDSocio varchar(13)

alter table libro
add IDEditora int

alter table libro
add IDAutor int

--Establecer llaves foraneas-- 

ALTER TABLE Prestamo ADD CONSTRAINT FK_Prestamo_IDSocio FOREIGN KEY (IDSocio) REFERENCES Socio(Cedula)
ALTER TABLE Pestamo DROP CONSTRAINT FK_Prestamo_IDSocio
ALTER TABLE Prestamo ADD CONSTRAINT FK_Prestamo_IDlibro FOREIGN KEY (IDlibro) REFERENCES libro(ID)
ALTER TABLE Prestamo DROP CONSTRAINT FK_Prestamo_IDlibro
ALTER TABLE Libro ADD CONSTRAINT FK_libro_IDEditora FOREIGN KEY (IDEditora) REFERENCES Casa_Editora(ID)
ALTER TABLE Libro DROP CONSTRAINT FK_libro_IDEditora
ALTER TABLE Libro ADD CONSTRAINT FK_libro_IDAutor FOREIGN KEY (IDAutor) REFERENCES Autor(ID)
ALTER TABLE Libro DROP CONSTRAINT FK_libro_IDAutor
ALTER TABLE Libro ADD CONSTRAINT FK_libro_IDPais FOREIGN KEY (IDPais) REFERENCES Pais(ID)
ALTER TABLE Libro DROP CONSTRAINT FK_libro_IDPais
ALTER TABLE Libro ADD CONSTRAINT FK_libro_IDMoneda FOREIGN KEY (IDMoneda) REFERENCES Moneda(ID)
ALTER TABLE Libro DROP CONSTRAINT FK_libro_IDMoneda



