-- Stored procedure para insertar un nuevo cliente
CREATE PROCEDURE InsertarCliente
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @dni VARCHAR(10),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20),
    @email VARCHAR(100)
AS
BEGIN
    INSERT INTO Cliente (nombre, apellido, dni, direccion, telefono, email)
    VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @email)
END

go

-- Stored procedure para eliminar un cliente
CREATE PROCEDURE EliminarCliente
    @clienteId INT
AS
BEGIN
    DELETE FROM Cliente
    WHERE id = @clienteId
END

go

-- Stored procedure para actualizar un cliente
CREATE PROCEDURE ActualizarCliente
    @clienteId INT,
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @dni VARCHAR(10),
    @direccion VARCHAR(100),
    @telefono VARCHAR(20),
    @email VARCHAR(100)
AS
BEGIN
    UPDATE Cliente
    SET nombre = @nombre,
        apellido = @apellido,
        dni = @dni,
        direccion = @direccion,
        telefono = @telefono,
        email = @email
    WHERE id = @clienteId
END