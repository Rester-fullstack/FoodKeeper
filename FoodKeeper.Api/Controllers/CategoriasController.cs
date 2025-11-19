using AutoMapper;
using FoodKeeper.Api.Data;
using FoodKeeper.Api.Dtos;
using FoodKeeper.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodKeeper.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoriasController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> GetAll()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<CategoriaDto>>(categorias));
        }

        // GET: api/categorias/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoriaDto>> GetById(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
                return NotFound(new { message = "Categoria não encontrada." });

            return Ok(_mapper.Map<CategoriaDto>(categoria));
        }

        // GET: api/categorias/{id}/produtos
        [HttpGet("{id:int}/produtos")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetProdutosPorCategoria(int id)
        {
            // Verifica se a categoria existe
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
            return NotFound(new { message = "Categoria não encontrada." });

            // Busca produtos dessa categoria
            var produtos = await _context.Produtos
            .Where(p => p.CategoriaId == id)
            .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProdutoDto>>(produtos));
        }


        // POST: api/categorias
        [HttpPost]
        public async Task<ActionResult<CategoriaDto>> Create(CreateCategoriaDto dto)
        {
            var categoria = _mapper.Map<Categoria>(dto);
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            var categoriaDto = _mapper.Map<CategoriaDto>(categoria);

            return CreatedAtAction(nameof(GetById), new { id = categoria.Id }, categoriaDto);
        }

        // PUT: api/categorias/{id}
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, CreateCategoriaDto dto)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
                return NotFound(new { message = "Categoria não encontrada." });

            _mapper.Map(dto, categoria);

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/categorias/{id}
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
                return NotFound(new { message = "Categoria não encontrada." });

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
