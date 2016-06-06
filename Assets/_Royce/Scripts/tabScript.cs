using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tabScript : MonoBehaviour {

    public GameObject[] TabBoxes;

    private float ytrans;

    private bool isclicked;
    private int lasttab;


    void Start()
    {
        ytrans = TabBoxes[0].GetComponent<RectTransform>().rect.height;
        isclicked = false;
    }

    public void avatarClick()
    {
        tabClick(0);
    }
    public void upgradeClick()
    {
        tabClick(1);
    }
    public void gachaClick()
    {
        tabClick(2);
    }
    public void relicClick()
    {
        tabClick(3);
    }
    public void shopClick()
    {
        tabClick(4);
    }

    private void tabClick(int clicked)
    {
        if (!isclicked)
        {
            gameObject.transform.localPosition += (Vector3.up * ytrans);
            TabBoxes[clicked].transform.localPosition += (Vector3.up * ytrans);
            isclicked = true;
        }
        else
        {
            gameObject.transform.localPosition += (Vector3.down * ytrans);
            TabBoxes[lasttab].transform.localPosition += (Vector3.down * ytrans);
            isclicked = false;

            if (lasttab != clicked)
            {
                gameObject.transform.localPosition += (Vector3.up * ytrans);
                TabBoxes[clicked].transform.localPosition += (Vector3.up * ytrans);
                isclicked = true;
            }
        }

        lasttab = clicked;
    }
}
