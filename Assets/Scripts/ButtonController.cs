using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void Back_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Back_Scene1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void Back_Scene2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void Back_Scene3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
    }
    public void Option_Scene1()
    {
        SceneManager.LoadScene("Option_Scene1");
    }
    public void Option_Scene2()
    {
        SceneManager.LoadScene("Option_Scene2");
    }
    public void Option_Scene3()
    {
        SceneManager.LoadScene("Option_Scene3");
    }
    public void Start_Scene1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
