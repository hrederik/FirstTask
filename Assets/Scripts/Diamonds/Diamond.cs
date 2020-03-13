using UnityEngine;
using UnityEngine.Events;

public class Diamond : PlayerTrigger
{
    [SerializeField] private int _score = 1;
    public event UnityAction<int> Collected;

    private void OnTriggerEnter(Collider collider)
    {
        if (PlayerChecker.IsPlayer(collider))
        {
            Collected(_score);
            gameObject.SetActive(false);
        }
    }
}
