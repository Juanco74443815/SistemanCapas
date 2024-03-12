-- Crear la tabla TipoProd
CREATE TABLE TipoProd (
    idtipopro INT PRIMARY KEY,
    nombre VARCHAR(100),
    estado VARCHAR(20)
);

-- Crear la tabla Marca
CREATE TABLE Marca (
    idmarca INT PRIMARY KEY,
    nombre VARCHAR(100),
    estado VARCHAR(20)
);

-- Crear la tabla Persona
CREATE TABLE Persona (
    idpersona INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellidos VARCHAR(100),
    telefono VARCHAR(15),
    ci VARCHAR(20),
    correo VARCHAR(100),
    estado VARCHAR(20)
);

-- Crear la tabla Cliente
CREATE TABLE Cliente (
    idcliente INT PRIMARY KEY,
    idpersona INT,
    tipocliente VARCHAR(50),
    codigocliente VARCHAR(50),
    estado VARCHAR(20),
    FOREIGN KEY (idpersona) REFERENCES Persona(idpersona)
);

-- Crear la tabla Usuario
CREATE TABLE Usuario (
    idusuario INT PRIMARY KEY,
    idpersona INT,
    nombreuser VARCHAR(50),
    contraseña VARCHAR(100),
    fechareg DATETIME,
    FOREIGN KEY (idpersona) REFERENCES Persona(idpersona)
);

-- Crear la tabla Proveedor
CREATE TABLE Proveedor (
    idproveedor INT PRIMARY KEY,
    nombre VARCHAR(100),
    telefono VARCHAR(15),
    direccion VARCHAR(255),
    estado VARCHAR(20)
);

-- Crear la tabla Venta
CREATE TABLE Venta (
    idventa INT PRIMARY KEY,
    idcliente INT,
    idvendedor INT,
    fecha DATE ,
    total DECIMAL(10, 2),
    estado VARCHAR(20),
    FOREIGN KEY (idcliente) REFERENCES Cliente(idcliente),
    FOREIGN KEY (idvendedor) REFERENCES Usuario(idusuario)
);

-- Crear la tabla Producto
CREATE TABLE Producto (
    idproducto INT PRIMARY KEY,
    idtipoproducto INT,
    nombre VARCHAR(100),
    codigobarra VARCHAR(50),
    idmarca INT,
    unidad VARCHAR(50),
    descripcion TEXT,
    estado VARCHAR(20),
    FOREIGN KEY (idtipoproducto) REFERENCES TipoProd(idtipopro),
    FOREIGN KEY (idmarca) REFERENCES Marca(idmarca)
);

-- Crear la tabla DetalleEvent
CREATE TABLE DetalleEvent (
    iddetalleevent INT PRIMARY KEY,
    idventa INT,
    idproducto INT,
    cantidad INT,
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(20),
    FOREIGN KEY (idventa) REFERENCES Venta(idventa),
    FOREIGN KEY (idproducto) REFERENCES Producto(idproducto)
);

-- Crear la tabla Ingreso
CREATE TABLE Ingreso (
    idingreso INT PRIMARY KEY,
    idproveedor INT,
    fechaingreso DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(20),
    FOREIGN KEY (idproveedor) REFERENCES Proveedor(idproveedor)
);

-- Crear la tabla DetalleIng
CREATE TABLE DetalleIng (
    iddetalleing INT PRIMARY KEY,
    idproducto INT,
    idingreso INT,
    fechavenc DATE,
    cantidad INT,
    preciocosto DECIMAL(10, 2),
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(20),
    FOREIGN KEY (idproducto) REFERENCES Producto(idproducto),
    FOREIGN KEY (idingreso) REFERENCES Ingreso(idingreso)
);

-- Crear la tabla Provee
CREATE TABLE Provee (
    idprovee INT PRIMARY KEY,
    idproducto INT,
    idproveedor INT,
    fecha DATE,
    precio DECIMAL(10, 2),
    FOREIGN KEY (idproducto) REFERENCES Producto(idproducto),
    FOREIGN KEY (idproveedor) REFERENCES Proveedor(idproveedor)
);

-- Crear la tabla Rol
CREATE TABLE Rol (
    idrol INT PRIMARY KEY,
    nombre VARCHAR(100),
    estado VARCHAR(20)
);

-- Crear la tabla UsuarioRol
CREATE TABLE UsuarioRol (
    idusuariorol INT PRIMARY KEY,
    idusuario INT,
    idrol INT,
    fechaasigna DATE,
    estado VARCHAR(20),
    FOREIGN KEY (idusuario) REFERENCES Usuario(idusuario),
    FOREIGN KEY (idrol) REFERENCES Rol(idrol)
);