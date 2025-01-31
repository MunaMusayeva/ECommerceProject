using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface ISummaryOfSalesByQuarterService
{
    List<SummaryOfSalesByQuarter> GetAll();
    List<SummaryOfSalesByQuarter> GetAllByOrder(int orderId);
    SummaryOfSalesByQuarter GetById(int id);
    void Add(SummaryOfSalesByQuarter summaryOfSalesByQuarter);
    void Update(SummaryOfSalesByQuarter summaryOfSalesByQuarter);
    void Delete(int summaryOfSalesByQuarterId);
}
