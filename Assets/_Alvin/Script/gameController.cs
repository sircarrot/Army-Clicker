using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour
{
    public bool _firstSpawn = false;
    public int _score = 0;
    public int _tapPower = 1;
    public int _currentEnemyHealth;//264 default width
    public int _maxEnemyHealth;
    public string _monsterName;
    public int _stage = 1;
    public bool _monsterSpawned = false;
    public string _state = "defend";
    public bool _moving = false;
    public string[] _names = new string[] {"Super Shrek","Shrek of death","The reker-shreker"};
}
