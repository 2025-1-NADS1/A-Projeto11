# Sistema de Monitoramento de Ambiente com TCP

Este projeto consiste em uma aplicação cliente-servidor que implementa um sistema de monitoramento de ambiente utilizando comunicação TCP. O sistema é composto por dois componentes principais: um servidor TCP e uma interface gráfica cliente.

## Componentes do Sistema

### 1. Servidor TCP (EXEMPLO_02_SERVER)
O servidor é responsável por:
- Escutar conexões TCP na porta 30000
- Processar comandos recebidos dos clientes
- Responder com informações sobre data, hora e configurações de horário de verão

Comandos suportados pelo servidor:
- `GET TIME` - Retorna a hora atual
- `GET TIME LONDON` - Retorna a hora atual em Londres (UTC+4)
- `GET DATE` - Retorna a data atual
- `SET SUMMERTIME TRUE/FALSE` - Configura o horário de verão

### 2. Cliente com Interface Gráfica (FormsCliente)
O cliente é uma aplicação Windows Forms que permite:
- Monitorar diferentes cômodos de uma residência
- Visualizar status de ar-condicionado
- Monitorar sensores de movimento
- Interface amigável com combobox para seleção de cômodos

Cômodos monitorados:
- Sala
- Cozinha
- Quarto de casal
- Quarto das crianças

## Requisitos do Sistema
- .NET Framework
- Windows OS
- Visual Studio (para desenvolvimento)

## Como Executar

1. Inicie o servidor TCP (EXEMPLO_02_SERVER)
2. Execute a aplicação cliente (FormsCliente)
3. Selecione um cômodo no combobox
4. Clique em "Enviar" para visualizar as informações do ambiente

## Funcionalidades

### Servidor
- Comunicação TCP bidirecional
- Suporte a múltiplas conexões simultâneas
- Processamento de comandos em tempo real
- Configuração de horário de verão

### Cliente
- Interface gráfica intuitiva
- Monitoramento em tempo real
- Visualização de status por cômodo
- Registro de horário das operações
- Botão para limpar histórico

## Arquitetura
O projeto utiliza uma arquitetura cliente-servidor com:
- Comunicação TCP/IP
- Threads para processamento paralelo
- Interface gráfica Windows Forms
- Sistema de logging para registro de eventos

## Observações
- O servidor deve estar em execução antes de iniciar o cliente
- As conexões são estabelecidas no localhost (127.0.0.1)
- O sistema suporta múltiplos clientes simultaneamente 