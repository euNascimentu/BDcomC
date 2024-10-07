-- Cria o banco de dados
CREATE DATABASE registros;
 
-- Usa o banco de dados criado
USE registros;
 
-- Cria a tabela de cadastro de clientes com o campo UF
CREATE TABLE clientes (
    Cliente INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    rg VARCHAR(9) NOT NULL UNIQUE,
    dataNascimento DATE NOT NULL,
    celular VARCHAR(15) NOT NULL,
    sexo CHAR(1) NOT NULL CHECK (sexo IN ('M', 'F', 'O')),
    uf_nascimento CHAR(2) NOT NULL  
);
 
show tables;
 
select * from clientes;