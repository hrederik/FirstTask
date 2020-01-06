using UnityEngine;

public class CollectableDiamond : MonoBehaviour
{
    [SerializeField] private int _scoreAmount = 1;
    private Scores _scores;

    private void Start()
    {
        _scores = FindObjectOfType<Scores>();
    }

    private void OnTriggerEnter(Collider collider)
	{
		if (collider.transform.GetComponent<PlayerMovement>())
		{
            _scores.AddScores(_scoreAmount);
            gameObject.SetActive(false);
		}
	}
}