using System.Collections.Generic;
using System.Threading.Tasks;
using CarManager.Data;

namespace CarManager.Services
{
    public interface ICarService
    {
        Task<Car> CreateCar(Car car);
        Task<string> UpdateCar(string id, Car car);
        Task<string> DeleteCar(string id);
        Task<Car> GetCar(string id);
        Task<IEnumerable<Car>> GetCars();
        Task<IEnumerable<Car>> SearchCar(string searchTerm);
    }
}
