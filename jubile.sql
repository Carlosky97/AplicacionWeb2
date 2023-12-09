CREATE DATABASE jubile;
USE jubile;

CREATE TABLE IF NOT EXISTS Cliente  (
idCliente int not null primary key,
NombreCliente varchar(120) not null,
ApellidoCliente varchar(120) not null,
RutCliente varchar(15) not null,
NacCliente varchar(30) not null,
FecCliente date not null,
AFP varchar(15) not null,
UF int not null,
TelefonoCliente int not null,
DireccionCliente varchar(150) not null,
CuidadCliente varchar(80) not null,
Cargo varchar(80) not null,
Email varchar(150) not null,
Observaciones varchar(255) not null
);

SELECT * FROM Cliente;

CREATE TABLE IF NOT EXISTS Empleado (
idEmpleado int not null primary key,
NombreEmpleado varchar(120),
ApellidoEmpleado varchar(120),
RutEmpleado varchar(15),
FecEmpleado date,
Comision int,
TelefonoEmpleado int,
Calificacion varchar(15),
idCliente int,
CONSTRAINT FK_idCliente FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente)
);

drop table Cliente;