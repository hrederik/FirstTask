using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private PlatformGenerator _platformGenerator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<PlayerMovement>())
        {
            _platformGenerator.StartGenerate();
        }
    }
}