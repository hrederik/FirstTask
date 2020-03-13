public interface IListenerProvider
{
    void AddListener(PlayerTrigger playerTrigger);
    void RemoveListener(PlayerTrigger playerTrigger);
}