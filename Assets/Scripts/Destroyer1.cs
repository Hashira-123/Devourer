using UnityEngine;

public class Destroyer1 : MonoBehaviour
{
    public float lifetime;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
