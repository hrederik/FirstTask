using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private PlayerTrigger[] _objects;
    [SerializeField] private MonoBehaviour _listenerProvider;
    private IListenerProvider ListenerProvider => (IListenerProvider)_listenerProvider;

    private void OnEnable()
    {
        foreach (var item in _objects)
        {
            ListenerProvider.AddListener(item);
        }
    }

    private void Start()
    {
        Generate();
    }

    private void OnDisable()
    {
        foreach (var item in _objects)
        {
            ListenerProvider.RemoveListener(item);
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