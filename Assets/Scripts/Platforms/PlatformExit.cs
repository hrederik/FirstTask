using UnityEngine;

public class PlatformExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponentInParent<PlatformGenerator>().StartGenerate();
        }
    }
}