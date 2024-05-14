use master;
go
drop database if exists novabaza;
go
create database novabaza;
go

use novabaza;

create table tablica(
prvo int not null,
drugo bit not null,
trece varchar(5)
);