use master;
go
drop database if exists vjezbanje12;
go
create database vjezbanje12;
go

use vjezbanje12;

create table ucenici(
sifra int not null primary key identity (10,1),
ime varchar(25) not null,
prezime varchar(50)not null,
oib char(11)
);

create table uciteljice(
sifra int not null primary key identity (10,1),
ime varchar(25) not null,
prezime varchar(50) not null,
oib char(11)
);

create table radionice(
sifra int not null primary key identity (10,1),
naziv varchar(100) not null,
uciteljica int not null,
ucenik int not null,
maxucenika int not null
);

alter table radionice add foreign key (uciteljica) references uciteljice(sifra);
alter table radionice add foreign key (ucenik) references ucenici(sifra);