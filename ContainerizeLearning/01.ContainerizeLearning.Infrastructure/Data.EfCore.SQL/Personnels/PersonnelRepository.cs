using ContainerizeLearning.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContainerizeLearning.Infrastructure.Data.EfCore.SQL
{
public class PersonnelRepository : IPersonnelRepository
{
    private readonly HRDbContext _context;

    public PersonnelRepository(HRDbContext context)
    {
        this._context = context;
    }

        public async Task Add(Personnel personnel, CancellationToken cancellationToken = default) 
        {
            await _context.Personnels.AddAsync(personnel, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Personnel> Get(int id, CancellationToken cancellationToken = default) 
        {
            var personnel = await _context.Personnels.FirstOrDefaultAsync(c=> c.Id == id);
            return personnel;
        }

        public async Task Update(Personnel personnel, CancellationToken cancellationToken = default)
        {
            _context.Update(personnel);
             await _context.SaveChangesAsync(cancellationToken);
        }
    }
}