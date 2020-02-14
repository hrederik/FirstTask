using UnityEngine;

public class GamePause : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void StopGame()
    {
        Time.timeScale = 0;
    }
}
