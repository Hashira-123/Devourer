using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction = false;

    void FixedUpdate()
    {
        if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
        else
            CenterCircle.transform.Rotate(0, 0, -150 * Time.deltaTime);
    }

    public void CnangeDirection()
    {
        direction = !direction;
    }
}
