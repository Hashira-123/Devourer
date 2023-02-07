using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Sprite onMusic;
    public Sprite offMusic;

    public Image MusicButton;
    public bool isOn;



    private void Start()
    {
        isOn = true;

    }
    public void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.sprite = onMusic;
            isOn = true;
        }
        else if(PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.sprite = offMusic;
            isOn = false;
        }
    }
    public void OnOffSounds()
    {
        if (!isOn)
        {
            AudioListener.volume = 1f;
            isOn = true;
        }
        else if (isOn)
        {
            AudioListener.volume = 0f;
            isOn = false;
        }
    }


    public void offSaund()
    {
        if(!isOn)
        {
            PlayerPrefs.SetInt("music", 0);

        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);

        }
    }
}