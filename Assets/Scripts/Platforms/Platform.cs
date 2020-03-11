using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Generator _diamondsGenerator;
    [SerializeField] private Generator _barrierGenerator;

    public void OnPlaced()
    {
        _diamondsGenerator.Generate();
        _barrierGenerator.Generate();
    }
}