USE MonitoreoEnergetico;
GO

-- sp_ObtenerInvestor -------------
CREATE PROCEDURE sp_ObtenerInvestor
AS
BEGIN
    SELECT * FROM dbo.Investor;
END;
GO

-- sp_InsertarInversor ------------
-- sp_InsertarInversor ------------
CREATE PROCEDURE sp_InsertarInversor
    @nombreInversor VARCHAR(500),
    @tipoInversor VARCHAR(150),
    @paisOrigenInversor VARCHAR(100),
    @emailInversor VARCHAR(500),
    @telefonoInversor INT
AS
BEGIN
    INSERT INTO Investor(
        nombreInversor,
        tipoInversor,
        paisOrigenInversor,
        emailInversor,
        telefonoInversor
    )
    VALUES (
        @nombreInversor,
        @tipoInversor,
        @paisOrigenInversor,
        @emailInversor,
        @telefonoInversor
    );
END;
GO

-- sp_ActualizarInversor -----------
CREATE PROCEDURE sp_ActualizarInversor
    @idInversor SMALLINT,
    @nombreInversor VARCHAR(500),
    @tipoInversor VARCHAR(150),
    @paisOrigenInversor VARCHAR(100),
    @emailInversor VARCHAR(500),
    @telefonoInversor INT
AS
BEGIN
    UPDATE Investor
    SET 
        nombreInversor = @nombreInversor,
        tipoInversor = @tipoInversor,
        paisOrigenInversor = @paisOrigenInversor,
        emailInversor = @emailInversor,
        telefonoInversor = @telefonoInversor
    WHERE idInversor = @idInversor;
END;
GO

-- sp_EliminarInversor -------------
CREATE PROCEDURE sp_EliminarInversor
    @idInversor SMALLINT
AS
BEGIN
    DELETE FROM Investor
    WHERE idInversor = @idInversor;
END;
GO
