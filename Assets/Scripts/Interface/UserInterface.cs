using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterface : Singletone<UserInterface>
{
	[SerializeField] private GameObject _gameUI;
	[SerializeField] private GameObject _gameOverUI;
	
	[Space]
	[SerializeField] private Text _scoreLabel;

    public void GameOver()
    {
        _gameUI.SetActive(false);
        _gameOverUI.SetActive(true);
    }

	public void UpdateScoreLabel(int amount)
	{
		if (_scoreLabel)
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