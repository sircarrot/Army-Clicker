using UnityEngine;
using System.Collections;

public class UIcontroller : MonoBehaviour {

    public GameObject PauseCanvas;
	
    public void Pause()
    {
        PauseCanvas.SetActive(true);
    }
    public void ClosePause()
    {
        PauseCanvas.SetActive(false);
    }
}
