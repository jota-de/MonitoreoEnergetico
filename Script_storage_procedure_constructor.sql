USE MonitoreoEnergetico;
GO

-- sp_ObtenerConstructores -------------
CREATE PROCEDURE sp_ObtenerConstructores
AS
BEGIN
    SELECT * FROM dbo.Constructor;
END;
GO

-- sp_InsertarConstructor --------------
CREATE PROCEDURE sp_InsertarConstructor
    @nombreEmpresa VARCHAR(500),
    @paisOrigenEmpresa VARCHAR(50),
    @especializacion VARCHAR(50),
    @emailEmpresa VARCHAR(100),
    @telefonoEmpresa INT
AS
BEGIN
    INSERT INTO Constructor(
        nombreEmpresa,
        paisOrigenEmpresa,
        especializacion,
        emailEmpresa,
        telefonoEmpresa
    )
    VALUES (
        @nombreEmpresa,
        @paisOrigenEmpresa,
        @especializacion,
        @emailEmpresa,
        @telefonoEmpresa
    );
END;
GO

-- sp_ActualizarConstructor -----------
-- NOTA: No se permite modificar el 'codigoEmpresa' ya que es identificador único
CREATE PROCEDURE sp_ActualizarConstructor
    @idEmpresa SMALLINT,
    @nombreEmpresa VARCHAR(500),
    @paisOrigenEmpresa VARCHAR(50),
    @especializacion VARCHAR(50),
    @emailEmpresa VARCHAR(100),
    @telefonoEmpresa INT
AS
BEGIN
    UPDATE Constructor
    SET 
        nombreEmpresa = @nombreEmpresa,
        paisOrigenEmpresa = @paisOrigenEmpresa,
        especializacion = @especializacion,
        emailEmpresa = @emailEmpresa,
        telefonoEmpresa = @telefonoEmpresa
    WHERE idEmpresa = @idEmpresa;
END;
GO

-- sp_EliminarConstructor -------------
CREATE PROCEDURE sp_EliminarConstructor
    @idEmpresa SMALLINT
AS
BEGIN
    DELETE FROM Constructor
    WHERE idEmpresa = @idEmpresa;
END;
GO

-- sp_BuscarConstructorPorId -------------
CREATE PROCEDURE sp_BuscarConstructorPorId
    @idEmpresa SMALLINT
AS
BEGIN
    SELECT *
    FROM Constructor
    WHERE idEmpresa = @idEmpresa;
END;
GO
