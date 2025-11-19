import React, { useEffect, useState } from "react";
import ProdutoCard from "../components/ProdutoCard";

export default function Produtos() {
  const [produtos, setProdutos] = useState([]);

  useEffect(() => {
    const data = [
      { id: 1, nome: "🍎 Maçã", quantidade: 20, dataValidade: "2025-12-01", categoriaNome: "Frutas" },
      { id: 2, nome: "🥛 Leite", quantidade: 15, dataValidade: "2025-11-25", categoriaNome: "Laticínios" },
      { id: 3, nome: "🥩 Carne Bovina", quantidade: 5, dataValidade: "2025-11-20", categoriaNome: "Carnes" },
      { id: 4, nome: "🍞 Pão Francês", quantidade: 50, dataValidade: "2025-11-19", categoriaNome: "Pães" },
      { id: 5, nome: "🥗 Alface", quantidade: 10, dataValidade: "2025-11-18", categoriaNome: "Verduras" },
    ];
    setProdutos(data);
  }, []);

  return (
    <div>
      <h1 className="mb-4">Todos os Produtos</h1>
      <div className="row g-3">
        {produtos.map((p) => (
          <div className="col-12 col-sm-6 col-md-4" key={p.id}>
            <ProdutoCard produto={p} />
          </div>
        ))}
      </div>
    </div>
  );
}
