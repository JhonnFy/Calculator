CREATE DATABASE AuditCalculator;
GO

USE AuditCalculator;
GO


CREATE TABLE TransactionAudit (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único
    Num1 INT NULL,  -- Permitir NULL para operaciones unarias
    Num2 INT NULL,  -- Permitir NULL para operaciones como raíz cuadrada
    Operador VARCHAR(10) NOT NULL, -- Almacena el operador usado
    Resultado DECIMAL(18, 6) NOT NULL, -- Soporta números con decimales
    FechaHora DATETIME DEFAULT GETDATE() -- Registra la fecha y hora automáticamente
);