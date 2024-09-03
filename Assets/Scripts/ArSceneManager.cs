using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArSceneManager : MonoBehaviour
{
    public GameObject row1;
    public GameObject row2;
    public GameObject arrow;
    public GameObject x;
    public GameObject modal1;
    public GameObject modal2;
    public GameObject modal3;
    public GameObject Page1;
    public GameObject Page2;
    public GameObject ar;

    public void Next()
    {
        row1.SetActive(false);
        row2.SetActive(true);
        arrow.SetActive(false);
        x.SetActive(true);
    }

    public void Previous()
    {
        row1.SetActive(true);
        row2.SetActive(false);
        arrow.SetActive(true);
        x.SetActive(false);
    }

    public void OpenModal1()
    {
        CloseModal2();
        modal1.SetActive(true);
    }

    public void OpenModal2()
    {
        CloseModal1();
        modal2.SetActive(true);
    }

    public void CloseModal1()
    {
        modal1.SetActive(false);
    }

    public void CloseModal2()
    {
        modal2.SetActive(false);
    }

    public void OpenModal3()
    {
        modal3.SetActive(true);
    }

    public void CloseModal3()
    {
        modal3.SetActive(false);
        Debug.Log("Closing Modal 3");
        ar.GetComponent<Sc>().ShowCut();
        ar.GetComponent<Sc>().HideOriginal();
    }

    public void OpenPage1()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }
    public void OpenPage2()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }
}
