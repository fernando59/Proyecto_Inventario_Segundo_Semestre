use proyecto_Venta
go
-------------------Producto 
--Mostrar producto
create proc Mostrar_Producto
as
select Id_Productos, Productos.Nombre,Descripcion,Precio_compra,Stock,Categoria.Nombre_Categoria
from Productos,Categoria
where Id_Categoria=Productos.Id_categorias
go
--Insertar Producto
create proc Insertar_Producto
@Nombre nvarchar(50) ,
@Descripcion nvarchar(100),
@Precio_compra decimal(14,2),
@Stock int,
@Id_categorias int
as
insert into Productos  values (@Nombre,@Descripcion,@Precio_compra,@Stock,@Id_categorias)
go
--Modificar Producto
create proc Modificar_Producto
@Nombre nvarchar(50) ,
@Descripcion nvarchar(100),
@Precio_compra decimal(6,2),
@Stock int,
@Id_categorias int,
@id int
as
update Productos  set Nombre=@Nombre,Descripcion= @Descripcion,Precio_compra= @Precio_compra,Stock= @Stock,id_categorias=@Id_categorias 
where Id_Productos=@Id
go
drop proc Modificar_Producto
--Elimnar producto
create proc Eliminar_Producto
@Id_Producto int
as
delete from Productos where Id_Productos=@Id_Producto
go
--Buscar productos
create proc Buscar_Producto
@Buscar nvarchar(50)
as
select Id_Productos, Productos.Nombre,Descripcion,Precio_compra,Stock,Categoria.Nombre_Categoria
from Productos,Categoria
where Nombre like '%'+@Buscar+'%' and Productos.Id_categorias=Categoria.Id_Categoria
go
--Restar stock
create proc Restar_Stock
@Id_Producto int,
@Cantidad int
as
update Productos set Stock=Stock-@Cantidad
where Id_Productos=@Id_Producto
go

