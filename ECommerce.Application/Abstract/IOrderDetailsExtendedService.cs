using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface IOrderDetailsExtendedService
{
    List<OrderDetailsExtended> GetAll();
    List<OrderDetailsExtended> GetAllByProduct(int productId);
    OrderDetailsExtended GetById(int id);
    void Add(OrderDetailsExtended orderDetailsExtended);
    void Update(OrderDetailsExtended orderDetailsExtended);
    void Delete(int orderDetailsExtendedId);
}
