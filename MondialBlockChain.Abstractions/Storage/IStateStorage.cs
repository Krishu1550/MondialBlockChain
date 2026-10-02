namespace MondialBlockChain.Abstractions.Storage;

public interface IStateStorage
{
    void Set(
        string key,
        object value);

    T Get<T>(string key);

    bool Exists(string key);
}