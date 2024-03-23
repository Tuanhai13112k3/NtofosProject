create database Ntofos
Use Ntofos
CREATE TABLE Users (
    UserID INT  PRIMARY KEY IDENTITY(1,1) ,
    Username VARCHAR(255) NOT NULL,
	Fullname NVARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL, 
    Email VARCHAR(255) NOT NULL,
    Role VARCHAR(50) DEFAULT 'User',
    UNIQUE (Username),
    UNIQUE (Email)
);
INSERT INTO Users (Username, Fullname, Password, Email, Role) 
VALUES 
('vu1995', N'Vũ Official', 'vu1995', 'user1@example.com', 'User'),
('hat1984', N'Hà Anh Tuấn', 'hat1984', 'user2@example.com', 'User'),
('mck_nger', N'MCK // Nger', 'mcknger', 'user3@example.com', 'User'),
('Hai2', 'Hai2', '131103', 'Tuanhai13112k3@gmail.com', 'Admin'),
('hwangcho', N'Hwang Cho Story', 'hwangcho', 'user4@example.com', 'User');

CREATE TABLE Songs (
    SongID INT PRIMARY KEY IDENTITY(1,1) ,
    SongName NVARCHAR(255) NOT NULL,
    Artists NVARCHAR(max) NOT NULL,
	Composer NVARCHAR(max),
	Genre NVarchar(max),
    ReleaseDate Datetime not null,
    FilePath VARCHAR(255) not null,
    UploadedBy INT,
    FOREIGN KEY (UploadedBy) REFERENCES Users(UserID)
);
INSERT INTO Songs (SongName, Artists, Composer, Genre, ReleaseDate, FilePath, UploadedBy) 
VALUES 
(N'KHÔNG QUAN TRỌNG', N'Vụ nổ lớn', N' MCK ft. ORIJINN, TAGE, JUSTATEE, TRUNG TRẦN', N'Pop', '2024-03-08', 'khong-quan-trong.mp3', 3),
(N'Bản tình ca của Đá', N'HwangCho', N'HwangCho', N'Chill', '2022-12-17', 'bantinhcacuada.mp3', 5)

CREATE TABLE Films (
    FilmID INT PRIMARY KEY IDENTITY(1,1) ,
    FilmName NVARCHAR(255) NOT NULL,
    Artists NVARCHAR(max) NOT NULL,
	Creator Nvarchar(max) Not null,
	Genre NVarchar(max),
    ReleaseDate Datetime not null,
    FilePath VARCHAR(255) not null,
    UploadedBy INT,
    FOREIGN KEY (UploadedBy) REFERENCES Users(UserID)
);
INSERT INTO Films (FilmName, Artists, Creator, Genre, ReleaseDate, FilePath, UploadedBy) 
VALUES 
(N'Dành Hết Xuân Thì Để Chờ Nhau', N'Vũ. feat. Hà Anh Tuấn',N'Vũ. feat. Hà Anh Tuấn', N'MV', '2024-03-14', 'DHXTDCN.mp4', 1),
(N'Nước Ngoài', N'Hà Anh Tuấn', N'Phan Mạnh Quỳnh', N'MV', '2023-02-01', 'nuocngoai.mp4', 2);
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    SongID INT,
    FilmID INT,
    ReviewText NVARCHAR(MAX),
    Rating INT,
    ReviewDate DATETIME,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (SongID) REFERENCES Songs(SongID),
    FOREIGN KEY (FilmID) REFERENCES Films(FilmID)
);



