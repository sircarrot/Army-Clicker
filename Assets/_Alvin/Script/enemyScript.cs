using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour
{
    public gameController _gameController;
    void Update()
    {
        if (_gameController._firstSpawn == true)
        {
            if (_gameController._currentEnemyHealth <= 0)
            {
                _gameController._monsterSpawned = false;
                _gameController._score += 10 * _gameController._stage;
                _gameController._stage += 1;  
            }
        }
    }
}

