using UnityEngine;
using UnityEngine.Events;

public class DeathTriger : MonoBehaviour
{
    [SerializeField] private UnityEvent HitEvent;

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.GetComponent<PlayerMovement>())
        {
            HitEvent.Invoke();
        }
    }
}
