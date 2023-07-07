namespace MyPieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        public readonly IShoppingCart _shoppingCart;
        public readonly MyPieShopDbContext _myPieShopDbContext;

        public OrderRepository(IShoppingCart shoppingCart, MyPieShopDbContext myPieShopDbContext)
        {
            _shoppingCart = shoppingCart;
            _myPieShopDbContext = myPieShopDbContext;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _myPieShopDbContext.Orders.Add(order);

            _myPieShopDbContext.SaveChanges();
        }
    }
}
