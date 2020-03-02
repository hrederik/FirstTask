using UnityEngine;
using UnityEngine.Events;

public class PlayerTriger : MonoBehaviour
{
    [SerializeField] private UnityEvent _playerInteracted;
    public event UnityAction PlayerInteracted
    {
        add => _playerInteracted.AddListener(value);
        remove => _playerInteracted.RemoveListener(value);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (PlayerChecker.IsPlayer(collider))
        {
            _playerInteracted.Invoke();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (PlayerChecker.IsPlayer(collision))
        {
            _playerInteracted.Invoke();
        }
    }
}