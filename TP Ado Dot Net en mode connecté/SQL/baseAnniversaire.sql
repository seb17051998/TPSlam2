drop database if exists baseAnniversaire;
create database baseAnniversaire;
use baseAnniversaire;

create table anniversaire(
	id int auto_increment not null,
	dateAnniversaire datetime,
	nomPseudonyme char(40) not null,
	prenomPseudonyme char(40) not null,
	nom char(40),
	prenom char(40),
	index(id)
	);
	
alter table anniversaire add constraint pk_anniversaire primary key(id);