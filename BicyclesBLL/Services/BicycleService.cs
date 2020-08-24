using BicyclesBLL.Interfaces;
using BicyclesBLL.Views;
using BicyclesDAL.Entities;
using BicyclesDAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace BicyclesBLL.Services
{
    public class BicycleService : IBicycleService
    {
        private readonly IBicycleRepository _bicycleRepository;
        public BicycleService(IBicycleRepository bicycleRepository)
        {
            _bicycleRepository = bicycleRepository;
        }
        public async Task Add(AddBicycleView bicycle)
        {
            var bike = new Bicycle
            {
                Name = bicycle.Name,
                Type = bicycle.Type,
                Price = bicycle.Price,
                Rented = false
            };
            await _bicycleRepository.Create(bike);
        }

        public async Task Delete(string id)
        {
            await _bicycleRepository.Delete(id);
        }

        public async Task<List<GetBicycleView>> GetAll()
        {
            var bikes = await _bicycleRepository.GetAll();
            var result = bikes.Select(bike => new GetBicycleView()
            {
                Id = bike.Id,
                Name = bike.Name,
                Type = bike.Type,
                Price = bike.Price,
                Rented = bike.Rented
            }).ToList();
            return result;
        }

        public async Task Update(UpdateBicycleView bicycleView)
        {
            Bicycle bicycle = new Bicycle
            {
                Id = bicycleView.Id,
                Name = bicycleView.Name,
                Type = bicycleView.Type,
                Price = bicycleView.Price,
                Rented = bicycleView.Rented
            };
            await _bicycleRepository.Update(bicycle);
        }
    }
}
