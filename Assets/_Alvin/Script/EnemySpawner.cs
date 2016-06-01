using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public gameController _gameController;
    void Update()
    {
        if (_gameController._monsterSpawned == false)
        {
            _gameController._currentEnemyHealth = 10 * _gameController._stage * 2;
            _gameController._maxEnemyHealth = 10 * _gameController._stage * 2;
            _gameController._monsterName = _gameController._names[Random.Range(0, _gameController._names.Length-1)];
            _gameController._monsterSpawned = true;
            _gameController._firstSpawn = true;
        }
    }
}     
        