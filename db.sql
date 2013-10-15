go
create table delegaciones
(
	id int identity(1, 1) primary key,
	nombre nvarchar(120),
	telefono nvarchar(120),
	direccion nvarchar(250)
)
go
create table personal
(
	id int identity(1, 1) primary key,
	num_placa nvarchar(250),
	nombre nvarchar(250),
	telefono nvarchar(120),
	direccion nvarchar(250),
	delegacion_id int foreign key references delegaciones(id)
)
go
create table roles
(
 id int identity(1, 1) primary key,
 nombre nvarchar(120)	
)
go
create table usuarios
(
	id int identity(1, 1) primary key,
	usuario nvarchar(50),
	pwd binary(16),
	empleado_id int foreign key references personal(id),
	rol_id int foreign key references roles(id)
)
go
create table accesos
(
	id int identity(1, 1) primary key,
	fecha datetime,
	accion nvarchar(120),
	usuario_id int foreign key references usuarios(id),
	personal_id int foreign key references personal(id)
)
go
create table tipo_situaciones
(
	id int identity(1, 1) primary key,
	nombre nvarchar(120),
)
go
create table delincuentes
(
	id int identity(1, 1) primary key,
	nombre nvarchar(250),
	edad int,
	fecha_nacimiento datetime,
	telefono nvarchar(120),
	direccion nvarchar(250),
	imagen nvarchar(250),
	nacionalidad nvarchar(250),
	genero nvarchar(20),
)
go
create table situaciones
(
	id int identity(1, 1) primary key,
	situacion nvarchar(250),
	fecha datetime,
	lugar nvarchar(120),
	personal_id int foreign key references personal(id),
	tipo_situacion_id int foreign key references tipo_situaciones(id),
	delegacion_id int foreign key references delegaciones(id)
)
go
create table situaciones_delincuentes 
(
	delincuente_id int foreign key references delincuentes(id),
	situacion_id int foreign key references situaciones(id),
	constraint pk_situacion_delincuente primary key (delincuente_id, situacion_id)
)
go
create table victimas
(
	id int identity(1, 1) primary key,
	nombre nvarchar(250),
	edad int,
	fecha_nacimiento datetime,
	telefono nvarchar(120),
	direccion nvarchar(250),
	imagen nvarchar(250),
	situacion_id int foreign key references situaciones(id)
)
go
insert into delegaciones(nombre, telefono, direccion)values('La presa', '12463', 'Colonia los pinos');
insert into personal(num_placa, nombre, telefono, direccion, delegacion_id)values('12345', 'Manuel Mendez', '8855', 'test', 1);
insert into roles(nombre)values('Admin');
insert into usuarios(usuario, pwd, empleado_id, rol_id)values('admin', HashBytes('MD5', cast('12345' as varchar)), 1, 1);