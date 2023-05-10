using BikeService.Models;

namespace BikeService.Service;

public interface IBikeService
{
    HashSet<Bike> GetAllBikes();
    Bike GetBikeById(int id);
    void CreateBike(Bike bike);
    void UpdateBike(Bike bike);
    void DeleteBike(int id);
}