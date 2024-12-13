CREATE DATABASE QuanLySinhVien
USE QuanLySinhVien



CREATE TABLE Faculty (
    FacultyID INT PRIMARY KEY,              
    FacultyName NVARCHAR(200) NOT NULL      
)

CREATE TABLE Student (
    StudentID NVARCHAR(20) PRIMARY KEY,     
    FullName NVARCHAR(200) NOT NULL,        
    AverageScore FLOAT CHECK (AverageScore BETWEEN 0 AND 10),
    FacultyID INT,                          
    CONSTRAINT FK_Student_Faculty FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID) 
)

INSERT INTO Faculty (FacultyID, FacultyName)
VALUES
    (1, N'Công Nghệ Thông Tin'),
    (2, N'Ngôn Ngữ Anh'),
    (3, N'Quản Trị Kinh Doanh');


INSERT INTO Student (StudentID, FullName, AverageScore, FacultyID)
VALUES
    (N'1611061916', N'Nguyễn Trần Hoàng Lan', 4.5, 1),
    (N'1711060596', N'Đàm Minh Đức', 2.5, 1),
    (N'1711061004', N'Nguyễn Quốc An', 10.0, 2);



	SELECT * FROM dbo.Student

	DELETE FROM Student
    WHERE StudentID = '2'


	SELECT * FROM dbo.Faculty

		DELETE FROM Faculty
    WHERE FacultyID = '6'

	ALTER TABLE Faculty
ADD TotalProfessor INT NULL;
