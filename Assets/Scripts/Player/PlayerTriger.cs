using UnityEngine;
using UnityEngine.Events;

public class PlayerTriger : MonoBehaviour
{
    [SerializeField] private UnityEvent _exitEvent;

    private void OnTriggerEnter(Collider collider)
    {
        if (IsPlayer(collider))
        {
            _exitEvent.Invoke();
        }
    }

    private bool IsPlayer(Collider collider)
    {
        return collider.transform.GetComponent<PlayerMovement>();
    }
}