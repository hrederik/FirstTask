using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private DiamondsGenerator _diamondsGenerator;
    [SerializeField] private BarrierGenerator _barrierGenerator;

    public void OnPlaced()
    {
        _diamondsGenerator.Generate();
        _barrierGenerator.Generate();
    }
}
