create table livraria (
	idlivro int not null auto_increment,
    nome varchar (90) not null,
    autor varchar (45) not null,
    editora varchar (45) not null,
    qtdepag int not null,
    primary key (idlivro)
);