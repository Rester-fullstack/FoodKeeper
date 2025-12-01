# 🍽️ FoodKeeper — Sistema de Gerenciamento de Produtos Alimentícios

O **FoodKeeper** é um sistema completo desenvolvido para controlar produtos alimentícios, permitindo gerenciar **categorias**, **produtos**, **estoque**, **validade** e acompanhar alertas importantes como produtos prestes a vencer ou com quantidade baixa.

Este projeto foi construído como uma aplicação **Full Stack** com **.NET 8** no backend e **React 18** no frontend.

---

## 🚀 Tecnologias Utilizadas

### 🔧 **Backend — FoodKeeper.Api (.NET 8)**
- 🟣 **ASP.NET Core 8**
- 🟢 **Entity Framework Core**
- 🟡 **SQL Server**
- 🔑 **JWT Authentication** *(se habilitado)*
- 📄 **Swagger / OpenAPI** para documentação da API

### 🎨 **Frontend — foodkeeper-web (React + Vite)**
- ⚛️ **React 18**
- ⚡ **Vite**
- 💨 **Tailwind CSS**
- 🎨 **Bootstrap 5**
- 🔗 **Axios** para consumo da API
- 🔔 **React Toastify** para notificações

---

## 📦 Funcionalidades Principais

### 🛒 **Gestão de Produtos**
- Cadastro, edição e remoção de produtos  
- Listagem de produtos com busca e filtros  
- Organização por categorias  

### ⏳ **Validades**
- Produtos próximos do vencimento  
- Lista de produtos vencidos  
- Alerta visual + notificações no frontend  

### 📉 **Estoque**
- Produtos com estoque baixo  
- Indicadores visuais para níveis críticos  
- Atualização de quantidade  

### 💬 **Interface Moderna**
- Layout responsivo (mobile-first)  
- Navbar fixa e intuitiva  
- Cards estilizados  
- Feedback visual com hover e alertas  

---

## 🗂 Estrutura do Projeto

FoodKeeper/
│
├── README.md
│
├── FoodKeeper.Api/ # Backend (.NET 8)
│ ├── Controllers/
│ ├── Data/
│ ├── Dtos/
│ ├── Models/
│ └── Program.cs
│
└── foodkeeper-web/ # Frontend (React + Vite)
├── src/
│ ├── components/ # Navbar, CategoriaCard, ProdutoCard
│ ├── pages/ # Home, Produtos, Vencidos, EstoqueBaixo
│ └── services/ # API Requests
└── package.json

---

## ▶️ Como Executar o Projeto

### **1. Backend (.NET 8)**

cd FoodKeeper.Api
dotnet restore
dotnet build
dotnet run
Crie a base de dados no SQL Server e configure o appsettings.json.

2. Frontend (React + Vite)

Copiar código
cd foodkeeper-web
npm install
npm run dev
📌 Status do Projeto
✔️ Em desenvolvimento (versão inicial pronta)
🚀 Planejada futura expansão com relatórios e dashboard

📄 Licença
MIT License © 2025 — Este projeto é open-source.

👩‍💻 Autora
Ester da Costa Batista
📍 Aracaju - SE, Brasil
📧 ester.retse30@gmail.com
🔗 LinkedIn: https://www.linkedin.com/in/ester-da-costa-batista-929500295
