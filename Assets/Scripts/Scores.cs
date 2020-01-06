using UnityEngine;
using UnityEngine.Events;

public class Scores : MonoBehaviour
{
    public static int Value { get; private set; }
    public event UnityAction<int> UpdateScores;

    public void AddScores(int amount)
    {
        Value += amount;
        UpdateScores(Value);
    }
}
