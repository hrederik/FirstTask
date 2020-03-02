using UnityEngine;

public class DiamondsGenerator : Generator
{
    [SerializeField] private Scores _scores;

    private void OnEnable()
    {
        foreach (var diamond in Objects)
        {
            diamond.GetComponent<Diamond>().DiamondCollected += OnDiamondCollected;
        }
    }

    private void OnDisable()
    {
        foreach (var diamond in Objects)
        {
            diamond.GetComponent<Diamond>().DiamondCollected -= OnDiamondCollected;
        }
    }

    private void OnDiamondCollected(int amount)
    {
        _scores.OnDiamondCollected(amount);
    }
}