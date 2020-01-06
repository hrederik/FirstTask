using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
	[SerializeField] private GameObject _gameUI;
	[SerializeField] private GameObject _gameOverUI;
	[Space]
    [SerializeField] private Scores _scores;
	[SerializeField] private Text _scoreLabel;

    private void Start()
    {
        _scores.UpdateScores += UpdateScoreLabel;
    }

    public void ShowGameOverUI()
    {
        _gameUI.SetActive(false);
        _gameOverUI.SetActive(true);
    }

	public void UpdateScoreLabel(int amount)
	{
        _scoreLabel.text = amount.ToString();
	}

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}