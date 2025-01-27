using Domain.Common;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICarRepository : IRepository<CarModel>
    {
        Task<IEnumerable<CarModel>> GetCarByModelAsync(string model);
    }
}
