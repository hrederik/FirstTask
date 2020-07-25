using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private List<Platform> _platforms = new List<Platform>();
    [SerializeField] private float _delay = 2;

    private float _platformLength;

    private void Start()
    {
        _platformLength = _platforms[0].transform.localScale.z;
    }

    public void StartExtension()
    {
        StartCoroutine(GenerateDelay());
    }

    IEnumerator GenerateDelay()
    {
        yield return new WaitForSeconds(_delay);
        ExtendGroundLine();
    }

    private void ExtendGroundLine()
    {
        Platform first = _platforms[0];
        Platform last = _platforms[_platforms.Count - 1];

        first.transform.position = new Vector3(0, 0, last.transform.position.z + _platformLength);
        first.OnPlaced();

        _platforms.Remove(first);
        _platforms.Add(first);
    }
}