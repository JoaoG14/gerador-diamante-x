# Gerador de Diamante com X

## Introdução

O **Gerador de Diamante com X** é uma aplicação console desenvolvida em C# que permite ao usuário criar representações visuais de diamantes formados por caracteres "X". O programa aceita um número ímpar como entrada e gera um diamante com altura e largura máxima correspondentes a esse número.

## Funcionalidades

- **Interface de usuário amigável**: Menu interativo com instruções claras para o usuário.
- **Validação de entrada**: Aceita apenas números ímpares, garantindo que o diamante tenha uma forma simétrica.
- **Geração dinâmica**: Cria diamantes de qualquer tamanho ímpar conforme solicitado pelo usuário.
- **Opção de repetição**: Permite ao usuário gerar múltiplos diamantes em uma única execução do programa.
- **Código modular**: Implementação organizada em classes e métodos específicos, facilitando a manutenção e extensão.

## Como Funciona

O programa utiliza algoritmos para:

1. Calcular o número correto de espaços e caracteres 'X' para cada linha
2. Gerar a parte superior do diamante (incluindo a linha do meio)
3. Gerar a parte inferior do diamante
4. Exibir o resultado no console

## Estrutura do Código

O projeto está organizado em três classes principais:

- **Program.cs**: Contém o ponto de entrada do programa e o loop principal.
- **Menu.cs**: Responsável pela interface do usuário e validação de entrada.
- **GeradorDiamante.cs**: Implementa a lógica de geração do padrão de diamante.

## Exemplo de Execução

Aqui está um exemplo de como a aplicação funciona:

![Exemplo de execução do Gerador de Diamante com X](https://i.imgur.com/KxtQMJs.gif)

1. O programa exibe um cabeçalho introdutório
2. Solicita ao usuário que insira um número ímpar
3. Valida a entrada e gera o diamante correspondente
4. Pergunta se o usuário deseja gerar outro diamante
5. Repete o processo ou finaliza o programa conforme a escolha do usuário

## Requisitos

- .NET 5.0 ou superior
- Sistema operacional compatível com .NET (Windows, macOS, Linux)

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:

```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real

```
dotnet run --project JogoDosDados.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./JogoDosDados.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:

```
JogoDosDados.ConsoleApp.exe
```
