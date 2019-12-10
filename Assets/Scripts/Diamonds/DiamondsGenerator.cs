using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondsGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _diamonds;

    private void Start()
    {
        Generate();
    }

    public void Generate()
    {
        DisableDiamonds();

        int startPoint;
        int endPoint;

        startPoint = Random.Range(0, _diamonds.Length - 1);
        endPoint = Random.Range(startPoint, _diamonds.Length - 1);

        for (int i = startPoint; i < endPoint; i++)
        {
            _diamonds[i].SetActive(true);
        }
    }

    private void DisableDiamonds()
    {
        for (int i = 0; i < _diamonds.Length; i++)
        {
            _diamonds[i].SetActive(false);
        }
    }
}
