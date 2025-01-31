using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Implementation;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concrete;

public class SummaryOfSalesByQuarterService(ISummaryOfSalesByQuarterDal summaryOfSalesByQuarterDal) : ISummaryOfSalesByQuarterService
{
    private readonly ISummaryOfSalesByQuarterDal _summaryOfSalesByQuarterDal = summaryOfSalesByQuarterDal;

    public void Add(SummaryOfSalesByQuarter summary)
    {
        _summaryOfSalesByQuarterDal.Add(summary);
    }

    public void Delete(int summaryId)
    {
        var summary = _summaryOfSalesByQuarterDal.Get(p => p.OrderId == summaryId);
        _summaryOfSalesByQuarterDal.Delete(summary);
    }

    public List<SummaryOfSalesByQuarter> GetAll()
    {
        return _summaryOfSalesByQuarterDal.GetList();
    }
  
    public SummaryOfSalesByQuarter GetById(int id)
    {
        return _summaryOfSalesByQuarterDal.Get(p => p.OrderId == id);
    }

    public void Update(SummaryOfSalesByQuarter summary)
    {
        _summaryOfSalesByQuarterDal.Update(summary);
    }

    List<SummaryOfSalesByQuarter> ISummaryOfSalesByQuarterService.GetAllByOrder(int orderId)
    {
        return _summaryOfSalesByQuarterDal.GetList(p => p.OrderId == orderId || orderId == 0);
    }
}
