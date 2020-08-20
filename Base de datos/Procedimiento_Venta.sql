use Proyecto_Venta
go
--------------------------------------Venta
--Listar Producto
create proc Listar_Producto
as
select Id_Productos,Nombre
from Productos
go
--Insertar Venta
create proc Insertar_Venta
@Id_cliente int,
@Fecha nvarchar (50),
@tipo_pago nvarchar(100)
as
insert into Venta (Id_cliente2,fecha,tipo_pago)values(@Id_Cliente,@Fecha,@tipo_pago)
go
--Obtener IdVenta
create proc Obtener_IdVenta
as
select top(1 )Id_Venta 
from Venta 
order by Id_Venta desc
go
--Inserta detalleVenta
create proc Insertar_DetalleVenta
@Id_Detalle_Venta int,
@Id_productos3 int,
@Cantidad int,
@precio decimal(10,2)
as
insert into Detalle_Venta (Id_Detalle_Venta,Id_Productos3,Cantidad,Precio,total) values(@Id_Detalle_Venta,@Id_productos3,@Cantidad,@precio,@Cantidad*@precio)
go
--Mostrar Venta
create proc Mostrar_Venta
as
select Detalle_Venta.Id,Productos.Nombre,Detalle_Venta.precio,Detalle_Venta.Cantidad,Persona.Nombre,Persona.Apellido,Detalle_Venta.total,Venta.tipo_pago
from Venta,Detalle_Venta,Productos,Cliente,Persona
where Productos.Id_Productos=Detalle_Venta.Id_productos3 and Venta.Id_Venta=Detalle_Venta.Id_Detalle_Venta
and cliente.Id_Cliente=Persona.Id_Persona and Cliente.Id_Cliente=Venta.ID_cliente2
go
--Mostrar total
create proc Mostrar_Total_Venta
as
select  sum(cantidad*precio) as Total
from Detalle_Venta
go
--Mostrar por fecha
create proc Mostrar_por_Fechas
@fecha nvarchar(50)
as
select Detalle_Venta.Id,Productos.Nombre,Detalle_Venta.precio,Detalle_Venta.Cantidad,Persona.Nombre,Persona.Apellido,Detalle_Venta.total,Venta.tipo_pago
from Detalle_Venta,Venta,Productos,Persona,Cliente
where Productos.Id_Productos=Detalle_Venta.Id_productos3 and Venta.Id_Venta=Detalle_Venta.Id_Detalle_Venta
and cliente.Id_Cliente=Persona.Id_Persona and Cliente.Id_Cliente=Venta.ID_cliente2 and venta.fecha=@fecha
go