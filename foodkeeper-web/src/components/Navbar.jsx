import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { getProdutosVencidos, getProdutosEstoqueBaixo } from "../services/api";

export default function Navbar() {
  const [vencidos, setVencidos] = useState(0);
  const [estoqueBaixo, setEstoqueBaixo] = useState(0);

  useEffect(() => {
    async function fetchData() {
      const produtosVencidos = await getProdutosVencidos();
      const produtosBaixo = await getProdutosEstoqueBaixo();
      setVencidos(produtosVencidos.length);
      setEstoqueBaixo(produtosBaixo.length);
    }
    fetchData();
  }, []);

  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark mb-4">
      <div className="container">
        <Link className="navbar-brand" to="/">FoodKeeper 🍎</Link>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>

        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav ms-auto">
            <li className="nav-item">
              <Link className="nav-link" to="/">Home 🏠</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/produtos">Produtos 📦</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/vencidos">
                Vencidos ⚠️ 
                {vencidos > 0 && (
                  <span className="badge bg-danger ms-1">{vencidos}</span>
                )}
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/estoque-baixo">
                Estoque Baixo ⚠️
                {estoqueBaixo > 0 && (
                  <span className="badge bg-warning text-dark ms-1">{estoqueBaixo}</span>
                )}
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
}
