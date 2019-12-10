using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singletone<GameManager>
{
    [SerializeField] private Player _player;

	public static int Scores { get; private set; }

	public void RestartGame()
	{
		Scores = 0;

		UserInterface.instance.UpdateScoreLabel(Scores);
	}

	public void GameOver()
	{
        if (_player)
            _player.enabled = false;
        
        UserInterface.instance.GameOver();
    }

	public void AddScores(int amount)
	{
		Scores += amount;
        
		UserInterface.instance.UpdateScoreLabel(Scores);
	}
}