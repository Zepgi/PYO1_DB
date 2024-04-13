USE HOTELKARPAS

ALTER TABLE Cliente ADD nombre VARCHAR(100) NOT NULL;

CREATE TABLE Rol
	(idRol INT PRIMARY KEY NOT NULL,
	nombreRol VARCHAR(50) NOT NULL)

ALTER TABLE Usuario
ALTER COLUMN rol INT NOT NULL

EXEC sp_rename 'Usuario.rol',  'idRol', 'COLUMN';

ALTER TABLE Usuario
ADD FOREIGN KEY(idRol) REFERENCES Rol(idRol)

INSERT INTO Rol
VALUES	(1,
		'Administrador'),
		(2,
		'Recepcionista')

INSERT INTO Usuario
VALUES (703100722,
		'Eyden Su Díaz',
		'09-17-2004',
		'Pacuare Nuevo',
		'dadad',
		123,
		1,
		'M'),
		(12345678,
		'Lionel Messi',
		'01-01-2001',
		'Cieneguita',
		'dada',
		123,
		2,
		'M')

CREATE TABLE Cuenta (
	idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario) NOT NULL,
	idCuenta INT PRIMARY KEY NOT NULL,
	pasword VARCHAR(50) NOT NULL
);

INSERT INTO Cuenta
VALUES (703100722,
		1,
		'admin'),
		(12345678,
		2,
		'1234')


DROP TABLE Reserva;
SELECT * FROM Reserva


CREATE TABLE Reserva
	(idReserva INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NOT NULL,
	estadoReserva VARCHAR(50) NOT NULL,
	fechaEntrada DATE NOT NULL,
	fechaSalida DATE NOT NULL,
	idHabitacion INT FOREIGN KEY REFERENCES Habitacion(idHabitacion) NOT NULL,
	descuentoAplicado BIT NOT NULL);
	-----------------------sin cambios--------------------------------------------

CREATE TABLE Habitacion
	(idHabitacion INT PRIMARY KEY NOT NULL,
	tipo VARCHAR(50) NOT NULL,
	precio DECIMAL(32,2) NOT NULL);

CREATE TABLE Cliente (
	idCliente INT PRIMARY KEY NOT NULL,
	paisProcedencia VARCHAR(200) NOT NULL,
	telefono INT NOT NULL,
	correoElectronico VARCHAR(200) NOT NULL,
);

CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY NOT NULL,
    nombreCompleto VARCHAR(150) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    direccionVivienda VARCHAR(200) NOT NULL,
    email VARCHAR(100) NOT NULL,
    numTell INT NOT NULL,
    rol BIT NOT NULL,
	genero VARCHAR(2) NOT NULL
	
);




use HOTELKARPAS


select * from Reserva

select * from Cliente

SELECT * FROM Habitacion

DELETE FROM Reserva

ALTER TABLE Reserva ADD precioTotal int not null;

SELECT tipo FROM Habitacion
SELECT * FROM Cliente
SELECT * FROM Cuenta

DROP TABLE Habitacion

CREATE TABLE Habitacion
	(idHabitacion INT PRIMARY KEY NOT NULL,
	tipo VARCHAR(50) NOT NULL,
	precio DECIMAL(32,2) NOT NULL);

	DELETE FROM Habitacion

INSERT INTO Habitacion(
	idHabitacion,
	tipo,
	precio

)VALUES(
	1,
	'Premium',
	60000.0
	
);

INSERT INTO Habitacion(
	idHabitacion,
	tipo,
	precio

)VALUES(
	2,
	'Familiar',
	53000.0
	
);

INSERT INTO Habitacion(
	idHabitacion,
	tipo,
	precio

)VALUES(
	3,
	'Pareja',
	40000.0
	
);

INSERT INTO Habitacion(
	idHabitacion,
	tipo,
	precio

)VALUES(
	4,
	'Villa',
	20000.0
	
);

1,1....
1,2....
1,3....
1,4
1,5...descuentosDisponibles

CREATE TABLE Reserva
	(idReserva INT PRIMARY KEY  NOT NULL,
	idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NOT NULL,
	estadoReserva VARCHAR(50) NOT NULL,
	fechaEntrada DATE NOT NULL,
	fechaSalida DATE NOT NULL,
	idHabitacion INT FOREIGN KEY REFERENCES Habitacion(idHabitacion) NOT NULL,
	descuentoAplicado Bit NOT NULL,
	precioTotal decimal(33,2) not null
	);


DROP TABLE Reserva

INSERT INTO Reserva (idReserva,idCliente, estadoReserva, fechaEntrada, fechaSalida,idHabitacion, descuentoAplicado, precioTotal)
VALUES (1, 703100722, 'Activa', '2024-04-11', '2024-04-15',1, 0, 10000);

INSERT INTO Cliente VALUES(
703100722, 'Costa Rica', 84035342, 'esu@estudiantec.cr', 'Eyden Su Díaz'
);


