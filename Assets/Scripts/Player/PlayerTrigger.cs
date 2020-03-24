using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _playerInteracted;

    private void OnTriggerEnter(Collider collider)
    {
        if (IsPlayer(collider.transform))
        {
            OnPlayerEnter();
        } 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (IsPlayer(collision.transform))
        {
            OnPlayerEnter();
        }
    }

    protected virtual void OnPlayerEnter()
    {
        _playerInteracted.Invoke();
    }

    private bool IsPlayer(Transform checkableObject)
    {
        return checkableObject.GetComponent<PlayerMovement>();
    }
}