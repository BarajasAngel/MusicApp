CREATE DATABASE MusicAppDB
GO

USE MusicAppDB
GO

CREATE TABLE Canciones(
Id_Cancion INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Link NVARCHAR(MAX) NOT NULL,
Titulo NVARCHAR(30) NOT NULL,
Grupo NVARCHAR(30) NOT NULL,
A�o NVARCHAR(4) NOT NULL,
Genero NVARCHAR(30) NOT NULL
);
GO

