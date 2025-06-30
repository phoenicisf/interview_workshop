using System.Diagnostics;

namespace StressTestSimulation.Cases
{
    // # 2. เทคนิคการเข้าถึงและรวบรวมข้อมูลตามต้างการ
    public class QueryAndManipulation
    {
        readonly List<Product> sampleDataProducts;
        public QueryAndManipulation()
        {
            sampleDataProducts = new Product().SampleProducts(2000);
        }
        public async Task<(List<(int orderId, decimal totalAmount)> top10OrderHighestValue, List<(int productId, int totalCount)> top10PopularProductIds)> Run()
        {
            var sw = new Stopwatch();
            List<(int orderId, decimal totalAmount)> top10OrderHighestValue = new List<(int orderId, decimal totalAmount)>();
            List<(int productId, int totalCount)> top10PopularProductIds = new List<(int productId, int totalCount)>();
            Console.WriteLine($"Generate data...");
            var orders = GenerateSampleOrders(30000, 1000);
            Console.WriteLine($"Generate data completed");

            // implement code here

            // from object: orders
            // Process Step 1: The top 10 highest-value orders from the past 30 days.

            // Process Step 2: Top 10 Popular Products from the past 30 days.

            return (top10OrderHighestValue, top10PopularProductIds);
        }

        public List<Order> GenerateSampleOrders(int orderCount = 1000, int itemsPerOrder = 1000)
        {
            var random = new Random();
            var orders = new List<Order>();
            DateTime now = DateTime.Now;
            DateTime yearFromNow = now.AddYears(-1);
            long range = (now.Ticks - yearFromNow.Ticks);

            for (int i = 0; i < orderCount; i++)
            {
                var order = new Order
                {
                    Id = i,
                    OrderDate = now.AddTicks(random.NextInt64(range))
                };

                for (int j = 0; j < itemsPerOrder; j++)
                {
                    int productId = random.Next(1, 2000);
                    int qty = random.Next(1, 5);

                    order.Items.Add(new OrderItem
                    {
                        ProductId = sampleDataProducts[productId].ProductId,
                        Quantity = qty,
                        Price = sampleDataProducts[productId].Price
                    });
                }

                orders.Add(order);
            }

            return orders;
        }
    }
}
