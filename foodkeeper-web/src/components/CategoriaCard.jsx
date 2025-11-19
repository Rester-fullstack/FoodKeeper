import React from "react";

export default function CategoriaCard({ name, onClick }) {
  return (
    <div className="card text-center shadow-sm" style={{ cursor: "pointer" }} onClick={onClick}>
      <div className="card-body">
        <h5 className="card-title">{name}</h5>
      </div>
    </div>
  );
}
