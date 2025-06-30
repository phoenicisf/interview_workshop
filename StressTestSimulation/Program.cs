using StressTestSimulation.Cases;

Console.WriteLine("Application started");

// # ข้อ 1.
BottleneckCase bottleneckCase = new BottleneckCase();
var milliseconds = bottleneckCase.RunAsync().GetAwaiter().GetResult();
Console.WriteLine($"1. BottleneckCase Run time: {milliseconds} Milliseconds.");
Console.WriteLine();
Console.WriteLine();

// # ข้อ 2.
QueryAndManipulation queryAndManipulation = new QueryAndManipulation();
var result = queryAndManipulation.RunAsync().GetAwaiter().GetResult();
Console.WriteLine("2. QueryAndManipulation: The top 10 highest-value orders from the past 30 days.");
for (int i = 0; i < result.top10OrderHighestValue.Count; i++)
{
    Console.WriteLine($"{i + 1}) OrderId: {result.top10OrderHighestValue[i].orderId}     TotalAmount: {result.top10OrderHighestValue[i].totalAmount}");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("2. QueryAndManipulation: Top 10 Popular Products from the past 30 days.");
for (int i = 0; i < result.top10PopularProductIds.Count; i++)
{
    Console.WriteLine($"{i + 1}) ProductId: {result.top10PopularProductIds[i].productId}     Total: {result.top10PopularProductIds[i].totalCount}");
}
Console.WriteLine("Press key to exit.");
Console.ReadKey();