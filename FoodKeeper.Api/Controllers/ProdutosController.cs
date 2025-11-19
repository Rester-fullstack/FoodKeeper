using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using FoodKeeper.Api.Data;
using FoodKeeper.Api.Models;
using FoodKeeper.Api.Dtos;

namespace FoodKeeper.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProdutosController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetAll()
        {
            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }

        // GET: api/produtos/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoDto>> GetById(int id)
        {
            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (produto == null)
                return NotFound(new { message = "Produto não encontrado." });

            return Ok(_mapper.Map<ProdutoDto>(produto));
        }

        // POST: api/produtos
        [HttpPost]
        public async Task<ActionResult<ProdutoDto>> Create(CreateProdutoDto dto)
        {
            // Valida categoria
            var categoria = await _context.Categorias.FindAsync(dto.CategoriaId);
            if (categoria == null)
                return BadRequest(new { message = "Categoria inválida." });

            var produto = _mapper.Map<Produto>(dto);

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            // Inclui categoria para DTO
            await _context.Entry(produto).Reference(p => p.Categoria).LoadAsync();

            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produtoDto);
        }

        // PUT: api/produtos/{id}
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, CreateProdutoDto dto)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
                return NotFound(new { message = "Produto não encontrado." });

            // Valida categoria
            var categoria = await _context.Categorias.FindAsync(dto.CategoriaId);
            if (categoria == null)
                return BadRequest(new { message = "Categoria inválida." });

            _mapper.Map(dto, produto);

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/produtos/{id}
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
                return NotFound(new { message = "Produto não encontrado." });

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // GET: api/produtos/categoria/{categoriaId}
        [HttpGet("categoria/{categoriaId:int}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetByCategoria(int categoriaId)
        {
            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.CategoriaId == categoriaId)
                .OrderBy(p => p.Nome)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }

        // GET: api/produtos/vencidos
        [HttpGet("vencidos")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetVencidos()
        {
            var hoje = DateTime.Today;

            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.DataValidade < hoje)
                .OrderBy(p => p.DataValidade)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }

        // GET: api/produtos/validade/proximos
        [HttpGet("validade/proximos")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetProximosAVencer()
        {
            var hoje = DateTime.Today;
            var limite = hoje.AddDays(30);

            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.DataValidade >= hoje && p.DataValidade <= limite)
                .OrderBy(p => p.DataValidade)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }

        // GET: api/produtos/estoque/baixo
        [HttpGet("estoque/baixo")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetEstoqueBaixo([FromQuery] int limite = 5)
        {
            var produtos = await _context.Produtos
                .Include(p => p.Categoria)
                .Where(p => p.Quantidade <= limite)
                .OrderBy(p => p.Quantidade)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }
    }
}
