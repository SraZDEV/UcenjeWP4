use master;
go
drop database if exists vjezbanje3;
go
create database vjezbanje3;
go

use vjezbanje3

create table kustosi(
sifra		int not null primary key identity (100,1),
ime			varchar(25) not null,
prezime		varchar(50) not null,
oib			char(11)
);

create table izlozbe(
sifra			int not null primary key identity (1000,1),
kustos			int not null,
vrstaizlozbe	varchar(100) not null,
cijena			decimal(6,2) not null
);


create table sponzori(
ime			varchar(100) not null,
izlozba		int not null,
kustos		int not null
);

alter table izlozbe add foreign key (kustos) references kustosi(sifra);
alter table sponzori add foreign key (izlozba) references izlozbe(sifra);
alter table sponzori add foreign key (kustos) references kustosi(sifra);