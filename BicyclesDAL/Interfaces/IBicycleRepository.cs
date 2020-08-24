using BicyclesDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BicyclesDAL.Interfaces
{
    public interface IBicycleRepository
    {
        Task Create(Bicycle bicycle);
        Task Delete(string id);
        Task<List<Bicycle>> GetAll();
        Task Update(Bicycle bicycle);
    }
}
