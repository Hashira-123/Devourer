using UnityEngine;
using UnityEngine.UI;

public class ScoreMM : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    public void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.Save();
    }
}
