use master;
go
drop database if exists vjezbanje4;
go
create database vjezbanje4;
go

use vjezbanje4

create table svecenici(
sifra		int not null primary key identity (10000,1),
ime			varchar(25) not null,
prezime		varchar(50) not null,
oib			char(11),
nadredeni	int
);

create table poslovi(
sifra			int not null primary key identity (1,1),
svecenik		int not null,
vrsta			varchar(100) not null,
trajanje		time
);

create table hijerarhija(
svecenik		int not null,
posao			int not null
);

alter table poslovi add foreign key (svecenik) references svecenici(sifra);
alter table svecenici add foreign key (nadredeni) references svecenici(sifra);
alter table hijerarhija add foreign key (svecenik) references svecenici(sifra);
alter table hijerarhija add foreign key (posao) references poslovi(sifra);