using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreScript : MonoBehaviour {
    public Text _text;
    public gameController _gameController;
    
    void Start ()
    {
        _text = this.GetComponent<Text>();
    }
	
	void Update ()
    {
        _text.text = " = "+ _gameController._score;
	}
}
