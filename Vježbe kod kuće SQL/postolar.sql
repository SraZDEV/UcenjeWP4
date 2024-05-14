use master;
go
drop database if exists vjezbanje6;
go
create database vjezbanje6;
go

use vjezbanje6

create table postolari(
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
postolar int not null
);

create table korisnici(
sifra int not null primary key identity (10000,1),
ime varchar(25) not null,
prezime varchar(59) not null,
obuca int
);

create table obuca(
sifra int not null primary key identity (100000,1),
postolar int not null,
segrt int not null,
korisnik int not null,
brojpopravaka int,
uizradi bit
);

alter table segrti add foreign key (postolar) references postolari(sifra);
alter table korisnici add foreign key (obuca) references obuca(sifra);
alter table obuca add foreign key (postolar) references postolari(sifra);
alter table obuca add foreign key (segrt) references segrti(sifra);