/*Creando la base de datos*/
create database Soft_Transporte_SQL
go

use Soft_Transporte_SQL
go


create table clientes(
idCliente int identity (1,1) primary key not null,
nombreCliente nvarchar (100),
telCliente nvarchar (100),
direccionCliente nvarchar (200),
correoCliente nvarchar (100),
observacionCliente nvarchar (300)
)
go

create table camiones(
idCamion int identity (1,1) primary key not null,
marca nvarchar (100),
modelo int,
patente nvarchar (50),
capacidad nvarchar(100),
observacionCamion nvarchar (300)
)
go

create table choferes(
idChofer int identity (1,1) primary key not null,
nombreChofer nvarchar (100),
licencia nvarchar (100),
documento nvarchar(100),
telefono nvarchar (100),
antiguedad nvarchar (50)
)
go

create table viajes(
idViaje bigint identity (1,1) primary key not null,
idCamion int,
idChofer int,
idCliente int,
fechaViaje nvarchar (50),
origen nvarchar (150),
destino nvarchar (150),
carga nvarchar (150),
costo nvarchar (150),
observacionViaje nvarchar (300),
foreign key (idCamion) references camiones (idCamion) on update cascade on delete cascade,
foreign key (idChofer) references choferes (idChofer) on update cascade on delete cascade,
foreign key (idCliente) references clientes (idCliente) on update cascade on delete cascade
)
go