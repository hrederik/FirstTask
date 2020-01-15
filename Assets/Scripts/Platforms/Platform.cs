using UnityEngine;
using UnityEngine.Events;

public class Platform : MonoBehaviour
{
    [SerializeField] private UnityEvent ExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<PlayerMovement>())
        {
            ExitEvent.Invoke();
        }
    }
}