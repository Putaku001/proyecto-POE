CREATE DATABASE SistemaProyectosDB;

	SELECT * FROM users				


SELECT r.idRol, m.nameForm , p.idPermission 
FROM rolPermission rp
JOIN roles r ON rp.idRoles = r.idRol
JOIN permission p ON rp.idPermission = p.idPermission
JOIN menu m ON p.idMenu = m.idMenu
JOIN users u on u.idRol = r.idRol
WHERE u.idUser = @idUser;


SELECT t.idTask, t.idProyect, p.titleName, t.nameTask, t.descriptionTask, t.idEmployee from task t 
                                left join proyect p on t.idProyect = p.idProyect
                                LEFT JOIN employee e on e.idEmployee = e.idUser
                                WHERE t.idTask = 3

UPDATE Users
SET email ='default@gmail.com'
WHERE idUser = 15;


*/* Metodo para proyecto*/*
SELECT idProyect, titleName, description, idClient, idEmployee, idStatusProyect, dateInit, dateEnd FROM proyect


SELECT 
                                P.idProyect,
                                P.titleName,
                                P.description,   
                                CU.UserAccount AS Client,
								p.idEmployee,
                                EU.UserAccount AS Employee,
	                            E.workStation,
	                            P.dateInit,
                                P.dateEnd,
                                S.statusproyect

                            FROM 
                                Proyect P
                            LEFT JOIN StatusProyect S ON P.idStatusProyect = S.idStatusProyect
                            LEFT JOIN Clients CL ON P.idClient = CL.idCliente
                            LEFT JOIN Users CU ON CL.idUser = CU.idUser
                            LEFT JOIN Employee E ON P.idEmployee = E.idEmployee
                            LEFT JOIN Users EU ON E.idUser = EU.idUser
							WHERE p.idEmployee = 1

							select a.idAdmin, u.userAccount from Admins a
							LEFT JOIN Users u on a.idUser = u.idUser

							select e.idEmployee, u.UserAccount from employee e LEFT JOIN Users u on e.idUser = u.idUser

							select c.idCliente, u.userAccount from Clients c LEFT JOIN Users u on c.idUser = u.idUser 

							/*SELECT DE PERMISOS*/
							SELECT p.idPermission, p.idMenu, m.nameForm FROM permission p
							LEFT JOIN menu m on p.idMenu = m.idMenu

							SELECT rp.idRolPermission, rp.idPermission, rp.idRoles, m.nameForm FROM rolPermission rp
							LEFT JOIN permission p on rp.idPermission = p.idPermission
							LEFT JOIN menu m on p.idMenu = m.idMenu 





SELECT p.idProyect, p.titleName, p.description, p.idClient, p.idEmployee, p.idStatusProyect, p.dateInit, p.dateEnd, u.UserAccount FROM proyect p
INNER JOIN  Users u on p.idEmployee = u.idUser 


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
	idTask INT,
	[file] varbinary(MAX)
    FOREIGN KEY (idStatusProyect) REFERENCES statusProyect(idStatusProyect),
    FOREIGN KEY (idClient) REFERENCES Clients(idCliente)ON DELETE SET NULL,
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee) ON DELETE SET NULL
);








select * from RequestProjectClient

INSERT INTO statusProyect(statusproyect)
VALUES('Pendiente'),('Abierto'),('En progreso'),('esperando aprobacion del cliente'),('Rechazado'),('Terminado')
	
INSERT INTO RequestProjectClient(idClient, codeProject, nameProject, descriptionProject, idStatusProject)
VALUES(12, 'U24947', 'proyecto prueba2', 'descripcion proyeto prueba2', 4 )




/* NUEVAS TABLAS */
CREATE TABLE RequestProjectClient
(
	idProject INT PRIMARY KEY IDENTITY(1,1),
	idClient INT,
	codeProject NVARCHAR(6) NOT NULL,
	nameProject NVARCHAR(200) NOT NULL,
	descriptionProject NVARCHAR(200) NOT NULL,
	[file] VARBINARY(MAX),
	idStatusProject INT,
	idRefused INT,
	dateInit DATE,
	dateEnd DATE,
	dateRegistration DATETIME DEFAULT GETDATE()

	FOREIGN KEY (idStatusProject) REFERENCES statusProyect(idStatusProyect),
	FOREIGN KEY (idClient) REFERENCES Clients(idCliente),
	FOREIGN KEY (idRefused) REFERENCES RefusedProject(idRefused)
)


CREATE TABLE RefusedProject
(
	idRefused INT PRIMARY KEY IDENTITY(1,1),
	idProject INT,
	reason NVARCHAR(50) NOT NULL,
	reasonForRejection NVARCHAR(500) NOT NULL

)

DROP TABLE taskProjects
CREATE TABLE taskProjects (
    idTask INT PRIMARY KEY identity(1,1),
	codeProject NVARCHAR(6),
    nameTask VARCHAR(100),
    descriptionTask VARCHAR(255),
    idEmployee INT,
	idStatusTask INT,
	dateEnd DATE,
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee),
	FOREIGN KEY (idStatusTask) REFERENCES taskEmployeesStatus(idStatusTask)
);

CREATE TABLE taskEmployeesStatus
(
	idStatusTask INT PRIMARY KEY IDENTITY(1,1),
	statusTask NVARCHAR(50)
)

INSERT INTO taskEmployeesStatus(statusTask)
VALUES('Pendiente'),('En proceso'),('Terminado')

/* Consulta para proyecto de cliente */
SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, rf.reason, rf.reasonForRejection, r.dateRegistration FROM RequestProjectClient r
LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
LEFT JOIN Clients c on c.idCliente = r.idClient
LEFT JOIN Users u on u.idUser = c.idUser
LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject


/* Consulta para tareas de proyectos */
SELECT tp.idTask, tp.codeProject, TP.idEmployee , u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
LEFT JOIN employee e on e.idEmployee = tp.idEmployee
LEFT JOIN Users u on u.idUser = e.idEmployee
INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask

/* Consulta para proyectos rechazados */
SELECT p.codeProject, rp.reason, rp.reasonForRejection, sp.statusproyect FROM RefusedProject rp
LEFT JOIN RequestProjectClient p on p.idProject = rp.idProject
LEFT JOIN statusProyect sp on sp.idStatusProyect = p.idStatusProject







SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, rf.reason, rf.reasonForRejection, r.dateRegistration FROM RequestProjectClient r
                                 LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
                                 LEFT JOIN Clients c on c.idCliente = r.idClient
                                 LEFT JOIN Users u on u.idUser = c.idUser
                                 LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject
                                 WHERE idClient = 11 AND st.statusproyect = 'Pendiente'













alter tabLE Proyect
ADD task INT

alter table Proyect
ADD CONSTRAINT Fk_task FOREIGN KEY(task) REFERENCES task(idTask)


select * from task


CREATE TABLE task (
    idTask INT PRIMARY KEY identity(1,1),
    nameTask VARCHAR(100),
    descriptionTask VARCHAR(255),
    idEmployee INT,
    idProyect INT,
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee),
    FOREIGN KEY (idProyect) REFERENCES proyect(idProyect)
);


SELECT t.idProyect, p.titleName, t.nameTask, t.descriptionTask, t.idEmployee from task t 
left join proyect p on t.idProyect = p.idProyect
LEFT JOIN employee e on e.idEmployee = e.idUser
WHERE t.idProyect = 1


SELECT 
                                P.idProyect,
                                P.titleName,
								p.idClient,
								p.idEmployee,
								t.nameTask,
	                            P.dateInit,
                                P.dateEnd,
                                p.idStatusProyect

                            FROM 
                                Proyect P
								left join task t on t.idTask = p.task


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

	






