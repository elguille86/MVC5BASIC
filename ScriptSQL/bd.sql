create database bd_escuela
go
use bd_escuela
go
create table cargo(
car_cod int not null primary key,
cas_des varchar(50) not null
)
go
create table usuario(
usu_cod int not null primary key,
usu_nom varchar(50) not null,
car_cod int not null references cargo
)

GO
insert into cargo(car_cod,cas_des) values(1,'administrador');
insert into cargo(car_cod,cas_des) values(2,'auxiliar');
insert into cargo(car_cod,cas_des) values(3,'soporte');


insert into usuario(usu_cod,usu_nom,car_cod) values(1,'guillermo',1);
insert into usuario(usu_cod,usu_nom,car_cod) values(2,'jorge',2);
insert into usuario(usu_cod,usu_nom,car_cod) values(3,'luis',3);

create table area(
are_cod int not null primary key,
are_des varchar(50) not null
)
create table empleado(
emp_cod int not null primary key,
emp_nom varchar(50) not null,
are_cod int not null references area
)


insert into area(are_cod,are_des) values(1,'gerencia');
insert into area(are_cod,are_des) values(2,'recursos humanos');
insert into area(are_cod,are_des) values(3,'almacen');



insert into empleado(emp_cod,emp_nom,are_cod) values(1,'Luthien',1);
insert into empleado(emp_cod,emp_nom,are_cod) values(2,'Beren',1);
insert into empleado(emp_cod,emp_nom,are_cod) values(3,'Bilbo',2);
insert into empleado(emp_cod,emp_nom,are_cod) values(4,'Tom',2);
insert into empleado(emp_cod,emp_nom,are_cod) values(5,'Marry',3);
insert into empleado(emp_cod,emp_nom,are_cod) values(6,'Samwise',3);


GO 

Create Procedure PR_LISTAR_AREA
as
	Select * from area
go

Create Procedure PR_BUSCAR_AREA
@codigo int
as
select * from area where are_cod = @codigo
go

create Procedure PR_INSERTAR_AREA
@descripcion varchar(100)
as
if not exists (select * from area where are_des = @descripcion)
begin
declare @codigo1 int
select @codigo1 = isnull(max(are_cod),0) + 1 from area
insert into area(are_cod,are_des) values(@codigo1,@descripcion);
end
GO

Create Procedure PR_ACTUALIZAR_AREA
@codigo2 int, @descripcion2 varchar(100)
as
-- Valido
if not exists(select * from area where are_des = @descripcion2)
begin
	update area set are_des = @descripcion2 where are_cod= @codigo2
end
GO

Create Procedure PR_ELIMINAR_AREA
@codigo3 int
as
delete area where are_cod = @codigo3
go