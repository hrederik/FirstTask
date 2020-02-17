using UnityEngine;
using UnityEngine.Events;

public class CollectableDiamond : MonoBehaviour
{
    [SerializeField] private int _score = 1;
    public event UnityAction<int> DiamondCollected;

    private void OnTriggerEnter(Collider collider)
	{
		if (IsPlayer(collider))
        {
            DiamondCollected(_score);
            gameObject.SetActive(false);
        }
	}

    private bool IsPlayer(Collider collider)
    {
        return collider.transform.GetComponent<PlayerMovement>();
    }
}