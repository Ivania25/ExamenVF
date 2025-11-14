using FoodTrack.Domain.Entities;
using FoodTrack.Domain.Interfaces;
namespace FoodTrack.Infrastructure;
public class InMemoryFoodTruckRepository:IFoodTruckRepository{private readonly List<FoodTruck> _fts=new(); public void Add(FoodTruck f)=>_fts.Add(f); public IEnumerable<FoodTruck> GetAll()=>_fts; public FoodTruck? GetById(int id)=>_fts.FirstOrDefault(x=>x.Id==id);} 