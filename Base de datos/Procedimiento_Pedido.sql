use Proyecto_Venta
go
------------------------------------Pedidos
--Insertar Pedido
create proc Insertar_Pedido
@Fecha nvarchar(50),
@tipo_pago nvarchar(50),
@Id_proveedor2 int
as
insert into Pedido values(@Fecha,@tipo_pago,@Id_proveedor2)
go
--Inserta detallePedido
create proc Insertar_DetallePedido
@Id_Detalle_Pedido int,
@Id_productos3 int,
@Cantidad int,
@precio decimal(10,2)
as
insert into Detalle_Pedido (Id_Pedido,Id_Productos3,Cantidad,Precio,total) values(@Id_Detalle_Pedido,@Id_productos3,@Cantidad,@precio,@Cantidad*@precio)
go
--Obtener Id
create proc Obtener_IdPedido
as
select top(1 )Id_Pedido
from Pedido 
order by Id_Pedido desc
go
--Mostrar Pedido
create proc Mostrar_Pedido
as
select Detalle_Pedido.Id,Persona.Nombre,Persona.Apellido,Proveedor.producto,Detalle_Pedido.cantidad,Detalle_Pedido.Precio,Detalle_Pedido.total,Pedido.tipo_pago
from Pedido,Detalle_Pedido,Persona,Proveedor,Productos
where Persona.Id_Persona=Proveedor.Id_proveedor and Detalle_Pedido.Id_Pedido=Pedido.Id_Pedido and Pedido.Id_Proveedor2=Proveedor.Id_proveedor
and Detalle_Pedido.Id_productos3=Productos.Id_Productos
go
--Sumar stock
create proc Sumar_Stock
@Id_Producto int,
@Cantidad int
as
update Productos set Stock=Stock+@Cantidad
where Id_Productos=@Id_Producto
go