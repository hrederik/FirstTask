using UnityEngine;

public class BarrierGenerator : Generator
{
    [SerializeField] private UserInterface _interface;
    [SerializeField] private GamePause _gamePause;

    private void OnEnable()
    {
        foreach (var barrier in Objects)
        {
            barrier.GetComponent<PlayerTriger>().PlayerInteracted += OnBarrierHit;
        }
    }

    private void OnDisable()
    {
        foreach (var barrier in Objects)
        {
            barrier.GetComponent<PlayerTriger>().PlayerInteracted -= OnBarrierHit;
        }
    }    

    private void OnBarrierHit()
    {
        _interface.ShowGameOverUI();
        _gamePause.StopGame();
    }
}