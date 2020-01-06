using UnityEngine;

public class DeathTriger : MonoBehaviour
{
    private UserInterface _interface;

    private void Start()
    {
        _interface = FindObjectOfType<UserInterface>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.GetComponent<PlayerMovement>())
        {
            _interface.ShowGameOverUI();
        }
    }
}
