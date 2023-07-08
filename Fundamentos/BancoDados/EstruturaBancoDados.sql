-- Criar a tabela de jogos
CREATE TABLE jogos (
    id INT PRIMARY KEY IDENTITY(1, 1),
    categoria VARCHAR(40),
    nome VARCHAR(100),
);

-- DOUBLE: decimal
-- BIT: 1, 0 => boolean
-- DATE: Data
-- DATETIME2: Data e hora
-- 

-- Consultar todos os campos da tabela de jogos
SELECT id, categoria, nome FROM jogos;