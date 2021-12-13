using PS.Template.Domain.Commands;
using PS.Template.Domain.Entities;
using System.Threading.Tasks;

namespace PS.Template.AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly TemplateDbContext _context;
        public GenericsRepository(TemplateDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remove<T>(T entity) where T : class
        {
            _context.Remove<T>(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update<T>(T entity) where T : class
        {
            _context.Update<T>(entity);
            await _context.SaveChangesAsync();
        }

    }
}
