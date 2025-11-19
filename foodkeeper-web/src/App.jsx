import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import Home from "./pages/Home";
import Produtos from "./pages/Produtos";
import ProdutosVencidos from "./pages/ProdutosVencidos";
import ProdutosEstoqueBaixo from "./pages/ProdutosEstoqueBaixo";

export default function App() {
  return (
    <BrowserRouter>
      <Navbar />
      <div className="container mt-4">
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/produtos" element={<Produtos />} />
          <Route path="/vencidos" element={<ProdutosVencidos />} />
          <Route path="/estoque-baixo" element={<ProdutosEstoqueBaixo />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}
