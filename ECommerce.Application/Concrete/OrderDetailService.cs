using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete;

public class OrderDetailService(IOrderDetailDal orderDetailDal) : IOrderDetailService
{
    private readonly IOrderDetailDal _orderDetailDal = orderDetailDal;

    public void Add(OrderDetail orderDetail)
    {
        _orderDetailDal.Add(orderDetail);
    }

    public void Delete(int orderDetailId)
    {
        var orderDetail = _orderDetailDal.Get(p => p.OrderId == orderDetailId);
        _orderDetailDal.Delete(orderDetail);
    }

    public List<OrderDetail> GetAll()
    {
        return _orderDetailDal.GetList();
    }

    public List<OrderDetail> GetAllByProduct(int productId)
    {
        return _orderDetailDal.GetList(p => p.ProductId == productId || productId == 0);
    }

    public OrderDetail GetById(int id)
    {
        return _orderDetailDal.Get(p => p.OrderId == id);
    }

    public void Update(OrderDetail orderDetail)
    {
        _orderDetailDal.Update(orderDetail);
    }
}
