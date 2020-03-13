using UnityEngine;

public class DiamondsListenerProvider : MonoBehaviour, IListenerProvider
{
    [SerializeField] private Scores _scores;

    public void AddListener(PlayerTrigger playerTrigger)
    {
        playerTrigger.GetComponent<Diamond>().Collected += OnInteracted;
    }

    public void RemoveListener(PlayerTrigger playerTrigger)
    {
        playerTrigger.GetComponent<Diamond>().Collected -= OnInteracted;
    }

    private void OnInteracted(int amount)
    {
        _scores.OnDiamondCollected(amount);
    }
}