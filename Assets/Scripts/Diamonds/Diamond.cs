using UnityEngine;
using UnityEngine.Events;

public class Diamond : MonoBehaviour
{
    [SerializeField] private int _score = 1;
    public event UnityAction<int> DiamondCollected;

    private void OnTriggerEnter(Collider collider)
	{
		if (PlayerChecker.IsPlayer(collider))
        {
            DiamondCollected(_score);
            gameObject.SetActive(false);
        }
	}
}