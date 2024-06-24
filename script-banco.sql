CREATE DATABASE Clube_Futebol;
GO

USE Clube_Futebol;
GO

CREATE TABLE tb_atletas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nome NVARCHAR(100),
    apelido NVARCHAR(50),
	data_nascimento DATE,
    altura FLOAT,
    peso FLOAT,
	posicao NVARCHAR(50),
    numero_camisa INT
);
GO

INSERT INTO tb_atletas (nome, apelido, data_nascimento, altura, peso, posicao, numero_camisa)
VALUES 
('Thibaut Nicolas Marc Courtois', 'Courtois', '1992-05-11', 1.99, 92, 'Goleiro', 1),
('Rúben Santos Gato Alves Dias', 'Rúben', '1997-05-14', 1.87, 82, 'Zagueiro Central', 3),
('Sergio Ramos Garcia', 'Sergio Ramos', '1986-03-30', 1.83, 75, 'Zagueiro Central', 4),
('Trent John Alexander-Arnold', 'Alexander-Arnold', '1998-10-07', 1.75, 69, 'Lateral Direito', 66),
('Andrew Robertson', 'Robertson', '1994-03-11', 1.78, 64, 'Lateral Esquerdo', 26),
('Kevin De Bruyne', 'De Bruyne', '1991-06-28', 1.81, 76, 'Meio Campo', 17),
('Rodrigo Hernández Cascante', 'Rodri', '1996-06-22', 1.91, 85, 'Volante', 16),
('Lionel Andrés Messi Cuccitini', 'Messi', '1987-06-24', 1.70, 72, 'Ponta Direita', 10),
('Cristiano Ronaldo dos Santos Aveiro', 'Ronaldo', '1985-02-05', 1.87, 85, 'Ponta Esquerda', 7),
('Neymar da Silva Santos Júnior', 'Neymar Jr', '1992-02-05', 1.75, 68, 'Atacante', 11),
('Robert Lewandowski', 'Lewandowski', '1988-08-21', 1.85, 81, 'Centroavante', 9),
('Gessé Felipe de Sá Taveira', 'Felipe', '1999-07-02', 1.74, 85, 'Goleiro', 25);
GO