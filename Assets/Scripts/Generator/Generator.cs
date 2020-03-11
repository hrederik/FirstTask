using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private PlayerTrigger[] _objects;
    [SerializeField] private MonoBehaviour _eventProvider;
    private IGenerated EventProvider => (IGenerated)_eventProvider;

    private void OnEnable()
    {
        foreach (var item in _objects)
        {
            item.PlayerInteracted += EventProvider.OnInteracted;
        }
    }

    private void Start()
    {
        Generate();
    }

    private void OnDisable()
    {
        foreach (var key in _objects)
        {
            key.PlayerInteracted -= EventProvider.OnInteracted;
        }
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