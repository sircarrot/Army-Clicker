using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class enemyHealthScript : MonoBehaviour
{
    public Text _text;
    public gameController _gameController;
    public RectTransform _bar;
    public float _health;
    void Start()
    {
        _text = this.GetComponent<Text>();
    }

    void Update()
    {
            _text.text = "HP : " + _gameController._currentEnemyHealth;
            _health = ((float)_gameController._currentEnemyHealth / (float)_gameController._maxEnemyHealth) * 264; //264 default width
            _bar.sizeDelta = new Vector2(_health, 21);
    }
}
