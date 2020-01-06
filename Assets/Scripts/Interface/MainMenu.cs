using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsPanel;

    public void OpenGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowAuthors()
    {
        _authorsPanel.SetBool("IsOpen", !_authorsPanel.GetBool("IsOpen"));
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
