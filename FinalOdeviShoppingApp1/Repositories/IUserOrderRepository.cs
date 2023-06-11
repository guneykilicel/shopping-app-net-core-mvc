namespace FinalOdeviShoppingApp1.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}