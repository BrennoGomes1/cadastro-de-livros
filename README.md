#  Sistema de Cadastro de Livros

Sistema web de cadastro de livros desenvolvido com **ASP.NET Core MVC**, **Entity Framework Core** e **PostgreSQL**.

##  Tecnologias Utilizadas

- [.NET 10.0](https://dotnet.microsoft.com/)
- [ASP.NET Core MVC](https://docs.microsoft.com/aspnet/core/mvc)
- [Entity Framework Core 10.0.8](https://docs.microsoft.com/ef/core/)
- [Npgsql.EntityFrameworkCore.PostgreSQL 10.0.1](https://www.npgsql.org/)
- [Bootstrap 5](https://getbootstrap.com/)

##  Funcionalidades

- Listar todos os livros cadastrados
- Cadastrar novo livro
- Editar livro existente
- Excluir livro

##  Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou superior
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL 18](https://www.postgresql.org/download/)

##  Como Rodar o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/BrennoGomes1/cadastro-de-livros.git
cd cadastro-de-livros
```

### 2. Configure o banco de dados

Crie um arquivo `appsettings.Development.json` na raiz do projeto com suas credenciais do PostgreSQL:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=cadastro_livros;Username=postgres;Password=SUA_SENHA"
  }
}
```

>  Este arquivo não vai para o GitHub. Nunca compartilhe sua senha!

### 3. Aplique as Migrations

No **Console do Gerenciador de Pacotes** do Visual Studio:

```powershell
Update-Database
```

### 4. Rode o projeto

Pressione **F5** no Visual Studio.

Acesse: `https://localhost:7020`

## 🗄️ Estrutura do Banco de Dados

**Tabela: `Livros`**

| Coluna         | Tipo      | Descrição              |
|----------------|-----------|------------------------|
| Id             | integer   | Chave primária         |
| Titulo         | text      | Título do livro        |
| Autor          | text      | Nome do autor          |
| AnoPublicacao  | integer   | Ano de publicação      |
| Genero         | text      | Gênero literário       |
| Preco          | numeric   | Preço do livro         |

##  Estrutura do Projeto

```
Cadastro de livros/
├── Controllers/
│   └── LivrosController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   └── Livro.cs
├── Views/
│   └── Livros/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
├── appsettings.json
└── Program.cs
```

##  Segurança

O arquivo `appsettings.Development.json` contém as credenciais do banco e **não deve ser enviado ao GitHub**. Certifique-se de que ele está no `.gitignore`:

```
appsettings.Development.json
```

##  Autor

Desenvolvido por **Brenno Gomes**

---

⭐ Se gostou do projeto, deixe uma estrela no repositório!
