using UnityEngine;
using System.Collections;

public class changeStage : MonoBehaviour {

    public GameObject _clouds;
    public GameObject _attackUI;
    public GameObject _defendUI;
    public gameController _gameController;
    private bool isCoroutineExecuting = false;

    public void _changeStage()
    {
        if(_gameController._moving == false)
        {
            if (_gameController._state == "defend")
            {
                _gameController._state = "attack";
            }
            else
            {
                _gameController._state = "defend";
            }
        }
    }

    public void Update()
    {
        if (_gameController._state == "attack" && _clouds.transform.position.y<=1200)
        {
            _gameController._moving = true;
            _clouds.transform.Translate(Vector3.up * 20);
            StartCoroutine(showUI(1));
        }
        else if (_gameController._state == "defend" && _clouds.transform.position.y >= -950)
        {
            _gameController._moving = true;
            _clouds.transform.Translate(Vector3.down * 20);
            StartCoroutine(HideUI(1));
        }
        if(_gameController._state == "attack" && _clouds.transform.position.y >= 1200)
        {
            _gameController._moving = false;
        }
        else if(_gameController._state == "defend" && _clouds.transform.position.y <= -950)
        {
            _gameController._moving = false;
        }
    }
    IEnumerator showUI(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        _attackUI.SetActive(true);
        _defendUI.SetActive(false);

        isCoroutineExecuting = false;
    }
    IEnumerator HideUI(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        _attackUI.SetActive(false);
        _defendUI.SetActive(true);

        isCoroutineExecuting = false;
    }
}
