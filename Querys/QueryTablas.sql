CREATE DATABASE HOTELKARPAS;

USE HOTELKARPAS;

CREATE TABLE Reserva
	(idReserva INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NOT NULL,
	estadoReserva VARCHAR(50) NOT NULL,
	temporada DATE NOT NULL,
	idHabitacion INT FOREIGN KEY REFERENCES Habitacion(idHabitacion) NOT NULL,
	descuentoAplicado BIT NOT NULL);

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
	genero VARCHAR(2) NOT NULL,
    rol BIT NOT NULL
);

CREATE TABLE BitacoraLogin
	(fechaLogin DATE PRIMARY KEY NOT NULL,
	idCuenta INT FOREIGN KEY REFERENCES Cuenta(idCuenta));

CREATE TABLE Cuenta (
	idUsuario INT FOREIGN KEY REFERENCES Usuario(idUsuario) NOT NULL,
	idCuenta INT PRIMARY KEY NOT NULL,
	pasword VARCHAR(50) NOT NULL
);