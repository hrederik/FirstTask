using UnityEngine;

public class Diamond : PlayerTrigger
{
    [SerializeField] private int _score = 1;
    [SerializeField] private Scores _scores;

    protected override void OnPlayerEnter()
    {
        _scores.OnDiamondCollected(_score);
        gameObject.SetActive(false);
    }
}