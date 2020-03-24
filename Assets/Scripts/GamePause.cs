using UnityEngine;

public class GamePause : MonoBehaviour
{
    private void Start()
    {
        Launch();
    }

    public void Launch()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}
