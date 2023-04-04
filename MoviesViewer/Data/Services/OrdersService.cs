using MoviesViewer.Models;

namespace MoviesViewer.Data.Services
{
    public class OrdersService : IOrdersService
    {
        public Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            throw new NotImplementedException();
        }

        public Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
