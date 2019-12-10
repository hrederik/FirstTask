using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, _target.transform.position.z);
    }
}
