using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarManager.Data;
using Microsoft.EntityFrameworkCore;

namespace CarManager.Services
{
    public class CarService : ICarService
    {
        private readonly CarContext _context;

        public CarService( CarContext context )
        {
            _context = context;
        }

        public async Task<Car> CreateCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public async Task<string> DeleteCar(string id)
        {
            _context.Cars.Remove(_context.Cars.Single(car => car.Id == id));
            await _context.SaveChangesAsync();

            return "Car has been removed";
        }

        public async Task<Car> GetCar(string id)
        {
            var car = await _context.Cars.SingleOrDefaultAsync(c => c.Id == id);

            return car;
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<string> UpdateCar(string id, Car car)
        {
            car.Id = id;
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
            return "successfully update car";
        }

        public async Task<IEnumerable<Car>> SearchCar(string searchTerm)
        {
            var cars = await _context.Cars.Where(car =>
                car.Make.ToLower().Contains(searchTerm.ToLower())
                || car.Model.ToLower().Contains(searchTerm.ToLower())).ToListAsync();
            return cars;
        }
    }
}
