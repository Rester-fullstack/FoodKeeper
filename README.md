# 🍽️ FoodKeeper

Um sistema completo para gerenciamento de produtos alimentícios, permitindo acompanhar categorias, produtos, validade e estoque.  

---

## 🚀 Tecnologias Utilizadas

### Backend (FoodKeeper.Api)
- 🟣 **.NET 8 / ASP.NET Core**
- 🟢 **Entity Framework Core**
- 🟡 **SQL Server**
- 🔑 **JWT Autenticação (se aplicável)**  
- 📄 **Swagger para documentação de API**

### Frontend (foodkeeper-web)
- ⚛️ **React 18**
- 💨 **Vite**
- 🎨 **Bootstrap 5**
- 🖌️ **Tailwind CSS** (para estilos adicionais)
- 📦 **React Toastify** (notificações)
- 🔗 **Axios / Fetch API** (consumo de API)

---

## 🗂 Estrutura do Projeto

FoodKeeper/
├── README.md
├── FoodKeeper.Api/ # Backend (.NET)
│ ├── Controllers/
│ ├── Data/
│ ├── Dtos/
│ ├── Models/
│ └── Program.cs
└── foodkeeper-web/ # Frontend (React)
├── src/
│ ├── components/ # Navbar, CategoriaCard, ProdutoCard
│ ├── pages/ # Home, Produtos, ProdutosVencidos, ProdutosEstoqueBaixo
│ └── services/ # API fetch functions
└── package.json

💡 Funcionalidades
📦 Listagem de produtos

🗂 Filtragem por categoria

⏳ Produtos próximos da validade

❌ Produtos vencidos

📉 Produtos com estoque baixo

💬 Alertas e notificações no frontend

🎨 Visual
O frontend utiliza Bootstrap + Tailwind CSS, garantindo:

Layout responsivo (mobile-first)

Cards modernos para categorias e produtos

Navbar fixa e intuitiva

Botões e interações com hover e feedback visual

🧩 Como Contribuir
Fork o repositório

Crie uma branch: git checkout -b feature/nova-funcionalidade

Faça commits: git commit -m "Descrição da mudança"

Envie para o repositório remoto: git push origin feature/nova-funcionalidade

Abra um Pull Request

📄 Licença
MIT License © 2025

