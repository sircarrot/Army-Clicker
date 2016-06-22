using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class relicScript : MonoBehaviour {

    public GameObject WhiteScreen;

    public void buyRelic()
    {
        StartCoroutine(ScreenFlash());
    }
    IEnumerator ScreenFlash()
    {
        WhiteScreen.GetComponent<Image>().CrossFadeAlpha(0f, 0f, false);
        WhiteScreen.SetActive(true);
        WhiteScreen.GetComponent<Image>().CrossFadeAlpha(1f, 0.5f, false);
        yield return new WaitForSeconds(0.5f);



        WhiteScreen.GetComponent<Image>().CrossFadeAlpha(0f, 0.5f, false);
        yield return new WaitForSeconds(0.5f);
    }
}
