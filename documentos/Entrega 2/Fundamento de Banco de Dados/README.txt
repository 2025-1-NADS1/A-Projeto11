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


-- Tabela: sensor
CREATE TABLE sensor (
    cd_sensor VARCHAR2(15) PRIMARY KEY,
    local VARCHAR2(50),
    valor_atual NUMBER(10,2),
    id VARCHAR2(15),
    ativo VARCHAR2(15),
    tipo VARCHAR2(20)
);

-- Tabela: dispositivos
CREATE TABLE dispositivos (
    cd_dispositivos VARCHAR2(15) PRIMARY KEY,
    status VARCHAR2(10),
    consumoEnergia_hora NUMBER(10,2),
    consumoAgua_hora NUMBER(10,2),
    tipo_dispositivo VARCHAR2(30)
);

-- Tabela: dashboard
CREATE TABLE dashboard (
    cd_dashboard VARCHAR2(15) PRIMARY KEY,
    descricao VARCHAR2(100),
    status VARCHAR2(20),
    layout VARCHAR2(20)
);