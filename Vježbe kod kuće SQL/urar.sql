use master;
go
drop database if exists vjezbanje7;
go
create database vjezbanje7;
go

use vjezbanje7

create table urari(
sifra int not null primary key identity (1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
segrt int not null
);

create table segrti(
sifra int not null primary key identity (1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
korisnik int not null,
urar int not null
);

create table korisnici(
sifra int not null primary key identity (10000,1),
ime varchar(25) not null,
prezime varchar(59) not null,
sat int
);

create table satovi(
sifra int not null primary key identity (100000,1),
urar int not null,
segrt int not null,
korisnik int not null,
brojpopravaka int,
uizradi bit
);

alter table segrti add foreign key (urar) references urari(sifra);
alter table korisnici add foreign key (sat) references satovi(sifra);
alter table satovi add foreign key (urar) references urari(sifra);
alter table satovi add foreign key (segrt) references segrti(sifra);