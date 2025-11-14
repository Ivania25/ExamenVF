using FoodTrack.Domain.Enums;
namespace FoodTrack.Domain.Entities;
public class EventLog{public int OrderId{get;;set;} public OrderState EstadoAnterior{get;set;} public OrderState EstadoNuevo{get;set;} public DateTime Fecha{get;set;}=DateTime.Now;}