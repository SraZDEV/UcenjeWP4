use master;
go
drop database if exists vjezbanje9;
go
create database vjezbanje9;
go

use vjezbanje9;

create table djelatnici(
sifra int not null primary key identity(1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11)
);

create table korisnici(
sifra int not null primary key identity (10,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
djelatnik int not null,
usluga int
);

create table usluge(
sifra int not null primary key identity (10,1),
naziv varchar(100),
djelatnik int,
cijena decimal(5,2),
trajanje int
);

alter table korisnici add foreign key (djelatnik) references djelatnici(sifra);
alter table korisnici add foreign key (usluga) references usluge(sifra);
alter table usluge add foreign key (djelatnik) references djelatnici(sifra);