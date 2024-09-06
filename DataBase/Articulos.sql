-- CREATE DATABASE Articulos 
-- use Articulos 

-- Create table Productos(
--     IdArticulo int primary key identity(1,1),
--     CodigoArticulo varchar(10) unique not null,
--     Nombre varchar(50) not null,
--     Descripcion varchar(80) null
-- )

-- alter table Productos
-- add Precio decimal(10,2) not null

-- alter table Productos 
-- add Imagen varchar(255) null

-- create table Marca(
--     idMarca int primary key identity(1,1),
--     NombreMarca varchar(80) not null unique
-- )

-- create table Categoria(
--     idCategoria int primary key identity(1,1),
--     NombreCategoria varchar(80) not null unique
-- )

-- alter table Productos
-- add constraint fk_marca FOREIGN key (IdMarca) REFERENCES Marca(IdMarca)