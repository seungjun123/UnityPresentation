using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    GameObject gameobject;
    AudioSource audio;
    public AudioMixer masterMixer;
    public Slider audioSlider;
    private void Awake()
    {
        gameobject = GameObject.Find("GameObject");
        audio = gameobject.GetComponent<AudioSource>();
        if (audio.isPlaying)
        {
            return;
        }
        else
        {
            audio.Play();
            DontDestroyOnLoad(gameobject);
        }
    }
    public void BackMusicStop()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
    public void AudioControl()
    {
        float volume = audioSlider.value;
        if (volume == -40f) masterMixer.SetFloat("BGM", -40);
        else masterMixer.SetFloat("BGM", volume);
    }

}
