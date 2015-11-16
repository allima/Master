
create database masterimovel;
use masterimovel;

create table corretor
(
id int identity not null primary key,
nome varchar(250) not null,
email varchar(250) not null,
endereco  varchar(250) not null,
cpf varchar(25) not null,
rg varchar(25) not null,
telefone varchar(25) not null,
);
create table  inquilino
(
id int identity not null primary key,
nome varchar(250) not null,
email varchar(250) not null,
endereco  varchar(250) not null,
cpf varchar(25) not null,
rg varchar(25) not null,
telefone varchar(25) not null,
);
create table imovel
(
id int identity not null primary key,
decricao varchar(250) not null,
);
create table proprietario
(
id int identity not null primary key,
nome varchar(250) not null,
email varchar(250) not null,
endereco  varchar(250) not null,
cpf varchar(25) not null,
rg varchar(25) not null,
telefone varchar(25) not null,
);

create table proprietario_imovel
(
id int identity not null primary key,
id_imovel int not null,
id_proprietario int not null,
constraint proimoimovel_fk foreign key(id_imovel) references imovel(id),
constraint proimoproprietario_fk foreign key(id_proprietario) references proprietario(id)
);

create table locacao(
id int,
id_imovel int not null,
id_inquilino int not null,
id_corretor int not null,
constraint locimovel_fk foreign key(id_imovel) references imovel(id),
constraint locinquilino_fk foreign key(id_inquilino) references inquilino(id),
constraint loccorretor_fk foreign key(id_corretor) references corretor(id)
);
