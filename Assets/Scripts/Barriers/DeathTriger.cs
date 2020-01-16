using UnityEngine;
using UnityEngine.Events;

public class DeathTriger : MonoBehaviour
{
    [SerializeField] private UnityEvent _hitEvent;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.GetComponent<PlayerMovement>())
        {
            _hitEvent.Invoke();
        }
    }
}
