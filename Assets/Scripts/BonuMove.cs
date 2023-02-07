using UnityEngine;

public class BonuMove : MonoBehaviour
{

    [SerializeField] GameObject bonus;
    [SerializeField] float speed;

 
    void FixedUpdate()
    {
        bonus.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
