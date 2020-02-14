using UnityEngine;

public class DiamondsGenerator : MonoBehaviour
{
    [SerializeField] private CollectableDiamond[] _diamonds;
    [SerializeField] private Scores _scores;

    private void OnEnable()
    {
        foreach (var diamond in _diamonds)
        {
            diamond.DiamondCollected += _scores.OnDiamondCollected;
        }
    }

    private void OnDisable()
    {
        foreach (var diamond in _diamonds)
        {
            diamond.DiamondCollected -= _scores.OnDiamondCollected;
        }
    }

    private void Start()
    {
        Generate();
    }

    private void DisableDiamonds()
    {
        for (int i = 0; i < _diamonds.Length; i++)
        {
            _diamonds[i].gameObject.SetActive(false);
        }
    }

    public void Generate()
    {
        DisableDiamonds();

        int startPoint = Random.Range(0, _diamonds.Length - 1);
        int endPoint = Random.Range(startPoint, _diamonds.Length - 1);

        for (int i = startPoint; i < endPoint; i++)
        {
            _diamonds[i].gameObject.SetActive(true);
        }
    }
}
