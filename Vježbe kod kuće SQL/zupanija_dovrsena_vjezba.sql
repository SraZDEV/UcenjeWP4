use master;
go
drop database if exists zupanija;
go
create database zupanija;
go

use zupanija;

create table zupanija(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
zupan int not null
);

create table zupan(
sifra int not null primary key identity(1,1),
ime varchar(100) not null,
prezime varchar(100) not null
);

create table opcina(
sifra int not null primary key identity(1,1),
zupanija int not null,
naziv varchar(100) not null
);

create table mjesto(
sifra int not null primary key identity(1,1),
opcina int not null,
naziv varchar(100) not null
);


alter table opcina add foreign key (zupanija) references zupanija(sifra);
alter table mjesto add foreign key (opcina) references opcina(sifra)
alter table zupanija add foreign key (zupan) references zupan(sifra);


--INSERT NAREDNE

--select * from zupanija;

--insert into zupanija(naziv,zupan)
--values ('Osječko-Baranjska',1),('Brodsko-Posavska',2),('Zagrebačka',3);

--select * from zupan;

--insert into zupan (ime,prezime)
--values ('Pero','Perić'),('Ivo','Ivić'),('Hrvoje','Horvat');

--select * from opcina;

--insert into opcina (naziv,zupanija) values ('Darda',2),('Kneževi Vinogradi',2),('Donji Andrijevci',3),
--('Čeminac',2),('Čepin',2),('Brod Moravice',3);

--select * from mjesto

--insert into mjesto(naziv,opcina) values ('Darda',1),('Čeminac',4),('Bilje',1),('Kozarac',1),('Lug',1),
--('Luč',1),('Branjin Vrh',2),('Zmajevac',2),('Suza',2),('Kneževi Vinogradi',2),('Draž',2),('Gajić',2);


--UPDATE NAREDBE

--select * from mjesto

--update mjesto set
--naziv='Zmajevac1'
--where sifra = 8;

--update mjesto set
--naziv='Bilje1'
--where sifra = 3;

--update mjesto set
--naziv='Darda1'
--where sifra = 1;

--update mjesto set
--naziv='Knezevi Vinogradi'
--where sifra = 10;

--update mjesto set
--naziv='Draz'
--where sifra = 11;


--DELETE NAREDBA

--select * from opcina;

--delete from opcina where sifra=5;

--delete from opcina where sifra=3;