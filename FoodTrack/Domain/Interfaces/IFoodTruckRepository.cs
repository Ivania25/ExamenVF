using FoodTrack.Domain.Entities;
namespace FoodTrack.Domain.Interfaces;
public interface IFoodTruckRepository{FoodTruck? GetById(int id); IEnumerable<FoodTruck> GetAll(); void Add(FoodTruck ft);}