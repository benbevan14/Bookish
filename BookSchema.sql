DROP DATABASE IF EXISTS bookish;
CREATE DATABASE bookish;

USE bookish;

CREATE TABLE users (
	Id int Identity(1, 1) NOT NULL PRIMARY KEY,
	FirstName VARCHAR(255) NOT NULL,
	LastName VARCHAR(255) NOT NULL,
	Username VARCHAR(255) NOT NULL
);

CREATE TABLE books (
	Id int Identity(1, 1) NOT NULL PRIMARY KEY,
	Title VARCHAR(255) NOT NULL,
	Author VARCHAR(255) NOT NULL,
	ISBN char(10) NOT NULL,
	Barcode char(13) NOT NULL,
	Pages int NOT NULL
);

CREATE TABLE copies (
	Id int Identity(1, 1) NOT NULL PRIMARY KEY,
	BookId int NOT NULL,
	FOREIGN KEY (BookId) REFERENCES books(Id),
	BorrowedBy int,
	FOREIGN KEY (BorrowedBy) REFERENCES users(Id),
	DueDate date
);
