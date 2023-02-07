using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour {
    //ссылка на сайт
    [SerializeField] string url;
    // метод открытия URL
    public void OnOpenUrl()
    {
        Application.OpenURL("https://store.steampowered.com/curator/25299524-AFGAN-friends/#browse");
    }
}