using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour
{
    public int _price;
    public int _increase;
    public gameController _gameController;

    public void onTap ()
    {
	    if(_gameController._score>= _price)
        {
            _gameController._score=_gameController._score - _price;
            _gameController._tapPower = _gameController._tapPower + _increase;
        }
	}
}
