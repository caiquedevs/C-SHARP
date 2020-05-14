CREATE DATABASE pizzaria DEFAULT CHARACTER SET utf8 DEFAULT collate utf8_general_ci;
USE pizzaria;

CREATE TABLE tb_cliente (
	ID INT auto_increment ,
	NOME VARCHAR (30) NOT NULL,
	CONTATO VARCHAR (30) NOT NULL,
	ENDERECO VARCHAR (30) NOT NULL,
	CEP VARCHAR (30) NOT NULL,
	NUMERO VARCHAR (30) NOT NULL,
	COMPLEMENTO VARCHAR (30) NOT NULL,
	PRIMARY KEY (ID)
)DEFAULT CHARSET = utf8;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
CREATE TABLE tb_produto (
	ID INT auto_increment,
	NOME  VARCHAR (100) NOT NULL,
	INGREDIENTES VARCHAR (100) NOT NULL ,
	VALOR VARCHAR (100) NOT NULL ,
	CATEGORIA VARCHAR (100) NOT NULL,
	PRIMARY KEY (ID)
)DEFAULT CHARSET = utf8;

CREATE TABLE tb_pedido (
	ID INT auto_increment,
	data VARCHAR (100) NOT NULL,
	IDCLIENTE INT NOT NULL,
	IDPRODUTO INT NOT NULL,
	PRIMARY KEY (ID)
)DEFAULT CHARSET = utf8;

alter table TB_PEDIDO ADD FOREIGN KEY (IDCLIENTE) REFERENCES TB_CLIENTE (ID);
alter table TB_PEDIDO ADD FOREIGN KEY (IDPRODUTO) REFERENCES TB_PRODUTO (ID);
