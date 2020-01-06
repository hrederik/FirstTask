using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> _platforms = new List<GameObject>();
    [SerializeField] private float _delay = 2;

    private float _platformLength;

    private void Start()
    {
        _platformLength = _platforms[0].transform.localScale.z;
    }

    public void StartGenerate()
    {
        StartCoroutine(GenerateDelay());
    }

    IEnumerator GenerateDelay()
    {
        yield return new WaitForSeconds(_delay);
        Generate();
    }

    private void Generate()
    {
        GameObject temp = _platforms[0];

        temp.transform.position = new Vector3(0, 0, _platforms[_platforms.Count - 1].transform.position.z + _platformLength);

        temp.GetComponent<DiamondsGenerator>().Generate();
        temp.GetComponent<BarrierGenerator>().Generate();

        _platforms.RemoveAt(0);
        _platforms.Add(temp);
    }
}