using FoodTrack.Domain.Enums;
namespace FoodTrack.Domain.Services;
public class OrderService{public bool CambioDeEstadoValido(OrderState a,OrderState n)=> n switch{OrderState.EnPreparacion=>a==OrderState.Creada,OrderState.Lista=>a==OrderState.EnPreparacion,OrderState.Entregada=>a==OrderState.Lista,_=>false};}