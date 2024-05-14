use master;
go
drop database if exists vjezbanje13;
go
create database vjezbanje13;
go

use vjezbanje13;

create table razredi(
sifra int not null primary key identity(10,1),
naziv varchar(30) not null,
brojucenika int not null,
ucenik int,
profesor int
);

create table ucenici(
sifra int not null primary key identity(10,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11),
razred int
);

create table profesori(
sifra int not null primary key identity(10,1),
ime varchar(25) not null,
prezime varchar(50) not null,
razred int not null,
brojrazreda int
);

alter table ucenici add foreign key (razred) references razredi(sifra);
alter table profesori add foreign key (razred) references razredi(sifra);
alter table razredi add foreign key (ucenik) references ucenici(sifra);
alter table razredi add foreign key (profesor) references profesori(sifra);