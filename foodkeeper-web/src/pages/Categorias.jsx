import { useEffect, useState } from "react";
import { getCategorias } from "../services/api";

export default function Categorias() {
  const [categorias, setCategorias] = useState([]);

  useEffect(() => {
    fetchCategorias();
  }, []);

  const fetchCategorias = async () => setCategorias(await getCategorias());

  return (
    <div className="p-4">
      <h1 className="text-2xl font-bold mb-4">Categorias</h1>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
        {categorias.map(c => (
          <div key={c.id} className="border p-4 rounded shadow hover:bg-gray-100 transition cursor-pointer">
            <h2 className="text-xl font-semibold">{c.nome}</h2>
          </div>
        ))}
      </div>
    </div>
  );
}
