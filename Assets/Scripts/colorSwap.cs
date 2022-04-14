using UnityEngine;
using System;
using System.Collections;


public class colorSwap
  : MonoBehaviour
{
    public Color StartColor;
    public Color EndColor;
    public float time;
    bool goingForward;
    bool isCycling;
    Material myMaterial;

    private void Awake()
    {
        goingForward = true;
        isCycling = false;
        myMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (!isCycling)
        {
            if (goingForward) 
            {
                myMaterial.SetColor("_EmissionColor", StartColor);
            }
            else
            {
                myMaterial.SetColor("_EmissionColor", EndColor);
            }        
        }
    }

    IEnumerator CycleMaterial(Color startColor, Color endColor, float cycleTime, Material mat)
    {
        isCycling = true;
        float currentTime = 0;
        while (currentTime < cycleTime)
        {
            currentTime += Time.deltaTime;
            float t = currentTime / cycleTime;
            Color currentColor = Color.Lerp(startColor, endColor, t);
            mat.color = currentColor;
            yield return null;
        }
        isCycling = false;
        goingForward = !goingForward;

    }

}
