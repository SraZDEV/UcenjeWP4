use master;
go
drop database if exists vjezbanje;
go
create database vjezbanje;
go

use vjezbanje

create table radnici(
sifra		int not null primary key identity (1,1),
ime			varchar(25) not null,
prezime		varchar(50) not null,
oib			char(11) not null
);


create table sticenici (
vrsta		varchar(50) not null,
naziv		varchar(15) not null,
sifra		int not null primary key identity (1,1),
radnik		int not null
);


create table prostori(
rednibroj		varchar(15) not null,
veličina		decimal(4,1),
sticeniksifra	int not null primary key identity (1,1),
radnik			int
);

alter table sticenici add foreign key (radnik) references radnici(sifra);
alter table prostori add foreign key (sticeniksifra) references sticenici(sifra);
alter table prostori add foreign key (radnik) references radnici(sifra);