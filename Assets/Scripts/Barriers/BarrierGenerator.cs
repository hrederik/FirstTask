using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _barriers;

    private void Start()
    {
        Generate();
    }

    public void Generate()
    {
        int random;

        for (int i = 0; i < _barriers.Length; i++)
        {
            random = Random.Range(0, 12);

            _barriers[i].SetActive(random <= 5);
        }
    }
}
