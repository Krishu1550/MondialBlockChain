using MondialBlockChain.Abstractions.Storage;
using MondialBlockChain.Abstractions.Events;

namespace MondialBlockChain.Abstractions.Blockchain;

public interface IBlockchainContext
{
    IStateStorage Storage { get; }

    IEventBus Events { get; }
}
