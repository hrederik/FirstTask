using UnityEngine;
using UnityEngine.Events;

public class CollectableDiamond : MonoBehaviour
{
    [SerializeField] private int _scoreAmount = 1;
    private UnityAction<int> _diamondCollected;
    public event UnityAction<int> DiamondCollected
    {
        add => _diamondCollected += value;
        remove => _diamondCollected -= value;
    }

    private void OnTriggerEnter(Collider collider)
	{
		if (IsPlayer(collider))
        {
            _diamondCollected(_scoreAmount);
            gameObject.SetActive(false);
        }
	}

    private bool IsPlayer(Collider collider)
    {
        return collider.transform.GetComponent<PlayerMovement>();
    }
}