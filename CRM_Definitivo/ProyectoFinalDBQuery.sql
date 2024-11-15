CREATE DATABASE SistemaProyectosDB;

	SELECT * FROM proyect				


SELECT r.idRol, m.nameForm , p.idPermission 
FROM rolPermission rp
JOIN roles r ON rp.idRoles = r.idRol
JOIN permission p ON rp.idPermission = p.idPermission
JOIN menu m ON p.idMenu = m.idMenu
JOIN users u on u.idRol = r.idRol
WHERE u.idUser = @idUser;



UPDATE Users
SET email ='default@gmail.com'
WHERE idUser = 15;



update Users
set idRol = 'Sijilo75'
WHERE idUser = 5

ALTER TABLE Users
ADD CONSTRAINT Fk_Roles FOREIGN KEY(idRol) REFERENCES roles(idRol)

CREATE TABLE Users 
(
    idUser INT PRIMARY KEY identity(1,1),
	UserAccount VARCHAR(255),
    nameuser VARCHAR(50),
    lastName VARCHAR(50),
    birthdate DATE,
    numberPhone VARCHAR(15),
    passworduser VARCHAR(100),
    country VARCHAR(50),
    city VARCHAR(50),
    statususer VARCHAR(20),
	idRol int

	CONSTRAINT Fk_Roles  FOREIGN KEY(idRol) REFERENCES roles(idRol)
);

CREATE TABLE Admins (
    idAdmin INT PRIMARY KEY identity(1,1),
    idUser INT,
    FOREIGN KEY (idUser) REFERENCES Users(idUser)
);

CREATE TABLE Clients (
    idCliente INT PRIMARY KEY identity(1,1),
    idUser INT,
    FOREIGN KEY (idUser) REFERENCES Users(idUser) ON DELETE SET NULL
);

CREATE TABLE employee (
    idEmployee INT PRIMARY KEY identity(1,1),
    idUser INT,
	namaEmployee NVARCHAR(100),
    comment VARCHAR(255),
    workStation VARCHAR(50),
	FOREIGN KEY (idUser) REFERENCES Users(idUser) ON DELETE SET NULL
);

CREATE TABLE statusProyect (
    idStatusProyect INT PRIMARY KEY identity(1,1),
    statusproyect VARCHAR(50)
);

CREATE TABLE proyect (
    idProyect INT PRIMARY KEY identity(1,1),
    dateInit DATE,
    dateEnd DATE,
    description VARCHAR(255),
    titleName VARCHAR(100),
    idStatusProyect INT,
    idClient INT null,
    idEmployee INT,
	[file] varbinary(MAX)
    FOREIGN KEY (idStatusProyect) REFERENCES statusProyect(idStatusProyect),
    FOREIGN KEY (idClient) REFERENCES Clients(idCliente)ON DELETE SET NULL,
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee) ON DELETE SET NULL
);

CREATE TABLE task (
    idTask INT PRIMARY KEY identity(1,1),
    nameTask VARCHAR(100),
    descriptionTask VARCHAR(255),
    idEmployee INT,
    idProyect INT,
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee),
    FOREIGN KEY (idProyect) REFERENCES proyect(idProyect)
);

EXEC sp_rename 'roles.idRoles', 'idRol', 'COLUMN';


CREATE TABLE roles (
    idRol INT PRIMARY KEY identity(1,1),
    Rol VARCHAR(50),
);

CREATE TABLE permission (
    idPermission INT PRIMARY KEY identity(1,1),
    idMenu INT,
    FOREIGN KEY (idMenu) REFERENCES menu(idMenu)
);

CREATE TABLE rolPermission (
    idRolPermission INT PRIMARY KEY identity(1,1),
    idRoles INT,
    idPermission INT,
    FOREIGN KEY (idRoles) REFERENCES roles(idRoles),
    FOREIGN KEY (idPermission) REFERENCES permission(idPermission)
);

CREATE TABLE menu (
    idMenu INT PRIMARY KEY identity(1,1),
    name VARCHAR(50),
    nameForm VARCHAR(50)
);

INSERT INTO Clients(idUser) 
VALUES (1); 

INSERT INTO Admins (idUser) 
VALUES (2);

INSERT INTO employee (idUser, comment, workStation) 
VALUES (3, 'Desarrollador Full Stack', 'Oficina 101');

INSERT INTO statusProyect (statusproyect) 
VALUES 
('En Proceso'),
('Finalizando'),
('Finalizado');

INSERT INTO proyect (dateInit, dateEnd, description, titleName, idStatusProyect, idClient, idEmployee) 
VALUES 
('2024-01-01', '2024-06-01', 'Proyecto de migración a la nube', 'Migración Nube', 1, 1, 1);

INSERT INTO task (nameTask, descriptionTask, idEmployee, idProyect) 
VALUES 
('Desarrollo Backend', 'Implementación del API REST', 1, 1);

INSERT INTO roles (Rol) 
VALUES 
('Admin'),
('Empleado');


SELECT idRol FROM roles WHERE Rol = 'Admin';

DELETE FROM roles WHERE Rol = 'ADMIN';

DROP TRIGGER InsertRoleInSpecificTable


CREATE TRIGGER InsertRoleInSpecificTable
ON Users
AFTER INSERT
AS
BEGIN
    DECLARE @idUser INT;
    DECLARE @idRol INT;
    DECLARE @adminRoleId INT;
    DECLARE @clientRoleId INT;
    DECLARE @employeeRoleId INT;

    SELECT @adminRoleId = idRol FROM roles WHERE Rol = 'Admin';
    SELECT @clientRoleId = idRol FROM roles WHERE Rol = 'Cliente';
    SELECT @employeeRoleId = idRol FROM roles WHERE Rol = 'Empleado';

    DECLARE user_cursor CURSOR FOR SELECT idUser, idRol FROM inserted;
    OPEN user_cursor;
    FETCH NEXT FROM user_cursor INTO @idUser, @idRol;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        IF @idRol = @adminRoleId
        BEGIN
            INSERT INTO Admins (idUser) VALUES (@idUser);
        END
        ELSE IF @idRol = @clientRoleId
        BEGIN
            INSERT INTO Clients (idUser) VALUES (@idUser);
        END
        ELSE IF @idRol = @employeeRoleId
        BEGIN
            INSERT INTO Employee (idUser) VALUES (@idUser);
        END

        FETCH NEXT FROM user_cursor INTO @idUser, @idRol;
    END;

    CLOSE user_cursor;
    DEALLOCATE user_cursor;
END;


CREATE TRIGGER UpdateRoleInSpecificTable
ON Users
AFTER UPDATE
AS
BEGIN
    DECLARE @idUser INT;
    DECLARE @oldRoleId INT;
    DECLARE @newRoleId INT;
    DECLARE @adminRoleId INT;
    DECLARE @clientRoleId INT;
    DECLARE @employeeRoleId INT;

    SELECT @adminRoleId = idRol FROM roles WHERE Rol = 'Admin';
    SELECT @clientRoleId = idRol FROM roles WHERE Rol = 'Cliente';
    SELECT @employeeRoleId = idRol FROM roles WHERE Rol = 'Empleado';

    DECLARE user_cursor CURSOR FOR 
        SELECT idUser, idRol FROM inserted;
    OPEN user_cursor;
    FETCH NEXT FROM user_cursor INTO @idUser, @newRoleId;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @oldRoleId = idRol FROM deleted WHERE idUser = @idUser;

        IF @oldRoleId != @newRoleId
        BEGIN
            IF @oldRoleId = @adminRoleId
            BEGIN
                DELETE FROM Admins WHERE idUser = @idUser;
            END
            ELSE IF @oldRoleId = @clientRoleId
            BEGIN
                DELETE FROM Clients WHERE idUser = @idUser;
            END
            ELSE IF @oldRoleId = @employeeRoleId
            BEGIN
                DELETE FROM Employee WHERE idUser = @idUser;
            END

            IF @newRoleId = @adminRoleId
            BEGIN
                INSERT INTO Admins (idUser) VALUES (@idUser);
            END
            ELSE IF @newRoleId = @clientRoleId
            BEGIN
                INSERT INTO Clients (idUser) VALUES (@idUser);
            END
            ELSE IF @newRoleId = @employeeRoleId
            BEGIN
                INSERT INTO Employee (idUser) VALUES (@idUser);
            END
        END

        FETCH NEXT FROM user_cursor INTO @idUser, @newRoleId;
    END;

    CLOSE user_cursor;
    DEALLOCATE user_cursor;
END;

*/*EN PROCESO DE PRUEBA */*
CREATE TRIGGER trg_DeleteMenu ON menu
AFTER DELETE
AS
BEGIN
    DELETE FROM rolPermission
    WHERE idPermission IN (SELECT idPermission FROM permission WHERE idMenu IN (SELECT idMenu FROM DELETED));

    DELETE FROM permission
    WHERE idMenu IN (SELECT idMenu FROM DELETED);
END;

	






