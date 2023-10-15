using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private int _spawningTime;

    private Transform[] _point;

    private void Start()
    {
        _point = new Transform[_spawnPoint.childCount];

        for (int i = 0; i < _point.Length; i++)
        {
            _point[i] = _spawnPoint.GetChild(i);
        }

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < _point.Length; i++)
        {
            Quaternion angleSpawn = _point[i].rotation;

            Instantiate(_enemy, _point[i].position, angleSpawn);

            yield return new WaitForSeconds(_spawningTime);
        }
    }
}
