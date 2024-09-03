using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScrollManager : MonoBehaviour
{
    SceneMana s;
    public ScrollRect scrollRectComponent;
    public TMP_Text continueButtonText;
    public TMP_Text skipButtonText;
    public Image progressBar;
    public Image progressBar1;
    public Image progressBar2;

    void Start()
    {
        s = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SceneMana>();
    }

    void Update()
    {

        if(scrollRectComponent.horizontalNormalizedPosition < 0.75f - 0.005f)
        {
            continueButtonText.text = "Continue";
            skipButtonText.text = "Skip";
        }
        else
        {
            continueButtonText.text = "Start configuration";
            skipButtonText.text = "Close the app";
        }

        if(scrollRectComponent.horizontalNormalizedPosition < 0.25f - 0.005f)
        { 
            progressBar.gameObject.SetActive(true);
            progressBar1.gameObject.SetActive(false);
        }
        else if (scrollRectComponent.horizontalNormalizedPosition < 0.75f - 0.005f)
        {
            progressBar.gameObject.SetActive(false);
            progressBar1.gameObject.SetActive(true);
            progressBar2.gameObject.SetActive(false);
        }
        else
        {
            progressBar1.gameObject.SetActive(false);
            progressBar2.gameObject.SetActive(true);
        }
    }
     
    public void ContinueScrolling()
    {
        Debug.Log(scrollRectComponent.horizontalNormalizedPosition);
        if (scrollRectComponent.horizontalNormalizedPosition < 0.25f - 0.005f)
            scrollRectComponent.horizontalNormalizedPosition = 0.5f;
        else if (scrollRectComponent.horizontalNormalizedPosition < 0.75 - 0.005f)
            scrollRectComponent.horizontalNormalizedPosition = 1;
        else
            s.Main();
    }

    public void Skip()
    {
        if (scrollRectComponent.horizontalNormalizedPosition < 0.75f - 0.005f)
            s.Main();
        else
            Application.Quit();
    }
}
