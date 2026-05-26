-- ============================================
-- Crear la base de datos
-- ============================================
CREATE DATABASE SistemaPagosDB;
GO

USE SistemaPagosDB;
GO

-- ============================================
-- Tabla: Usuarios (contraseña en texto plano)
-- ============================================
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Identificacion CHAR(12) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Contrasena NVARCHAR(100) NOT NULL,   -- texto plano
    Rol NVARCHAR(20) NOT NULL DEFAULT 'Usuario', -- 'Admin' o 'Usuario'
    FechaRegistro DATETIME DEFAULT GETDATE(),
    
    CONSTRAINT CHK_Usuarios_Identificacion CHECK (Identificacion LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
GO

-- ============================================
-- Tabla: Clientes
-- ============================================
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Identificacion CHAR(12) NOT NULL UNIQUE,
    NombreCompleto NVARCHAR(200) NOT NULL,
    Correo NVARCHAR(100) NULL,
    Telefono NVARCHAR(20) NULL,
    
    CONSTRAINT CHK_Clientes_Identificacion CHECK (Identificacion LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
GO

-- ============================================
-- Tabla: Pagos
-- ============================================
CREATE TABLE Pagos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL FOREIGN KEY REFERENCES Clientes(Id),
    UsuarioId INT NOT NULL FOREIGN KEY REFERENCES Usuarios(Id),
    Descripcion NVARCHAR(200) NOT NULL,
    Monto DECIMAL(18,2) NOT NULL,
    FechaPago DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- Tabla: PasswordResets (recuperación)
-- ============================================
CREATE TABLE PasswordResets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UsuarioId INT NOT NULL FOREIGN KEY REFERENCES Usuarios(Id),
    Token NVARCHAR(255) NOT NULL,
    FechaExpiracion DATETIME NOT NULL,
    Usado BIT DEFAULT 0
);
GO

-- ============================================
-- Insertar usuario administrador de ejemplo
-- Identificación: 000000000001
-- Contraseña: 123
-- ============================================
INSERT INTO Usuarios (Identificacion, Nombre, Apellido, FechaNacimiento, Contrasena, Rol)
VALUES ('000000000001', 'Admin', 'Sistema', '1990-01-01', '123', 'Admin');

-- ============================================
-- Clientes de ejemplo
-- ============================================
INSERT INTO Clientes (Identificacion, NombreCompleto, Correo, Telefono)
VALUES 
    ('123456789012', 'Karen Ortega', 'karen@mail.com', '12345678'),
    ('987654321098', 'Carlos Pérez', 'carlos@mail.com', '87654321');

-- ============================================
-- Pagos de ejemplo
-- ============================================
INSERT INTO Pagos (ClienteId, UsuarioId, Descripcion, Monto, FechaPago)
VALUES 
    (1, 1, 'Compra supermercado', 150.75, DATEADD(day, -2, GETDATE())),
    (1, 1, 'Pago servicios', 80.50, DATEADD(day, -1, GETDATE())),
    (2, 1, 'Alquiler', 300.00, DATEADD(day, -3, GETDATE()));