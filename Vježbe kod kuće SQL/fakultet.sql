use master;
go
drop database if exists vjezbanje11;
go
create database vjezbanje11;
go

use vjezbanje11;

create table kolegij(
sifra int not null primary key identity (10,1),
naziv varchar(100) not null,
trajanje int,
brojstudenata int not null
);

create table rokovi(
sifra int not null primary key identity (10,1),
naziv varchar(100),
brojstudenata int not null,
maxbrojizlazaka int not null
);

create table studenti(
sifra int not null primary key identity (100,1),
ime varchar(25) not null,
prezime varchar(25) not null,
oib char(11),
kolegij int not null,
rok int not null,
brojizlazaka int not null
);

alter table studenti add foreign key (kolegij) references kolegij(sifra);
alter table studenti add foreign key (rok) references rokovi(sifra);