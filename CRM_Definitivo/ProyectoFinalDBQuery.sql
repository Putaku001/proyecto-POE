CREATE DATABASE SistemaProyectosDB;

SELECT * FROM users				

insert into menu
VALUES('Cliente', 'iconMenuItemProjectsEmployee')

INSERT INTO permission
VALUES(9)

INSERT into rolPermission
VALUES(4, 8)

SELECT r.idRol, m.nameForm , p.idPermission 
FROM rolPermission rp
JOIN roles r ON rp.idRoles = r.idRol
JOIN permission p ON rp.idPermission = p.idPermission
JOIN menu m ON p.idMenu = m.idMenu
JOIN users u on u.idRol = r.idRol
WHERE u.idUser = @idUser;



                SELECT COUNT(*) 
                FROM rolPermission rp
                INNER JOIN permission p ON rp.idPermission = p.idPermission

SELECT * FROM Users


insert into roles(Rol)
VALUES('Cliente')

DELETE FROM Users;


DELETE FROM Users
WHERE idUser IN(25);  


UPDATE Users
SET email ='default@gmail.com'
WHERE idUser = 15;


EXEC sp_rename 'Users.FechaRegistro', 'DateRegistration', 'COLUMN';

UPDATE Users SET FechaRegistro = '2024-10-25 23:38:20' 

SELECT u.idUser, r.idRol, u.UserAccount, u.nameuser, u.lastName, u.email, u.birthdate, 
                                        u.numberPhone, u.passworduser, u.country, u.city, u.statususer, u.DateRegistration
                                 FROM Users u
                                 INNER JOIN roles r on r.idRol = u.idRol


update Users
set idRol = 'Sijilo75'
WHERE idUser = 5

ALTER TABLE Users
ADD CONSTRAINT Fk_Roles FOREIGN KEY(idRol) REFERENCES roles(idRol)

ALTER TABLE Users
ADD email VARCHAR(100)

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
('2024-01-01', '2024-06-01', 'Proyecto de migraci�n a la nube', 'Migraci�n Nube', 1, 1, 1);

INSERT INTO task (nameTask, descriptionTask, idEmployee, idProyect) 
VALUES 
('Desarrollo Backend', 'Implementaci�n del API REST', 1, 1);

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


