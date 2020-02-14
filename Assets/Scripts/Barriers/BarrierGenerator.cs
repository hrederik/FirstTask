using UnityEngine;

public class BarrierGenerator : MonoBehaviour
{
    [SerializeField] private PlayerCollider[] _barriers;
    [SerializeField] private UserInterface _interface;
    [SerializeField] private GamePause _gamePause;

    private void OnEnable()
    {
        foreach (var barrier in _barriers)
        {
            barrier.HitEvent += _interface.ShowGameOverUI;
            barrier.HitEvent += _gamePause.StopGame;
        }
    }

    private void OnDisable()
    {
        foreach (var barrier in _barriers)
        {
            barrier.HitEvent -= _interface.ShowGameOverUI;
            barrier.HitEvent -= _gamePause.StopGame;
        }
    }

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
            _barriers[i].gameObject.SetActive(GetRandomBool());
        }
    }
}
