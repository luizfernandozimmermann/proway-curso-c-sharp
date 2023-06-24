CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	quantidade INT,
	preco_unitario DECIMAL(13, 2)
);


SELECT * FROM produtos;

CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(100) NOT NULL,
	cpf VARCHAR(14) NOT NULL,
	data_nascimento DATETIME NOT NULL,

	estado CHAR(2) NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	bairro VARCHAR(40) NOT NULL,
	logradouro VARCHAR(50) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	complemento TEXT
);

ALTER TABLE clientes ADD data_nascimento DATETIME2 NOT NULL;

ALTER TABLE clientes ADD cep CHAR(9) NOT NULL;