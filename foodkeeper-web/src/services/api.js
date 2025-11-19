const BASE_URL = "http://localhost:5184/api"; // ajuste se necessário

export async function getProdutos() {
  const res = await fetch(`${BASE_URL}/produtos`);
  return res.json();
}

export async function getProdutosByCategoria(categoriaId) {
  const res = await fetch(`${BASE_URL}/produtos/categoria/${categoriaId}`);
  return res.json();
}

export async function getProdutosVencidos() {
  const res = await fetch(`${BASE_URL}/produtos/vencidos`);
  return res.json();
}

export async function getProdutosProximosAVencer() {
  const res = await fetch(`${BASE_URL}/produtos/validade/proximos`);
  return res.json();
}

export async function getProdutosEstoqueBaixo(limite = 5) {
  const res = await fetch(`${BASE_URL}/produtos/estoque/baixo?limite=${limite}`);
  return res.json();
}

export async function getCategorias() {
  const res = await fetch(`${BASE_URL}/categorias`);
  return res.json();
}
