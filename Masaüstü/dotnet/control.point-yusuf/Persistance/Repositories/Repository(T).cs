using System.Linq.Expressions;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ITM_Server.Persistance.Repositories;

public class Repository<T> : IRepository<T> where T : class, new()
{
   private readonly ItmContext itmContext;

   public Repository(ItmContext itmContext)
   {
      this.itmContext = itmContext;
   }

   public async Task CreateAsync(T entity)
   {
      await this.itmContext.Set<T>().AddAsync(entity);
      await this.itmContext.SaveChangesAsync();
   }

   public async Task<List<T>> GetAllAsync()
   {
      return await this.itmContext.Set<T>().AsNoTracking().ToListAsync();
   }

   public async Task<T?> GetByIdAsync(object id)
   {
      return await this.itmContext.Set<T>().FindAsync(id);
   }

   public async Task UpdateAsync(T entity)
   {
      this.itmContext.Set<T>().Update(entity);
      await this.itmContext.SaveChangesAsync();
   }

   public async Task RemoveAsync(T entity)
   {
      this.itmContext.Set<T>().Remove(entity);
      await this.itmContext.SaveChangesAsync();
   }

   public async Task<T?> GetByFilterAsync(Expression<Func<T?,bool>> entity)
   {
      return await this.itmContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(entity);
   }
 

}
