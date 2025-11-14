using FoodTrack.Domain.Entities;
namespace FoodTrack.Domain.Interfaces;
public interface IEventLogRepository{void Add(EventLog log); IEnumerable<EventLog> GetByOrder(int id);}