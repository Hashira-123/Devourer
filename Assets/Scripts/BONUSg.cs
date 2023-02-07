using UnityEngine;

public class BONUSg : MonoBehaviour
{
    public bool isMulti;
    public GameObject sound;

    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Instantiate(sound, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}