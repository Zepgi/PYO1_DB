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
		'M',
		1),
		(12345678,
		'Lionel Messi',
		'01-01-2001',
		'Cieneguita',
		'dada',
		123,
		'M',
		2)


INSERT INTO Cuenta
VALUES (703100722,
		1,
		'admin'),
		(12345678,
		2,
		'1234')