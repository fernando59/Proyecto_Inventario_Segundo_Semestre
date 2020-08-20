use Proyecto_Venta
------------------------Procedimientos almacenados categoria
--Isertar categoria
create proc Insertar_Categoria
@Nombre nvarchar(50),
@Descripcion nvarchar(50)
as
insert into Categoria (Nombre_Categoria,detalle) values(@Nombre,@Descripcion)
go
--Modificar categoria
create proc Modificar_Categoria
@Id int,
@Nombre nvarchar(50),
@Descripcion nvarchar(50)
as
update  Categoria set Nombre_Categoria=@Nombre,detalle=@Descripcion where Id_Categoria=@Id
go
--Mostrar en el combobox
create proc Mostrar_CategoriaCombo
as
select Id_Categoria,Nombre_Categoria
from Categoria
go
--Buscar categoria
create proc Buscar_Producto_Categoria
@Buscar nvarchar(50)
as
select Id_Productos, Productos.Nombre,Descripcion,Precio_compra,Stock,Categoria.Nombre_Categoria
from Productos,Categoria
where Categoria.Nombre_Categoria like '%'+@Buscar+'%' and Productos.Id_categorias=Categoria.Id_Categoria
go
----------------------Mostrar 
create proc Mostrar_Categoria
as
select * from Categoria
go
--Listar_Categoria
create proc Listar_Categoria
as
select Id_Categoria,Nombre_Categoria
from Categoria
go
--Buscar categoria
create proc Buscar_Categoria
@Buscar nvarchar(50)
as
select Id_Categoria,Nombre_Categoria,detalle
from Categoria
where Nombre_Categoria like '%'+@Buscar+'%' 
go
--Elimnar categoria
create proc Eliminar_Categoria
@Id_Categoria int
as
delete from Categoria where Id_Categoria=@Id_Categoria
go
--Mostrar total
create proc Mostrar_Total
as
select  count(Precio_compra) as Total
from Productos
go
drop proc Mostrar_Total
 ---------------------------------------------------
 create proc Mostrar
as
select *
from Productos 
go