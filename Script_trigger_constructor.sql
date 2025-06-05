CREATE TRIGGER trg_codigo_constructor
ON Constructor
AFTER INSERT
AS
BEGIN
    UPDATE Constructor
    SET codigoEmpresa = 'E' + RIGHT('0000' + CAST(i.idEmpresa AS VARCHAR), 4)
    FROM Constructor AS c
    INNER JOIN inserted AS i ON c.idEmpresa = i.idEmpresa;
END;
GO
