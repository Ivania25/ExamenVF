using FoodTrack.Domain.Entities;
namespace FoodTrack.Domain.Interfaces;
public interface IOrderRepository{Order? GetById(int id); IEnumerable<Order> GetByFoodTruck(int ft); void Add(Order o); void Update(Order o);}