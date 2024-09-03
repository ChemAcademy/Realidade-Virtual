using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatScroll : MonoBehaviour
{

    public ScrollRect scrollRectComponent;
    private float baseX;

    // Start is called before the first frame update
    void Start()
    {
        baseX = transform.localPosition.x;

    }

    // Update is called once per frame
    void Update()
    {
        //change image position base on scrol percentage
        transform.localPosition = new Vector3(  baseX - scrollRectComponent.horizontalNormalizedPosition * 140, 
                                                transform.localPosition.y, 
                                                transform.localPosition.z);
    }
}
