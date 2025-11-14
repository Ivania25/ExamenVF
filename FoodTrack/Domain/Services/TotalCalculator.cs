using FoodTrack.Domain.Entities;
namespace FoodTrack.Domain.Services;
public class TotalCalculator{public decimal CalcularTotal(Order o)=>o.Items.Sum(i=>i.Precio*i.Cantidad);}