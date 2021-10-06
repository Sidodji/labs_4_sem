use master;
create DataBase ADO10;
use ADO10;
create table AUTHOR
(
	id int primary key not null,
	first_name nvarchar(30) not null,
	last_name nvarchar(30) not null
)
create table PUBLISHER
(
	id int primary key not null,
	name nvarchar(30) not null
)

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
(4, 'Kali')


insert AUTHOR(id, first_name, last_name) values
(1, 'Sergeu' , 'Dovlatov'),
(2, 'Mihail' , 'Bulgacov'),
(3, 'ALexandr' , 'Pushkin'),
(4, 'Vlad' , 'Sor'),
(5, 'Edil' , 'Lim')


insert BOOK(id, author_key, publisher_key, title, photo) values
(1, 1, 1, 'Chemodan', '/Resources/Dorian.jpg'),
(2, 2, 2, 'Zapiski', '/Resources/MartinEden.jpg')



