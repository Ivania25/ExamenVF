using FoodTrack.Domain.Enums;
namespace FoodTrack.Domain.Entities;
public class Order{public int Id{get;set;} public int FoodTruckId{get;set;} public List<OrderItem> Items{get;set;}=new(); public OrderState Estado{get;set;}=OrderState.Creada; public decimal Total{get;set;} public DateTime Timestamp{get;set;}=DateTime.Now;}
public class OrderItem{public string Nombre{get;set;} public decimal Precio{get;set;} public int Cantidad{get;set;}}