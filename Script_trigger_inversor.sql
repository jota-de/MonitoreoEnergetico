CREATE TRIGGER trg_codigo_inversor
ON Investor
AFTER INSERT
AS
BEGIN
    UPDATE Investor
    SET codigoInversor = 'I' + RIGHT('0000' + CAST(i.idInversor AS VARCHAR), 4)
    FROM Investor AS inv
    INNER JOIN inserted AS i ON inv.idInversor = i.idInversor;
END;
GO
