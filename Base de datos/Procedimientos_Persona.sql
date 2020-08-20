use Proyecto_Venta;
go
--Procedimientos almacenados personas
--Insertar Usuario
create proc Insertar_Usuario
@Usuario nvarchar(50),
@Contrasena nvarchar(50),
@Email nvarchar(50)
as
insert into Login_Venta values(@Usuario,@Contrasena,@Email)
go
--Modificar Usuario
create proc Modificar_Usuario
@Id int,
@Usuario nvarchar(50),
@Contrasena nvarchar(50),
@Email nvarchar(50)
as
Update  Login_Venta set Usuario=@Usuario,Contrasena=@Contrasena ,Email=@Email
where Id_Usuario=@Id
go
--Mostrar Usuario
create proc Mostrar_Usuario
as
select Id_Usuario,Usuario,Contrasena,Email
from Login_Venta
go
--Verificar usuario
create proc Verificar_Usuario
@Usuario nvarchar(50)
as
select Usuario
from Login_Venta where @Usuario=Usuario 
go
--Verificar Contraseña
create proc Verificar_Contrasena
@Contrasena nvarchar(50)
as
select Contrasena
from Login_Venta where @Contrasena=Contrasena
go
--Insertar UsuarioCliente
create proc Insertar_PersonaCLiente
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(10)
as
insert into Persona values(1,@Nombre,@Apellido,@Telefono)
go
--Modificar PersonaCLiente
create proc Modificar_PersonaCliente
@Id int,
@Nombre nvarchar(50) ,
@Apellido nvarchar(50),
@Telefono nvarchar(10)
as
update  Persona set Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono
where Persona.Id_Persona=@Id
go
--Modificar Cliente
create proc Modificar_Cliente
@Id int,
@Direccion nvarchar(50)
as
update Cliente set Direccion=@Direccion
where Id_Cliente=@Id
go
--Eliminar Cliente
create proc Eliminar_Cliente
@Id int
as
delete Persona
where Id_Cliente=@Id 
go
--Verificar Id
create proc Obtener_Id
as
select top(1) Id_Persona
from Persona
order by Id_Persona desc
go
------------------------------------------------------Cliente
--Insertar Cliente
create proc Insertar_Cliente
@Direccion nvarchar(100),
@Id_persona int
as
insert into Cliente values (@Id_persona,@Direccion)
go
--Mostrar Cliente
create proc Mostrar_Clientes
as
select Persona.Id_Persona, Persona.nombre,Persona.Apellido,Persona.Telefono,Cliente.Direccion
from Cliente,Persona
where Cliente.Id_Cliente=Persona.Id_Persona
go
--Insertar Persona_Proveedor
create proc Insertar_PersonaProveedor
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@Telefono nvarchar(10)
as
insert into Persona values(2,@Nombre,@Apellido,@Telefono)
go
--Eliminar Proveedor
create proc Eliminar_Proveedor
@Id int
as
delete Proveedor
where Id_proveedor=@Id 
go
--Mostrar Proveedor
create proc Mostrar_Proveedor
as
select Persona.Id_Persona,Persona.Nombre,Persona.Apellido,Persona.Telefono,Proveedor.correo,Proveedor.producto
from Persona,Proveedor
where Persona.Id_Persona=Proveedor.Id_proveedor
go
--Insertar Proveedor
create proc Insertar_Proveedor
@Correo nvarchar(50),
@Id_persona int,
@producto nvarchar(50)
as
insert into Proveedor values (@Id_persona,@Correo,@producto)
go
--Modificar PersonaCLiente
create proc Modificar_PersonaProveedor
@Id int,
@Nombre nvarchar(50) ,
@Apellido nvarchar(50),
@Telefono nvarchar(10)
as
update  Persona set Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono
where Persona.Id_Persona=@Id
go
--Modificar Cliente
create proc Modificar_Proveedor
@Id int,
@Correo nvarchar(50),
@Producto nvarchar(50)
as
update Proveedor set correo=@Correo,producto=@Producto
where Id_proveedor=@Id
go