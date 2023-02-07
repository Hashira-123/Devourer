using UnityEngine;
using UnityEngine.UI;


public class BallScripts : MonoBehaviour
{
    public int score = 1;
    public GameObject sound;
    public GameObject panel;
    [SerializeField] Text scoreText;

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            score++;
        }
    
        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            Destroy(gameObject);
            panel.SetActive(true);
        }
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }
   
}
