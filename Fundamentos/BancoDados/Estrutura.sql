CREATE TABLE jogos (
    id INT PRIMARY KEY IDENTITY(1, 1),
    categoria VARCHAR(40),
    nome VARCHAR(100)
);

SELECT id, categoria, nome FROM jogos;