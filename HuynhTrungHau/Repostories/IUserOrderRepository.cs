namespace HuynhTrungHau
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();

    }
}