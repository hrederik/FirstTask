using UnityEngine;

public class DiamondsEventProvider : MonoBehaviour, IGenerated
{
    [SerializeField] private Scores _scores;

    public void OnInteracted()
    {
        _scores.OnDiamondCollected();
    }
}