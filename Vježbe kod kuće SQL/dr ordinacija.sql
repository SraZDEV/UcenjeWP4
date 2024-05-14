use master;
go
drop database if exists vjezbanje8;
go
create database vjezbanje8;
go

use vjezbanje8;

create table doktori(
sifra int not null primary key identity (1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
medicinskasestra int not null
);

create table medicinskesestre(
sifra int not null primary key identity (1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11)
);

create table pacijenti(
sifra int not null primary key identity (10000,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
doktor int not null,
brojljecena int not null,
ljecenjeutijeku bit not null
);

alter table doktori add foreign key (medicinskasestra) references medicinskesestre(sifra);
alter table pacijenti add foreign key (doktor) references doktori(sifra);