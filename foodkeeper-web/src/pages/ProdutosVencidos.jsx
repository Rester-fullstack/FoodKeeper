import React, { useEffect, useState } from "react";
import ProdutoCard from "../components/ProdutoCard";

export default function ProdutosVencidos() {
  const [produtos, setProdutos] = useState([]);

  useEffect(() => {
    const data = [
      { id: 1, nome: "🥛 Leite", quantidade: 2, dataValidade: "2025-10-01", categoriaNome: "Laticínios" },
      { id: 2, nome: "🍞 Pão Francês", quantidade: 5, dataValidade: "2025-11-15", categoriaNome: "Pães" },
    ];
    setProdutos(data);
  }, []);

  return (
    <div>
      <h1 className="mb-4 text-danger">Produtos Vencidos ⚠️</h1>
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
