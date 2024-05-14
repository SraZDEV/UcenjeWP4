use master;
go
drop database if exists novabaza;
go
create database novabaza;
go

use novabaza;

create table tablica(
prvo int primary key identity(1,1) not null,
drugo bit ,
trece varchar(5)
);

create table drugatablica(
drugaprvo int primary key identity(1,1) not null,
drugodrugo varchar(5)
);