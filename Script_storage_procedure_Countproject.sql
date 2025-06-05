USE MonitoreoEnergetico;
GO

-- =========================================
-- sp_ContarProyectosHydro
-- =========================================
CREATE PROCEDURE sp_ContarProyectosHydro
AS
BEGIN
    SELECT COUNT(*) AS TotalProyectosHydro
    FROM dbo.Project
    WHERE tipoGeneracion = 'Hydro';
END;
GO

-- =========================================
-- sp_ContarProyectosSolar
-- =========================================
CREATE PROCEDURE sp_ContarProyectosSolar
AS
BEGIN
    SELECT COUNT(*) AS TotalProyectosSolar
    FROM dbo.Project
    WHERE tipoGeneracion = 'Solar';
END;
GO

-- =========================================
-- sp_ContarProyectosWind
-- =========================================
CREATE PROCEDURE sp_ContarProyectosWind
AS
BEGIN
    SELECT COUNT(*) AS TotalProyectosWind
    FROM dbo.Project
    WHERE tipoGeneracion = 'Wind';
END;
GO
