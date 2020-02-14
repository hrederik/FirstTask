using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _whatIsGround;

    public bool CheckGround()
    {
        return Physics.OverlapSphere(_point.position, _radius, _whatIsGround).Length > 0;
    }
}
