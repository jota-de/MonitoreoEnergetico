-- Crear base de datos
CREATE DATABASE MonitoreoEnergetico;
GO

-- Usar base de datos
USE MonitoreoEnergetico;
GO

-- Tabla de Roles
CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY,
    NombreRol NVARCHAR(50) NOT NULL
);
GO

-- Tabla de Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY,
    Usuario NVARCHAR(50) NOT NULL,
    Clave NVARCHAR(50) NOT NULL,
    RolId INT NOT NULL,
    FOREIGN KEY (RolId) REFERENCES Roles(IdRol)
);
GO

-- Tabla de Inversores
CREATE TABLE Investor (
    idInversor SMALLINT IDENTITY(1,1) PRIMARY KEY,
    nombreInversor VARCHAR(500) NOT NULL,
    codigoInversor VARCHAR(25) UNIQUE,
    tipoInversor VARCHAR(150) NOT NULL,
    paisOrigenInversor VARCHAR(100) NOT NULL,
    emailInversor VARCHAR(500) NOT NULL,
    telefonoInversor INT NOT NULL
);
GO

-- Tabla de Constructores
CREATE TABLE Constructor (
    idEmpresa SMALLINT IDENTITY(1,1) PRIMARY KEY,
    nombreEmpresa VARCHAR(500) NOT NULL,
    codigoEmpresa VARCHAR(25) UNIQUE,
    paisOrigenEmpresa VARCHAR(50) NOT NULL,
    especializacion VARCHAR(50) NOT NULL,
    emailEmpresa VARCHAR(100) NOT NULL,
    telefonoEmpresa INT NOT NULL
);
GO

-- Tabla de Proyectos
CREATE TABLE Project (
    idProyecto SMALLINT IDENTITY(1,1) PRIMARY KEY,
    nombreProyecto VARCHAR(500) NOT NULL,
    codigoProyecto VARCHAR(25) UNIQUE,
    tipoGeneracion VARCHAR(25) NOT NULL,
    numeroUnidades SMALLINT,
    departamento VARCHAR(100) NOT NULL,
    municipio VARCHAR(100) NOT NULL,
    capacidadInstalada FLOAT NOT NULL,
    idInversor SMALLINT,
    idEmpresa SMALLINT,

    FOREIGN KEY (idInversor) REFERENCES Investor(idInversor),
    FOREIGN KEY (idEmpresa) REFERENCES Constructor(idEmpresa)
);
GO
