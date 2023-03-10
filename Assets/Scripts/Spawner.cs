using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;

    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
