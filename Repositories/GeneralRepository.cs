﻿using MiniProject_MCC75.Repositories.Interface;
using MiniProject_MCC75.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MiniProject_MCC75.Repositories;

public class GeneralRepository<key, Entity> : IRepository<key, Entity>
    where Entity : class
{
    private readonly MyContext context;

    public GeneralRepository(MyContext context)
    {
        this.context = context;
    }
    public async Task<int> Delete(key key)
    {
        var entity = await GetById(key);
        if (entity == null)
        {
            return 0;
        }
        context.Set<Entity>().Remove(entity);
        return await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Entity>> GetAll()
    {
        return await context.Set<Entity>().ToListAsync();//tanya await
    }

    public async Task<Entity?> GetById(key? key)
    {
        if (key == null)
        {
            return null;
        }
        return await context.Set<Entity>().FindAsync(key);
    }

    public async Task<int> Insert(Entity entity)
    {
        await context.Set<Entity>().AddAsync(entity);
        return await context.SaveChangesAsync();
    }

    public async Task<int> Update(Entity entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        return await context.SaveChangesAsync();
    }
}
