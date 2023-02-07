using UnityEngine;

public class MusicOptions : MonoBehaviour
{
    public bool isOn;

    private void Start()
    {
        isOn = true;
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
}
