CREATE DATABASE bd_questionbase;

USE bd_questionbase;

CREATE TABLE Usuario(
id int AUTO_INCREMENT PRIMARY KEY,
nome varchar(100),
email varchar(100),
senha varchar(100),
tipoUsuario varchar(100)
);

CREATE TABLE Curso(
id int AUTO_INCREMENT PRIMARY KEY,
nome varchar (100),
idModulo int,
idQuestoes int,
FOREIGN KEY (idQuestoes) references Questoes(id),
FOREIGN KEY (idModulo) references Modulo(id)
);

CREATE TABLE Modulo(
id int AUTO_INCREMENT PRIMARY KEY,
nome varchar(100),
idQuestoes int,
FOREIGN KEY (idQuestoes) references Questoes(id)
);

CREATE TABLE Questoes(
id int AUTO_INCREMENT PRIMARY KEY,
idProvas int,
idRespostas int,
enunciado varchar(250),
FOREIGN KEY(idProvas) references Provas(id)
FOREIGN KEY(idRespostas) references Respostas(id)
);

CREATE TABLE Respostas(
id int AUTO_INCREMENT PRIMARY KEY,
idQuestoes int,
resposta varchar(250),
FOREIGN KEY(idQuestoes) references Questoes(id)
);

CREATE TABLE Provas(
id int AUTO_INCREMENT PRIMARY KEY,
titulo varchar(250),
numeroQuestoes int,
dificuldadeQuestoes varchar(100)
);

INSERT INTO Usuario(nome, email, senha, tipoUsuario) 
VALUES ('Rodolfo', 'rodolfo@gmail.com', '2b7af07d140b1473b5330e7f5f024b9c', 'premium'),
('Victor Hugo', 'victorhugo@gmail.com', '94638b16549125c7511e1f067905634f', 'gratuito');