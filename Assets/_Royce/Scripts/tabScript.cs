﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tabScript : MonoBehaviour
{

    //public GameObject[] Tabs;
    public GameObject TabBox;
    public GameObject[] TabBoxes;

    private float ytrans;
    private int lasttab;
    private int frames = 15;
    private bool isclicked = false;
    private bool isCoroutineExecuting = false;

    void Start()
    {
        ytrans = TabBoxes[0].GetComponent<RectTransform>().rect.height;
    }

    public void avatarClick()
    {
        StartCoroutine(tabClick(0, frames));
    }
    public void upgradeClick()
    {
        StartCoroutine(tabClick(1, frames));
    }
    public void gachaClick()
    {
        StartCoroutine(tabClick(2, frames));
    }
    public void relicClick()
    {
        StartCoroutine(tabClick(3, frames));
    }
    public void shopClick()
    {
        StartCoroutine(tabClick(4, frames));
    }

    IEnumerator tabClick(int clicked, int frames)
    {
        if (isCoroutineExecuting) { yield break; }

        isCoroutineExecuting = true;

        if (!isclicked)
        {
            for (int i = 0; i < frames; i++)
            {
                gameObject.transform.localPosition += (Vector3.up * ytrans / frames);
                TabBoxes[clicked].transform.localPosition += (Vector3.up * ytrans / frames);
                isclicked = true;
                yield return new WaitForEndOfFrame();
            }
        }
        else
        {
            for (int i = 0; i < frames; i++)
            {
                gameObject.transform.localPosition += (Vector3.down * ytrans / frames);
                TabBoxes[lasttab].transform.localPosition += (Vector3.down * ytrans / frames);
                isclicked = false;
                yield return new WaitForEndOfFrame();
            }
            if (lasttab != clicked)
            {
                for (int i = 0; i < frames; i++)
                {
                    gameObject.transform.localPosition += (Vector3.up * ytrans / frames);
                    TabBoxes[clicked].transform.localPosition += (Vector3.up * ytrans / frames);
                    isclicked = true;
                    yield return new WaitForEndOfFrame();
                }
            }
        }
        lasttab = clicked;
        isCoroutineExecuting = false;
    }
}
