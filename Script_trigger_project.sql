CREATE TRIGGER trg_codigo_project
ON Project
AFTER INSERT
AS
BEGIN
    UPDATE Project
    SET codigoProyecto = 'P' + RIGHT('0000' + CAST(i.idProyecto AS VARCHAR), 4)
    FROM Project AS p
    INNER JOIN inserted AS i ON p.idProyecto = i.idProyecto;
END;
GO
