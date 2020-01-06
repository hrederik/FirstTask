using UnityEngine;

public class BarrierGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _barriers;

    private void Start()
    {
        Generate();
    }

    private bool GetRandomBool()
    {
        return Random.Range(0, 100) <= 50;
    }

    public void Generate()
    {
        for (int i = 0; i < _barriers.Length; i++)
        {
            _barriers[i].SetActive(GetRandomBool());
        }
    }
}
