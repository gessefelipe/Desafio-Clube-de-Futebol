# Teste Técnico ASP.NET
<div align="center">
  Trata-se de uma aplicação web para um clube de futebol para o controle de atletas que permite incluir, alterar, deletar e listar atletas.

  ![](https://img.shields.io/badge/autor-Gess%C3%A9%20Felipe-brightgreen)
  ![](https://img.shields.io/badge/Linguagem-C%23-brightgreen)
</div>

## Pré-Requisitos

- **Visual Studio**
- **SQL Server** — Banco de dados relacional 
- **Git** — Para clonar o repositório
 
## Configuração do Ambiente

1. **Clonar o Repositório**

Clone este repositório usando `git clone https://github.com/gessefelipe/Desafio-Clube-de-Futebol.git`

2. **Abrir o Projeto**

Abra o Visual Studio e navegue até `File > Open > Project/Solution`.

Selecione o arquivo de solução (.sln) do projeto para abrir.

3. **Configurar o Banco de Dados**

- **SQL Server**:
- **Criar Banco de Dados**: Execute o script SQL fornecido (`script-banco.sql`) para criar o banco de dados, tabela tb_atletas e inserir dados de atletas para alimentação da tabela.

4. **Configuração do Banco de Dados no Projeto**

- No Visual Studio, abra o arquivo `Web.config` e ajuste a string de conexão para apontar para o seu servidor SQL Server e banco de dados recém-criado:

  ```xml
  <connectionStrings>
      <add name="DefaultConnection" connectionString="Data Source=data-soruce;Initial Catalog=Clube_Futebol;Persist Security Info=True;User ID=user_id;Password=password" providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```

5. **Build e Execução**

- Compile o projeto no Visual Studio para verificar se não há erros.

6. **Acesso à Aplicação**

- Após a compilação bem-sucedida, a aplicação estará acessível localmente através do navegador: `https://localhost:44359/`.

## CONTATOS
**LinkedIn**: [https://www.linkedin.com/in/gessefelipe](https://www.linkedin.com/in/gessefelipe/)  
**WhatsApp**: (11) 95679-9932
