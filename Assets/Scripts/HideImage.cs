using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideImage : MonoBehaviour
{
    public GameObject Red, Blue, Yellow;
    public void HideImages_Red()
    {
        Blue.SetActive(false);
        Yellow.SetActive(false);
        Invoke("ShowImages_Red", 1);
    }
    public void ShowImages_Red()
    {
        Blue.SetActive(true);
        Yellow.SetActive(true);
    }
    public void HideImages_Blue()
    {
        Red.SetActive(false);
        Yellow.SetActive(false);
        Invoke("ShowImages_Blue", 1);
    }
    public void ShowImages_Blue()
    {
        Red.SetActive(true);
        Yellow.SetActive(true);
    }
    public void HideImages_Yellow()
    {
        Blue.SetActive(false);
        Red.SetActive(false);
        Invoke("ShowImages_Yellow", 1);
    }
    public void ShowImages_Yellow()
    {
        Blue.SetActive(true);
        Red.SetActive(true);
    }
}
