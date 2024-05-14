use master;
go
drop database if exists vjezbanje2;
go
create database vjezbanje2;
go

use vjezbanje2

create table odgajatelji(
sifra	int not null primary key identity (1,1),
ime		varchar(20) not null,
prezime	varchar(40) not null,
oib		char(11)
);

create table skupine(
sifra				int not null primary key identity (1,1),
naziv				varchar(60) not null,
odgajatelj			int not null,
velicinaskupine		int not null
);

create table djeca(
ime			varchar(25) not null,
prezime		varchar(50) not null,
skupina		int not null 
);

alter table skupine add foreign key (odgajatelj) references odgajatelji(sifra);
alter table djeca add foreign key (skupina) references skupine(sifra);