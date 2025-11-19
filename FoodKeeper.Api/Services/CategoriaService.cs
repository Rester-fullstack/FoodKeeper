using AutoMapper;
using FoodKeeper.Api.Data;
using FoodKeeper.Api.Dtos;
using FoodKeeper.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodKeeper.Api.Services
{
    public class CategoriaService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoriaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CategoriaDto>> GetAllAsync()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return _mapper.Map<List<CategoriaDto>>(categorias);
        }

        public async Task<CategoriaDto?> GetByIdAsync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            return categoria == null ? null : _mapper.Map<CategoriaDto>(categoria);
        }

        public async Task<CategoriaDto> CreateAsync(CreateCategoriaDto dto)
        {
            var categoria = _mapper.Map<Categoria>(dto);

            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return _mapper.Map<CategoriaDto>(categoria);
        }

        public async Task<bool> UpdateAsync(int id, CreateCategoriaDto dto)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
                return false;

            categoria.Nome = dto.Nome;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria == null)
                return false;

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
