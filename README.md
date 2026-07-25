# 🍽️ FoodKeeper

Sistema Full Stack para gerenciamento de produtos alimentícios, desenvolvido com **ASP.NET Core Web API**, **React** e **SQL Server**.

O FoodKeeper permite controlar produtos, categorias, estoque e datas de validade, oferecendo uma interface moderna para gerenciamento de alimentos e acompanhamento de itens próximos ao vencimento ou com estoque reduzido.

---

## 🚀 Funcionalidades

### 📦 Gestão de Produtos

- Cadastro de produtos
- Edição de produtos
- Exclusão de produtos
- Listagem de produtos
- Busca por nome
- Organização por categorias

### 🏷️ Categorias

- Cadastro de categorias
- Associação de produtos às categorias

### 📉 Controle de Estoque

- Atualização de quantidade
- Produtos com estoque baixo
- Indicadores visuais

### ⏳ Controle de Validade

- Produtos próximos do vencimento
- Produtos vencidos
- Alertas visuais

### 🎨 Interface

- Layout responsivo
- Navegação intuitiva
- Feedback visual
- Notificações

---

# 🛠️ Tecnologias Utilizadas

## Backend

- C#
- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI

## Frontend

- React 18
- Vite
- Tailwind CSS
- Bootstrap 5
- Axios
- React Toastify

---

# 🏗️ Arquitetura

```text
React + Vite
      │
      ▼
Axios
      │
      ▼
ASP.NET Core Web API
      │
      ▼
Entity Framework Core
      │
      ▼
SQL Server
```

---

# 📂 Estrutura do Projeto

```text
FoodKeeper
│
├── FoodKeeper.Api
│   ├── Controllers
│   ├── Data
│   ├── DTOs
│   ├── Models
│   ├── Program.cs
│   └── appsettings.json
│
├── foodkeeper-web
│   ├── src
│   │   ├── assets
│   │   ├── components
│   │   ├── pages
│   │   ├── services
│   │   └── App.jsx
│   │
│   ├── package.json
│   └── vite.config.js
│
└── README.md
```

---

# ▶️ Como executar

## Clone o repositório

```bash
git clone https://github.com/Rester-fullstack/FoodKeeper.git
```

Entre na pasta

```bash
cd FoodKeeper
```

---

## Backend

Entre na API

```bash
cd FoodKeeper.Api
```

Restaure os pacotes

```bash
dotnet restore
```

Compile

```bash
dotnet build
```

Configure a conexão com o SQL Server no arquivo:

```
appsettings.json
```

Execute

```bash
dotnet run
```

A API ficará disponível juntamente com a documentação Swagger.

---

## Frontend

Entre na pasta

```bash
cd foodkeeper-web
```

Instale as dependências

```bash
npm install
```

Execute

```bash
npm run dev
```

---

# 📸 Screenshots

Adicione imagens da aplicação, por exemplo:

```text
Home

Produtos

Categorias

Cadastro

Estoque Baixo

Produtos Vencidos
```

---

# 📚 Objetivos do Projeto

Este projeto foi desenvolvido para praticar:

- Desenvolvimento Full Stack
- ASP.NET Core Web API
- React
- Entity Framework Core
- SQL Server
- Consumo de APIs REST
- CRUD completo
- Organização em camadas
- Integração entre frontend e backend

---

# 🔮 Melhorias Futuras

- Autenticação completa com JWT
- Dashboard administrativo
- Relatórios em PDF
- Exportação para Excel
- Upload de imagens dos produtos
- Docker
- Deploy em nuvem
- Testes automatizados

---

# 👩‍💻 Desenvolvedora

**Ester da Costa Batista**

Desenvolvedora Full Stack

### Tecnologias

- C#
- .NET
- ASP.NET Core
- React
- SQL Server
- Entity Framework Core
- JavaScript
- HTML
- CSS

GitHub:

https://github.com/Rester-fullstack

LinkedIn:

https://www.linkedin.com/in/ester-da-costa-batista-929500295

---

# 📄 Licença

Projeto desenvolvido para fins de estudo e portfólio.
