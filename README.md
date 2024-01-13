# MisPeliculas <img src="https://github.com/helenacota/EP3BD1/blob/master/Imagens/pipocaLogo.png" alt="Logo do Sistema" width="40"/>

## Descrição do Projeto

Este projeto consiste em um sistema que utiliza SQL para cgerenciamento de prêmios para filmes e atores. Dessa forma, foi desenvolvido uma aplicação que oferece funcionalidades relacionadas a cadastros de pessoas, eventos, prêmios, nomeações, premiações e filmes, com gráficos e informações sintetizadas para o cumprimento do trabalho. Para este projeto, utilizamos o PostgreSQL como SGBD e o Visual Studio Comumnity 2022 junto com .NET framework e, por fim, a linguagem utilizada foi o C# em um esquema de Windows Form Application. 

## Funcionalidades da Aplicação (Separadas em abas)

1. **Aba de 'Cadastro':** 
    - Funcionalidade para cadastrar pessoas.
        - [X] Permite cadastrar uma pessoa.
        - [X] Visualização em uma DataGridView dos atributos de todas as pessoas cadastradas no sistema.
   
    - Funcionalidade para cadastrar filmes.
      - [X] Permite cadastrar um filme.
      - [X] Visualização em uma DataGridView dos filmes cadastrados.
      - [X] Botão para abrir uma nova tela para adição de uma nova função a um filme.
        - [X] Nessa tela, é possível verificar todas as funções de um filme.
        - [X] Ao lado, são exibidos o ID de todos os filmes e seus títulos.

    - Funcionalidade para cadastrar eventos.
      - [X] Permite cadastrar eventos.
      - [X] Botão para adicionar uma nova edição.
        - [X] Na nova página, é possível registrar todas as edições.
        - [X] Também é possível cadastrar jurados para uma edição específica.

    - Funcionalidade para cadastrar prêmios.
      - [X] Permite cadastrar prêmios.
      - [X] Em prêmios, é possível verificar em uma DataGridView todos os prêmios de uma dada edição de um evento específico.

    - Funcionalidade para cadastrar nomeações.
    - Funcionalidade para cadastrar premiações.
   

2. **Aba de 'Estatísticas':**
    - [X] Gera um gráfico, histograma, dos dez atores (atrizes) com maior número de prêmios.
    - [X] Gera um gráfico, histograma, dos 10 filmes mais premiados.
    - [X] Gera um gráfico, histograma, dos 10 filmes com maior arrecadação.

3. **Aba de 'Informações':**
    - [X] Lista os atores e atrizes nominados como melhor ator em todos os eventos existentes.
    - [X] Dado um prêmio, indicar quais foram os autores ou filmes nominados e premiados.
   
## Sobre o SQL e Como Rodar

Os scripts relacionados ao banco de dados PostgreSQL estão localizados na pasta `PgSQL`. Dentro dessa pasta, você encontrará tanto o script de geração do banco de dados quanto um exemplo de script para popular algumas tabelas.

### Scripts na Pasta PgSQL

- **Script de Geração do Banco de Dados:**
  - Este script é responsável por criar as tabelas necessárias para o funcionamento do programa.

- **Script de População de Tabelas (Exemplo):**
  - Este script oferece exemplos de dados para popular algumas tabelas do banco de dados.

### Rodando o Programa

Para rodar o programa, é necessário seguir alguns passos obrigatórios (a não realização correta desses passos resultará em erros):

1. **Criar um Banco de Dados:**
   - Utilize um cliente de administração do PostgreSQL. Sugerimos o pgAdmin e, após isso, crie um banco de dados chamado `MisPeliculas`.

2. **Configurar Atributos de Conexão:**
   - Antes de rodar o script de geração, certifique-se de configurar os atributos de conexão. Eles devem incluir:
     - **Server:** O endereço do servidor: `localhost`.
     - **Port:** O número da porta: `5432`.
     - **Database:** O nome do banco de dados criado anteriormente:`MisPeliculas`.
     - **User Id:** O usuário do PostgreSQL: `postgres`.
     - **Password:** A senha associada ao usuário: `admin`.

   Certifique-se de seguir de forma correta esses passos. Caso não sejam seguidos ou já possua alguma pré-configuração torna-se necessário alterar a linha de conexão no próprio código localizado na pasta `Arquitetura`. Dentro dessa pasta, encontra-se a classe `DbConnection` e a `String` de Conexão. Os dados passados correspondem a linha que já está lá, ou seja:
```
Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=MisPeliculas;User Id=postgres;Password=admin;");
```  
Observação: Se for necessário alterar a string do banco de dados, torna-se também necessário a recompilação. Portanto, deve-se baixar o Visual Studio 2022. Caso siga os passos corretamente, não é necessário alterar nada e, ou seja, basta rodar o script e executar o exe (localizado em bin>release).

4. **Rodar o Script de Geração:**
   - Execute o script de geração do banco de dados no banco criado. Isso criará as tabelas necessárias para o funcionamento do programa.

Após seguir esses passos, o programa estará configurado e pronto para ser executado com o banco de dados PostgreSQL.
