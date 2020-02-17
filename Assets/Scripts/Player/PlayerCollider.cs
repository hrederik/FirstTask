using UnityEngine;
using UnityEngine.Events;

public class PlayerCollider : MonoBehaviour
{
    public UnityAction HitEvent;

    private void OnCollisionEnter(Collision collision)
    {
        if (IsPlayer(collision))
        {
            HitEvent();
        }
    }

    private bool IsPlayer(Collision collision)
    {
        return collision.transform.GetComponent<PlayerMovement>();
    }
}