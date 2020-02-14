using UnityEngine;
using UnityEngine.Events;

public class PlayerCollider : MonoBehaviour
{
    private UnityAction _hitEvent;
    public event UnityAction HitEvent
    {
        add => _hitEvent += value;
        remove => _hitEvent -= value;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (IsPlayer(collision))
        {
            _hitEvent();
        }
    }

    private bool IsPlayer(Collision collision)
    {
        return collision.transform.GetComponent<PlayerMovement>();
    }
}