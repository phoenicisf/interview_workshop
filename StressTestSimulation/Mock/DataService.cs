public class DataService
{
    // Simulate remote fetch
    public async Task<string> FetchFromRemoteAsync(int id)
    {
        await Task.Delay(100); // Simulated latency
        return $"remote-{id}";
    }

    // Simulate business logic
    public async Task<string> TransformDataAsync(string raw, int multiplier)
    {
        await Task.Delay(50); // Simulate CPU/I/O delay
        return $"{raw}-value-{multiplier * 2}";
    }

    // Simulate database save
    public async Task SaveToDbAsync(string finalValue)
    {
        await Task.Delay(10); // Simulated DB latency
    }

    
}
