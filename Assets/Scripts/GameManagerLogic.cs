using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerLogic : MonoBehaviour
{
    public int TotalItemCount;
    public int Stage;
    public Text stageCountText;
    public Text playerCountText;
    void Awake()
    {
        Time.timeScale = 1;
        stageCountText.text = "/ " + TotalItemCount.ToString();
    }
    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scene" + Stage);
        }
    }
}
