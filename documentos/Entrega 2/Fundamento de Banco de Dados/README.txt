-- Tabela: usuario
CREATE TABLE usuario (
    cd_usuario VARCHAR2(15) PRIMARY KEY,
    senha VARCHAR2(20),
    nome VARCHAR2(40),
    cadastro DATE,
    tipo_usuario VARCHAR2(20),
    email VARCHAR2(100),
    cd_ambientes VARCHAR2(15),
    cd_dashboard VARCHAR2(15)
);

-- Tabela: ambientes
CREATE TABLE ambientes (
    id_sensor VARCHAR2(15) PRIMARY KEY,
    consumo_energiaAtual DECIMAL(10,2),
    consumo_aguaAtual DECIMAL(10,2),
    comodo VARCHAR2(50),
    cd_ambientes VARCHAR2(15),
    FOREIGN KEY (cd_ambientes) REFERENCES usuario(cd_ambientes)