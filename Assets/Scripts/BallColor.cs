using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallColor : MonoBehaviour
{
    public Material material;
    public void ColorChangeRed()
    {
        material.color = Color.red;
    }
    public void ColorChangeBlue()
    {
        material.color = Color.blue;
    }
    public void ColorChangeYellow()
    {
        material.color = Color.yellow;
    }
    
}
