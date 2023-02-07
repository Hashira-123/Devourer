using System.Collections;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] objects;
    [SerializeField] Vector2 range;

    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}


