using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ExpandScript : MonoBehaviour
{
    GameObject shown;
    GameObject hidden;
    float hiddenHeight;
    float baseHeight;
    // Start is called before the first frame update
    void Start()
    {       
        shown = transform.GetChild(0).gameObject;
        hidden = transform.GetChild(1).gameObject;
        hiddenHeight = hidden.GetComponent<RectTransform>().rect.height;
        baseHeight = GetComponent<RectTransform>().rect.height;
    }

    public void Log()
    {
        Debug.Log("Clicked");
    }

    public void Expand()
    {
        hidden.SetActive(true);

        var rt = GetComponent<RectTransform>();

        rt.sizeDelta = new Vector2(rt.rect.width, baseHeight + hiddenHeight);     
        LayoutRebuilder.MarkLayoutForRebuild(transform.parent.GetComponent<RectTransform>());

        shown.GetComponent<Button>().onClick.RemoveListener(Expand);
        shown.GetComponent<Button>().onClick.AddListener(Collapse);
    }

    public void Collapse()
    {
        hidden.SetActive(false);

        var rt = GetComponent<RectTransform>();

        rt.sizeDelta = new Vector2(rt.rect.width, baseHeight);
        LayoutRebuilder.MarkLayoutForRebuild(transform.parent.GetComponent<RectTransform>());

        shown.GetComponent<Button>().onClick.RemoveListener(Collapse);
        shown.GetComponent<Button>().onClick.AddListener(Expand);
    }
}
