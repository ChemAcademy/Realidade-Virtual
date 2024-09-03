using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
using System.Linq;

public class Sc : MonoBehaviour
{

    public Transform planeDebug;
    public GameObject target;
    public GameObject fluid;
    public GameObject lowerHull;

    // Start is called before the first frame update
    void Start()
    {        
        StartCut();
        fluid.GetComponent<GeneralTemperature>().running = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void StartCut()
    {
        SlicedHull hull = target.Slice(planeDebug.position, planeDebug.up);
        
        if(hull != null){           
            lowerHull = hull.CreateLowerHull(target);
            
            lowerHull.GetComponent<Renderer>().materials = lowerHull.GetComponent<Renderer>().materials[0..^1];
            lowerHull.transform.parent = target.transform.parent;
            lowerHull.SetActive(false);
            lowerHull.transform.position = target.transform.position;
        }
    }

    public void HideCut(){
        lowerHull.SetActive(false);
    }

    public void ShowCut(){
        Debug.Log("Showing cut");
        lowerHull.SetActive(true);
    }

    public void HideOriginal(){
        target.SetActive(false);
    }

    public void ShowOriginal(){
        target.SetActive(true);
    }

}