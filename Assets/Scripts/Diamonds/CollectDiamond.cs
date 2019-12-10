using System;
using UnityEngine;

public class CollectDiamond : MonoBehaviour
{ 
    [SerializeField] private int _scoreAmount = 1;

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player")
		{
            GameManager.instance.AddScores(_scoreAmount);

            gameObject.SetActive(false);
		}
	}
}
