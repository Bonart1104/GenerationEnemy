using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * _speed);

    }
}
