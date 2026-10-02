using MondialBlockChain.Events.Services;

namespace MondialBlockChain.Tests;

public class EventBusTests
{
    [Fact]
    public void Publish_Should_Store_Event()
    {
        var bus =
            new EventBus();

        bus.Publish(
            "TestEvent",
            new { });

        Assert.Single(bus.Events);
    }

    [Fact]
    public void Event_Should_Have_Correct_Name()
    {
        var bus =
            new EventBus();

        bus.Publish(
            "Transfer",
            new { });

        Assert.Equal(
            "Transfer",
            bus.Events.First().Name);
    }
}