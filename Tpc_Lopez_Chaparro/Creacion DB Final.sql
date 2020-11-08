Create database TPC_LopezChaparroProga
go
use TPC_LopezChaparroProga
go
Create Table Empleados (
	ID smallint not null primary key identity (1,1),
	Legajo smallint not null unique,
	Nombre varchar(100) not null,
	Apellido varchar(50) not null,
	DNI varchar(20) not null unique,
	Telefono varchar(20) not null,
	mail varchar(100) not null unique,
	Estado bit not null,
)
GO
Create table Usuario(
	IDEmpleado smallint not null primary key,
	NombreUsuario varchar(50) not null unique,
	Contraseña VARBINARY(8000) not null,
	Perfil varchar(50) not null,
 )
 go
 create table Tipo_Platos(
	ID tinyint not null primary key identity(1,1),
	Nombre varchar(50),
 )
 go
 Create table Carta(
	ID smallint not null primary key identity(1,1),
	Nombre varchar(50) not null,
	Precio money not null,
	IDTipo_Platos tinyint foreign key references Tipo_Platos(ID),
	Descripcion varchar(100) null,
)
go
create table Pedido(
	ID bigint not null primary key identity(1,1),
	NumPedido bigint not null,
	IDCarta smallint foreign key references Carta(ID),
	IDEmpleado smallint foreign key references Empleados(ID),
	NumeroMesa smallint not null,
	Estado bit not null, 
)
go
Create table DetallePedido(
		ID bigint not null primary key identity(1,1),
		NumPedido bigint not null,
		IDCarta smallint foreign key references Carta(ID),
		cantidad tinyint not null,
		Precio money not null,
	)
go
alter table Usuario 
add constraint FK_Empleados foreign key (IDEmpleado) references Empleados (ID)
go
alter table Carta
add constraint CHK_PrecioPositivo Check (precio>0)
go
alter table Pedido
add constraint CHK_MesaPositivo check (NumeroMesa > 0)
go
alter table DetallePedido
add constraint CHK_CantPos check (cantidad > 0)
go
alter table DetallePedido
add constraint CHK_PrecioPos check (Precio > 0)
go
alter table Usuario
add constraint CHK_NombrePerfil check(Perfil = 'Administrador' or Perfil = 'Mozo' or Perfil = 'Cocina' or perfil='Caja' )
