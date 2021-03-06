﻿using UnityEngine;

public class TargetFollowing : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, _target.transform.position.z);
    }
}
