namespace MyPieShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
