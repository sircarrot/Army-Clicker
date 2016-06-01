using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class enemyNameScript : MonoBehaviour
{
    public Text _text;
    public gameController _gameController;

    void Start()
    {
        _text = this.GetComponent<Text>();
    }

    void Update()
    {
        _text.text = _gameController._monsterName;
    }
}
