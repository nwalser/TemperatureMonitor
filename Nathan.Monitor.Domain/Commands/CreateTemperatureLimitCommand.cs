namespace Nathan.Monitor.Domain.Commands;

public class CreateTemperatureLimitCommand
{
    public string Name { get; private set; }
    public double Limit { get; private set; }
}