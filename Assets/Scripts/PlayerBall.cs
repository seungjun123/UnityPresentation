using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerBall : MonoBehaviour
{
    public float jumpPower = 30;
    bool isJump = false;
    int itemCount = 0;
    public GameManagerLogic manager;
    Rigidbody rigid;
    AudioSource audio;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
            isJump = true;
            jumpPower = 15;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
            jumpPower = 30;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
        else if(other.tag == "Finish" && manager.Stage == 3 && itemCount == manager.TotalItemCount)
        {
            SceneManager.LoadScene("Clear");
        }
        else if(other.tag == "Finish")
        {
            if(manager.TotalItemCount == itemCount)
            {
                SceneManager.LoadScene("Scene" + (manager.Stage+1).ToString());
            }
            else
            {
                SceneManager.LoadScene("Scene" + (manager.Stage).ToString());
            }
        }
    }
}
