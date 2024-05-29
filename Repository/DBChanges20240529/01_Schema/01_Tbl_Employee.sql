USE[SandBox]
CREATE TABLE Employee (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    MiddleName NVARCHAR(50),
    LastName NVARCHAR(50),
    Address1 NVARCHAR(100),
    Address2 NVARCHAR(100),
    City NVARCHAR(50),
    State NVARCHAR(50),
    Zip INT,
    JoiningDate DATETIME,
    Department INT,
    Salary INT,
    HasLeft BIT,
    LeavingDate DATETIME,
    CreatedDate DATETIME,
    CreatedBy NVARCHAR(50),
    UpdatedOn DATETIME,
    UpdatedBy NVARCHAR(50)
);
