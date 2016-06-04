using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class inateDamage : MonoBehaviour
{
    public gameController _gameController;
    private float _timer = 1;
	void Update ()
    {
        if (_timer>0)
        {
            _timer -= 1 * Time.deltaTime;
        }
        else
        {
            _gameController._currentEnemyHealth -= _gameController._armyPower;
            _timer = 1;
        }
    }
}
