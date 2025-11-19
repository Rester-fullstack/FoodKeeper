import React from "react";

export default function ProdutoCard({ produto }) {
  return (
    <div className="card shadow-sm">
      <div className="card-body">
        <h5 className="card-title">{produto.nome}</h5>
        <p className="card-text">Quantidade: {produto.quantidade}</p>
        <p className="card-text">Validade: {new Date(produto.dataValidade).toLocaleDateString()}</p>
        <p className="card-text">Categoria: {produto.categoriaNome}</p>
      </div>
    </div>
  );
}
