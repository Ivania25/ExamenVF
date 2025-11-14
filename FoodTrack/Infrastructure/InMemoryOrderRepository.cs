using FoodTrack.Domain.Entities;
using FoodTrack.Domain.Interfaces;
namespace FoodTrack.Infrastructure;
public class InMemoryOrderRepository:IOrderRepository{private readonly List<Order> _orders=new(); public void Add(Order o)=>_orders.Add(o); public Order? GetById(int id)=>_orders.FirstOrDefault(x=>x.Id==id); public IEnumerable<Order> GetByFoodTruck(int id)=>_orders.Where(x=>x.FoodTruckId==id); public void Update(Order o){var i=_orders.FindIndex(x=>x.Id==o.Id); if(i!=-1)_orders[i]=o;}}