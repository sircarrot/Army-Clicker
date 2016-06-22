using UnityEngine;
using System.Collections;

public class upgradeArmyScript : MonoBehaviour {

    public gameControllerRoyce _gameController;

    private float _timer = 1;
    private bool isrunning;

    public void OnUpgradeArmy()
    {
        if (!isrunning) { isrunning = true; }
        _gameController.armypower[gameObject.GetComponent<upgradeID>()._upgradeID] += _gameController.armypowerincrease[gameObject.GetComponent<upgradeID>()._upgradeID];
        _gameController.armypowerincrease[gameObject.GetComponent<upgradeID>()._upgradeID] *= 2;

    }
    void Update()
    {
        if(isrunning)
        {
            if (_timer > 0)
            {
                _timer -= 1 * Time.deltaTime;
            }
            else
            {
                //_gameController._currentEnemyHealth -= _gameController._armyPower;
                Debug.Log(_gameController.armypower[gameObject.GetComponent<upgradeID>()._upgradeID]);
                _timer = 1;
            }
        }
    }
}
