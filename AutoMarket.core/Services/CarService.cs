using AutoMarket.core.Contracts;
using AutoMarket.core.Models.Car;
using AutoMarket.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.core.Services
{
    public class CarService : ICarService
    {
        private readonly AutoMarketDbContext context;
        public CarService(AutoMarketDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<CarImageAndNameViewModel>> GetPicturesAsync()
        {

            return await context.Cars
                .OrderBy(c => c.Id)
                .Take(5)
                .Select(c => new CarImageAndNameViewModel()
                {
                    CarModel= c.Model,
                    ImageUrl = c.ImageUrl
                })
                .AsNoTracking()
                .ToListAsync();

        }
    }
}
