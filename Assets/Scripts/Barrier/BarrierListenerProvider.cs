using UnityEngine;

public class BarrierListenerProvider : MonoBehaviour, IListenerProvider
{
    [SerializeField] private UserInterface _interface;
    [SerializeField] private GamePause _gamePause;

    public void AddListener(PlayerTrigger playerTrigger)
    {
        playerTrigger.PlayerInteracted += OnInteracted;
    }

    public void RemoveListener(PlayerTrigger playerTrigger)
    {
        playerTrigger.PlayerInteracted -= OnInteracted;
    }

    private void OnInteracted()
    {
        _interface.ShowGameOverUI();
        _gamePause.StopGame();
    }
}