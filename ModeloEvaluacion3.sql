SET QUOTED_IDENTIFIER ON

go
                                                     
use master  

go

create database "BaseDatosRetail"  

go

use "BaseDatosRetail"  

go

create table "Usuario" ( 
	"Id_usuario" int not null,
	"Pass_usuario" nvarchar(50) not null)  

go

alter table "Usuario"
	add constraint "Usuario_PK" primary key ("Id_usuario")   


go
                                                 
create table "Retail" ( 
	"Id_Retail" int not null,
	"Nombre_Retail" nvarchar(50) not null,
	"Direccion_Retail" nvarchar(100) not null)  

go

alter table "Retail"
	add constraint "Retail_PK" primary key ("Id_Retail")   


go

                                                        
create table "Producto" ( 
	"Id_producto" int not null,
	"Nombre_producto" nvarchar(50) not null,
	"Marca_producto" nvarchar(100) not null,
	"Precio_producto" int not null,
	"Stock_producto" int not null,
	"Fecha_Termino_Subasta" date not null,
	"Id_Retail" int not null)  

go

alter table "Producto"
	add constraint "Producto_PK" primary key ("Id_producto")   


go

                                          
alter table "Producto"
	add constraint "Retail_Producto_FK1" foreign key (
		"Id_Retail")
	 references "Retail" (
		"Id_Retail") 

go

create table "Cliente" ( 
	"Id_Cliente" int not null,
	"Nombre_Cliente" nvarchar(100) not null)  

go

alter table "Cliente"
	add constraint "Cliente_PK" primary key ("Id_Cliente")   


go

                                                        
create table "Tarjeta" ( 
	"Id_tarjeta" int not null,
	"saldo_tarjeta" int not null,
	"linea_credito_tarjeta" int not null,
	"Id_Cliente" int not null)  

go

alter table "Tarjeta"
	add constraint "Tarjeta_PK" primary key ("Id_tarjeta")   


go

                                          
alter table "Tarjeta"
	add constraint "Retail_Tarjeta_FK1" foreign key (
		"Id_Cliente")
	 references "Cliente" (
		"Id_Cliente") 

go


INSERT INTO [BaseDatosRetail].[dbo].[Retail] VALUES (00001,'Falabella','Las animas 1233')

INSERT INTO [BaseDatosRetail].[dbo].[Usuario] VALUES (123456,'Juan')


INSERT INTO [BaseDatosRetail].[dbo].[Cliente] VALUES (14,'Pedro')
INSERT INTO [BaseDatosRetail].[dbo].[Cliente] VALUES (15,'Roberto')

INSERT INTO [BaseDatosRetail].[dbo].[Tarjeta] VALUES (1,100000,150000,14)
INSERT INTO [BaseDatosRetail].[dbo].[Tarjeta] VALUES (2,100000,150000,15)


