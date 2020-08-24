using BicyclesBLL.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicyclesBLL.Interfaces
{
    public interface IBicycleService
    {
        Task Add(AddBicycleView bicycle);
        Task Update(UpdateBicycleView bicycle);
        Task Delete(string id);
        Task<List<GetBicycleView>> GetAll();
    }
}
