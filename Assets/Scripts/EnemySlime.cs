using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _target;


    private void Start()
    {
        _target = GameObject.Find("TargetCube").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, Time.deltaTime * _speed);
        transform.LookAt(_target.position);

    }
}

