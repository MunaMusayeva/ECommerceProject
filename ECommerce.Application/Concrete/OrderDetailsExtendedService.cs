using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Implementation;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete;

public class OrderDetailsExtendedService(IOrderDetailsExtendedDal orderDetailsExtendedDal) : IOrderDetailsExtendedService
{
    private readonly IOrderDetailsExtendedDal _orderDetailsExtendedDal = orderDetailsExtendedDal;

    public void Add(OrderDetailsExtended orderDetailsExtended)
    {
        _orderDetailsExtendedDal.Add(orderDetailsExtended);
    }

    public void Delete(int orderDetailsExtendedId)
    {
        var orderDetailsExtended = _orderDetailsExtendedDal.Get(p => p.OrderId == orderDetailsExtendedId);
        _orderDetailsExtendedDal.Delete(orderDetailsExtended);
    }

    public List<OrderDetailsExtended> GetAll()
    {
        return _orderDetailsExtendedDal.GetList();
    }

    public List<OrderDetailsExtended> GetAllByProduct(int productId)
    {
        return _orderDetailsExtendedDal.GetList(p => p.ProductId == productId || productId == 0);
    }

    public OrderDetailsExtended GetById(int id)
    {
        return _orderDetailsExtendedDal.Get(p => p.OrderId == id);
    }

    public void Update(OrderDetailsExtended orderDetailsExtended)
    {
        _orderDetailsExtendedDal.Update(orderDetailsExtended);
    }
}
