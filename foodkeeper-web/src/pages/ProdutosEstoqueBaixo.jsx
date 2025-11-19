import React, { useEffect, useState } from "react";
import ProdutoCard from "../components/ProdutoCard";

export default function ProdutosEstoqueBaixo() {
  const [produtos, setProdutos] = useState([]);

  useEffect(() => {
    const data = [
      { id: 1, nome: "🥩 Carne Bovina", quantidade: 3, dataValidade: "2025-11-20", categoriaNome: "Carnes" },
      { id: 2, nome: "🥗 Alface", quantidade: 2, dataValidade: "2025-11-18", categoriaNome: "Verduras" },
      { id: 3, nome: "🍫 Chocolate", quantidade: 1, dataValidade: "2026-02-01", categoriaNome: "Snacks" },
    ];
    setProdutos(data);
  }, []);

  return (
    <div>
      <h1 className="mb-4 text-warning">Estoque Baixo ⚠️</h1>
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
