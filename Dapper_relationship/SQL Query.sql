-- Many to Many

--CREATE TABLE Author(
--     Id int PRIMARY KEY IDENTITY(1,1),
--     [Name] nvarchar(100),
--     [SurName] nvarchar(100)
--)

--CREATE TABLE Book(
--[Id] int PRIMARY KEY IDENTITY(1, 1),
--[Name] nvarchar(50)
--)



--CREATE TABLE Prices(
--[Id] int PRIMARY KEY IDENTITY(1, 1),
--AuthorId int REFERENCES Author(Id),
--BookId int REFERENCES Book(Id),
--Price money NOT NULL CHECK(Price>=0)
--UNIQUE(AuthorId),
--UNIQUE(BookId)
--)


--INSERT INTO Author
--VALUES(N'Aleksandr', N'Matrosov'),
--(N'Alexey ', N'Arkhangelsky'),
--(N'Boris ', N'Carpov'),
--(N'Vladimir ', N'Korol'),
--(N'James R. ', N'Groff'),
--(N'Evangelos ', N'Petrusos'),
--( N'Kevin ', N'Reichard'),
--( N'Ludmila', N'Omelchenko'),
--( N'Mark ', N'Braun')

--INSERT INTO Book
--VALUES (N'SQL'),
--       (N'Delphi'),
--       (N'Vnutrennie voiska Kavkazskii krest 2'),
--       (N'Korol, dama, valet '),
--       (N'SQL: The Complete Reference, 3rd Edition'),
--       (N'Power Tools for Maximizing the API '),
--       (N'The Complete Guide to Spring Training 2022 Florida'),
--       (N'Microsoft Windows 7'),
--       (N'A Tale of Two Synods')

--INSERT INTO Prices
--VALUES(1,1,250),
--      (2,2,300),
--      (3,3,100),
--      (4,4,600),
--      (5,5,620),
--      (6,6,650),
--      (7,7,740),
--      (8,8,590),
--      (9,9,500)
      



