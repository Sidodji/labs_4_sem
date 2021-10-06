use ADO10;

create table AUTHOR
(
	id int primary key not null,
	first_name nvarchar(30) not null,
	last_name nvarchar(30) not null
);
create table PUBLISHER
(
	id int primary key not null,
	name nvarchar(30) not null
);

create table BOOK
(
	id int primary key not null,
	author_key int not null references AUTHOR(id),
	publisher_key int not null references PUBLISHER(id),
	title nvarchar(100) not null,
	photo nvarchar(250)	
)


insert PUBLISHER(id, name) values
(1, 'Aversev'),
(2, 'Piter'),
(3, 'Litera'),
(4, 'Koloss')


insert AUTHOR(id, first_name, last_name) values
(1, 'Stiven' , 'King'),
(2, 'Jack' , 'London'),
(3, 'Oscar' , 'Wailde'),
(4, 'Victor' , 'Gugo')


insert BOOK(id, author_key, publisher_key, title, photo) values
(1, 1, 1, 'It', '/Resources/It.jpg'),
(2, 2, 2, 'Martin Eden', '/Resources/MartinEden.jpg')


USE ADO10;
GO 
CREATE PROCEDURE ShowBook AS 
SELECT  BOOK.title AS TITLE, AUTHOR.last_name AS AUTHOR, PUBLISHER.name AS PUBLISHER FROM BOOK JOIN AUTHOR ON BOOK.author_key=AUTHOR.id
   		JOIN PUBLISHER ON BOOK.publisher_key=PUBLISHER.id 