CREATE DATABASE employees_db;
USE employees_db;

CREATE TABLE Employees(
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeName VARCHAR(40) NOT NULL,
	Department VARCHAR(30) NOT NULL,
	Salary INT NOT NULL
);

INSERT INTO Employees(EmployeeName, Department, Salary)
VALUES('Jeff', 'SDE', 30000);

SELECT * FROM Employees;

CREATE TABLE EmployeesAudit(
	AuditID INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeID INT,
	AuditAction VARCHAR(10),
	OldValue NVARCHAR(MAX),
	NewValue NVARCHAR(MAX),
	ChangedBy VARCHAR(50),
	ChangedDate DATETIME DEFAULT GETDATE()
);

SELECT * FROM EmployeesAudit;

GO
CREATE TRIGGER trgEmployeesAudit
ON Employees
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ActionType VARCHAR(10);

	IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
		SET @ActionType = 'UPDATE';
	ELSE IF EXISTS (SELECT * FROM inserted)
		SET @ActionType = 'INSERT';
	ELSE IF EXISTS (SELECT * FROM deleted)
		SET @ActionType = 'DELETE';
	ELSE
		RETURN;


	IF @ActionType = 'INSERT'
	BEGIN
		INSERT INTO EmployeesAudit(EmployeeID, AuditAction, OldValue, NewValue, ChangedBy, ChangedDate)
		SELECT 
			i.EmployeeID,
			'INSERT',
			NULL,
			(SELECT * FROM inserted i2 WHERE i2.EmployeeID = i.EmployeeID FOR JSON AUTO),
			SYSTEM_USER,
			GETDATE()
		FROM inserted i;
	END

	IF @ActionType = 'DELETE'
	BEGIN
		INSERT INTO EmployeesAudit(EmployeeID, AuditAction, OldValue, NewValue, ChangedBy, ChangedDate)
		SELECT 
			d.EmployeeID,
			'DELETE',
			(SELECT * FROM deleted d2 WHERE d2.EmployeeID = d.EmployeeID FOR JSON AUTO),
			NULL,
			SYSTEM_USER,
			GETDATE()
		FROM deleted d;
	END

	IF @ActionType = 'UPDATE'
	BEGIN
		INSERT INTO EmployeesAudit(EmployeeID, AuditAction, OldValue, NewValue, ChangedBy, ChangedDate)
		SELECT 
			i.EmployeeID,
			'UPDATE',
			(SELECT * FROM deleted d WHERE d.EmployeeID = i.EmployeeID FOR JSON AUTO),
			(SELECT * FROM inserted i2 WHERE i2.EmployeeID = i.EmployeeID FOR JSON AUTO),
			SYSTEM_USER,
			GETDATE()
		FROM inserted i;
	END
END;
GO

INSERT INTO Employees(EmployeeName, Department, Salary)
VALUES('Amit Sharma', 'HR', 25000);


SELECT * FROM EmployeesAudit;

UPDATE Employees
SET Salary = 28000
WHERE EmployeeID = 1;


DELETE FROM Employees
WHERE EmployeeID = 1;


SELECT * FROM EmployeesAudit;


CREATE PROCEDURE spAddEmployee
	@Name VARCHAR(40),
	@Department VARCHAR(30),
	@Salary INT
AS
BEGIN
	SET NOCOUNT ON;

	IF @Name IS NULL OR @Name = ''
	BEGIN
		PRINT 'Error: Employee name cannot be empty';
		RETURN;
	END

	INSERT INTO Employees(EmployeeName, Department, Salary)
	VALUES(@Name, @Department, @Salary);
END;
GO

EXEC spAddEmployee
	@Name = 'Sumit',
	@Department = 'Finance',
	@Salary = 35000;


CREATE PROCEDURE spUpdateEmployee
	@ID INT,
	@Name VARCHAR(40),
	@Department VARCHAR(30),
	@Salary INT
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @ID)
	BEGIN
		PRINT 'Error: Employee ID not found';
		RETURN;
	END

	UPDATE Employees
	SET
		EmployeeName = @Name,
		Department = @Department,
		Salary = @Salary
	WHERE EmployeeID = @ID;
END;
GO


EXEC spUpdateEmployee
	@ID = 2,
	@Name = 'Shivani',
	@Department = 'Accounts',
	@Salary = 38000;


SELECT * FROM Employees;
SELECT * FROM EmployeesAudit;
