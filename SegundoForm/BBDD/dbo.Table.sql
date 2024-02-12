CREATE TABLE [dbo].[Proyectos]
(
    [codigo] NVARCHAR(50) NOT NULL, 
    [descripcion] TEXT NULL, 
    [fechaInicio] DATE NULL, 
    [fechaFin] DATE NULL, 
    [estado] NVARCHAR(50) NULL, 
    [presupuestoInicial] FLOAT NULL, 
    [presupuestoActual] FLOAT NULL, 
    [cambios] TEXT NULL, 
    [codCliente] NVARCHAR(50) NULL, 
    PRIMARY KEY ([codigo])
)
