USE MonitoreoEnergetico;
GO

-- =========================================
-- sp_ObtenerProyecto
-- =========================================
CREATE PROCEDURE sp_ObtenerProyecto
AS
BEGIN
    SELECT * FROM dbo.Project;
END;
GO

-- =========================================
-- sp_InsertarProyecto
-- =========================================
CREATE PROCEDURE sp_InsertarProyecto
    @nombreProyecto VARCHAR(500),
    @tipoGeneracion VARCHAR(25),
    @numeroUnidades SMALLINT,
    @departamento VARCHAR(100),
    @municipio VARCHAR(100),
    @capacidadInstalada FLOAT,
    @idInversor SMALLINT,
    @idEmpresa SMALLINT
AS
BEGIN
    INSERT INTO Project(
        nombreProyecto,
        tipoGeneracion,
        numeroUnidades,
        departamento,
        municipio,
        capacidadInstalada,
        idInversor,
        idEmpresa
    )
    VALUES (
        @nombreProyecto,
        @tipoGeneracion,
        @numeroUnidades,
        @departamento,
        @municipio,
        @capacidadInstalada,
        @idInversor,
        @idEmpresa
    );
END;
GO

-- =========================================
-- sp_ActualizarProyecto
-- =========================================
CREATE PROCEDURE sp_ActualizarProyecto
    @idProyecto SMALLINT,
    @nombreProyecto VARCHAR(500),
    @tipoGeneracion VARCHAR(25),
    @numeroUnidades SMALLINT,
    @departamento VARCHAR(100),
    @municipio VARCHAR(100),
    @capacidadInstalada FLOAT,
    @idInversor SMALLINT,
    @idEmpresa SMALLINT
AS
BEGIN
    UPDATE Project
    SET
        nombreProyecto = @nombreProyecto,
        tipoGeneracion = @tipoGeneracion,
        numeroUnidades = @numeroUnidades,
        departamento = @departamento,
        municipio = @municipio,
        capacidadInstalada = @capacidadInstalada,
        idInversor = @idInversor,
        idEmpresa = @idEmpresa
    WHERE idProyecto = @idProyecto;
END;
GO

-- =========================================
-- sp_EliminarProyecto
-- =========================================
CREATE PROCEDURE sp_EliminarProyecto
    @idProyecto SMALLINT
AS
BEGIN
    DELETE FROM Project
    WHERE idProyecto = @idProyecto;
END;
GO