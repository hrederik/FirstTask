using UnityEngine;
using UnityEngine.Events;

public class Scores : MonoBehaviour
{
    private int _value;
    public event UnityAction<int> ScoresUpdated;

    public void OnDiamondCollected(int amount)
    {
        _value += amount;
        ScoresUpdated(_value);
    }
}