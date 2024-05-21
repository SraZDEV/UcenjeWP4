use master;
go
drop database if exists fitnessklub;
go
create database fitnessklub;
go

use fitnessklub;

create table radnici(
id int not null primary key identity(1,1),
ime varchar(25) not null,
prezime varchar(50) not null,
email varchar(155) not null,
userid varchar(25) not null,
pwd varchar(25) not null
);

create table privatni_treneri(
id int not null primary key identity(10,1),
ime varchar(25) not null,
prezime varchar(50) not null,
email varchar(155) not null,
cijena_sat decimal(3,2)
);

create table clanovi(
id int not null primary key identity(10000,1),
ime varchar(25) not null,
prezime varchar(50) not null,
email varchar(155) not null,
grupa int not null,
clan_od datetime not null
);

create table grupe(
id int not null primary key identity(10,1),
naziv varchar(155) not null,
clan int not null,
privatni_trener int not null,
kolicina_clanova int not null,
cijena decimal(10,2)
);

alter table clanovi add foreign key (id) references grupe(id);
alter table grupe add foreign key (id) references privatni_treneri(id);