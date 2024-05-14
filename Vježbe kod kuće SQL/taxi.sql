use master;
go
drop database if exists vjezbanje5;
go
create database vjezbanje5;
go

use vjezbanje5

create table vozaci(
sifra		int not null primary key identity (100,1),
vozilo		int,
ime			varchar(25) not null,
prezime		varchar(50) not null,
oib			char(11)
);

create table putnici(
sifra		int not null primary key identity (100,1),
ime			varchar(25) not null,
prezime		varchar(50) not null,
oib			char(11),
vozilo		int,
);

create table vozila(
sifra			int not null primary key identity (1000,1),
vrsta			varchar(50) not null,
markavozila		varchar(50) not null,
registracija	varchar(10) not null,
vozac			int not null,
brojputnika		int not null,
putnik			int not null
);

alter table vozila add foreign key (vozac) references vozaci(sifra);
alter table vozila add foreign key (putnik) references putnici(sifra);
alter table putnici add foreign key (vozilo) references vozila(sifra);
alter table vozaci add foreign key (vozilo) references vozila(sifra);