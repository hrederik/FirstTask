using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private PlayerTrigger[] _objects;

    private void Start()
    {
        Generate();
    }

    public void Generate()
    {
        DisableObjects();

        for (int i = 0; i < _objects.Length; i++)
        {
            _objects[i].gameObject.SetActive(GetRandomBool());
        }
    }

    private void DisableObjects()
    {
        for (int i = 0; i < _objects.Length; i++)
        {
            _objects[i].gameObject.SetActive(false);
        }
    }

    private bool GetRandomBool()
    {
        return Random.Range(0, 100) <= 50;
    }
}