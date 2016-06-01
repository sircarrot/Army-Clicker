using UnityEngine;
using System.Collections;

public class scoreOnTap : MonoBehaviour
{
    public gameController _gameController;
    public GameObject _enemySprite;
    public void onTap()
    {
        if(_gameController._moving == false)
        {
            if(_gameController._state=="defend")
            {
                _gameController._score += _gameController._tapPower;
            }
            if (_gameController._state == "attack")
            {
                _gameController._currentEnemyHealth -= _gameController._tapPower;
                _enemySprite.GetComponent<Animator>().SetBool("Damaged",true);
                StartCoroutine(waitForSecond(0.1f));
            }
        }
    }
    IEnumerator waitForSecond(float time)
    {
        yield return new WaitForSeconds(time);

        _enemySprite.GetComponent<Animator>().SetBool("Damaged", false);

    }
}
