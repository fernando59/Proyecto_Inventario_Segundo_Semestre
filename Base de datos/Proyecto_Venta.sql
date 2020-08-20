create database Proyecto_Venta;
use Proyecto_Venta;

create table Login_Venta
(
Id_Usuario int identity(1,1) primary key not null,
Usuario nvarchar(50) not null,
Contrasena nvarchar(50) not null,
Email nvarchar(50),
);
--Tipo de persona
create table Tipo_Persona
(
TipoPersona int identity (1,1) primary key,
Nombre varchar(50)
);
--Persona
create table Persona
(
Id_Persona int identity(1,1) primary key not null,
tipo_persona2 int not null references Tipo_Persona (TipoPersona),
Nombre nvarchar(50) not null,
Apellido nvarchar(50) not null,
Telefono nvarchar(10),
constraint Persona_AltPK unique (Id_Persona,tipo_persona2)
)
--Proveedores
create table Proveedor
(
Id_proveedor int primary key,
correo nvarchar(50),
producto nvarchar(50),
foreign key(Id_proveedor) references Persona(Id_Persona)
);
--Tabla cliente
create table Cliente
(
Id_Cliente int primary key,
tipo_persona3 as 1 persisted,
Direccion nvarchar(100),
foreign key(Id_Cliente,tipo_persona3) references Persona(Id_Persona,tipo_persona2) on delete  cascade 
);
--Tabla categoria
create table Categoria
(
Id_Categoria int identity (1,1) primary key not null,
Nombre_Categoria nvarchar(50) not null,
detalle nvarchar(50),
);
--Tabla productos
create table Productos
(
Id_Productos int identity(1,1) primary key,
Nombre nvarchar(50) not null,
Descripcion nvarchar(100) not null,
Precio_compra decimal(6,2),
Stock int,
Id_categorias int
foreign key(Id_Categorias) references Categoria (Id_categoria) 
on update cascade on delete cascade
);
--tabla venta
create table Venta
(
Id_Venta int identity (1,1) primary key not null,
ID_cliente2 int,
Fecha nvarchar (50),
tipo_pago nvarchar(100),
constraint Relacion_A_Cliente foreign key(Id_cliente2) references Cliente(Id_Cliente)
on update cascade on delete cascade,
);
--Detalle venta
create table Detalle_Venta
(
Id int identity(1,1),
Id_Detalle_Venta int,
Id_productos3 int,
Cantidad int,
precio decimal(10,2),
total decimal(10,2),
foreign key(Id_productos3) references Productos (Id_Productos) 
on update cascade on delete cascade,
foreign key(Id_Detalle_Venta) references Venta(Id_Venta)
on update cascade on delete cascade,
primary key(Id,Id_Detalle_Venta,Id_productos3)
);
--tabla compra
create table Pedido
(
Id_Pedido int identity(1,1) primary key,
Fecha nvarchar(50),
tipo_pago nvarchar(50),
Id_proveedor2 int,
constraint Relacion_A_Proveedor foreign key(Id_proveedor2) references Proveedor(Id_Proveedor)
on update cascade on delete cascade,
);
--Detalle compra
create table Detalle_Pedido
(
Id int identity(1,1),
Id_Pedido int,
Id_productos3 int,
cantidad int,
Precio decimal(14,2),
total decimal(14,2),
constraint Relacion_A_Productos foreign key(Id_productos3) references Productos (Id_Productos) 
on update cascade on delete cascade,
constraint Relacion_A_Pedido foreign key(Id_Pedido) references Pedido(Id_Pedido)
on update cascade on delete cascade,
primary key(Id,Id_Pedido,Id_productos3)
);
go

