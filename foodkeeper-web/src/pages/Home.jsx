import React, { useState, useEffect } from "react";
import CategoriaCard from "../components/CategoriaCard";

export default function Home() {
  const [categorias, setCategorias] = useState([]);

  useEffect(() => {
    // Dados fictícios com emojis
    const data = [
      { id: 1, nome: "🍎 Frutas" },
      { id: 2, nome: "🥩 Carnes" },
      { id: 3, nome: "🥛 Laticínios" },
      { id: 4, nome: "🍞 Pães" },
      { id: 5, nome: "🥗 Verduras" },
      { id: 6, nome: "🍫 Snacks" },
    ];
    setCategorias(data);
  }, []);

  return (
    <div>
      <h1 className="mb-4">Categorias</h1>
      <div className="row g-3">
        {categorias.map((c) => (
          <div className="col-12 col-sm-6 col-md-4" key={c.id}>
            <CategoriaCard name={c.nome} onClick={() => alert(`Categoria: ${c.nome}`)} />
          </div>
        ))}
      </div>
    </div>
  );
}
