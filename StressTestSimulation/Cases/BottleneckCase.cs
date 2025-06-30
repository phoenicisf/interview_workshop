using System.Diagnostics;

namespace StressTestSimulation.Cases
{
    // # 1. แก้ปัญหาการทำงานที่ช้า
    public class BottleneckCase
    {
        // Optimize this code below
        public async Task<long> RunAsync()
        {
            var stopwatch = new Stopwatch();
            DataService dataService = new DataService();
            // Create 100 Orders
            stopwatch.Start();
            for (int i = 0; i < 200; i++)
            {
                var raw = await dataService.FetchFromRemoteAsync(i);
                var transformed = await dataService.TransformDataAsync(raw, i);
                await dataService.SaveToDbAsync(transformed);
            }
            stopwatch.Stop();
            // 40 sec
            return stopwatch.ElapsedMilliseconds;
        }
    }
}
