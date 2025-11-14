using FoodTrack.Domain.Entities;
using FoodTrack.Domain.Interfaces;
namespace FoodTrack.Infrastructure;
public class InMemoryEventLogRepository:IEventLogRepository{private readonly List<EventLog> _logs=new(); public void Add(EventLog l)=>_logs.Add(l); public IEnumerable<EventLog> GetByOrder(int id)=>_logs.Where(x=>x.OrderId==id);} 