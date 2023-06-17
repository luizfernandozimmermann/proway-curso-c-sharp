CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	quantidade INT,
	preco_unitario DECIMAL(13, 2)
);


SELECT * FROM produtos;