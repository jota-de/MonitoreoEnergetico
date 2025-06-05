-- Inserción de datos
INSERT INTO Roles (NombreRol) VALUES
('Tecnico'),
('Ventas');

INSERT INTO Usuarios (Usuario, Clave, RolId) VALUES
('tec', 'Tec123', 1),    -- Técnico
('sales1', 'Sales2024', 2);  -- Ventas

GO

-- Creación del procedimiento almacenado
CREATE PROCEDURE sp_Login
  @Usuario NVARCHAR(50),
  @Clave NVARCHAR(50)
AS
BEGIN
  SELECT u.IdUsuario, u.Usuario, r.NombreRol
  FROM Usuarios u
  INNER JOIN Roles r ON u.RolId = r.IdRol
  WHERE u.Usuario = @Usuario AND u.Clave = @Clave
END;
	