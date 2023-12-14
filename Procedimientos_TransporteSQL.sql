/*Para usar la base de datos nombrada*/
use Soft_Transporte_SQL
go

/*Procedimientos para la tabla Clientes*/
create proc MostrarCliente
as
select
idCliente as "ID Cliente",
nombreCliente as Nombre,
telCliente as Telefono,
direccionCliente as Direccion,
correoCliente as Correo,
observacionCliente as "Observación"
from clientes
go

create proc InsertarCliente
@nombreCliente nvarchar (100),
@telCliente nvarchar (100),
@direccionCliente nvarchar (200),
@correoCliente nvarchar (100),
@observacionCliente nvarchar (300)
as
insert into clientes values (@nombreCliente, @telCliente, @direccionCliente, @correoCliente, @observacionCliente)
go

create proc EditarCliente
@idCliente int,
@nombreCliente nvarchar (100),
@telCliente nvarchar (100),
@direccionCliente nvarchar (200),
@correoCliente nvarchar (100),
@observacionCliente nvarchar (300)
as
update clientes set nombreCliente=@nombreCliente, telCliente=@telCliente, direccionCliente=@direccionCliente, correoCliente=@correoCliente, @observacionCliente=@observacionCliente where idCliente=@idCliente
go

create proc EliminarCliente
@idCliente int
as
delete from clientes where idCliente=@idCliente
go


create proc ListarCliente
as
select *from clientes order by idCliente asc
go

/*PROCEDIMIENTOS PARA TABLA CAMIONES*/

create proc MostrarCamion
as
select
idCamion as "ID Camion",
marca as Marca,
modelo as Modelo,
patente as Patente,
capacidad as Capacidad,
observacionCamion as "Observación"
from camiones
go
select *from camiones
create proc InsertarCamion
@marca nvarchar (100),
@modelo int,
@patente nvarchar (50),
@capacidad nvarchar (100),
@observacionCamion nvarchar (300)
as
insert into camiones values (@marca, @modelo, @patente, @capacidad, @observacionCamion)
go

create proc EditarCamion
@idCamion int,
@marca nvarchar (100),
@modelo int,
@patente nvarchar (50),
@capacidad nvarchar (100),
@observacionCamion nvarchar (300)
as 
update camiones set marca=@marca, modelo=@modelo, patente=@patente, capacidad=@capacidad, observacionCamion=@observacionCamion where idCamion=@idCamion
go

create proc EliminarCamion
@idCamion int
as
delete from camiones where idCamion=@idCamion
go

create proc ListarCamion
as
select *from camiones order by idCamion asc
go

/*PROCEDIMIENTOS PARA TABLA CHOFERES*/

create proc MostrarChofer
as
select
idChofer as "ID Chofer",
nombreChofer as Nombre,
licencia as "Vencimiento Licencia",
documento as DNI,
telefono as Telefono,
antiguedad as Antiguedad
from choferes
go

create proc InsertarChofer
@nombreChofer nvarchar (100),
@licencia nvarchar (100),
@documento nvarchar (100),
@telefono nvarchar (100),
@antiguedad nvarchar (50)
as 
insert into choferes values (@nombreChofer, @licencia, @documento, @telefono, @antiguedad)
go

create proc EditarChofer
@idChofer int,
@nombreChofer nvarchar (100),
@licencia nvarchar (100),
@documento nvarchar (100),
@telefono nvarchar (100),
@antiguedad nvarchar (50)
as
update choferes set nombreChofer=@nombreChofer, licencia=@licencia, documento=@documento, telefono=@telefono, antiguedad=@antiguedad where idChofer=@idChofer
go

create proc EliminarChofer
@idChofer int
as
delete from choferes where idChofer=@idChofer
go	

create proc ListarChofer
as
select *from choferes order by idChofer asc
go

/*PROCEDIMIENTOS PARA LA TABLA VIAJES*/

create proc MostrarViajes
as
select
idViaje as "ID",
camiones.patente as Camion,
choferes.nombreChofer as Chofer,
clientes.nombreCliente as Cliente,
fechaViaje as Fecha,
origen as Origen,
destino as Destino,
carga as Carga,
costo as Costo,
observacionViaje as "Observación"
from viajes
inner join camiones on camiones.idCamion=viajes.idCamion
inner join choferes on choferes.idChofer=viajes.idChofer
inner join clientes on clientes.idCliente=viajes.idCliente
go

create proc InsertarViaje
@idCamion int,
@idChofer int,
@idCliente int,
@fechaViaje nvarchar (50),
@origen nvarchar (150),
@destino nvarchar (150),
@carga nvarchar (150),
@costo nvarchar (150),
@observacionViaje nvarchar (300)
as
insert into viajes values (@idCamion, @idChofer, @idCliente, @fechaViaje, @origen, @destino, @carga, @costo, @observacionViaje)
go


create proc EditarViaje
@idViaje bigint,
@idCamion int,
@idChofer int,
@idCliente int,
@fechaViaje nvarchar (50),
@origen nvarchar (150),
@destino nvarchar (150),
@carga nvarchar (150),
@costo nvarchar (150),
@observacionViaje nvarchar (300)
as
update viajes set idCamion=@idCamion, idChofer=@idChofer, idCliente=@idCliente, fechaViaje=@fechaViaje, origen=@origen, destino=@destino, carga=@carga, costo=@costo, observacionViaje=@observacionViaje where idViaje=@idViaje
go

create proc EliminarViaje
@idViaje bigint
as
delete from viajes where idViaje=@idViaje
go

insert into viajes 
values ( '4','3','4', '2023-12-12', 'Lujan', 'Maipu', 'Maiz', '2500', 'Entrega inmediata');

select *from viajes