CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni VARCHAR(15) NOT NULL,
    direccion VARCHAR(100),
    telefono VARCHAR(15),
    email VARCHAR(100)
)

CREATE TABLE Vehiculo (
    id INT PRIMARY KEY IDENTITY(1,1),
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    patente VARCHAR(15) UNIQUE,
    cliente_id INT NOT NULL FOREIGN KEY REFERENCES Cliente(id)
)

CREATE TABLE Auto (
    id INT PRIMARY KEY IDENTITY(1,1),
    tipo INT NOT NULL,
	cantidad_puertas INT NOT NULL,
    vehiculo_id INT NOT NULL FOREIGN KEY REFERENCES Vehiculo(id)
);

CREATE TABLE Moto (
    id INT PRIMARY KEY IDENTITY(1,1),
    cilindrada INT NOT NULL,
	vehiculo_id INT NOT NULL FOREIGN KEY REFERENCES Vehiculo(id)
);

CREATE TABLE Presupuesto (
    id INT PRIMARY KEY IDENTITY(1,1),
    vehiculo_id INT NOT NULL FOREIGN KEY REFERENCES Vehiculo(id),
    cliente_id INT NOT NULL FOREIGN KEY REFERENCES Cliente(id),
    fecha DATETIME NOT NULL,
    costo_total DECIMAL(8,2) NOT NULL
);

CREATE TABLE Desperfecto (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(100) NOT NULL,
    costo_manobra DECIMAL(8,2) NOT NULL,
    tiempo_estimado INT NOT NULL,
	presupuesto_id INT NOT NULL FOREIGN KEY REFERENCES Presupuesto(id)
);

CREATE TABLE Repuesto (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    precio DECIMAL(8,2) NOT NULL
);

CREATE TABLE Desperfecto_Repuesto (
	id INT PRIMARY KEY IDENTITY(1,1),
    desperfecto_id INT NOT NULL FOREIGN KEY REFERENCES Desperfecto(id),
    repuesto_id INT NOT NULL FOREIGN KEY REFERENCES Repuesto(id),
    cantidad INT NOT NULL
);