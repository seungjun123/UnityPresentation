using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPopup : MonoBehaviour
{
    public GameObject panel;
    bool IsPause;
    private void Start()
    {
        IsPause = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsPause == false)
            {
                Time.timeScale = 0;
                IsPause = true;
                panel.SetActive(true);
                return;
            }
            if(IsPause == true)
            {
                Time.timeScale = 1;
                IsPause = false;
                panel.SetActive(false);
                return;
            }
        }
    }
    public void MenuPopupButton()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    public void Continue()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
