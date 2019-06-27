CREATE DATABASE QuanLyNhanVien
GO

USE QuanLyNhanVien
GO

CREATE TABLE Employees
(
	EmployeesCode NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(100) NOT NULL,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Sex NVARCHAR(100) NOT NULL,
	Salary FLOAT NOT NULL,
	Address NVARCHAR(100) NOT NULL,
	Phone NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Phong NVARCHAR(100) NOT NULL,
	ManagerCode NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE City
(
	CityCode NVARCHAR(100) PRIMARY KEY,
	NameCity NVARCHAR(100)
)
GO

CREATE TABLE Department
(
	DepartmentCode NVARCHAR(100) PRIMARY KEY,
	NameDepartment NVARCHAR(100) NOT NULL,
	ManagerCode NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Family
(
	EmployeesCode NVARCHAR(100) PRIMARY KEY,
	NameFamily NVARCHAR(100) NOT NULL,
	Sex NVARCHAR(100) NOT NULL,
	Relationship NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Project
(
	ProjectCode NVARCHAR(100) PRIMARY KEY,
	NameProject NVARCHAR(100) NOT NULL,
	PlaceProject NVARCHAR(100) NOT NULL,
	DepartmentCode NVARCHAR(100)
)
GO

INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Admin01', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'Quang', -- FirstName - nvarchar(100)
    N'Nguyen', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'1', -- Phong - nvarchar(100)
    N'Không có'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Admin02', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'Tuan', -- FirstName - nvarchar(100)
    N'Bui', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'2', -- Phong - nvarchar(100)
    N'Không có'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Admin03', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'Giao', -- FirstName - nvarchar(100)
    N'XXX', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'3', -- Phong - nvarchar(100)
    N'Không có'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Staff01', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'XXX', -- FirstName - nvarchar(100)
    N'XXX', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'1', -- Phong - nvarchar(100)
    N'Admin01'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Staff02', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'XXX', -- FirstName - nvarchar(100)
    N'XXX', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'2', -- Phong - nvarchar(100)
    N'Admin02'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Employees
(
    EmployeesCode,
    PassWord,
    FirstName,
    LastName,
    Sex,
    Salary,
    Address,
    Phone,
    Email,
    Phong,
    ManagerCode
)
VALUES
(   N'Staff03', -- EmployeesCode - nvarchar(100)
    N'12345', -- PassWord - nvarchar(100)
    N'XXX', -- FirstName - nvarchar(100)
    N'XXX', -- LastName - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    10000, -- Salary - float
    N'Số 1. Đường Võ Văn Ngân. Quận Thủ Đức. TP.HCM', -- Address - nvarchar(100)
    N'0123456789', -- Phone - nvarchar(100)
    N'abc@gmail.com', -- Email - nvarchar(100)
    N'3', -- Phong - nvarchar(100)
    N'Admin03'  -- ManagerCode - nvarchar(100)
    )
GO

INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'01', -- CityCode - nvarchar(100)
    N'TP.Hồ Chí Minh'  -- NameCity - nvarchar(100)
    )
GO
INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'02', -- CityCode - nvarchar(100)
    N'Hà Nội'  -- NameCity - nvarchar(100)
    )
GO
INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'03', -- CityCode - nvarchar(100)
    N'Huế'  -- NameCity - nvarchar(100)
    )
GO
INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'04', -- CityCode - nvarchar(100)
    N'Đà Nẵng'  -- NameCity - nvarchar(100)
    )
GO
INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'05', -- CityCode - nvarchar(100)
    N'Vũng Tàu'  -- NameCity - nvarchar(100)
    )
GO
INSERT dbo.City
(
    CityCode,
    NameCity
)
VALUES
(   N'06', -- CityCode - nvarchar(100)
    N'Bạc Liêu'  -- NameCity - nvarchar(100)
    )
GO

INSERT dbo.Department
(
    DepartmentCode,
    NameDepartment,
    ManagerCode
)
VALUES
(   N'1', -- DepartmentCode - nvarchar(100)
    N'Tài Chính', -- NameDepartment - nvarchar(100)
    N'Admin01'  -- ManagerCode - nvarchar(100)
    )
GO

INSERT dbo.Department
(
    DepartmentCode,
    NameDepartment,
    ManagerCode
)
VALUES
(   N'2', -- DepartmentCode - nvarchar(100)
    N'Kế Toán', -- NameDepartment - nvarchar(100)
    N'Admin02'  -- ManagerCode - nvarchar(100)
    )
GO
INSERT dbo.Department
(
    DepartmentCode,
    NameDepartment,
    ManagerCode
)
VALUES
(   N'3', -- DepartmentCode - nvarchar(100)
    N'Nghiên Cứu', -- NameDepartment - nvarchar(100)
    N'Admin03'  -- ManagerCode - nvarchar(100)
    )
GO

INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Admin01', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO
INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Admin02', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO
INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Admin03', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nam', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO
INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Staff01', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nữ', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO
INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Staff02', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nữ', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO
INSERT dbo.Family
(
    EmployeesCode,
    NameFamily,
    Sex,
    Relationship
)
VALUES
(   N'Staff03', -- EmployeesCode - nvarchar(100)
    N'XXX', -- NameFamily - nvarchar(100)
    N'Nữ', -- Sex - nvarchar(100)
    N'XXX'  -- Relationship - nvarchar(100)
    )
GO

INSERT dbo.Project
(
    ProjectCode,
    NameProject,
    PlaceProject,
    DepartmentCode
)
VALUES
(   N'PJC01', -- ProjectCode - nvarchar(100)
    N'Xây Cầu', -- NameProject - nvarchar(100)
    N'Thủ Đức', -- PlaceProject - nvarchar(100)
    N'1'  -- DepartmentCode - nvarchar(100)
    )
GO
INSERT dbo.Project
(
    ProjectCode,
    NameProject,
    PlaceProject,
    DepartmentCode
)
VALUES
(   N'PJC02', -- ProjectCode - nvarchar(100)
    N'Xây Nhà', -- NameProject - nvarchar(100)
    N'Thủ Đức', -- PlaceProject - nvarchar(100)
    N'2'  -- DepartmentCode - nvarchar(100)
    )
GO
INSERT dbo.Project
(
    ProjectCode,
    NameProject,
    PlaceProject,
    DepartmentCode
)
VALUES
(   N'PJC03', -- ProjectCode - nvarchar(100)
    N'Xây Hầm', -- NameProject - nvarchar(100)
    N'Thủ Đức', -- PlaceProject - nvarchar(100)
    N'3'  -- DepartmentCode - nvarchar(100)
    )
GO
