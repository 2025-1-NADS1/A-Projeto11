# Documentação dos Testes de Comunicação TCP

## Visão Geral
Este projeto implementa testes de comunicação TCP cliente-servidor para verificar a conectividade de rede e a funcionalidade de troca de dados.

## Implementação do Cliente
A aplicação cliente realiza dois testes principais:

### Teste 1: Conexão Básica
- Tenta estabelecer uma conexão TCP com o servidor
- Configuração do Servidor:
  - IP: 127.0.0.1 (localhost)
  - Porta: 80

### Teste 2: Troca de Dados
- Envia uma mensagem de teste para o servidor
- Aguarda resposta do servidor
- Implementa mecanismo de tentativas (5 tentativas)
- Tempo de espera entre tentativas: 100ms

## Detalhes Técnicos
- Utiliza `TcpClient` para comunicação de rede
- Implementa tratamento adequado de conexão e gerenciamento de erros
- Codificação de caracteres: UTF8
- Manipulação de fluxo de rede para transmissão de dados

## Tratamento de Erros
A implementação inclui tratamento para:
- Exceções de Socket (problemas de conexão)
- Exceções gerais
- Cenários de timeout
- Respostas vazias do servidor

## Como Usar
1. Inicie primeiro a aplicação servidor
2. Execute a aplicação cliente
3. Monitore a saída do console para ver os resultados dos testes

## Dependências
- .NET Framework
- System.Net.Sockets
- System.Text
- System.Threading