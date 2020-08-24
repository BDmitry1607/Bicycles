using BicyclesDAL.Entities;
using BicyclesDAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicyclesDAL.Repositories
{
    public class BicycleRepository : IBicycleRepository
    {
        private readonly StoreContext _context;
        public BicycleRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task Create(Bicycle bicycle)
        {
            await _context.Bicycles.AddAsync(bicycle);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            Bicycle bicycle = await _context.Bicycles.FindAsync(id);
            if(bicycle != null)
            {
                _context.Bicycles.Attach(bicycle);
                _context.Bicycles.Remove(bicycle);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Bicycle>> GetAll()
        {
            return await _context.Bicycles.ToListAsync();
        }

        public async Task Update(Bicycle bicycle)
        {
                _context.Entry(bicycle).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
        }
    }
}
