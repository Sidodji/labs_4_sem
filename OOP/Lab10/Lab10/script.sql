use master;
create DataBase Lab10;
use Lab10;

create table BOOK
(
	Id int primary key not null,
	Title varchar not null, 
	AuthorName varchar not null, 
	AuthorLastName nvarchar(100) not null,
	photo nvarchar(250)	
)

insert BOOK(Id, Title, AuthorName, AuthorLastName, photo) values
(1, 'Book1', 'Chelovek', 'Ded', '/Resources/Dorian.jpg'),
(2, 'Book2', 'Chelovek2', 'Ded2', '/Resources/MartinEden.jpg')



