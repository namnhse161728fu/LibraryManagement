CREATE DATABASE LibraryManagement
use LibraryManagement
CREATE TABLE Category (
    CategoryID INT identity(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);


CREATE TABLE Book (
    BookID INT identity(1,1) PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    AuthorID nvarchar(50),
    CategoryID INT,
    PublishedDate DATE,
    Quantity INT DEFAULT 0,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

create table Department (
	DepartmentID varchar(10) primary key,
	DepartmentName nvarchar(100)
)

CREATE TABLE Student (
    StudentID varchar(10) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    Phone VARCHAR(15),
    DepartmentID varchar(10) Foreign key references Department(DepartmentID)
);

CREATE TABLE Librarian (
    LibrarianID int identity(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email VARCHAR(100),
	[Password] varchar(20),
    Phone VARCHAR(15)
);

CREATE TABLE Loan (
    LoanID INT identity(1,1) PRIMARY KEY,
    StudentID varchar(10),
    LibrarianID INT,
    LoanDate DATETIME NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (LibrarianID) REFERENCES Librarian(LibrarianID)
);

Create table LoanDetail (
	LoanDetailID int identity(1,1) primary key,
	BookID INT,
	LoanID INT,
	Status bit CHECK (Status IN (0, 1)),
	DueDate DATETIME NOT NULL,
	ReturnDate DATETIME,
	FOREIGN KEY (BookID) REFERENCES Book(BookID),
	FOREIGN KEY (LoanID) REFERENCES Loan(LoanID)
)
