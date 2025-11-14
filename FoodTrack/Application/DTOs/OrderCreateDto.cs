namespace FoodTrack.Application.DTOs;
public class OrderCreateDto{public int FoodTruckId{get;set;} public List<OrderItemDto> Items{get;set;}}
public class OrderItemDto{public string Nombre{get;set;} public decimal Precio{get;set;} public int Cantidad{get;set;}}