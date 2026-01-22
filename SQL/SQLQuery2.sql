USE ms_dynamicsDB;

DROP TABLE IF EXISTS My_Students;
DROP TABLE IF EXISTS Trainers;
DROP TABLE IF EXISTS MyCourses;

CREATE TABLE MyCourses (
    CourseId INT PRIMARY KEY,
    CourseName VARCHAR(100)
);

CREATE TABLE My_Students (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    CourseId INT
);

CREATE TABLE Trainers (
    TrainerId INT PRIMARY KEY,
    TrainerName VARCHAR(50),
    ManagerId INT
);

INSERT INTO MyCourses VALUES
(1, 'FULLSTACK'),
(2, 'CYBERSECURITY'),
(3, 'DIGITALMARKETING'),
(4, 'UI/UX');

INSERT INTO My_Students VALUES
(101, 'RAHUL', 1),
(102, 'NEHA', 2),
(103, 'SATYA', 3),
(104, 'DIVYA', 4);

INSERT INTO Trainers VALUES
(1, 'ARJUN', NULL),
(2, 'RAVI', 1),
(3, 'SNEHA', 1),
(4, 'KIRAN', 2);


SELECT s.StudentName, s.StudentId, c.CourseName
FROM My_Students s
JOIN MyCourses c
ON s.CourseId = c.CourseId;

SELECT s.StudentName, c.CourseName
FROM My_Students s
LEFT JOIN MyCourses c
ON s.CourseId = c.CourseId;

SELECT s.StudentName, c.CourseName
FROM My_Students s
RIGHT JOIN MyCourses c
ON s.CourseId = c.CourseId;

SELECT s.StudentName, c.CourseName
FROM My_Students s
FULL OUTER JOIN MyCourses c
ON s.CourseId = c.CourseId;

SELECT 
    t1.TrainerName AS Trainer,
    t2.TrainerName AS Manager
FROM Trainers t1
LEFT JOIN Trainers t2
ON t1.ManagerId = t2.TrainerId;
