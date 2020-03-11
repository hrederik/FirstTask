using UnityEngine;

public class BarrierEventProvider : MonoBehaviour, IGenerated
{
    [SerializeField] private UserInterface _interface;
    [SerializeField] private GamePause _gamePause;

    public void OnInteracted()
    {
        _interface.ShowGameOverUI();
        _gamePause.StopGame();
    }
}